using BusinessLogicLayer.Validations.DTOsValidationRules.Base;
using CoreLayer.DTOs;
using FluentValidation;

namespace BusinessLogicLayer.Validations.DTOsValidationRules
{
    public class CategoryDtoValidator : BaseDtoValidator<CategoryDto>
    {
        public CategoryDtoValidator()
        {
            RuleFor(x => x.Name)
           .NotNull()
           .WithMessage("Kategori adı boş bırakılamaz")
           .NotEmpty()
           .WithMessage("Kategori adı boş bırakılamaz")
           .MinimumLength(3)
           .WithMessage("Kategori adı  en az 3 karakter olmalıdır")
           .MaximumLength(100)
           .WithMessage("Kategori adı en fazla 100 karakter olmalıdır");

           RuleFor(x => x.Description)
          .NotNull()
          .WithMessage("Kategori açıklaması boş bırakılamaz")
          .NotEmpty()
          .WithMessage("Kategori açıklaması boş bırakılamaz")
          .MinimumLength(3)
          .WithMessage("Kategori açıklaması en az 3 karakter olmalıdır")
          .MaximumLength(100)
          .WithMessage("Kategori açıklaması en fazla 100 karakter olmalıdır");


        }

    }
}
