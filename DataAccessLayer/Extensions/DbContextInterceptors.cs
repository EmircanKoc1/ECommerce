using DataAccessLayer.Entities.Base.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
namespace DataAccessLayer.Extensions
{
    public static class DbContextInterceptors
    {

        public static void UseCustomInterceptor(this IEnumerable<EntityEntry> entries)
        {

            var now = DateTime.Now;
            foreach (var entry in entries)
            {
                if (entry.Entity is not BaseEntity entity)
                    continue;

                switch (entry.State)
                {
                    case EntityState.Deleted:
                        entry.State = EntityState.Modified;
                        entity.Status = false;
                        entity.DeletedDate = now;
                        break;
                    case EntityState.Modified:
                        entity.UpdatedDate = now;
                        break;
                    case EntityState.Added:
                        entity.CreatedDate = now;
                        entity.Status = true;
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
