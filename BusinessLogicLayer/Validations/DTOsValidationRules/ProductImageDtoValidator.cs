using BusinessLogicLayer.Validations.DTOsValidationRules.Base;
using CoreLayer.DTOs;
using FluentValidation;

namespace BusinessLogicLayer.Validations.DTOsValidationRules
{
    public class ProductImageDtoValidator : BaseDtoValidator<ProductImageDto>
    {
        public ProductImageDtoValidator()
        {
            RuleFor(x => x.ImagePath)
                .NotNull()
                .WithMessage("Resim yolu boş olamaz")
                .NotEmpty()
                .WithMessage("Resim yolu boş olamaz");

        }
    }
}
