using Entity;
using System.Threading.Tasks;

namespace IdentityServer.Authenticate
{
    public interface IJwtService
    {
        Task<AccessToken> GenerateAsync(User user);
    }
}
