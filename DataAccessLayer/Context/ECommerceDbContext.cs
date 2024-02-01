using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DataAccessLayer.Context
{
    public class ECommerceDbContext : DbContext
    {
        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options)
        {

        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<BrandDetail> BrandDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<OrderStatus> orderStatuses { get; set; }
        public DbSet<PaymentCard> PaymentCards { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ShipmentCompany> ShipmentCompanies { get; set; }
        public DbSet<ShipmentCompanyDetail> ShipmentDetails { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Token> Tokens { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //modelBuilder.UsePropertyAccessMode(PropertyAccessMode.)

        }


    }
}
