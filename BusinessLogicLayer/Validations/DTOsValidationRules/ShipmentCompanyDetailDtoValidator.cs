using BusinessLogicLayer.Validations.DTOsValidationRules.Base;
using CoreLayer.DTOs;
using FluentValidation;

namespace BusinessLogicLayer.Validations.DTOsValidationRules
{
    public class ShipmentCompanyDetailDtoValidator : BaseDtoValidator<ShipmentCompanyDetailDto>
    {
        public ShipmentCompanyDetailDtoValidator()
        {
            RuleFor(x => x.Description)
                .NotEmpty()
                .WithMessage("Kargo firması açıklaması boş olamaz")
                .NotNull()
                .WithMessage("Kargo firması açıklaması boş olamaz")
                .MaximumLength(300)
                .WithMessage("Kargo firması açıklaması en fazla 300 karakter olabilir")
                .MinimumLength(3)
                .WithMessage("Kargo firması açıklaması en az 3 karakter olabilir");


            RuleFor(x => x.TotalShipmentCount)
                .Must(count => count >= 0)
                .WithMessage("Toplam kargo sayısı en az 0 olabilir");

            RuleFor(x => x.TotalSuccessfulShipmentCount)
                .Must(count => count >= 0)
                .WithMessage("Toplam başarılı kargo sayısı en az 0 olabilir");

            RuleFor(x => x.TotalFailedShipmentCount)
                .Must(count => count >= 0)
                .WithMessage("Toplam başarısız kargo sayısı en az 0 olabilir");

            RuleFor(x => x.FoundedYear)
                .NotNull()
                .WithMessage("Kuruluş yılı boş olamaz")
                .NotEmpty()
                .WithMessage("Kuruluş yılı boş olamaz")
                .Must(date => date <= DateTime.Now)
                .WithMessage("Geçerli bir kuruluş tarihi girilmelidir");
                
        }
    }
}
