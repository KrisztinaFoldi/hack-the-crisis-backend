using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using System.Threading.Tasks;
using HTCCovidBE.DTOs;
using HTCCovidBE.Models;
using Microsoft.EntityFrameworkCore;

namespace HTCCovidBE.Services
{
    public class DogService : IDogService
    {
        private readonly ApplicationContext applicationContext;
        private readonly IMapper mapper;

        public DogService(ApplicationContext applicationContext, IMapper mapper)
        {
            this.applicationContext = applicationContext;
            this.mapper = mapper;
        }

        public async Task<Dog> FindDogById(long dogId)
        {
            var dog = await applicationContext.Dogs.SingleOrDefaultAsync(d => d.DogId == dogId);
            return dog;
        }

        public async Task AddDogAsync(DogDTO addDogDTO, string userId)
        {
            var newDog = mapper.Map<DogDTO, Dog>(addDogDTO);
            newDog.UserId = userId;
            await applicationContext.AddAsync(newDog);
            await applicationContext.SaveChangesAsync();
        }

        public async Task EditDogAsync(DogDTO editDogDTO, long dogId)
        {
            var dogToEdit = await FindDogById(dogId);
            if (dogToEdit != null)
            {
                var editedDog = mapper.Map(editDogDTO, dogToEdit);
                applicationContext.Dogs.Update(editedDog);
                await applicationContext.SaveChangesAsync();
            }
        }

        public async Task DeleteDogAsync(Dog deleteDogDTO)
        {
           applicationContext.Remove(deleteDogDTO);
           await applicationContext.SaveChangesAsync();
            
        }
    }
}
