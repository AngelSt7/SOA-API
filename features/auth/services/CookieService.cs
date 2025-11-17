namespace SOA.features.auth.services
{
    public class CookieService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CookieService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public void SetTokenCookie(string token, double expireMinutes, bool secureOnly = true)
        {
            var context = _httpContextAccessor.HttpContext;
            if (context == null) return;

            context.Response.Cookies.Append("TOKEN", token, new CookieOptions
            {
                HttpOnly = true,
                Secure = secureOnly && context.Request.IsHttps,
                SameSite = SameSiteMode.Strict,
                Expires = DateTime.UtcNow.AddMinutes(expireMinutes)
            });
        }

        public string? GetTokenCookie()
        {
            return _httpContextAccessor.HttpContext?.Request.Cookies["TOKEN"];
        }

        public void RemoveTokenCookie()
        {
            _httpContextAccessor.HttpContext?.Response.Cookies.Delete("TOKEN");
        }
    }
}
