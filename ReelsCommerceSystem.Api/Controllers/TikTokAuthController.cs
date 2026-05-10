using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Api.Controllers;
using ReelsCommerceSystem.Application.DTOs.Request.TikTok;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Shared.Responses;
using System.Net;
using System.Text.Json;
using System.Web;
using Microsoft.Extensions.Caching.Memory;

namespace ReelsCommerceSystem.API.Controllers;

public class TikTokAuthController : AppBaseController
{
    private readonly IConfiguration _config;
    private readonly HttpClient _httpClient;
    private readonly UserManager<User> _userManager;
    private readonly IJwtService _jwtService;
    private readonly IMemoryCache _cache;

    private record OAuthState(string SuccessUrl, string FailUrl);

    public TikTokAuthController(
        IConfiguration config,
        IHttpClientFactory httpClientFactory,
        UserManager<User> userManager,
        IJwtService jwtService,
        IMemoryCache cache)
    {
        _config = config;
        _httpClient = httpClientFactory.CreateClient();
        _userManager = userManager;
        _jwtService = jwtService;
        _cache = cache;
    }

    [HttpGet("login")]
    public IActionResult TikTokLogin(
        [FromQuery] string frontendLoginSuccessUrl,
        [FromQuery] string frontendLoginFailUrl,
        [FromQuery] string? redirectUri = null) // optional (for mobile deep link)
    {
        var clientKey = _config["TikTokAuth:ClientKey"];
        var defaultRedirectUri = _config["TikTokAuth:RedirectUri"];
        var finalRedirectUri = redirectUri ?? defaultRedirectUri;

        var state = Guid.NewGuid().ToString("N");
        var stateData = new OAuthState(frontendLoginSuccessUrl, frontendLoginFailUrl);
        _cache.Set(state, stateData, TimeSpan.FromHours(1));

        // Store these as defaults for this provider
        _cache.Set("TikTokAuth:DefaultSuccessUrl", frontendLoginSuccessUrl, TimeSpan.FromHours(1));
        _cache.Set("TikTokAuth:DefaultFailUrl", frontendLoginFailUrl, TimeSpan.FromHours(1));

        var url = $"https://www.tiktok.com/v2/auth/authorize/?" +
                  $"client_key={clientKey}&" +
                  $"scope=user.info.basic&" +
                  $"response_type=code&" +
                  $"redirect_uri={HttpUtility.UrlEncode(finalRedirectUri)}&" +
                  $"state={state}";

        return Redirect(url);
    }

    // (Web): TikTok → Callback
    [HttpGet("callback")]
    public async Task<IActionResult> TikTokCallback(string? code, string? state, string? error)
    {
        if (string.IsNullOrEmpty(state) || !_cache.TryGetValue(state, out OAuthState? stateData))
            return Redirect(GetFailRedirect(state, "Invalid state — possible CSRF attack"));

        var successUrl = stateData?.SuccessUrl ?? _cache.Get<string>("TikTokAuth:DefaultSuccessUrl") ?? _config["TikTokAuth:DefaultSuccessUrl"];
        var failUrl = stateData?.FailUrl ?? _cache.Get<string>("TikTokAuth:DefaultFailUrl") ?? _config["TikTokAuth:DefaultFailUrl"];

        _cache.Remove(state);

        if (!string.IsNullOrEmpty(error))
            return Redirect($"{failUrl}?error={Uri.EscapeDataString(error)}");

        try
        {
            var (user, jwt, expiresAt) = await ExchangeTikTokCodeAsync(code!);

            // Store in cookies for web
            Response.Cookies.Append("auth_token", jwt, new CookieOptions
            {
                HttpOnly = false,
                Secure = true, // Must be true for SameSite = None
                SameSite = SameSiteMode.None,
                Expires = expiresAt
            });

            Response.Cookies.Append("auth_expiry", expiresAt.ToString("o"), new CookieOptions
            {
                HttpOnly = false,
                Secure = true, // Must be true for SameSite = None
                SameSite = SameSiteMode.None,
                Expires = expiresAt
            });

            // If frontend is on a different domain, cookies might not be accessible.
            // It's safer to also pass the token in the query string.
            var redirectUrl = successUrl;
            if (redirectUrl.Contains("?"))
                redirectUrl += $"&token={jwt}";
            else
                redirectUrl += $"?token={jwt}";

            return Redirect(redirectUrl);
        }
        catch (Exception ex)
        {
            return Redirect($"{failUrl}?error={Uri.EscapeDataString(ex.Message)}");
        }
    }

    // (Mobile): Exchange Code → 
[HttpPost("exchange")]
public async Task<IActionResult> ExchangeCode([FromBody] TikTokExchangeReq request)
{
    if (string.IsNullOrEmpty(request.Code) || string.IsNullOrEmpty(request.State))
    {
        return BadRequest(ApiResponse<object>.ErrorResponse(
            HttpStatusCode.BadRequest,
            en: "Missing code or state.",
            ar: "الرمز أو الحالة مفقودة."
        ));
    }

        if (!_cache.TryGetValue(request.State, out _))
        {
            return BadRequest(ApiResponse<object>.ErrorResponse(
                HttpStatusCode.BadRequest,
                en: "Invalid or expired state.",
                ar: "رمز الحالة غير صالح أو منتهي الصلاحية."
            ));
        }

        _cache.Remove(request.State);

    try
    {
        var (user, jwt, expiresAt) = await ExchangeTikTokCodeAsync(request.Code);

        var data = new
        {
            token = jwt,
            expiresAt,
            user = new
            {
                user.Id,
                user.DisplayName,
                user.ImageURL,
                user.Email
            }
        };

        return Ok(ApiResponse<object>.SuccessResponse(
            data,
            HttpStatusCode.OK,
            en: "TikTok login successful.",
            ar: "تم تسجيل الدخول عبر تيك توك بنجاح."
        ));
    }
    catch (Exception ex)
    {
        return BadRequest(ApiResponse<object>.ErrorResponse(
            HttpStatusCode.BadRequest,
            en: ex.Message,
            ar: "حدث خطأ أثناء تسجيل الدخول عبر تيك توك."
        ));
    }
}

private async Task<(User user, string jwt, DateTime expiresAt)> ExchangeTikTokCodeAsync(string code)
    {
        var clientKey = _config["TikTokAuth:ClientKey"];
        var clientSecret = _config["TikTokAuth:ClientSecret"];
        var redirectUri = _config["TikTokAuth:RedirectUri"];

        var tokenRequest = new FormUrlEncodedContent(new Dictionary<string, string>
        {
            { "client_key", clientKey! },
            { "client_secret", clientSecret! },
            { "code", code },
            { "grant_type", "authorization_code" },
            { "redirect_uri", redirectUri! }
        });

        var tokenResponse = await _httpClient.PostAsync("https://open.tiktokapis.com/v2/oauth/token/", tokenRequest);
        var tokenResult = await tokenResponse.Content.ReadAsStringAsync();

        if (!tokenResponse.IsSuccessStatusCode)
            throw new Exception($"Token exchange failed: {tokenResult}");

        using var tokenDoc = JsonDocument.Parse(tokenResult);
        var root = tokenDoc.RootElement;

        if (!root.TryGetProperty("access_token", out var accessTokenProp))
            throw new Exception("TikTok token response missing 'access_token'");

        var accessToken = accessTokenProp.GetString();
        var openId = root.GetProperty("open_id").GetString();

        // Get user info
        var userInfoRequest = new HttpRequestMessage(HttpMethod.Get,
            "https://open.tiktokapis.com/v2/user/info/?fields=open_id,display_name,avatar_url");
        userInfoRequest.Headers.Authorization =
            new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);

        var userInfoResponse = await _httpClient.SendAsync(userInfoRequest);
        var userInfoResult = await userInfoResponse.Content.ReadAsStringAsync();

        if (!userInfoResponse.IsSuccessStatusCode)
            throw new Exception($"User info request failed: {userInfoResult}");

        using var userDoc = JsonDocument.Parse(userInfoResult);
        if (!userDoc.RootElement.TryGetProperty("data", out var userData) ||
            !userData.TryGetProperty("user", out var userJson))
            throw new Exception("TikTok user info invalid response");

        var displayName = userJson.GetProperty("display_name").GetString();
        var avatar = userJson.TryGetProperty("avatar_url", out var avatarProp) ? avatarProp.GetString() : null;

        // Create or find user
        var existingUser = await _userManager.FindByLoginAsync("TikTok", openId!);
        User user;

        if (existingUser == null)
        {
            user = new User
            {
                EmailConfirmed = true,
                UserName = $"tiktok_{openId}",
                Email = $"{openId}@tiktok.local",
                DisplayName = displayName ?? "TikTok User",
                ImageURL = avatar ?? string.Empty
            };

            var createResult = await _userManager.CreateAsync(user);
            if (!createResult.Succeeded)
                throw new Exception("User creation failed");

            await _userManager.AddLoginAsync(user, new UserLoginInfo("TikTok", openId!, "TikTok"));
            await _userManager.AddToRoleAsync(user, "User");
        }
        else
        {
            user = existingUser;
        }

        var jwt = await _jwtService.CreateTokenAsync(user);
        var expiresAt = DateTime.UtcNow.AddMonths(1);

        return (user, jwt, expiresAt);
    }

    private string GetFailRedirect(string? state, string message)
    {
        if (state != null && _cache.TryGetValue(state, out OAuthState? stateData))
        {
            _cache.Remove(state);
            return $"{stateData.FailUrl}?error={Uri.EscapeDataString(message)}";
        }

        var defaultFail = _cache.Get<string>("TikTokAuth:DefaultFailUrl") ?? _config["TikTokAuth:DefaultFailUrl"] ?? "https://localhost:4200/login/tiktok/fail";
        return $"{defaultFail}?error={Uri.EscapeDataString(message)}";
    }
}

