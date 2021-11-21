using Entity.Models;
using Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IdentityServer
{
    public static class UserManagerExtensions
    {
        public static async Task<Result> FinadUserForRegsiterAsync(this UserManager<User> userManager, string userName, string phone, string email)
        {
            var user = await userManager.Users.AsNoTracking()
                .FirstOrDefaultAsync(f => f.UserName == userName ||
                                          f.PhoneNumber == phone ||
                                          f.Email == email);
            if (user is null) return new Result { Data = null, Errors = null, Success = true };

            if (user is not null && user.UserName == userName)
                return new Result { Data = null, Errors = new List<string> { $"this '{userName}' is  username exists " }, Success = false };

            if (user is not null && user.PhoneNumber == phone)
                return new Result { Data = null, Errors = new List<string> { $"this '{phone}' is  phone exists " }, Success = false };

            if (user is not null && user.Email == email)
                return new Result { Data = null, Errors = new List<string> { $"this '{email}' is  email exists " }, Success = false };

            return new Result { Data = null, Errors = null, Success = false };
        }

        public static async Task<Result> GetUserFullNameAsync(this UserManager<User> userManager , string userName)
        {
            var user = await userManager.Users.AsNoTracking().FirstOrDefaultAsync(f => f.UserName == userName);
            if (user is not null )
                return new Result { Data = user.FullName, Errors = null, Success = true };
            throw new Exception("Wrong username");
        }

        public static async Task<Result> GetUserFullNameAsync(this UserManager<User> userManager, int userId)
        {
            var user = await userManager.Users.AsNoTracking().FirstOrDefaultAsync(f => f.Id == userId);
            if (user is not null)
                return new Result { Data = user.FullName, Errors = null, Success = true };
            throw new Exception("Wrong userId");
        }
    }
}
