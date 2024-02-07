using BusinessLogicLayer.Validations.DTOsValidationRules.Base;
using CoreLayer.DTOs;
using FluentValidation;

namespace BusinessLogicLayer.Validations.DTOsValidationRules
{
    public class ClaimDtoValidator : BaseDtoValidator<ClaimDto>
    {

        public ClaimDtoValidator()
        {

            RuleFor(x => x.ClaimType)
             .NotNull()
             .WithMessage("Claim türü boş bırakılamaz")
             .NotEmpty()
             .WithMessage("Claim türü boş bırakılamaz")
             .MinimumLength(3)
             .WithMessage("Claim türü  en az 3 karakter olmalıdır")
             .MaximumLength(100)
             .WithMessage("Claim türü en fazla 100 karakter olmalıdır");

            RuleFor(x => x.ClaimName)
             .NotNull()
             .WithMessage("Claim adı boş bırakılamaz")
             .NotEmpty()
             .WithMessage("Claim adı boş bırakılamaz")
             .MinimumLength(3)
             .WithMessage("Claim adı  en az 3 karakter olmalıdır")
             .MaximumLength(100)
             .WithMessage("Claim adı en fazla 100 karakter olmalıdır");


        }
    }
}
