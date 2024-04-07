using BusinessLogicLayer.Validations.DTOsValidationRules.Base;
using CoreLayer.Constants.ValidationMessagesConstants;
using CoreLayer.DTOs;
using FluentValidation;

namespace BusinessLogicLayer.Validations.DTOsValidationRules
{
    public class BrandDtoValidator : BaseDtoValidator<BrandDto>
    {
        public BrandDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage(BrandDtoValidationMessages.NAME_NOT_EMPTY_MESSAGE)
                .NotNull()
                .WithMessage(BrandDtoValidationMessages.NAME_NOT_NULL_MESSAGE)
                .MinimumLength(BrandDtoValidationMessages.NAME_MINIMUM_LENGTH_VALUE)
                .WithMessage(BrandDtoValidationMessages.NAME_MINIMUM_LENGTH_MESSAGE)
                .MaximumLength(BrandDtoValidationMessages.NAME_MAXIMUM_LENGTH_VALUE)
                .WithMessage(BrandDtoValidationMessages.NAME_MAXIMUM_LENGTH_MESSAGE);

        }
    }
}
