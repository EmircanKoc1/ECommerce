using BusinessLogicLayer.Validations.DTOsValidationRules.Base;
using CoreLayer.DTOs;
using FluentValidation;

namespace BusinessLogicLayer.Validations.DTOsValidationRules
{
    public class BrandDetailDtoValidator : BaseDtoValidator<BrandDetailDto>
    {
        public BrandDetailDtoValidator()
        {
            RuleFor(x => x.Description)
              .NotNull()
              .WithMessage("Marka açıklaması boş bırakılamaz")
              .NotEmpty()
              .WithMessage("Marka açıklaması boş bırakılamaz")
              .MinimumLength(3)
              .WithMessage("Marka açıklaması en az 3 karakter olmalıdır")
              .MaximumLength(100)
              .WithMessage("Marka açıklaması en fazla 100 karakter olmalıdır");

            RuleFor(x => x.LogoPath)
             .NotNull()
             .WithMessage("Logo linki boş bırakılamaz")
             .NotEmpty()
             .WithMessage("Logo linki boş bırakılamaz")
             .MinimumLength(3)
             .WithMessage("Logo linki en az 3 karakter olmalıdır")
             .MaximumLength(100)
             .WithMessage("Logo linki en fazla 100 karakter olmalıdır");

            RuleFor(x => x.FoundedYear)
             .NotNull()
             .WithMessage("Logo linki boş bırakılamaz")
             .NotEmpty()
             .WithMessage("Logo linki boş bırakılamaz")
             .Must(date => date > DateTime.Now || date < DateTime.MinValue)
             .WithMessage("Lütfen geçerli bir kuruluş tarihi giriniz");




        }



    }
}
