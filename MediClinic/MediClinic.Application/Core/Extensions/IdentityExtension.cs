using MediClinic.Domain.Models.Entities.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MediClinic.Application.Core.Extensions
{
    static public partial class Extension
    {
        public static string[] principals = null;

        static public string GetPrincipalUserName(this ClaimsPrincipal principal)
        {
            string name = principal.FindFirstValue(ClaimTypes.Name);

            if (!string.IsNullOrWhiteSpace(name))
            {
                return $"{name}";
            }

            return principal.Claims.FirstOrDefault(c => c.Type.Equals(ClaimTypes.Email))?.Value;
        }

        static public string GetPrincipalEmail(this ClaimsPrincipal principal)
        {
            string email = principal.Claims.FirstOrDefault(c => c.Type.Equals("Email"))?.Value;

            if (!string.IsNullOrWhiteSpace(email))
            {
                return $"{email}";
            }

            return principal.Claims.FirstOrDefault(c => c.Type.Equals(ClaimTypes.Email))?.Value;
        }

        static public int? GetCurrentUserId(this ClaimsPrincipal principal)
        {
            try
            {
                string id = principal.FindFirstValue(ClaimTypes.NameIdentifier);
                return Int32.Parse(id);
            }
            catch (Exception)
            {

                return 0;
            }
        }


        static public bool HasAccess(this ClaimsPrincipal principal, string policyName)
        {
            return principal.IsInRole("SuperAdmin") ||
                principal.HasClaim(c => c.Type.Equals(policyName) && c.Value.Equals("1"));
        }
    }
}
