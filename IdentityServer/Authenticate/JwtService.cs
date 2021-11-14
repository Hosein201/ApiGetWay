using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.Authenticate
{
    public class JwtService : IJwtService
    {
        public Task<AccessToken> GenerateAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
