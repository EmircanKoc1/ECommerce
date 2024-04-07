using BusinessLogicLayer.Validations.DTOsValidationRules.Base;
using CoreLayer.Constants.ValidationMessagesConstants;
using CoreLayer.DTOs;
using FluentValidation;

namespace BusinessLogicLayer.Validations.DTOsValidationRules
{
    public class AddressDtoValidator : BaseDtoValidator<AddressDto>
    {
        public AddressDtoValidator()
        {
            RuleFor(x => x.City)
                .NotEmpty()
                .WithMessage(AddressValidationMessages.CITY_NOT_EMPTY_MESSAGE)
                .NotNull()
                .WithMessage(AddressValidationMessages.CITY_NOT_NULL_MESSAGE)
                .MinimumLength(AddressValidationMessages.CITY_MINIMUM_LENGTH_VALUE)
                .WithMessage(AddressValidationMessages.CITY_MINUMUM_LENGTH_MESSAGE)
                .MaximumLength(AddressValidationMessages.CITY_MAXIMUM_LENGTH_VALUE)
                .WithMessage(AddressValidationMessages.CITY_MAXIMUM_LENGTH_MESSAGE);

            RuleFor(x => x.Street)
                .NotEmpty()
                .WithMessage(AddressValidationMessages.STREET_NOT_EMPTY_MESSAGE)
                .NotNull()
                .WithMessage(AddressValidationMessages.STREET_NOT_NULL_MESSAGE)
                .MinimumLength(AddressValidationMessages.STREET_MINIMUM_LENGTH_VALUE)
                .WithMessage(AddressValidationMessages.STREET_MINIMUM_LENGTH_MESSAGE)
                .MaximumLength(AddressValidationMessages.STREET_MAXIMUM_LENGTH_VALUE)
                .WithMessage(AddressValidationMessages.STREET_MAXIMUM_LENGTH_MESSAGE);

            RuleFor(x => x.Zipcode)
                .NotEmpty()
                .WithMessage(AddressValidationMessages.ZIPCODE_NOT_EMPTY_MESSAGE)
                .NotNull()
                .WithMessage(AddressValidationMessages.ZIPCODE_NOT_NULL_MESSAGE)
                .MinimumLength(AddressValidationMessages.ZIPCODE_MINIMUM_LENGTH_VALUE)
                .WithMessage(AddressValidationMessages.ZIPCODE_MINUMUM_LENGTH_MESSAGE)
                .MaximumLength(AddressValidationMessages.ZIPCODE_MAXIMUM_LENGTH_VALUE)
                .WithMessage(AddressValidationMessages.ZIPCODE_MAXİMUM_LENGTH_MESSAGE);

            RuleFor(x => x.AdressDescription)
               .NotEmpty()
               .WithMessage(AddressValidationMessages.ADDRESSDESCRIPTION_NOT_EMPTY_MESSAGE)
               .NotNull()
               .WithMessage(AddressValidationMessages.ADDRESSDESCRIPTION_NOT_NULL_MESSAGE)
               .MinimumLength(AddressValidationMessages.ADDRESSDESCRIPTION_MINIMUM_LENGTH_VALUE)
               .WithMessage(AddressValidationMessages.ADDRESSDESCRIPTION_MINIMUM_LENGTH_MESSAGE)
               .MaximumLength(AddressValidationMessages.ADDRESSDESCRIPTION_MAXIMUM_LENGTH_VALUE)
               .WithMessage(AddressValidationMessages.ADDRESSDESCRIPTION_MAXİMUM_LENGTH_MESSAGE);

        }
    }
}
