using IdentityServer.UserManager;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using OrderProcessing.Dto;
using System.Net;
using System.Threading.Tasks;

namespace OrderProcessing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        private readonly IAuthenticateService Authenticate;

        public AuthenticateController(IAuthenticateService authenticate)
        {
            this.Authenticate = authenticate;
        }

        [HttpGet]
        public async Task<IActionResult> Login(LoginDto dto)
        {
            return Ok(new ApiResult { Data = await Authenticate.Login(dto), Errors = null, StatusCode = HttpStatusCode.OK, Success = true });
        }

        [HttpPost]
        public async Task<IActionResult> Regsiter(RegsiterDto dto)
        {
            return Ok(new ApiResult { Data = await Authenticate.Regsiter(dto), Errors = null, StatusCode = HttpStatusCode.OK, Success = true });
        }
    }
}
