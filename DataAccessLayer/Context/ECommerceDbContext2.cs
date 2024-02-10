using DataAccessLayer.Extensions;

namespace DataAccessLayer.Context
{
    public partial class ECommerceDbContext
    {
        public override int SaveChanges()
        {
            ChangeTracker.Entries().UseCustomInterceptor();
            return base.SaveChanges();
        }
        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {

            ChangeTracker.Entries().UseCustomInterceptor();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            ChangeTracker.Entries().UseCustomInterceptor();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            ChangeTracker.Entries().UseCustomInterceptor();
            return base.SaveChangesAsync(cancellationToken);
        }

    }
}
