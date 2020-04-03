using System;
using System.Threading.Tasks;
using HTCCovidBE.DTOs;

namespace HTCCovidBE.Services
{
    public interface ITaskService
    {
        Task CreateNewTaskAsync(NewTaskDTO newTaskDTO);
    }
}
