using BusinessLogicLayer.Validations.DTOsValidationRules.Base;
using CoreLayer.DTOs;
using FluentValidation;

namespace BusinessLogicLayer.Validations.DTOsValidationRules
{
    public class CommentDtoValidator : BaseDtoValidator<CommentDto>
    {
        public CommentDtoValidator()
        {
            RuleFor(x => x.Title)
             .NotNull()
             .WithMessage("Başlık alanı boş bırakılamaz")
             .NotEmpty()
             .WithMessage("Başlık alanı boş bırakılamaz")
             .MinimumLength(3)
             .WithMessage("Başlık alanı en az 3 karakter olmalıdır")
             .MaximumLength(100)
             .WithMessage("Başlık alanı en fazla 100 karakter olmalıdır");

            RuleFor(x => x.Text)
             .NotNull()
             .WithMessage("Yorum  boş bırakılamaz")
             .NotEmpty()
             .WithMessage("Yorum  boş bırakılamaz")
             .MinimumLength(3)
             .WithMessage("Yorum  en az 3 karakter olmalıdır")
             .MaximumLength(100)
             .WithMessage("Yorum  en fazla 100 karakter olmalıdır");

            RuleFor(x => x.Score)
              .Must(score => score < 0 || score > 10)
              .WithMessage("Puan 0 - 5 arasında olmalıdır");

        }
    }
}
