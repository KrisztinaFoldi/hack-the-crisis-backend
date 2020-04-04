using HTCCovidBE.DTOs;
using HTCCovidBE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HTCCovidBE.Services
{
    public interface IDogService
    {
        Task<Dog> FindDogById(long dogId);
        Task AddDogAsync(DogDTO addDogDTO, string userId);
        Task EditDogAsync(DogDTO editDogDTO, long dogId);
        Task DeleteDogAsync(Dog deleteDogDTO);
    }
}
