using AutoMapper;
using HTCCovidBE.Services.Helpers.AutoMapper.Profiles;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HTCCovidBE.Services.Helpers.AutoMapper
{
    public static class AutoMapperSetup
    {
        public static void SetUpAutoMapper(this IServiceCollection services)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DogFromDogDTO());
                cfg.AddProfile(new KennelFromKennelDTO());
            });

            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
