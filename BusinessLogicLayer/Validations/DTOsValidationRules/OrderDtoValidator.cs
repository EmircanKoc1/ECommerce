using BusinessLogicLayer.Validations.DTOsValidationRules.Base;
using CoreLayer.DTOs;
using FluentValidation;

namespace BusinessLogicLayer.Validations.DTOsValidationRules
{
    public class OrderDtoValidator : BaseDtoValidator<OrderDto>
    {
        public OrderDtoValidator()
        {

            RuleFor(x => x.TotalAmount)
                .Must(amount => amount >= 0)
                .WithMessage("Sipariş tutarı en düşük 0 olabilir");

            RuleFor(x => x.DiscountAmount)
                .Must(discountAmount => discountAmount >= 0)
                .WithMessage("İndirim tutarı en düşük 0 olabilir");


        }
    }
}
