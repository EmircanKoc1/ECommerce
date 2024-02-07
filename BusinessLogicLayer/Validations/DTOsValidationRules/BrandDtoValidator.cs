using BusinessLogicLayer.Validations.DTOsValidationRules.Base;
using CoreLayer.DTOs;
using FluentValidation;

namespace BusinessLogicLayer.Validations.DTOsValidationRules
{
    public class BrandDtoValidator : BaseDtoValidator<BrandDto>
    {
        public BrandDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotNull()
                .WithMessage("Marka adı boş bırakılamaz")
                .NotEmpty()
                .WithMessage("Marka adı boş bırakılamaz")
                .MinimumLength(3)
                .WithMessage("Sehir adı en az 3 karakter olmalıdır")
                .MaximumLength(100)
                .WithMessage("Sehir adı en fazla 100 karakter olmalıdır");

        }
    }
}
