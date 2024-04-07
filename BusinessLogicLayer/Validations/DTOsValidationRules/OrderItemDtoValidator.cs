using BusinessLogicLayer.Validations.DTOsValidationRules.Base;
using CoreLayer.Constants.ValidationMessagesConstants;
using CoreLayer.DTOs;
using FluentValidation;

namespace BusinessLogicLayer.Validations.DTOsValidationRules
{
    public class OrderItemDtoValidator : BaseDtoValidator<OrderItemDto>
    {
        public OrderItemDtoValidator()
        {
            RuleFor(x => x.Price)
                .Must(price => price >= OrderItemDtoValidatationMessages.PRICE_MINIMUM_VALUE)
                .WithMessage(OrderItemDtoValidatationMessages.PRICE_MINIMUM_MESSAGE);

            RuleFor(x => x.Quantity)
                .Must(quantity => quantity >= OrderItemDtoValidatationMessages.QUANTITY_MINIMUM_VALUE)
                .WithMessage(OrderItemDtoValidatationMessages.QUANTITY_MINIMUM_MESSAGE);

            RuleFor(x => x.TotalPrice)
                .Must(totalPrice => totalPrice >= OrderItemDtoValidatationMessages.TOTALPRICE_MINIMUM_VALUE)
                .WithMessage(OrderItemDtoValidatationMessages.TOTALPRICE_MINIMUM_MESSAGE);

        }
    }
}
