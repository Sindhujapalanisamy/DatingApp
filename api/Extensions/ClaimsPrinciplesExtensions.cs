using System.Security.Claims;

namespace api.Extensions
{
    public static class ClaimsPrinciplesExtensions
    {
        
        public static string GetUsername(this ClaimsPrincipal user)
        {
            return user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        }
    }
}