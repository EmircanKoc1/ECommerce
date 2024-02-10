using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccessLayer.ServiceRegistrations
{
    public static class DbContextRegistration
    {

        public static IServiceCollection ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        => services.AddDbContext<ECommerceDbContext>(config =>
        {
            config.UseSqlServer(configuration.GetConnectionString("SqlServer"));
        });


    }
}
