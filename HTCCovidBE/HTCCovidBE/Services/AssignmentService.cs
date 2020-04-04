using System;
using System.Threading.Tasks;
using HTCCovidBE.DTOs;
using HTCCovidBE.Models;

namespace HTCCovidBE.Services
{
    public class AssignmentService : IAssignmentService
    {
        private readonly ApplicationContext applicationContext;

        public AssignmentService(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        public async Task CreateNewAssignmentAsync(NewAssignmentDTO newAssignmentDTO)
        {
            var AssignmentToAdd = new Assignment
            {
                CategoryId = newAssignmentDTO.CategoryId,
                Title = newAssignmentDTO.Title,
                Description = newAssignmentDTO.Description,
                Place = newAssignmentDTO.Place,
                Date = newAssignmentDTO.Date,
                PaymentDetails = newAssignmentDTO.PaymentDetails,
                Price = newAssignmentDTO.Price

            };

            await applicationContext.AddAsync(AssignmentToAdd);
            await applicationContext.SaveChangesAsync();
        }
    }
}
