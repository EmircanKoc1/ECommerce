using BusinessLogicLayer.Validations.DTOsValidationRules;
using CoreLayer.DTOs;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLogicLayer.ServiceRegistrations
{
    public static class FluentValidationValidatorsRegistration
    {

        public static IServiceCollection AddValidationRules(this IServiceCollection services)
            => services
            .AddScoped<IValidator<AddressDto>, AddressDtoValidator>()
            .AddScoped<IValidator<BrandDto>, BrandDtoValidator>()
            .AddScoped<IValidator<BrandDetailDto>, BrandDetailDtoValidator>()
            .AddScoped<IValidator<CategoryDto>, CategoryDtoValidator>()
            .AddScoped<IValidator<ClaimDto>, ClaimDtoValidator>()
            .AddScoped<IValidator<CommentDto>, CommentDtoValidator>()
            .AddScoped<IValidator<CouponDto>, CouponDtoValidator>()
            .AddScoped<IValidator<OrderItemDto>, OrderItemDtoValidator>()
            .AddScoped<IValidator<OrderStatusDto>, OrderStatusDtoValidator>()
            .AddScoped<IValidator<PaymentCardDto>, PaymentCardDtoValidator>()
            .AddScoped<IValidator<ProductDto>, ProductDtoValidator>()
            .AddScoped<IValidator<ProductFeatureDto>, ProductFeatureDtoValidator>()
            .AddScoped<IValidator<ProductImageDto>, ProductImageDtoValidator>()
            .AddScoped<IValidator<ShipmentCompanyDetailDto>, ShipmentCompanyDetailDtoValidator>()
            .AddScoped<IValidator<ShipmentCompanyDto>, ShipmentCompanyDtoValidator>()
            .AddScoped<IValidator<SubCategoryDto>, SubCategoryDtoValidator>()
            .AddScoped<IValidator<TagDto>, TagDtoValidator>()
            .AddScoped<IValidator<TokenDto>, TokenDtoValidator>()
            .AddScoped<IValidator<UserDto>, UserDtoValidator>();


    }
}
