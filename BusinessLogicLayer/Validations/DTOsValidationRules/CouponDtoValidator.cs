using BusinessLogicLayer.Validations.DTOsValidationRules.Base;
using CoreLayer.DTOs;
using FluentValidation;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace BusinessLogicLayer.Validations.DTOsValidationRules
{
    public class CouponDtoValidator : BaseDtoValidator<CouponDto>
    {
        public CouponDtoValidator()
        {
            RuleFor(x => x.Name)
              .NotNull()
              .WithMessage("Kupon Adı boş bırakılamaz")
              .NotEmpty()
              .WithMessage("Kupon Adı boş bırakılamaz")
              .MinimumLength(3)
              .WithMessage("Kupon Adı en az 3 karakter olmalıdır")
              .MaximumLength(100)
              .WithMessage("Kupon adı en fazla 100 karakter olmalıdır");

            RuleFor(x => x.Description)
              .NotNull()
              .WithMessage("Kupon açıklaması boş bırakılamaz")
              .NotEmpty()
              .WithMessage("Kupon açıklaması boş bırakılamaz")
              .MinimumLength(3)
              .WithMessage("Kupon açıklaması en az 3 karakter olmalıdır")
              .MaximumLength(100)
              .WithMessage("Kupon açıklaması en fazla 100 karakter olmalıdır");

            RuleFor(x => x.Code)
              .NotNull()
              .WithMessage("Kupon kodu boş bırakılamaz")
              .NotEmpty()
              .WithMessage("Kupon kodu boş bırakılamaz")
              .MinimumLength(3)
              .WithMessage("Kupon kodu en az 3 karakter olmalıdır")
              .MaximumLength(100)
              .WithMessage("Kupon kodu en fazla 100 karakter olmalıdır");

            RuleFor(x => x.MinimumPrice)
              .Must(price => price >= 0)
              .WithMessage("Kupon için gereken minimum tutar en az 0 olmalıdır");

            RuleFor(x => x.DiscountAmount)
              .Must(price => price > 0)
              .WithMessage("Kupon indirim tutarı en az 1 olmalıdır");


            RuleFor(x => x.ExpirationDate)
                .Must(date => date  <= DateTime.Now)
                .WithMessage("Kupon artık geçerli değil");

        }
    }
}
