using DataAccessLayer.ServiceRegistrations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ServiceRegistrations
{
    public static class DataAccessLayerConfigurations
    {
        public static IServiceCollection DbContextConfig(this IServiceCollection services,IConfiguration configuration)
            => services.ConfigureDbContext(configuration);

        public static IServiceCollection RepositoriesConfig(this IServiceCollection services)
            => services.AddRepositories();


    }
}
