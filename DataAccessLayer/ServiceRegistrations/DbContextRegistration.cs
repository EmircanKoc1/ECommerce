﻿using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccessLayer.ServiceRegistrations
{
    public static class DbContextRegistration
    {

        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        => services.AddDbContextPool<ECommerceDbContext>(config =>
        {
            config.UseSqlServer(configuration.GetConnectionString("SqlServer"));
        });


    }
}
