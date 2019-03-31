using GG.Dion.Application.Interfaces;
using GG.Dion.Application.Services;
using GG.Dion.Domain.Interfaces.Repositories;
using GG.Dion.Domain.Interfaces.Services;
using GG.Dion.Domain.Services;
using GG.Dion.Infra.Data.Context;
using GG.Dion.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace GG.Dion.Infra.IoC
{
    public static class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Application
            services.AddScoped<ICustomerAppService, CustomerAppService>();

            // Domain
            services.AddScoped<ICustomerService, CustomerService>();

            // Infra - Data
            services.AddScoped<DionProjectContext>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
        }
    }
}
