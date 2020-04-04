using System;
using System.Threading.Tasks;
using HTCCovidBE.Models;
using HTCCovidBE.DTOs;

namespace HTCCovidBE.Services
{
    public class TaskService : ITaskService
    {
        private readonly ApplicationContext applicationContext;

        public TaskService(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        public Task CreateNewTaskAsync(NewTaskDTO newTaskDTO)
        {
            Models.Assignment NewTask = new Task();
           

            applicationContext.Tasks.AddAsync
        }
    }
}
