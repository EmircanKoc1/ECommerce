using BusinessLogicLayer.Services.Abstracts;
using BusinessLogicLayer.Services.Concretes;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLogicLayer.ServiceRegistrations
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddBllServices(this IServiceCollection services)
            => services
            .AddScoped<IAddressService, AddressService>();


    }
}
