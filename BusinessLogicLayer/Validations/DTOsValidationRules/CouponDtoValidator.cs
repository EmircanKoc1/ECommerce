using BusinessLogicLayer.Validations.DTOsValidationRules.Base;
using CoreLayer.Constants.ValidationMessagesConstants;
using CoreLayer.DTOs;
using FluentValidation;

namespace BusinessLogicLayer.Validations.DTOsValidationRules
{
    public class CouponDtoValidator : BaseDtoValidator<CouponDto>
    {
        public CouponDtoValidator()
        {

            RuleFor(x => x.Name)
              .NotNull()
              .WithMessage(CouponDtoValidationMessages.NAME_NOT_NULL_MESSAGE)
              .NotEmpty()
              .WithMessage(CouponDtoValidationMessages.NAME_NOT_EMPTY_MESSAGE)
              .MinimumLength(CouponDtoValidationMessages.NAME_MINIMUM_LENGTH_VALUE)
              .WithMessage(CouponDtoValidationMessages.NAME_MINIMUM_LENGTH_MESSAGE)
              .MaximumLength(CouponDtoValidationMessages.NAME_MAXIMUM_LENGTH_VALUE)
              .WithMessage(CouponDtoValidationMessages.NAME_MAXIMUM_LENGTH_MESSAGE);

            RuleFor(x => x.Description)
              .NotNull()
              .WithMessage(CouponDtoValidationMessages.DESCRIPTION_NOT_NULL_MESSAGE)
              .NotEmpty()
              .WithMessage(CouponDtoValidationMessages.DESCRIPTION_NOT_EMPTY_MESSAGE)
              .MinimumLength(CouponDtoValidationMessages.DESCRIPTION_MINIMUM_LENGTH_VALUE)
              .WithMessage(CouponDtoValidationMessages.DESCRIPTION_MINIMUM_LENGTH_MESSAGE)
              .MaximumLength(CouponDtoValidationMessages.DESCRIPTION_MAXIMUM_LENGTH_VALUE)
              .WithMessage(CouponDtoValidationMessages.DESCRIPTION_MAXIMUM_LENGTH_MESSAGE);


            RuleFor(x => x.Code)
              .NotNull()
              .WithMessage(CouponDtoValidationMessages.CODE_NOT_NULL_MESSAGE)
              .NotEmpty()
              .WithMessage(CouponDtoValidationMessages.CODE_NOT_EMPTY_MESSAGE)
              .MinimumLength(CouponDtoValidationMessages.CODE_MINIMUM_LENGTH_VALUE)
              .WithMessage(CouponDtoValidationMessages.CODE_MINIMUM_LENGTH_MESSAGE)
              .MaximumLength(CouponDtoValidationMessages.CODE_MAXIMUM_LENGTH_VALUE)
              .WithMessage(CouponDtoValidationMessages.DESCRIPTION_MAXIMUM_LENGTH_MESSAGE);

            RuleFor(x => x.MinimumPrice)
              .Must(price => price >= CouponDtoValidationMessages.MINIMUMPRICE)
              .WithMessage(CouponDtoValidationMessages.MINIMUMPRICE_MESSAGE);

            RuleFor(x => x.DiscountAmount)
              .Must(price => price > CouponDtoValidationMessages.DISCOUNTAMOUNT)
              .WithMessage(CouponDtoValidationMessages.DISCOUNTAMOUNT_MESSAGE);


            RuleFor(x => x.ExpirationDate)
                .Must(date => date <= DateTime.Now)
                .WithMessage(CouponDtoValidationMessages.EXPIRATIONDATE_MESSAGE);

        }
    }
}
