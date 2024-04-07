using BusinessLogicLayer.Validations.DTOsValidationRules.Base;
using CoreLayer.Constants.ValidationMessagesConstants;
using CoreLayer.DTOs;
using FluentValidation;

namespace BusinessLogicLayer.Validations.DTOsValidationRules
{
    public class ProductImageDtoValidator : BaseDtoValidator<ProductImageDto>
    {
        public ProductImageDtoValidator()
        {
            RuleFor(x => x.ImagePath)
                .NotNull()
                .WithMessage(ProductImageDtoValidationMessages.IMAGEPATH_NOT_NULL_MESSAGE)
                .NotEmpty()
                .WithMessage(ProductImageDtoValidationMessages.IMAGEPATH_NOT_EMPTY_MESSAGE);

        }
    }
}
