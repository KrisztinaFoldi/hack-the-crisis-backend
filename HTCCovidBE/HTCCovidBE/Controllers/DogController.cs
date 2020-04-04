using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HTCCovidBE.DTOs;
using HTCCovidBE.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HTCCovidBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogController : ControllerBase
    {
        private readonly IDogService dogService;

        public DogController(IDogService dogService)
        {
            this.dogService = dogService;
        }

        // POST api/<controller>
        [HttpPost("{userId}")]
        public async Task<ActionResult> AddDog([FromRoute] string userId, [FromBody] DogDTO dogDTO)
        {
            if (ModelState.IsValid)
            {
                await dogService.AddDogAsync(dogDTO, userId);
                return Ok();
            }

            return BadRequest();
        }

        // GET api/<controller>/5
        [HttpGet("{dogId}")]
        public async Task<ActionResult> EditDog([FromRoute] long dogId)
        {
            var dog = await dogService.FindDogById(dogId);
            if(dog == null)
            {
                return BadRequest("Nem található kutya");
            }

            return Ok(dog);
        }

        [HttpPost("{dogId}")]
        public async Task<ActionResult> EditDog([FromRoute] long dogId, [FromBody] DogDTO dogDTO)
        {
            if (ModelState.IsValid)
            {
                await dogService.EditDogAsync(dogDTO, dogId);
                return Ok();
            }

            return BadRequest();
        }


        // DELETE api/<controller>/5
        [HttpDelete("{userId}/{dogId}")]
        public async Task<ActionResult> DeleteDog ([FromRoute] string userId, long dogId)
        {
            var dogToDelete = await dogService.FindDogById(dogId);
            if (dogToDelete != null && dogToDelete.UserId == userId) 
            {
                await dogService.DeleteDogAsync(dogToDelete);
                return Ok();
            }

            return BadRequest();
        }
    }
}
