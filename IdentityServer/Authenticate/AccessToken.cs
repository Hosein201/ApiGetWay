using System;
using System.IdentityModel.Tokens.Jwt;

namespace IdentityServer.Authenticate
{
    public class AccessToken
    {
        public string Access_token { get; set; }
        public string Refresh_token { get; set; }
        public string Token_type { get; set; }
        public int Expires_in { get; set; }

        public AccessToken(JwtSecurityToken securityToken)
        {
            Access_token = new JwtSecurityTokenHandler().WriteToken(securityToken);
            Token_type = "Bearer";
            Expires_in = (int)(securityToken.ValidTo - DateTime.UtcNow).TotalSeconds;
        }
    }
}
