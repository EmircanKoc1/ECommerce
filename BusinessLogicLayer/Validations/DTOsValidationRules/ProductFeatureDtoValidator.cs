using BusinessLogicLayer.Validations.DTOsValidationRules.Base;
using CoreLayer.DTOs;
using FluentValidation;

namespace BusinessLogicLayer.Validations.DTOsValidationRules
{
    public class ProductFeatureDtoValidator : BaseDtoValidator<ProductFeatureDto>
    {
        public ProductFeatureDtoValidator()
        {
            RuleFor(x => x.Key)
                .NotNull()
                .WithMessage("Ürün özelliği kısmı boş olamaz")
                .NotEmpty()
                .WithMessage("Ürün özelliği kısmı boş olamaz")
                .MinimumLength(3)
                .WithMessage("Ürün özelliği en az 3 karakter olabilir")
                .MaximumLength(100)
                .WithMessage("Ürün özelliği en fazla 100 karakter olabilir");

            RuleFor(x => x.Value)
                .NotNull()
                .WithMessage("Ürün özelliği kısmı boş olamaz")
                .NotEmpty()
                .WithMessage("Ürün özelliği kısmı boş olamaz")
                .MinimumLength(3)
                .WithMessage("Ürün özelliği en az 3 karakter olabilir")
                .MaximumLength(100)
                .WithMessage("Ürün özelliği en fazla 100 karakter olabilir");

        }
    }
}
