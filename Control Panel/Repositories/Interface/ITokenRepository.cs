using Microsoft.AspNetCore.Identity;

namespace Control_Panel.Repositories.Interface
{
    public interface ITokenRepository
    {
        string CreateJwtToken(IdentityUser user, List<string> roles);
    }
}
