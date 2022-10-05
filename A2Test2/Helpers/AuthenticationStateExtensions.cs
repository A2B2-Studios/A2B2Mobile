using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace A2Test2.Helpers
{
    public static class AuthenticationStateExtensions
    {
        public static string GetUserId(this IEnumerable<Claim> claims)
        {
            return claims.FirstOrDefault(x => x.Type == "sub").Value.ToString();
        }
    }
}
