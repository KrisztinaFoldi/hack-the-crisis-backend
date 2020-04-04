using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HTCCovidBE.DTOs;
using HTCCovidBE.Models;
using HTCCovidBE.Services;
using Microsoft.AspNetCore.Mvc;

namespace HTCCovidBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignmentController : ControllerBase
    {
        private readonly IAssignmentService _assignmentService;

        public AssignmentController(IAssignmentService assignmentService)
        { 
            _assignmentService = assignmentService;
        }

//        [HttpGet]
//        public async Task<ActionResult<List<Category>>> AddAssignment()
//        {
//            
//        }

        [HttpPost]
        public async Task<ActionResult> AddAssignment([FromBody] NewAssignmentDTO assignmentDto)
        {
            if (ModelState.IsValid)
            {
                await _assignmentService.CreateNewAssignmentAsync(assignmentDto);
                return Ok();
            }

            return BadRequest();
        }
    }
}
