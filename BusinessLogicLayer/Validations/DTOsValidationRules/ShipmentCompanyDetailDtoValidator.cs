using BusinessLogicLayer.Validations.DTOsValidationRules.Base;
using CoreLayer.Constants.ValidationMessagesConstants;
using CoreLayer.DTOs;
using FluentValidation;

namespace BusinessLogicLayer.Validations.DTOsValidationRules
{
    public class ShipmentCompanyDetailDtoValidator : BaseDtoValidator<ShipmentCompanyDetailDto>
    {
        public ShipmentCompanyDetailDtoValidator()
        {
            RuleFor(x => x.Description)
                .NotEmpty()
                .WithMessage(ShipmentCompanyDetailDtoValidationMessages.DESCRIPTON_NOT_EMPTY_MESSAGE)
                .NotNull()
                .WithMessage(ShipmentCompanyDetailDtoValidationMessages.DESCRIPTON_NOT_NULL_MESSAGE)
                .MaximumLength(ShipmentCompanyDetailDtoValidationMessages.DESCRIPTION_MAXIMUM_LENGTH_VALUE)
                .WithMessage(ShipmentCompanyDetailDtoValidationMessages.DESCRIPTON_MINUMUM_LENGTH_MESSAGE)
                .MinimumLength(ShipmentCompanyDetailDtoValidationMessages.DESCRIPTION_MINIMUM_LENGTH_VALUE)
                .WithMessage(ShipmentCompanyDetailDtoValidationMessages.DESCRIPTON_MINUMUM_LENGTH_MESSAGE);


            RuleFor(x => x.TotalShipmentCount)
                .Must(count => count >= 0)
                .WithMessage(ShipmentCompanyDetailDtoValidationMessages.TOTALSHIPMENTCOUNT_MESSAGE);

            RuleFor(x => x.TotalSuccessfulShipmentCount)
                .Must(count => count >= 0)
                .WithMessage(ShipmentCompanyDetailDtoValidationMessages.TOTALSUCCESFULSHIPMENTCOUNT_MESSAGE);

            RuleFor(x => x.TotalFailedShipmentCount)
                .Must(count => count >= 0)
                .WithMessage(ShipmentCompanyDetailDtoValidationMessages.TOTALFAILEDSHIPMENTCOUNT_MESSAGE);

            RuleFor(x => x.FoundedYear)
                .NotNull()
                .WithMessage(ShipmentCompanyDetailDtoValidationMessages.FOUNDEDYEAR_NOT_NULL_MESSAGE)
                .NotEmpty()
                .WithMessage(ShipmentCompanyDetailDtoValidationMessages.FOUNDEDYEAR_NOT_EMPTY_MESSAGE)
                .Must(date => date <= DateTime.Now)
                .WithMessage(ShipmentCompanyDetailDtoValidationMessages.FOUNDEDYEAR_MESSAGE);
                
        }
    }
}
