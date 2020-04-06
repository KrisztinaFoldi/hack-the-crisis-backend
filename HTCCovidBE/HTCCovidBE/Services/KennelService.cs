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

        public async Task AddKennelAsync(KennelDTO kennelDTO)
        {
            var NewKennel = mapper.Map<KennelDTO, Kennel>(kennelDTO);
            await applicationContext.Kennels.AddAsync(NewKennel);
            await applicationContext.SaveChangesAsync();
        }
    }
}
