using Entity.Models;
using IdentityServer.Authenticate;
using Infrastructure;
using Microsoft.AspNetCore.Identity;
using OrderProcessing.Dto;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.UserManager
{
    public class AuthenticateService : IAuthenticateService
    {
        private readonly SignInManager<User> SignInManager;
        private readonly UserManager<User> UserManager;
        private readonly IJwtService JwtService;
        public AuthenticateService(SignInManager<User> signInManager, UserManager<User> userManager, IJwtService jwtService)
        {
            SignInManager = signInManager;
            UserManager = userManager;
            JwtService = jwtService;
        }

        public async Task<AccessToken> Login(LoginDto dto)
        {
            var user = await UserManager.FindByNameAsync(dto.UserName);
            var checkPassword = await SignInManager.CheckPasswordSignInAsync(user, dto.PassWord, false);
            if (checkPassword.Succeeded)
                return await JwtService.GenerateAsync(user);
            else
                throw new Exception("Wrong username or password.");
        }

        public async Task<AccessToken> Regsiter(RegsiterDto dto)
        {
            var result = await UserManager.FinadUserForRegsiterAsync(dto.UserName, dto.Phone, dto.Email);
            if (result.Success)
            {
                var destination = Mapping.MapTo<RegsiterDto, User>(dto);
                var user = await UserManager.CreateAsync(destination);
                if (user.Succeeded)
                    return await JwtService.GenerateAsync(destination);
                throw new Exception(user.Errors.FirstOrDefault().Description);
            }
            throw new Exception(result.Errors.FirstOrDefault());
        }
    }
}
