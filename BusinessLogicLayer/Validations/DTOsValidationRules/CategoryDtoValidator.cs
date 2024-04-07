using BusinessLogicLayer.Validations.DTOsValidationRules.Base;
using CoreLayer.Constants.ValidationMessagesConstants;
using CoreLayer.DTOs;
using FluentValidation;

namespace BusinessLogicLayer.Validations.DTOsValidationRules
{
    public class CategoryDtoValidator : BaseDtoValidator<CategoryDto>
    {
        public CategoryDtoValidator()
        {
            RuleFor(x => x.Name)
           .NotNull()
           .WithMessage(CategoryDtoValidationMessages.NAME_NOT_NULL_MESSAGE)
           .NotEmpty()
           .WithMessage(CategoryDtoValidationMessages.NAME_NOT_NULL_MESSAGE)
           .MinimumLength(CategoryDtoValidationMessages.NAME_MINIMUM_LENGTH_VALUE)
           .WithMessage(CategoryDtoValidationMessages.NAME_MINIMUM_LENGTH_MESSAGE)
           .MaximumLength(CategoryDtoValidationMessages.NAME_MAXIMUM_LENGTH_VALUE)
           .WithMessage(CategoryDtoValidationMessages.NAME_MAXIMUM_LENGTH_MESSAGE);

           RuleFor(x => x.Description)
          .NotNull()
          .WithMessage(CategoryDtoValidationMessages.DESCRIPTION_NOT_NULL_MESSAGE)
          .NotEmpty()
          .WithMessage(CategoryDtoValidationMessages.DESCRIPTION_NOT_EMPTY_MESSAGE)
          .MinimumLength(CategoryDtoValidationMessages.DESCRIPTION_MINIMUM_LENGTH_VALUE)
          .WithMessage(CategoryDtoValidationMessages.DESCRIPTION_MINIMUM_LENGTH_MESSAGE)
          .MaximumLength(CategoryDtoValidationMessages.DESCRIPTION_MAXIMUM_LENGTH_VALUE)
          .WithMessage(CategoryDtoValidationMessages.DESCRIPTION_MAXIMUM_LENGTH_MESSAGE);


        }

    }
}
