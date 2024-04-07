using BusinessLogicLayer.Validations.DTOsValidationRules.Base;
using CoreLayer.Constants.ValidationMessagesConstants;
using CoreLayer.DTOs;
using FluentValidation;

namespace BusinessLogicLayer.Validations.DTOsValidationRules
{
    public class OrderDtoValidator : BaseDtoValidator<OrderDto>
    {
        public OrderDtoValidator()
        {

            RuleFor(x => x.TotalAmount)
                .Must(amount => amount >= OrderDtoValidationMessages.TOTALAMOUNT_MINIMUM_VALUE)
                .WithMessage(OrderDtoValidationMessages.TOTALAMOUNT_MINIMUM_MESSAGE);

            RuleFor(x => x.DiscountAmount)
                .Must(discountAmount => discountAmount >= OrderDtoValidationMessages.DISCOUNT_MINIMUM_VALUE)
                .WithMessage(OrderDtoValidationMessages.DISCOUNT_MINIMUM_MESSAGE);


        }
    }
}
