using System;
using AutoMapper;
using HTCCovidBE.DTOs;
using HTCCovidBE.Models;

namespace HTCCovidBE.Services.Helpers.AutoMapper.Profiles
{
    public class KennelFromKennelDTO : Profile
    {
        public KennelFromKennelDTO()
        {
            CreateMap<KennelDTO, Kennel>();
        }
    }
}
