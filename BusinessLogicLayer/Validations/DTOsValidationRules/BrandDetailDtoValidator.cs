using BusinessLogicLayer.Validations.DTOsValidationRules.Base;
using CoreLayer.Constants.ValidationMessagesConstants;
using CoreLayer.DTOs;
using FluentValidation;

namespace BusinessLogicLayer.Validations.DTOsValidationRules
{
    public class BrandDetailDtoValidator : BaseDtoValidator<BrandDetailDto>
    {
        public BrandDetailDtoValidator()
        {
            RuleFor(x => x.Description)
              .NotNull()
              .WithMessage(BrandDetailDtoValidationMessages.DESCRIPTION_NOT_NULL_MESSAGE)
              .NotEmpty()
              .WithMessage(BrandDetailDtoValidationMessages.DESCRIPTION_NOT_EMPTY_MESSAGE)
              .MinimumLength(BrandDetailDtoValidationMessages.DESCRIPTON_MINIMUM_LENGTH_VALUE)
              .WithMessage(BrandDetailDtoValidationMessages.DESCRIPTION_MINIMUM_LENGTH_MESSAGE)
              .MaximumLength(BrandDetailDtoValidationMessages.DESCRIPTON_MAXIMUM_LENGTH_VALUE)
              .WithMessage(BrandDetailDtoValidationMessages.DESCRIPTION_MAXIMUM_LENGTH_MESSAGE);

            RuleFor(x => x.LogoPath)
             .NotNull()
             .WithMessage(BrandDetailDtoValidationMessages.LOGOPATH_NOT_NULL_MESSAGE)
             .NotEmpty()
             .WithMessage(BrandDetailDtoValidationMessages.LOGOPATH_NOT_EMPTY_MESSAGE)
             .MinimumLength(BrandDetailDtoValidationMessages.LOGOPATH_MINIMUM_LENGTH_VALUE)
             .WithMessage(BrandDetailDtoValidationMessages.LOGOPATH_MINIMUM_LENGTH_MESSAGE)
             .MaximumLength(BrandDetailDtoValidationMessages.LOGOPATH_MAXIMUM_LENGTH_VALUE)
             .WithMessage(BrandDetailDtoValidationMessages.LOGOPATH_MAXIMUM_LENGTH_MESSAGE);

            RuleFor(x => x.FoundedYear)
             .NotNull()
             .WithMessage(BrandDetailDtoValidationMessages.FOUNDEDYEAR_NOT_NULL_MESSAGE)
             .NotEmpty()
             .WithMessage(BrandDetailDtoValidationMessages.FOUNDEDYEAR_NOT_EMPTY_MESSAGE)
             .Must(date => date > DateTime.Now || date < DateTime.MinValue)
             .WithMessage(BrandDetailDtoValidationMessages.FOUNDEDYEAR_MUST_MESSAGE);




        }



    }
}
