using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Api.Controllers;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Shared.Responses;
using System.Text.Json;
using System.Web;

namespace ReelsCommerceSystem.API.Controllers;


public class TikTokAuthController : AppBaseController
{
    private readonly IConfiguration _config;
    private readonly HttpClient _httpClient;
    private readonly UserManager<User> _userManager;
    private readonly IJwtService _jwtService;

    // Simple in-memory store for valid states
    private static readonly Dictionary<string, DateTime> _validStates = new();
    private static readonly Dictionary<string, string> _stateSuccessRedirects = new();
    private static readonly Dictionary<string, string> _stateFaildRedirects = new();

    public TikTokAuthController(
        IConfiguration config,
        IHttpClientFactory httpClientFactory,
        UserManager<User> userManager,
        IJwtService jwtService)
    {
        _config = config;
        _httpClient = httpClientFactory.CreateClient();
        _userManager = userManager;
        _jwtService = jwtService;
    }

    [HttpGet("login")]
    public IActionResult TikTokLogin([FromQuery] string frontendLoginSuccessUrl, 
        [FromQuery] string frontendLoginFaildUrl)
    {
        var clientKey = _config["TikTokAuth:ClientKey"];
        var redirectUri = _config["TikTokAuth:RedirectUri"];
        var state = Guid.NewGuid().ToString("N");

        // ✅ Save state + URLs for later
        _validStates[state] = DateTime.UtcNow.AddMinutes(5);
        _stateSuccessRedirects[state] = frontendLoginSuccessUrl;
        _stateFaildRedirects[state] = frontendLoginFaildUrl;

        var url = $"https://www.tiktok.com/v2/auth/authorize/?" +
                  $"client_key={clientKey}&" +
                  $"scope=user.info.basic&" +
                  $"response_type=code&" +
                  $"redirect_uri={HttpUtility.UrlEncode(redirectUri)}&" +
                  $"state={state}";

        return Redirect(url);
    }

    [HttpGet("callback")]
    public async Task<IActionResult> TikTokCallback(string? code, string? state, string? error)
    {
        if (string.IsNullOrEmpty(state) || !_validStates.ContainsKey(state))
            return Redirect(GetFailRedirect(state, "Invalid state — possible CSRF attack"));

        _validStates.Remove(state);

        var successUrl = _stateSuccessRedirects.ContainsKey(state)
            ? _stateSuccessRedirects[state]
            : _config["TikTokAuth:DefaultSuccessUrl"];

        var failUrl = _stateFaildRedirects.ContainsKey(state)
            ? _stateFaildRedirects[state]
            : _config["TikTokAuth:DefaultFailUrl"];

        _stateSuccessRedirects.Remove(state);
        _stateFaildRedirects.Remove(state);

        if (!string.IsNullOrEmpty(error))
            return Redirect($"{failUrl}?error={Uri.EscapeDataString(error)}");

        try
        {
            var clientKey = _config["TikTokAuth:ClientKey"];
            var clientSecret = _config["TikTokAuth:ClientSecret"];
            var redirectUri = _config["TikTokAuth:RedirectUri"];

            var tokenRequest = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                { "client_key", clientKey! },
                { "client_secret", clientSecret! },
                { "code", code! },
                { "grant_type", "authorization_code" },
                { "redirect_uri", redirectUri! }
            });

            var tokenResponse = await _httpClient.PostAsync("https://open.tiktokapis.com/v2/oauth/token/", tokenRequest);
            var tokenResult = await tokenResponse.Content.ReadAsStringAsync();

            if (!tokenResponse.IsSuccessStatusCode)
                return Redirect($"{failUrl}?error=TokenExchangeFailed");

            using var tokenDoc = JsonDocument.Parse(tokenResult);
            var tokenRoot = tokenDoc.RootElement;

            if (!tokenRoot.TryGetProperty("access_token", out var accessTokenProp))
                return Redirect($"{failUrl}?error=AccessTokenMissing");

            var accessToken = accessTokenProp.GetString();
            var openId = tokenRoot.GetProperty("open_id").GetString();

            // Fetch user info
            var userInfoRequest = new HttpRequestMessage(
                HttpMethod.Get,
                "https://open.tiktokapis.com/v2/user/info/?fields=open_id,display_name,avatar_url");
            userInfoRequest.Headers.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);

            var userInfoResponse = await _httpClient.SendAsync(userInfoRequest);
            var userInfoResult = await userInfoResponse.Content.ReadAsStringAsync();

            if (!userInfoResponse.IsSuccessStatusCode)
                return Redirect($"{failUrl}?error=UserInfoFailed");

            using var userDoc = JsonDocument.Parse(userInfoResult);
            if (!userDoc.RootElement.TryGetProperty("data", out var userData) ||
                !userData.TryGetProperty("user", out var userJson))
                return Redirect($"{failUrl}?error=UserInfoInvalid");

            var displayName = userJson.GetProperty("display_name").GetString();
            var avatar = userJson.TryGetProperty("avatar_url", out var avatarProp)
                ? avatarProp.GetString()
                : null;

            var existingUser = await _userManager.FindByLoginAsync("TikTok", openId!);
            User user;

            if (existingUser == null)
            {
                user = new User
                {
                    UserName = $"tiktok_{openId}",
                    Email = $"{openId}@tiktok.local",
                    DisplayName = displayName!,
                    ImageURL = avatar!
                };

                var createResult = await _userManager.CreateAsync(user);
                if (!createResult.Succeeded)
                    return Redirect($"{failUrl}?error=UserCreationFailed");

                await _userManager.AddLoginAsync(user, new UserLoginInfo("TikTok", openId!, "TikTok"));
            }
            else
            {
                user = existingUser;
            }

            var jwt = await _jwtService.CreateTokenAsync(user);
            var expiresAt = DateTime.UtcNow.AddMonths(1);

            Response.Cookies.Append("auth_token", jwt, new CookieOptions
            {
                HttpOnly = true,
                Secure = true,
                SameSite = SameSiteMode.None,
                Expires = expiresAt
            });

            Response.Cookies.Append("auth_expiry", expiresAt.ToString("o"), new CookieOptions
            {
                HttpOnly = false,
                Secure = true,
                SameSite = SameSiteMode.None,
                Expires = expiresAt
            });

            return Redirect(successUrl);
        }
        catch (Exception ex)
        {
            // Log ex.Message or ex.StackTrace if needed
            return Redirect($"{failUrl}?error={Uri.EscapeDataString(ex.Message)}");
        }
    }

    private string GetFailRedirect(string? state, string message)
    {
        if (state != null && _stateFaildRedirects.TryGetValue(state, out var failUrl))
        {
            _stateFaildRedirects.Remove(state);
            return $"{failUrl}?error={Uri.EscapeDataString(message)}";
        }

        var defaultFail = _config["TikTokAuth:DefaultFailUrl"] ?? "https://localhost:4200/login/tiktok/fail";
        return $"{defaultFail}?error={Uri.EscapeDataString(message)}";
    }



}
