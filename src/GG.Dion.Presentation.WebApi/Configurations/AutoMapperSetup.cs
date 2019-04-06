using System;
using AutoMapper;
using GG.Dion.Application.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace GG.Dion.Presentation.WebApi.Configurations
{
    public static class AutoMapperSetup
    {
        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper();

            AutoMapperConfig.RegisterMappings();
        }
    }
}
