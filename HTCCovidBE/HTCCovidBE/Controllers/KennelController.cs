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

        // POST api/kennel
        [HttpPost]
        public async Task<ActionResult> AddKennel([FromBody] KennelDTO KennelDTO)
        {
            if (ModelState.IsValid)
            {
                await kennelService.AddKennelAsync( KennelDTO);
                return Ok();
            }

            return BadRequest();
        }

        // GET api/kennel/5
        [HttpGet("{KennelId}")]
        public async Task<ActionResult> EditKennel([FromRoute] long KennelId)
        {
            var Kennel = await kennelService.FindKennelByIdAsync(KennelId);
            if (Kennel == null)
            {
                return BadRequest("Nem található a keresett kutyafuttató");
            }

            return Ok(Kennel);
        }

        // POST api/kennel/5
        [HttpPost("{KennelId}")]
        public async Task<ActionResult> EditKennel([FromRoute] long KennelId, [FromBody] KennelDTO KennelDTO)
        {
            if (ModelState.IsValid)
            {
                await kennelService.EditKennelAsync(KennelDTO, KennelId);
                return Ok();
            }

            return BadRequest();
        }
    }
}