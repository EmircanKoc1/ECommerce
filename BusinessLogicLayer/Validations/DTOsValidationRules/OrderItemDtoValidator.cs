using BusinessLogicLayer.Validations.DTOsValidationRules.Base;
using CoreLayer.DTOs;
using FluentValidation;

namespace BusinessLogicLayer.Validations.DTOsValidationRules
{
    public class OrderItemDtoValidator : BaseDtoValidator<OrderItemDto>
    {
        public OrderItemDtoValidator()
        {
            RuleFor(x => x.Price)
                .Must(price => price >= 0)
                .WithMessage("Ürün fiyatı en az 0 olabilir");

            RuleFor(x => x.Quantity)
                .Must(quantity => quantity >= 1)
                .WithMessage("Alınan ürün miktarı en az 1 olmalıdır");

            RuleFor(x => x.TotalPrice)
                .Must(totalPrice => totalPrice >= 0)
                .WithMessage("Toplam tutar en az 0 olabilir");

        }
    }
}
