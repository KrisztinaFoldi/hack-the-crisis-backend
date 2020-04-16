using System;
using System.Threading.Tasks;
using HTCCovidBE.DTOs;
using HTCCovidBE.Models;

namespace HTCCovidBE.Services
{
    public interface IKennelService
    {
        Task AddKennelAsync(KennelDTO KennelDTO);
        Task<Kennel> FindKennelByIdAsync(long KennelId);
        Task EditKennelAsync(KennelDTO KennelDTO, long KennelId);
        Task DeleteKennelAsync(Kennel KennelToDelete);
        Task AddToFavourite(string UserId, long KennelId);
    }
}
