using Entity.Models;
using Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace IdentityServer.Authenticate
{
    public class JwtService : IJwtService
    {
        private readonly SettingGetWay siteSetting;
        //private readonly SignInManager<User> signInManager;

        public JwtService(IOptionsSnapshot<SettingGetWay> settings, SignInManager<User> signInManager)
        {
            siteSetting = settings.Value;
            //this.signInManager = signInManager;
        }

        public AccessToken GenerateAsync(User user)
        {
            var secretKey = Encoding.UTF8.GetBytes(siteSetting.JwtSettings.SecretKey); // longer that 16 character
            var encryptkey = Encoding.UTF8.GetBytes(siteSetting.JwtSettings.Encryptkey);
            var signingCredentials = new SigningCredentials(new SymmetricSecurityKey(secretKey), SecurityAlgorithms.HmacSha256Signature);

            var encryptingCredentials = new EncryptingCredentials(new SymmetricSecurityKey(encryptkey),
                      SecurityAlgorithms.Aes128KW, SecurityAlgorithms.Aes128CbcHmacSha256);

            var claims = GetClaimsAsync(user);

            var descriptor = new SecurityTokenDescriptor
            {
                Issuer = siteSetting.JwtSettings.Issuer,
                Audience = siteSetting.JwtSettings.Audience,
                IssuedAt = DateTime.Now,
                NotBefore = DateTime.Now.AddMinutes(siteSetting.JwtSettings.NotBeforeMinutes),
                Expires = DateTime.Now.AddMinutes(siteSetting.JwtSettings.ExpirationMinutes),
                SigningCredentials = signingCredentials,
                EncryptingCredentials = encryptingCredentials,
                Subject = new ClaimsIdentity(claims)
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var securityToken = tokenHandler.CreateJwtSecurityToken(descriptor);

            return new AccessToken(securityToken);
        }

        private static IEnumerable<Claim> GetClaimsAsync(User user)
        {
            //var result = await signInManager.ClaimsFactory.CreateAsync(user);

            var securityStampClaimType = new ClaimsIdentityOptions().SecurityStampClaimType;

            return new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                //new Claim(ClaimTypes.MobilePhone, "09123456987"),
                new Claim(securityStampClaimType, user.SecurityStamp.ToString())
            };
        }
    }
}
