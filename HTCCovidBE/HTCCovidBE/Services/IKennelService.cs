using System;
using System.Threading.Tasks;
using HTCCovidBE.DTOs;

namespace HTCCovidBE.Services
{
    public interface IKennelService
    {
        Task AddKennelAsync(KennelDTO kennelDTO);
    }
}
