using Microsoft.Extensions.DependencyInjection;

namespace BusinessLogicLayer.ServiceRegistrations
{
    public static class MediatRConfig
    {

        public static IServiceCollection AddMediatRConfig(this IServiceCollection services)
            => services.AddMediatR(config =>
            {
                config.RegisterServicesFromAssembly(typeof(MediatRConfig).Assembly);
            });

    }
}
