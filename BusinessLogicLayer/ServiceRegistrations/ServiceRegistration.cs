using BusinessLogicLayer.Services.Abstracts;
using BusinessLogicLayer.Services.Concretes;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLogicLayer.ServiceRegistrations
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddBllServices(this IServiceCollection services)
            => services
             .AddScoped<IAddressService, AddressService>()
             .AddScoped<IBrandService, BrandService>()
             .AddScoped<IBrandDetailService, BrandDetailService>()
             .AddScoped<ICategoryService, CategoryService>()
             .AddScoped<IClaimService, ClaimService>()
             .AddScoped<ICommentService, CommentService>()
             .AddScoped<ICouponService, CouponService>()
             .AddScoped<IOrderItemService, OrderItemService>()
             .AddScoped<IOrderService, OrderService>()
             .AddScoped<IOrderStatusService, OrderStatusService>()
             .AddScoped<IPaymentCardService, PaymentCardService>()
             .AddScoped<IProductService, ProductService>()
             .AddScoped<IProductFeatureService, ProductFeatureService>()
             .AddScoped<IProductImageService, ProductImageService>()
             .AddScoped<IShipmentCompanyService, ShipmentCompanyService>()
             .AddScoped<IShipmentCompanyDetailService, ShipmentCompanyDetailService>()
             .AddScoped<ISubCategoryService, SubCategoryService>()
             .AddScoped<ITagService, TagService>()
             .AddScoped<ITokenService, TokenService>()
             .AddTransient<IHashService, HashService>()
             .AddScoped<IUserService, UserService>();

    }
}
