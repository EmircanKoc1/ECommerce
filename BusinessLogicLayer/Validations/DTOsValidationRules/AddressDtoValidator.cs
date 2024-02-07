using BusinessLogicLayer.Validations.DTOsValidationRules.Base;
using CoreLayer.DTOs;
using FluentValidation;

namespace BusinessLogicLayer.Validations.DTOsValidationRules
{
    public class AddressDtoValidator : BaseDtoValidator<AddressDto>
    {
        public AddressDtoValidator()
        {
            RuleFor(x => x.City)
                .NotEmpty()
                .WithMessage("Sehir adı boş bırakılamaz")
                .NotNull()
                .WithMessage("Sehir adı boş bırakılamaz")
                .MinimumLength(3)
                .WithMessage("Sehir adı en az 3 karakter olmalıdır")
                .MaximumLength(100)
                .WithMessage("Sehir adı en fazla 100 karakter olmalıdır");

            RuleFor(x => x.Street)
                .NotEmpty()
                .WithMessage("Sokak adı bırakılamaz")
                .NotNull()
                .WithMessage("Sokak adı boş bırakılamaz")
                .MinimumLength(3)
                .WithMessage("Sokak adı en az 3 karakter olmalıdır")
                .MaximumLength(100)
                .WithMessage("Sokak adı en fazla 100 karakter olmalıdır");


            RuleFor(x => x.Zipcode)
                .NotEmpty()
                .WithMessage("Posta Kodu bırakılamaz")
                .NotNull()
                .WithMessage("Posta Kodu boş bırakılamaz")
                .MinimumLength(3)
                .WithMessage("Posta Kodu en az 3 karakter olmalıdır")
                .MaximumLength(100)
                .WithMessage("Posta Kodu en fazla 100 karakter olmalıdır");

            RuleFor(x => x.AdressDescription)
               .NotEmpty()
               .WithMessage("Address açıklaması boş bırakılamaz")
               .NotNull()
               .WithMessage("Address açıklaması boş bırakılamaz")
               .MinimumLength(3)
               .WithMessage("Address açıklaması en az 3 karakter olmalıdır")
               .MaximumLength(100)
               .WithMessage("Address açıklaması en fazla 100 karakter olmalıdır");

        }
    }
}
