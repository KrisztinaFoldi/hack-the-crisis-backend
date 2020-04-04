using System;
using System.Threading.Tasks;
using AutoMapper;
using HTCCovidBE.DTOs;
using HTCCovidBE.Models;

namespace HTCCovidBE.Services
{
    public class AssignmentService : IAssignmentService
    {
        private readonly ApplicationContext applicationContext;
        private readonly IMapper mapper;

        public AssignmentService(ApplicationContext applicationContext, IMapper mapper)
        {
            this.applicationContext = applicationContext;
            this.mapper = mapper;
        }

        public async Task CreateNewAssignmentAsync(NewAssignmentDTO newAssignmentDTO)
        {
            var AssignmentToAdd = mapper.Map<NewAssignmentDTO, Assignment>(newAssignmentDTO);
            await applicationContext.AddAsync(AssignmentToAdd);
            await applicationContext.SaveChangesAsync();
        }
    }
}
