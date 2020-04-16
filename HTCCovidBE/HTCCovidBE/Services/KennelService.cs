using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HTCCovidBE.DTOs;
using HTCCovidBE.Models;

namespace HTCCovidBE.Services
{
    public class KennelService : IKennelService
    {
        private readonly ApplicationContext applicationContext;
        private readonly IAccountService accountService;
        private readonly IMapper mapper;

        public KennelService(ApplicationContext applicationContext, IAccountService accountService, IMapper mapper)
        {
            this.applicationContext = applicationContext;
            this.accountService = accountService;
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

        public async Task AddToFavourite(string UserId, long KennelId)
        {
            var kennel = await FindKennelByIdAsync(KennelId);
            var user = await accountService.FindUserAsync(UserId);
            user.Favourites = new List<Favourite>();
            var favourite = new Favourite();
            favourite.UserId = UserId;
            favourite.User = user;
            favourite.KennelId = KennelId;
            favourite.Kennel = kennel;
            user.Favourites.Add(favourite);
            await applicationContext.SaveChangesAsync();
        }
    }
}
