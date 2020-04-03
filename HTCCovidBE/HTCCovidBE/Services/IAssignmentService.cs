using System;
using System.Threading.Tasks;
using HTCCovidBE.DTOs;

namespace HTCCovidBE.Services
{
    public interface IAssignmentService
    {
        Task CreateNewAssignmentAsync(NewAssignmentDTO newAssignmentDTO);
    }
}
