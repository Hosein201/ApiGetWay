using Entity.Models;

namespace IdentityServer.Authenticate
{
    public interface IJwtService
    {
        AccessToken GenerateAsync(User user);
    }
}
