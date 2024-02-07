using BusinessLogicLayer.Validations.DTOsValidationRules.Base;
using CoreLayer.DTOs;
using FluentValidation;

namespace BusinessLogicLayer.Validations.DTOsValidationRules
{
    public class ShipmentCompanyDtoValidator : BaseDtoValidator<ShipmentCompanyDto>
    {
        public ShipmentCompanyDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Kargo firması ismi boş olamaz")
                .NotNull()
                .WithMessage("Kargo firması ismi boş olamaz")
                .MinimumLength(3)
                .WithMessage("Kargo firması ismi en az 3 karakter olmalıdır")
                .MaximumLength(100)
                .WithMessage("Kargo firması ismi en fazla 100 karakter olmalıdır");
        }
    }
}
