using BusinessLogicLayer.Validations.DTOsValidationRules.Base;
using CoreLayer.DTOs;
using FluentValidation;

namespace BusinessLogicLayer.Validations.DTOsValidationRules
{
    public class TagDtoValidator : BaseDtoValidator<TagDto>
    {
        public TagDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Etiket adı boş olamaz")
                .NotNull()
                .WithMessage("Etiket adı boş olamaz")
                .MaximumLength(100)
                .WithMessage("Etiket adı en fazla 100 karakter olabilir")
                .MinimumLength(3)
                .WithMessage("Etiket adı en az 3 karakter olabilir");

            RuleFor(x => x.Description)
               .NotEmpty()
               .WithMessage("Etiket açıklaması boş olamaz")
               .NotNull()
               .WithMessage("Etiket açıklaması boş olamaz")
               .MaximumLength(100)
               .WithMessage("Etiket açıklaması en fazla 100 karakter olabilir")
               .MinimumLength(3)
               .WithMessage("Etiket açıklaması en az 3 karakter olabilir");

        }
    }
}
