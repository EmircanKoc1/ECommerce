using BusinessLogicLayer.Validations.DTOsValidationRules.Base;
using CoreLayer.Constants.ValidationMessagesConstants;
using CoreLayer.DTOs;
using FluentValidation;

namespace BusinessLogicLayer.Validations.DTOsValidationRules
{
    public class SubCategoryDtoValidator : BaseDtoValidator<SubCategoryDto>
    {
        public SubCategoryDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotNull()
                .WithMessage(SubCategoryDtoValidationMessages.NAME_NOT_NULL_MESSAGE)
                .NotEmpty()
                .WithMessage(SubCategoryDtoValidationMessages.NAME_NOT_EMPTY_MESSAGE)
                .MinimumLength(SubCategoryDtoValidationMessages.NAME_MINIMUM_LENGTH_VALUE)
                .WithMessage(SubCategoryDtoValidationMessages.NAME_MINIMUM_LENGTH_MESSAGE)
                .MaximumLength(SubCategoryDtoValidationMessages.NAME_MINIMUM_LENGTH_VALUE)
                .WithMessage(SubCategoryDtoValidationMessages.NAME_MINIMUM_LENGTH_MESSAGE);

            RuleFor(x => x.Description)
                .NotNull()
                .WithMessage(SubCategoryDtoValidationMessages.DESCRIPTION_NOT_NULL_MESSAGE)
                .NotEmpty()
                .WithMessage(SubCategoryDtoValidationMessages.DESCRIPTION_NOT_EMPTY_MESSAGE)
                .MinimumLength(SubCategoryDtoValidationMessages.DESCRIPTION_MINIMUM_LENGTH_VALUE)
                .WithMessage(SubCategoryDtoValidationMessages.DESCRIPTION_MINIMUM_LENGTH_MESSAGE)
                .MaximumLength(SubCategoryDtoValidationMessages.DESCRIPTION_MAXIMUM_LENGTH_VALUE)
                .WithMessage(SubCategoryDtoValidationMessages.DESCRIPTION_MAXIMUM_LENGTH_MESSAGE);




        }
    }
}
