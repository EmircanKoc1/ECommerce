using BusinessLogicLayer.Validations.DTOsValidationRules;
using CoreLayer.DTOs;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLogicLayer.ServiceRegistrations
{
    public static class FluentValidationValidatorsRegistration
    {

        public static IServiceCollection AddValidationRules(this IServiceCollection services)
            => services.AddScoped<IValidator<AddressDto>, AddressDtoValidator>();


    }
}
