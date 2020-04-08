using HTCCovidBE.DTOs;
using HTCCovidBE.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HTCCovidBE.Services
{
    public interface IAccountService
    {
        Task<IdentityResult> RegisterAsync(RegisterDTO model);
        Task DeleteUserAsync(User User);
        Task<User> FindUserAsync(string UserId);
    }
}
