using BusinessLogicLayer.Validations.DTOsValidationRules.Base;
using CoreLayer.Constants.ValidationMessagesConstants;
using CoreLayer.DTOs;
using FluentValidation;

namespace BusinessLogicLayer.Validations.DTOsValidationRules
{
    public class ShipmentCompanyDtoValidator : BaseDtoValidator<ShipmentCompanyDto>
    {
        public ShipmentCompanyDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage(ShipmentCompanyDtoValidationMessages.NAME_NOT_EMPTY_MESSAGE)
                .NotNull()
                .WithMessage(ShipmentCompanyDtoValidationMessages.NAME_NOT_NULL_MESSAGE)
                .MinimumLength(ShipmentCompanyDtoValidationMessages.NAME_MINIMUM_LENGTH_VALUE)
                .WithMessage(ShipmentCompanyDtoValidationMessages.NAME_MINIMUM_LENGTH_MESSAGE)
                .MaximumLength(ShipmentCompanyDtoValidationMessages.NAME_MAXIMUM_LENGTH_VALUE)
                .WithMessage(ShipmentCompanyDtoValidationMessages.NAME_MAXIMUM_LENGTH_MESSAGE);
        }
    }
}
