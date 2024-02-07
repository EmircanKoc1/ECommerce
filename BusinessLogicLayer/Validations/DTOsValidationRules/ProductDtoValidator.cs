using BusinessLogicLayer.Validations.DTOsValidationRules.Base;
using CoreLayer.DTOs;
using FluentValidation;

namespace BusinessLogicLayer.Validations.DTOsValidationRules
{
    public class ProductDtoValidator : BaseDtoValidator<ProductDto>
    {
        public ProductDtoValidator()
        {
            RuleFor(x => x.Name)
             .NotEmpty()
             .WithMessage("Ürün ismi boş olamaz")
             .NotNull()
             .WithMessage("Ürün ismi boş olamaz")
             .MaximumLength(100)
             .WithMessage("Ürün ismi en fazla 100 karakter olabilir")
             .MinimumLength(2)
             .WithMessage("Ürün ismi en az 2 karakter olabilir");

            RuleFor(x => x.Description)
             .NotEmpty()
             .WithMessage("Ürün açıklaması boş olamaz")
             .NotNull()
             .WithMessage("Ürün açıklaması boş olamaz")
             .MaximumLength(100)
             .WithMessage("Ürün açıklaması en fazla 100 karakter olabilir")
             .MinimumLength(2)
             .WithMessage("Ürün açıklaması en az 2 karakter olabilir");


            RuleFor(x => x.Price)
                .Must(price => price >= 0)
                .WithMessage("Ürün fiyatı en az 0 olabilir ");

            RuleFor(x => x.StockQuantity)
                .Must(quantity => quantity >= 0)
                .WithMessage("Ürün stok miktarı en az 0 olabilir");

        }
    }
}
