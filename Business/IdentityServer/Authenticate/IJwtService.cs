using Entity.Models;
using System.Threading.Tasks;

namespace IdentityServer.Authenticate
{
    public interface IJwtService
    {
       Task<AccessToken> GenerateAsync(User user);
    }
}
