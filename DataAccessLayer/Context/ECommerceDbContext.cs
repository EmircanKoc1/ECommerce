using CoreLayer.Exceptions;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DataAccessLayer.Context
{
    public partial class ECommerceDbContext : DbContext
    {
        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options)
        {
            if (options == null) throw new DbContextNotRegisteredException(nameof(ECommerceDbContext));
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }






    }
}
