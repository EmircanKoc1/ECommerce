using BusinessLogicLayer.Validations.DTOsValidationRules.Base;
using CoreLayer.DTOs;
using FluentValidation;

namespace BusinessLogicLayer.Validations.DTOsValidationRules
{
    public class PaymentCardDtoValidator : BaseDtoValidator<PaymentCardDto>
    {
        public PaymentCardDtoValidator()
        {
            RuleFor(x => x.Company)
              .NotEmpty()
              .WithMessage("Kuruluş ismi boş olamaz")
              .NotNull()
              .WithMessage("Kuruluş ismi boş olamaz")
              .MaximumLength(100)
              .WithMessage("Kuruluş ismi en fazla 100 karakter olabilir")
              .MinimumLength(2)
              .WithMessage("Kuruluş ismi en az 2 karakter olabilir");

            RuleFor(x => x.Number)
              .NotEmpty()
              .WithMessage("Kart numarası boş olamaz")
              .NotNull()
              .WithMessage("Kart numarası boş olamaz")
              .MaximumLength(100)
              .WithMessage("Kart numarası en fazla 100 karakter olabilir")
              .MinimumLength(2)
              .WithMessage("Kart numarası en az 10 karakter olabilir");


            RuleFor(x => x.PersonName)
              .NotEmpty()
              .WithMessage("Kart sahibi adı boş olamaz")
              .NotNull()
              .WithMessage("Kart sahibi adıboş olamaz")
              .MaximumLength(100)
              .WithMessage("Kart sahibi adı en fazla 100 karakter olabilir")
              .MinimumLength(2)
              .WithMessage("Kart sahibi adı en az 10 karakter olabilir");

            RuleFor(x => x.PersonSurname)
              .NotEmpty()
              .WithMessage("Kart sahibi soyadı boş olamaz")
              .NotNull()
              .WithMessage("Kart sahibi soyadı boş olamaz")
              .MaximumLength(100)
              .WithMessage("Kart sahibi soyadı en fazla 100 karakter olabilir")
              .MinimumLength(2)
              .WithMessage("Kart sahibi soyaadı en az 10 karakter olabilir");

            RuleFor(x => x.ExpireDate)
              .NotNull()
              .WithMessage("Kartın son kullanma tarihi boş olamaz")
              .NotEmpty()
              .WithMessage("Kartın son kullanma tarihi boş olamaz")
              .Must(date => date > DateTime.Now)
              .WithMessage("Son kullanma tarihi geçerli olan bir kart girilmeli");

            RuleFor(x => x.CCV)
              .NotEmpty()
              .WithMessage("CCV boş olamaz")
              .NotNull()
              .WithMessage("CCV boş olamaz")
              .MinimumLength(3)
              .WithMessage("CCV en az 3 karakter olabilir")
              .MaximumLength(3)
              .WithMessage("CCV en fazla 3 karakter olabilir");
        }
    }
}
