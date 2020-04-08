using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HTCCovidBE.DTOs;
using HTCCovidBE.Models;
using Microsoft.AspNetCore.Identity;

namespace HTCCovidBE.Services
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly ApplicationContext applicationContext;

        public AccountService(UserManager<User> userManager, SignInManager<User> signInManager, ApplicationContext applicationContext)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.applicationContext = applicationContext;
        }

        public async Task DeleteUserAsync(User User)
        {
            applicationContext.Users.Remove(User);
            await applicationContext.SaveChangesAsync();
        }

        public Task<User> FindUserAsync(string UserId)
        {
            return applicationContext.Users.FindAsync(UserId);
        }

        public async Task<IdentityResult> RegisterAsync(RegisterDTO model)
        {
            var user = new User { UserName = model.Name, Email = model.Email };
            var result = await userManager.CreateAsync(user, model.Password);

            return result;
        }
    }
}
