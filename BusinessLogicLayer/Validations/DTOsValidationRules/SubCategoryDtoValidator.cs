using BusinessLogicLayer.Validations.DTOsValidationRules.Base;
using CoreLayer.DTOs;
using FluentValidation;

namespace BusinessLogicLayer.Validations.DTOsValidationRules
{
    public class SubCategoryDtoValidator : BaseDtoValidator<SubCategoryDto>
    {
        public SubCategoryDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotNull()
                .WithMessage("Alt kategori ismi boş olamaz")
                .NotEmpty()
                .WithMessage("Alt kategori ismi boş olamaz")
                .MinimumLength(3)
                .WithMessage("Alt kategori ismi en az 3 karakter olmalıdır ")
                .MaximumLength(100)
                .WithMessage("Alt kategori ismi en fazla 100 karakter olmalıdır");

            RuleFor(x => x.Description)
                .NotNull()
                .WithMessage("Alt kategori açıklaması boş olamaz")
                .NotEmpty()
                .WithMessage("Alt kategori açıklaması boş olamaz")
                .MinimumLength(3)
                .WithMessage("Alt kategori açıklaması en az 3 karakter olmalıdır ")
                .MaximumLength(100)
                .WithMessage("Alt kategori açıklaması en fazla 100 karakter olmalıdır");




        }
    }
}
