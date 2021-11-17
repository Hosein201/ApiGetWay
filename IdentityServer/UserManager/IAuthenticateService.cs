using IdentityServer.Authenticate;
using OrderProcessing.Dto;
using System.Threading.Tasks;

namespace IdentityServer.UserManager
{
    public interface IAuthenticateService
    {
        Task<AccessToken> Login(LoginDto dto);
        Task<AccessToken> Regsiter(RegsiterDto dto);
    }
}
