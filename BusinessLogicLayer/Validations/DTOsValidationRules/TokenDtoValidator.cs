using BusinessLogicLayer.Validations.DTOsValidationRules.Base;
using CoreLayer.DTOs;
using FluentValidation;

namespace BusinessLogicLayer.Validations.DTOsValidationRules
{
    public class TokenDtoValidator : BaseDtoValidator<TokenDto>
    {

        public TokenDtoValidator()
        {
            RuleFor(x => x.TokenType)
                .NotEmpty()
                .WithMessage("Token türü alanı boş bırakılamaz")
                .NotNull()
                .WithMessage("Token türü alanı boş bırakılamaz")
                .MinimumLength(3)
                .WithMessage("Token türü alanı en az 3 karakter olmalıdır")
                .MaximumLength(30)
                .WithMessage("Token türü alanı en fazla 30 karakter olmalıdır");


            RuleFor(x => x.AccessToken)
                .NotEmpty()
                .WithMessage("Erişim tokeni alanı boş olamaz")
                .NotNull()
                .WithMessage("Erişim tokeni alanı boş olamaz")
                .MaximumLength(300)
                .WithMessage("Erişim tokeni en fazla 300 karakter uzunluğunda olabilir")
                .MinimumLength(3)
                .WithMessage("Erişim tokeni en az 3 karakter uzunluğunda olabilir");

            RuleFor(x => x.RefreshToken)
              .NotEmpty()
              .WithMessage("Yenileme tokeni alanı boş olamaz")
              .NotNull()
              .WithMessage("Yenileme tokeni alanı boş olamaz")
              .MaximumLength(300)
              .WithMessage("Yenileme tokeni en fazla 300 karakter uzunluğunda olabilir")
              .MinimumLength(3)
              .WithMessage("Yenileme tokeni en az 3 karakter uzunluğunda olabilir");

            RuleFor(x => x.TokenExpireDate)
                .NotNull()
                .WithMessage("Token bitiş tarihi alanı boş olamaz")
                .NotEmpty()
                .WithMessage("Token bitiş tarihi alanı boş olamaz")
                .Must(date => date > DateTime.Now)
                .WithMessage("Token bitiş tarihi şimdiden ileri de olmalı");

        }




    }
}
