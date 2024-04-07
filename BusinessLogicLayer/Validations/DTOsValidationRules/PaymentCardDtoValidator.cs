using BusinessLogicLayer.Validations.DTOsValidationRules.Base;
using CoreLayer.Constants.ValidationMessagesConstants;
using CoreLayer.DTOs;
using FluentValidation;

namespace BusinessLogicLayer.Validations.DTOsValidationRules
{
    public class PaymentCardDtoValidator : BaseDtoValidator<PaymentCardDto>
    {
        public PaymentCardDtoValidator()
        {
            RuleFor(x => x.Company)
              .NotEmpty()
              .WithMessage(PaymentCardDtoValidationMessages.COMPANY_NOT_EMPTY_MESSAGE)
              .NotNull()
              .WithMessage(PaymentCardDtoValidationMessages.COMPANY_NOT_NULL_MESSAGE)
              .MaximumLength(PaymentCardDtoValidationMessages.COMPANY_MAXIMUM_LENGTH_VALUE)
              .WithMessage(PaymentCardDtoValidationMessages.COMPANY_MAXIMUM_LENGTH_MESSAGE)
              .MinimumLength(PaymentCardDtoValidationMessages.COMPANY_MINIMUM_LENGTH_VALUE)
              .WithMessage(PaymentCardDtoValidationMessages.COMPANY_MAXIMUM_LENGTH_MESSAGE);

            RuleFor(x => x.Number)
              .NotEmpty()
              .WithMessage(PaymentCardDtoValidationMessages.NUMBER_NOT_EMPTY_MESSAGE)
              .NotNull()
              .WithMessage(PaymentCardDtoValidationMessages.NUMBER_NOT_NULL_MESSAGE)
              .MaximumLength(PaymentCardDtoValidationMessages.NUMBER_MAXIMUM_LENGTH_VALUE)
              .WithMessage(PaymentCardDtoValidationMessages.NUMBER_MAXIMUM_LENGTH_MESSAGE)
              .MinimumLength(PaymentCardDtoValidationMessages.NUMBER_MINIMUM_LENGTH_VALUE)
              .WithMessage(PaymentCardDtoValidationMessages.NUMBER_MINUMUM_LENGTH_MESSAGE);


            RuleFor(x => x.PersonName)
              .NotEmpty()
              .WithMessage(PaymentCardDtoValidationMessages.PERSONNAME_NOT_EMPTY_MESSAGE)
              .NotNull()
              .WithMessage(PaymentCardDtoValidationMessages.PERSONNAME_NOT_NULL_MESSAGE)
              .MaximumLength(PaymentCardDtoValidationMessages.PERSONNAME_MAXIMUM_LENGTH_VALUE)
              .WithMessage(PaymentCardDtoValidationMessages.PERSONNAME_MAXIMUM_LENGTH_MESSAGE)
              .MinimumLength(PaymentCardDtoValidationMessages.PERSONNAME_MINIMUM_LENGTH_VALUE)
              .WithMessage(PaymentCardDtoValidationMessages.PERSONNAME_MAXIMUM_LENGTH_MESSAGE);

            RuleFor(x => x.PersonSurname)
              .NotEmpty()
              .WithMessage(PaymentCardDtoValidationMessages.PERSONSURNAME_NOT_EMPTY_MESSAGE)
              .NotNull()
              .WithMessage(PaymentCardDtoValidationMessages.PERSONSURNAME_NOT_NULL_MESSAGE)
              .MaximumLength(PaymentCardDtoValidationMessages.PERSONSURNAME_MAXIMUM_LENGTH_VALUE)
              .WithMessage(PaymentCardDtoValidationMessages.PERSONSURNAME_MAXIMUM_LENGTH_MESSAGE)
              .MinimumLength(PaymentCardDtoValidationMessages.PERSONSURNAME_MINIMUM_LENGTH_VALUE)
              .WithMessage(PaymentCardDtoValidationMessages.PERSONSURNAME_MINUMUM_LENGTH_MESSAGE);

            RuleFor(x => x.ExpireDate)
              .NotNull()
              .WithMessage(PaymentCardDtoValidationMessages.EXPIREDATE_NOT_NULL_MESSAGE)
              .NotEmpty()
              .WithMessage(PaymentCardDtoValidationMessages.EXPIREDATE_NOT_EMPTY_MESSAGE)
              .Must(date => date > DateTime.Now)
              .WithMessage(PaymentCardDtoValidationMessages.EXPIREDATE_MESSAGE);

            RuleFor(x => x.CCV)
              .NotEmpty()
              .WithMessage(PaymentCardDtoValidationMessages.CCV_NOT_EMPTY_MESSAGE)
              .NotNull()
              .WithMessage(PaymentCardDtoValidationMessages.CCV_NOT_NULL_MESSAGE)
              .MinimumLength(PaymentCardDtoValidationMessages.CCV_MINIMUM_LENGTH_VALUE)
              .WithMessage(PaymentCardDtoValidationMessages.CCV_MINUMUM_LENGTH_MESSAGE)
              .MaximumLength(PaymentCardDtoValidationMessages.CCV_MAXIMUM_LENGTH_VALUE)
              .WithMessage(PaymentCardDtoValidationMessages.CCV_MAXIMUM_LENGTH_MESSAGE);
        }
    }
}
