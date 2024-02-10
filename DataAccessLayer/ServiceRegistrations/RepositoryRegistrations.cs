using DataAccessLayer.Repositories.Abstracts;
using DataAccessLayer.Repositories.Concretes.EfCoreRepositories;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccessLayer.ServiceRegistrations
{
    public static class RepositoryRegistrations
    {

        public static IServiceCollection AddRepositories(this IServiceCollection services)
            => services
            .AddScoped<IAddressRepository, AddressRepository>()
            .AddScoped<IBrandRepository, BrandRepository>()
            .AddScoped<IBrandDetailRepository, BrandDetailRepository>()
            .AddScoped<ICategoryRepository, CategoryRepository>()
            .AddScoped<IClaimRepository, ClaimRepository>()
            .AddScoped<ICommentRepository, CommentRepository>()
            .AddScoped<ICouponRepository, CouponRepository>()
            .AddScoped<IOrderItemRepository, OrderItemRepository>()
            .AddScoped<IOrderRepository, OrderRepository>()
            .AddScoped<IOrderStatusRepository, OrderStatusRepository>()
            .AddScoped<IPaymentCardRepository, PaymentCardRepository>()
            .AddScoped<IProductFeatureRepository, ProductFeatureRepository>()
            .AddScoped<IProductImageRepository, ProductImageRepository>()
            .AddScoped<IProductRepository, ProductRepository>()
            .AddScoped<IShipmentCompanyRepository, ShipmentCompanyRepository>()
            .AddScoped<IShipmentCompanyDetailRepository, ShipmentCompanyDetailRepository>()
            .AddScoped<ISubCategoryRepository, SubCategoryRepository>()
            .AddScoped<ITagRepository, TagRepository>()
            .AddScoped<ITokenRepository, TokenRepository>()
            .AddScoped<IUserRepository, UserRepository>();

    }
}
