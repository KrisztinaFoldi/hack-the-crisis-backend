using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HTCCovidBE.DTOs;
using HTCCovidBE.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HTCCovidBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "Admin")]
    public class KennelController : ControllerBase
    {
        private readonly IKennelService kennelService;

        public KennelController(IKennelService kennelService)
        {
            this.kennelService = kennelService;
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<ActionResult> AddKennel([FromBody] KennelDTO KennelDTO)
        {
            if (ModelState.IsValid)
            {
                await kennelService.AddKennelAsync(KennelDTO);
                return Ok();
            }

            return BadRequest();
        }

    }
}