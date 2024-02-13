using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ServiceRegistrations
{
    public static class AutoMapperConfiguration
    {
        public static IServiceCollection AutoMapperConfig(this IServiceCollection services)
            => services.AddAutoMapper(Assembly.GetExecutingAssembly());
    }
}
