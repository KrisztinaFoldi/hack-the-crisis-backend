using System;
using System.Threading.Tasks;
using AutoMapper;
using HTCCovidBE.DTOs;
using HTCCovidBE.Models;

namespace HTCCovidBE.Services
{
    public class KennelService : IKennelService
    {
        private readonly ApplicationContext applicationContext;
        private readonly IMapper mapper;

        public KennelService(ApplicationContext applicationContext, IMapper mapper)
        {
            this.applicationContext = applicationContext;
            this.mapper = mapper;
        }

        public async Task AddKennelAsync(KennelDTO KennelDTO)
        {
            var NewKennel = mapper.Map<KennelDTO, Kennel>(KennelDTO);
            await applicationContext.Kennels.AddAsync(NewKennel);
            await applicationContext.SaveChangesAsync();
        }

        public async Task DeleteKennelAsync(Kennel KennelToDelete)
        {
            applicationContext.Kennels.Remove(KennelToDelete);
            await applicationContext.SaveChangesAsync(); 
        }

        public async Task EditKennelAsync(KennelDTO KennelDTO, long KennelId)
        {
            var KennelToEdit = await FindKennelByIdAsync(KennelId);
            if(KennelToEdit != null)
            {
                var EditedKennel = mapper.Map(KennelDTO, KennelToEdit);
                applicationContext.Kennels.Update(EditedKennel);
                await applicationContext.SaveChangesAsync();
            }
        }

        public async Task<Kennel> FindKennelByIdAsync(long KennelId)
        {
            return await applicationContext.Kennels.FindAsync(KennelId);
        }
    }
}
