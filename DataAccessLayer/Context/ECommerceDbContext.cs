using CoreLayer.Exceptions;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DataAccessLayer.Context
{
    public partial class ECommerceDbContext : DbContext
    {
        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options)
            => _ = options ?? throw new DbContextNotRegisteredException();



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }






    }
}
