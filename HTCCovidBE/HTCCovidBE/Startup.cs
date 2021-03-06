﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HTCCovidBE.Models;
using HTCCovidBE.Services;
using HTCCovidBE.Services.Helpers.AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace HTCCovidBE
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IAccountService, AccountService>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddIdentity<User, IdentityRole>()
               .AddEntityFrameworkStores<ApplicationContext>();
            services.AddDbContext<ApplicationContext>(builder =>
                   builder.UseMySql(Configuration.GetConnectionString("DefaultConnection")));
            services.BuildServiceProvider().GetService<ApplicationContext>().Database.Migrate();
            services.AddTransient<IDogService, DogService>();
            services.AddTransient<IKennelService, KennelService>();
            services.SetUpAutoMapper();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
