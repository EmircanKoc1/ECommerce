using BusinessLogicLayer.Validations.DTOsValidationRules.Base;
using CoreLayer.DTOs;
using FluentValidation;

namespace BusinessLogicLayer.Validations.DTOsValidationRules
{
    public class UserDtoValidator : BaseDtoValidator<UserDto>
    {
        public UserDtoValidator()
        {
            RuleFor(x => x.Username)
                .NotNull()
                .WithMessage("Kullanıcı adı boş olamaz")
                .NotEmpty()
                .WithMessage("kullanıcı adı boş olamaz")
                .MaximumLength(100)
                .WithMessage("Kullanıcı adı en fazla 100 karakter olabilir")
                .MinimumLength(3)
                .WithMessage("Kullanıcı adı en az 100 karakter olabililr");


            RuleFor(x => x.Name)
                .NotNull()
                .WithMessage("Kullanıcının adı boş olamaz")
                .NotEmpty()
                .WithMessage("Kullanıcının adı boş olamaz")
                .MinimumLength(2)
                .WithMessage("Kullanıcının adı en az 2 karakter olabilir")
                .MaximumLength(30)
                .WithMessage("Kullanıcının adı en fazla 30 karakter olabilir");

            RuleFor(x => x.Surname)
                .NotNull()
                .WithMessage("Kullanıcının soyadı boş olamaz")
                .NotEmpty()
                .WithMessage("Kullanıcının soyadı boş olamaz")
                .MinimumLength(2)
                .WithMessage("Kullanıcının soyadı en az 2 karakter olabilir")
                .MaximumLength(30)
                .WithMessage("Kullanıcının soyadı en fazla 30 karakter olabilir");


            RuleFor(x => x.Email)
               .NotNull()
               .WithMessage("Kullanıcının adı boş olamaz")
               .NotEmpty()
               .WithMessage("Kullanıcının adı boş olamaz")
               .EmailAddress()
               .WithMessage("Email adresi geçersiz")
               .MinimumLength(5)
               .WithMessage("Kullanıcının email adresi en az 5 karakter olabilir")
               .MaximumLength(50)
               .WithMessage("Kullanıcının email adresi  en fazla 50 karakter olabilir");


            RuleFor(x => x.PhoneNumber)
              .NotNull()
              .WithMessage("Kullanıcının telefon numarası boş olamaz")
              .NotEmpty()
              .WithMessage("Kullanıcının telefon numarası boş olamaz")
              .MinimumLength(11)
              .WithMessage("Kullanıcının telefon numarası en az 11 karakter olabilir")
              .MaximumLength(11)
              .WithMessage("Kullanıcının telefon numarası en fazla 11 karakter olabilir");

            RuleFor(x => x.BirthDate)
              .NotNull()
              .WithMessage("Doğum tarihi boş bırakılamaz")
              .NotEmpty()
              .WithMessage("Doğum tarihi boş bırakılamaz")
              .Must(date => date > DateTime.Now)
              .WithMessage("Lütfen geçerli bir tarih girin");


            RuleFor(x => x.Password)
             .NotNull()
             .WithMessage("Kullanıcının şifresi  boş olamaz")
             .NotEmpty()
             .WithMessage("Kullanıcının şifresi  boş olamaz")
             .MinimumLength(8)
             .WithMessage("Kullanıcının şifresi  en az 8 karakter olabilir")
             .MaximumLength(16)
             .WithMessage("Kullanıcının şifresi  en fazla 16 karakter olabilir");


        }
    }
}
