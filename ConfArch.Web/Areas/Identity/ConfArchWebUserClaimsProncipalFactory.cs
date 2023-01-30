using ConfArch.Web.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ConfArch.Web.Areas.Identity
{
    public class ConfArchWebUserClaimsProncipalFactory : UserClaimsPrincipalFactory<ConfArchWebUser>
    {
        public ConfArchWebUserClaimsProncipalFactory(
            UserManager<ConfArchWebUser> userManager,
            IOptions<IdentityOptions> options): base(userManager, options)
        {
            
        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(ConfArchWebUser user)
        {
            var identity = await base.GenerateClaimsAsync(user);

            if (user.CareerStartedDate != null)
            {
                identity.AddClaim(new Claim("CareerStarted",
                   user.CareerStartedDate.ToShortDateString()));
            }
            if (!string.IsNullOrEmpty(user.FullName))
            {
                identity.AddClaim(new Claim("FullName",
                   user.FullName));
            }

            return identity;
        }
    }
}
