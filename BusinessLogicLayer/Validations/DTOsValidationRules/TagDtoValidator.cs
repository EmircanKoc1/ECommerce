using BusinessLogicLayer.Validations.DTOsValidationRules.Base;
using CoreLayer.Constants.ValidationMessagesConstants;
using CoreLayer.DTOs;
using FluentValidation;

namespace BusinessLogicLayer.Validations.DTOsValidationRules
{
    public class TagDtoValidator : BaseDtoValidator<TagDto>
    {
        public TagDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage(TagDtoValidationMessages.DESCRIPTION_NOT_EMPTY_MESSAGE)
                .NotNull()
                .WithMessage(TagDtoValidationMessages.DESCRIPTION_NOT_NULL_MESSAGE)
                .MaximumLength(TagDtoValidationMessages.NAME_MAXIMUM_LENGTH_VALUE)
                .WithMessage(TagDtoValidationMessages.NAME_MAXIMUM_LENGTH_MESSAGE)
                .MinimumLength(TagDtoValidationMessages.NAME_MINIMUM_LENGTH_VALUE)
                .WithMessage(TagDtoValidationMessages.NAME_MINIMUM_LENGTH_MESSAGE);

            RuleFor(x => x.Description)
               .NotEmpty()
               .WithMessage(TagDtoValidationMessages.DESCRIPTION_NOT_EMPTY_MESSAGE)
               .NotNull()
               .WithMessage(TagDtoValidationMessages.DESCRIPTION_NOT_NULL_MESSAGE)
               .MaximumLength(TagDtoValidationMessages.DESCRIPTION_MAXIMUM_LENGTH_VALUE)
               .WithMessage(TagDtoValidationMessages.DESCRIPTION_MAXIMUM_LENGTH_MESSAGE)
               .MinimumLength(TagDtoValidationMessages.DESCRIPTION_MINIMUM_LENGTH_VALUE)
               .WithMessage(TagDtoValidationMessages.DESCRIPTION_MINIMUM_LENGTH_MESSAGE);

        }
    }
}
