using BusinessLogicLayer.Validations.DTOsValidationRules.Base;
using CoreLayer.Constants.ValidationMessagesConstants;
using CoreLayer.DTOs;
using FluentValidation;

namespace BusinessLogicLayer.Validations.DTOsValidationRules
{
    public class ProductFeatureDtoValidator : BaseDtoValidator<ProductFeatureDto>
    {
        public ProductFeatureDtoValidator()
        {
            RuleFor(x => x.Key)
                .NotNull()
                .WithMessage(ProductFeatureDtoValidationMessages.KEY_NOT_NULL_MESSAGE)
                .NotEmpty()
                .WithMessage(ProductFeatureDtoValidationMessages.KEY_NOT_EMPTY_MESSAGE)
                .MinimumLength(ProductFeatureDtoValidationMessages.KEY_MINIMUM_LENGTH_VALUE)
                .WithMessage(ProductFeatureDtoValidationMessages.KEY_MINUMUM_LENGTH_MESSAGE)
                .MaximumLength(ProductFeatureDtoValidationMessages.KEY_MAXIMUM_LENGTH_VALUE)
                .WithMessage(ProductFeatureDtoValidationMessages.KEY_MAXIMUM_LENGTH_MESSAGE);

            RuleFor(x => x.Value)
                .NotNull()
                .WithMessage(ProductFeatureDtoValidationMessages.VALUE_NOT_NULL_MESSAGE)
                .NotEmpty()
                .WithMessage(ProductFeatureDtoValidationMessages.VALUE_NOT_EMPTY_MESSAGE)
                .MinimumLength(ProductFeatureDtoValidationMessages.VALUE_MINIMUM_LENGTH_VALUE)
                .WithMessage(ProductFeatureDtoValidationMessages.VALUE_MINUMUM_LENGTH_MESSAGE)
                .MaximumLength(ProductFeatureDtoValidationMessages.VALUE_MAXIMUM_LENGTH_VALUE)
                .WithMessage(ProductFeatureDtoValidationMessages.VALUE_MAXIMUM_LENGTH_MESSAGE);

        }
    }
}
