using BusinessLogicLayer.Validations.DTOsValidationRules.Base;
using CoreLayer.Constants.ValidationMessagesConstants;
using CoreLayer.DTOs;
using FluentValidation;

namespace BusinessLogicLayer.Validations.DTOsValidationRules
{
    public class ClaimDtoValidator : BaseDtoValidator<ClaimDto>
    {

        public ClaimDtoValidator()
        {

            RuleFor(x => x.ClaimName)
             .NotNull()
             .WithMessage(ClaimDtoValidationMessages.CLAIMNAME_NOT_NULL_MESSAGE)
             .NotEmpty()
             .WithMessage(ClaimDtoValidationMessages.CLAIMNAME_NOT_EMPTY_MESSAGE)
             .MinimumLength(ClaimDtoValidationMessages.CLAIMNAME_MINIMUM_LENGTH_VALUE)
             .WithMessage(ClaimDtoValidationMessages.CLAIMNAME_MINIMUM_LENGTH_MESSAGE)
             .MaximumLength(ClaimDtoValidationMessages.CLAIMNAME_MAXIMUM_LENGTH_VALUE)
             .WithMessage(ClaimDtoValidationMessages.CLAIMNAME_MAXIMUM_LENGTH_MESSAGE);

            RuleFor(x => x.ClaimType)
             .NotNull()
             .WithMessage(ClaimDtoValidationMessages.CLAIMTYPE_NOT_NULL_MESSAGE)
             .NotEmpty()
             .WithMessage(ClaimDtoValidationMessages.CLAIMTYPE_NOT_EMPTY_MESSAGE)
             .MinimumLength(ClaimDtoValidationMessages.CLAIMTYPE_MINIMUM_LENGTH_VALUE)
             .WithMessage(ClaimDtoValidationMessages.CLAIMTYPE_MINIMUM_LENGTH_MESSAGE)
             .MaximumLength(ClaimDtoValidationMessages.CLAIMTYPE_MAXIMUM_LENGTH_VALUE)
             .WithMessage(ClaimDtoValidationMessages.CLAIMTYPE_MAXIMUM_LENGTH_MESSAGE);


        }
    }
}
