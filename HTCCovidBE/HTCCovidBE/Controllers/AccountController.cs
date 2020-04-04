using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HTCCovidBE.DTOs;
using HTCCovidBE.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HTCCovidBE.Controllers
{
    [Authorize]
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService accountService;

        public AccountController(IAccountService accountService)
        {
            this.accountService = accountService;
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<ActionResult> Register([FromBody]RegisterDTO registerDTO)
        {
            if (!ModelState.IsValid) 
            {
                return BadRequest();
            }

            var result = await accountService.RegisterAsync(registerDTO);

            if (result.Succeeded)
            {
                return Ok();
            }

            return BadRequest(result);
        }


    }
}
