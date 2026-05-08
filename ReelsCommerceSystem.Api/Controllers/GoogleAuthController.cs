using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Api.Controllers;
using ReelsCommerceSystem.Application.DTOs.Request.Google;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Shared.Responses;
using System.Net;
using System.Text.Json;
using System.Web;

namespace ReelsCommerceSystem.API.Controllers;

public class GoogleAuthController : AppBaseController
{
    private readonly IConfiguration _config;
    private readonly HttpClient _httpClient;
    private readonly UserManager<User> _userManager;
    private readonly IJwtService _jwtService;

    // In-memory state tracking (move to Redis/DB in production)
    private static readonly Dictionary<string, DateTime> _validStates = new();
    private static readonly Dictionary<string, string> _stateSuccessRedirects = new();
    private static readonly Dictionary<string, string> _stateFailRedirects = new();

    public GoogleAuthController(
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

    // Step 1: Redirect user to Google login
    [HttpGet("login")]
    public IActionResult GoogleLogin(
        [FromQuery] string frontendLoginSuccessUrl,
        [FromQuery] string frontendLoginFailUrl,
        [FromQuery] string? redirectUri = null)
    {
        var clientId = _config["GoogleAuth:ClientId"];
        var defaultRedirectUri = _config["GoogleAuth:RedirectUri"];
        var finalRedirectUri = redirectUri ?? defaultRedirectUri;

        var state = Guid.NewGuid().ToString("N");
        _validStates[state] = DateTime.UtcNow.AddMinutes(5);
        _stateSuccessRedirects[state] = frontendLoginSuccessUrl;
        _stateFailRedirects[state] = frontendLoginFailUrl;

        var url =
            $"https://accounts.google.com/o/oauth2/v2/auth?" +
            $"client_id={clientId}&" +
            $"redirect_uri={HttpUtility.UrlEncode(finalRedirectUri)}&" +
            $"response_type=code&" +
            $"scope=openid%20email%20profile&" +
            $"access_type=offline&" +
            $"state={state}";

        return Redirect(url);
    }

    // Step 2: Google redirects here after user grants permission
    [HttpGet("callback")]
    public async Task<IActionResult> GoogleCallback(string? code, string? state, string? error)
    {
        if (string.IsNullOrEmpty(state) || !_validStates.ContainsKey(state))
            return Redirect(GetFailRedirect(state, "Invalid state — possible CSRF attack."));

        var successUrl = _stateSuccessRedirects.GetValueOrDefault(state) ?? _config["GoogleAuth:DefaultSuccessUrl"];
        var failUrl = _stateFailRedirects.GetValueOrDefault(state) ?? _config["GoogleAuth:DefaultFailUrl"];

        _validStates.Remove(state);
        _stateSuccessRedirects.Remove(state);
        _stateFailRedirects.Remove(state);

        if (!string.IsNullOrEmpty(error))
            return Redirect($"{failUrl}?error={Uri.EscapeDataString(error)}");

        try
        {
            var (user, jwt, expiresAt) = await ExchangeGoogleCodeAsync(code!);

            // Store cookies for web usage
            Response.Cookies.Append("auth_token", jwt, new CookieOptions
            {
                HttpOnly = false,
                Secure = false,
                SameSite = SameSiteMode.None,
                Expires = expiresAt
            });

            Response.Cookies.Append("auth_expiry", expiresAt.ToString("o"), new CookieOptions
            {
                HttpOnly = false,
                Secure = false,
                SameSite = SameSiteMode.None,
                Expires = expiresAt
            });

            return Redirect(successUrl!);
        }
        catch (Exception ex)
        {
            return Redirect($"{failUrl}?error={Uri.EscapeDataString(ex.Message)}");
        }
    }

    // Step 3: Mobile clients exchange code for JWT
    [HttpPost("exchange")]
    public async Task<IActionResult> ExchangeCode([FromBody] GoogleExchangeReq request)
    {
        if (string.IsNullOrEmpty(request.Code) || string.IsNullOrEmpty(request.State))
        {
            return BadRequest(ApiResponse<object>.ErrorResponse(
                HttpStatusCode.BadRequest,
                en: "Missing code or state.",
                ar: "الكود أو الحالة مفقودة."
            ));
        }

        if (!_validStates.ContainsKey(request.State))
        {
            return BadRequest(ApiResponse<object>.ErrorResponse(
                HttpStatusCode.BadRequest,
                en: "Invalid or expired state.",
                ar: "رمز الحالة غير صالح أو منتهي الصلاحية."
            ));
        }

        _validStates.Remove(request.State);

        try
        {
            var (user, jwt, expiresAt) = await ExchangeGoogleCodeAsync(request.Code);

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
                en: "Google login successful.",
                ar: "تم تسجيل الدخول عبر جوجل بنجاح."
            ));
        }
        catch (Exception ex)
        {
            return BadRequest(ApiResponse<object>.ErrorResponse(
                HttpStatusCode.BadRequest,
                en: ex.Message,
                ar: "حدث خطأ أثناء تسجيل الدخول عبر جوجل."
            ));
        }
    }

    private async Task<(User user, string jwt, DateTime expiresAt)> ExchangeGoogleCodeAsync(string code)
    {
        var clientId = _config["GoogleAuth:ClientId"];
        var clientSecret = _config["GoogleAuth:ClientSecret"];
        var redirectUri = _config["GoogleAuth:RedirectUri"];

        // 1. Exchange code for access token
        var tokenRequest = new FormUrlEncodedContent(new Dictionary<string, string>
        {
            ["code"] = code,
            ["client_id"] = clientId!,
            ["client_secret"] = clientSecret!,
            ["redirect_uri"] = redirectUri!,
            ["grant_type"] = "authorization_code"
        });

        var tokenResponse = await _httpClient.PostAsync("https://oauth2.googleapis.com/token", tokenRequest);
        var tokenResult = await tokenResponse.Content.ReadAsStringAsync();

        if (!tokenResponse.IsSuccessStatusCode)
            throw new Exception($"Token exchange failed: {tokenResult}");

        using var tokenDoc = JsonDocument.Parse(tokenResult);
        var root = tokenDoc.RootElement;
        var accessToken = root.GetProperty("access_token").GetString();

        // 2. Get user info from Google
        _httpClient.DefaultRequestHeaders.Authorization =
            new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);

        var userInfoResponse = await _httpClient.GetStringAsync("https://www.googleapis.com/oauth2/v2/userinfo");
        var userInfo = JsonDocument.Parse(userInfoResponse).RootElement;

        var email = userInfo.GetProperty("email").GetString();
        var name = userInfo.GetProperty("name").GetString();
        var picture = userInfo.GetProperty("picture").GetString();
        var googleId = userInfo.GetProperty("id").GetString();

        // 3. Create or find user
        var existingUser = await _userManager.FindByLoginAsync("Google", googleId!);
        User user;

        if (existingUser == null)
        {
            user = new User
            {
                Email = email,
                UserName = $"google_{googleId}",
                DisplayName = name ?? "Google User",
                ImageURL = picture ?? string.Empty,
                EmailConfirmed = true,
                Role = Domain.Enums.Role.Customer
            };

            var createResult = await _userManager.CreateAsync(user);
            if (!createResult.Succeeded)
                throw new Exception("User creation failed.");

            await _userManager.AddLoginAsync(user, new UserLoginInfo("Google", googleId!, "Google"));
        }
        else
        {
            user = existingUser;
        }

        // 4. Create JWT
        var jwt = await _jwtService.CreateTokenAsync(user);
        var expiresAt = DateTime.UtcNow.AddMonths(1);

        return (user, jwt, expiresAt);
    }

    private string GetFailRedirect(string? state, string message)
    {
        if (state != null && _stateFailRedirects.TryGetValue(state, out var failUrl))
        {
            _stateFailRedirects.Remove(state);
            return $"{failUrl}?error={Uri.EscapeDataString(message)}";
        }

        var defaultFail = _config["GoogleAuth:DefaultFailUrl"] ?? "https://localhost:4200/login/google/fail";
        return $"{defaultFail}?error={Uri.EscapeDataString(message)}";
    }
}