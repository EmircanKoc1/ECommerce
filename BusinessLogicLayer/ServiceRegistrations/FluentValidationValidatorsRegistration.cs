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
            .AddTransient<IValidator<AddressDto>, AddressDtoValidator>()
            .AddTransient<IValidator<BrandDto>, BrandDtoValidator>()
            .AddTransient<IValidator<BrandDetailDto>, BrandDetailDtoValidator>()
            .AddTransient<IValidator<CategoryDto>, CategoryDtoValidator>()
            .AddTransient<IValidator<ClaimDto>, ClaimDtoValidator>()
            .AddTransient<IValidator<CommentDto>, CommentDtoValidator>()
            .AddTransient<IValidator<CouponDto>, CouponDtoValidator>()
            .AddTransient<IValidator<OrderItemDto>, OrderItemDtoValidator>()
            .AddTransient<IValidator<OrderStatusDto>, OrderStatusDtoValidator>()
            .AddTransient<IValidator<PaymentCardDto>, PaymentCardDtoValidator>()
            .AddTransient<IValidator<ProductDto>, ProductDtoValidator>()
            .AddTransient<IValidator<ProductFeatureDto>, ProductFeatureDtoValidator>()
            .AddTransient<IValidator<ProductImageDto>, ProductImageDtoValidator>()
            .AddTransient<IValidator<ShipmentCompanyDetailDto>, ShipmentCompanyDetailDtoValidator>()
            .AddTransient<IValidator<ShipmentCompanyDto>, ShipmentCompanyDtoValidator>()
            .AddTransient<IValidator<SubCategoryDto>, SubCategoryDtoValidator>()
            .AddTransient<IValidator<TagDto>, TagDtoValidator>()
            .AddTransient<IValidator<TokenDto>, TokenDtoValidator>()
            .AddTransient<IValidator<UserDto>, UserDtoValidator>();


    }
}
