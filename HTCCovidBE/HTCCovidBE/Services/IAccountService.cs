using HTCCovidBE.DTOs;
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
    }
}
