using BusinessLogicLayer.Validations.DTOsValidationRules.Base;
using CoreLayer.Constants.ValidationMessagesConstants;
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
               .WithMessage(UserDtoValidationMessages.USERNAME_NOT_NULL_MESSAGE)
               .NotEmpty()
               .WithMessage(UserDtoValidationMessages.USERNAME_NOT_EMPTY_MESSAGE)
               .MaximumLength(UserDtoValidationMessages.USERNAME_MAXIMUM_LENGTH_VALUE)
               .WithMessage(UserDtoValidationMessages.USERNAME_MAXIMUM_LENGTH_MESSAGE)
               .MinimumLength(UserDtoValidationMessages.USERNAME_MINIMUM_LENGTH_VALUE)
               .WithMessage(UserDtoValidationMessages.USERNAME_MINIMUM_LENGTH_MESSAGE);


            RuleFor(x => x.Name)
                .NotNull()
                .WithMessage(UserDtoValidationMessages.NAME_NOT_NULL_MESSAGE)
                .NotEmpty()
                .WithMessage(UserDtoValidationMessages.NAME_NOT_EMPTY_MESSAGE)
                .MinimumLength(UserDtoValidationMessages.NAME_MINIMUM_LENGTH_VALUE)
                .WithMessage(UserDtoValidationMessages.NAME_MINIMUM_LENGTH_MESSAGE)
                .MaximumLength(UserDtoValidationMessages.NAME_MAXIMUM_LENGTH_VALUE)
                .WithMessage(UserDtoValidationMessages.NAME_MAXIMUM_LENGTH_MESSAGE);

            RuleFor(x => x.Surname)
                .NotNull()
                .WithMessage(UserDtoValidationMessages.SURNAME_NOT_NULL_MESSAGE)
                .NotEmpty()
                .WithMessage(UserDtoValidationMessages.SURNAME_NOT_EMPTY_MESSAGE)
                .MinimumLength(UserDtoValidationMessages.SURNAME_MINIMUM_LENGTH_VALUE)
                .WithMessage(UserDtoValidationMessages.SURNAME_MINIMUM_LENGTH_MESSAGE)
                .MaximumLength(UserDtoValidationMessages.SURNAME_MAXIMUM_LENGTH_VALUE)
                .WithMessage(UserDtoValidationMessages.SURNAME_MAXIMUM_LENGTH_MESSAGE);


            RuleFor(x => x.Email)
               .NotNull()
               .WithMessage(UserDtoValidationMessages.EMAIL_NOT_NULL_MESSAGE)
               .NotEmpty()
               .WithMessage(UserDtoValidationMessages.EMAIL_NOT_EMPTY_MESSAGE)
               .EmailAddress()
               .WithMessage(UserDtoValidationMessages.EMAIL_INVALID_MESSAGE)
               .MinimumLength(UserDtoValidationMessages.EMAIL_MINIMUM_LENGTH_VALUE)
               .WithMessage(UserDtoValidationMessages.EMAIL_MINIMUM_LENGTH_MESSAGE)
               .MaximumLength(UserDtoValidationMessages.EMAIL_MAXIMUM_LENGTH_VALUE)
               .WithMessage(UserDtoValidationMessages.EMAIL_MAXIMUM_LENGTH_MESSAGE);


            RuleFor(x => x.PhoneNumber)
              .NotNull()
              .WithMessage(UserDtoValidationMessages.PHONENUMBER_NOT_NULL_MESSAGE)
              .NotEmpty()
              .WithMessage(UserDtoValidationMessages.PHONENUMBER_NOT_EMPTY_MESSAGE)
              .MinimumLength(UserDtoValidationMessages.PHONENUMBER_MINIMUM_LENGTH_VALUE)
              .WithMessage(UserDtoValidationMessages.PHONENUMBER_MINIMUM_LENGTH_MESSAGE)
              .MaximumLength(UserDtoValidationMessages.PHONENUMBER_MAXIMUM_LENGTH_VALUE)
              .WithMessage(UserDtoValidationMessages.PHONENUMBER_MAXIMUM_LENGTH_MESSAGE);

            RuleFor(x => x.BirthDate)
              .NotNull()
              .WithMessage(UserDtoValidationMessages.BIRTHDATE_NOT_NULL_MESSAGE)
              .NotEmpty()
              .WithMessage(UserDtoValidationMessages.BIRTHDATE_NOT_EMPTY_MESSAGE)
              .Must(date => date > DateTime.Now)
              .WithMessage(UserDtoValidationMessages.BIRTHDATE_INVALID_MESSAGE);


            RuleFor(x => x.Password)
             .NotNull()
             .WithMessage(UserDtoValidationMessages.PASSWORD_NOT_NULL_MESSAGE)
             .NotEmpty()
             .WithMessage(UserDtoValidationMessages.PASSWORD_NOT_EMPTY_MESSAGE)
             .MinimumLength(UserDtoValidationMessages.PASSWORD_MINIMUM_LENGTH_VALUE)
             .WithMessage(UserDtoValidationMessages.PASSWORD_MINIMUM_LENGTH_MESSAGE)
             .MaximumLength(UserDtoValidationMessages.PASSWORD_MAXIMUM_LENGTH_VALUE)
             .WithMessage(UserDtoValidationMessages.PASSWORD_MAXIMUM_LENGTH_MESSAGE);
        }





    }
}


