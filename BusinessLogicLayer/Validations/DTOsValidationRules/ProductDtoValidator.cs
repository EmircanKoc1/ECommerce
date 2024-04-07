using BusinessLogicLayer.Validations.DTOsValidationRules.Base;
using CoreLayer.Constants.ValidationMessagesConstants;
using CoreLayer.DTOs;
using FluentValidation;

namespace BusinessLogicLayer.Validations.DTOsValidationRules
{
    public class ProductDtoValidator : BaseDtoValidator<ProductDto>
    {
        public ProductDtoValidator()
        {
            RuleFor(x => x.Name)
             .NotEmpty()
             .WithMessage(ProductDtoValidationMessages.NAME_NOT_EMPTY_MESSAGE)
             .NotNull()
             .WithMessage(ProductDtoValidationMessages.NAME_NOT_NULL_MESSAGE)
             .MaximumLength(ProductDtoValidationMessages.NAME_MAXIMUM_LENGTH_VALUE)
             .WithMessage(ProductDtoValidationMessages.NAME_MAXIMUM_LENGTH_MESSAGE)
             .MinimumLength(ProductDtoValidationMessages.NAME_MINIMUM_LENGTH_VALUE)
             .WithMessage(ProductDtoValidationMessages.NAME_MINUMUM_LENGTH_MESSAGE);

            RuleFor(x => x.Description)
             .NotEmpty()
             .WithMessage(ProductDtoValidationMessages.DESCRIPTION_NOT_EMPTY_MESSAGE)
             .NotNull()
             .WithMessage(ProductDtoValidationMessages.DESCRIPTION_NOT_NULL_MESSAGE)
             .MaximumLength(ProductDtoValidationMessages.DESCRIPTION_MAXIMUM_LENGTH_VALUE)
             .WithMessage(ProductDtoValidationMessages.DESCRIPTION_MAXIMUM_LENGTH_MESSAGE)
             .MinimumLength(ProductDtoValidationMessages.DESCRIPTION_MINIMUM_LENGTH_VALUE)
             .WithMessage(ProductDtoValidationMessages.DESCRIPTION_MINUMUM_LENGTH_MESSAGE);


            RuleFor(x => x.Price)
                .Must(price => price >= ProductDtoValidationMessages.PRICE_VALUE)
                .WithMessage(ProductDtoValidationMessages.PRICE_MESSAGE);

            RuleFor(x => x.StockQuantity)
                .Must(quantity => quantity >= ProductDtoValidationMessages.STOCKQUANTITY_VALUE)
                .WithMessage(ProductDtoValidationMessages.STOCKQUANTITY_MESSAGE);

        }
    }
}
