using Microsoft.AspNetCore.Mvc;

namespace Presentation.WebAPI.Extensions.ServiceRegistrations
{
    public static class Configurations
    {
        public static IServiceCollection ConfigModelState(this IServiceCollection services)
            => services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });
    }
}
