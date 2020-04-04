using AutoMapper;
using HTCCovidBE.DTOs;
using HTCCovidBE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HTCCovidBE.Services.Helpers.AutoMapper.Profiles
{
    public class AssignmentFromNewAssignmentDTO : Profile
    {
        public AssignmentFromNewAssignmentDTO()
        {
            CreateMap<NewAssignmentDTO, Assignment>();   
        }
    }
}
