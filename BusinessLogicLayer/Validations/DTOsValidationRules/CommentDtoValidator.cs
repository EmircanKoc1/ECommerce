using BusinessLogicLayer.Validations.DTOsValidationRules.Base;
using CoreLayer.Constants.ValidationMessagesConstants;
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
             .WithMessage(CommentDtoValidationMessages.TITLE_NOT_NULL_MESSAGE)
             .NotEmpty()
             .WithMessage(CommentDtoValidationMessages.TITLE_NOT_EMPTY_MESSAGE)
             .MinimumLength(CommentDtoValidationMessages.TITLE_MINIMUM_LENGTH_VALUE)
             .WithMessage(CommentDtoValidationMessages.TITLE_MINIMUM_LENGTH_MESSAGE)
             .MaximumLength(CommentDtoValidationMessages.TITLE_MAXIMUM_LENGTH_VALUE)
             .WithMessage(CommentDtoValidationMessages.TITLE_MAXIMUM_LENGTH_MESSAGE);

            RuleFor(x => x.Text)
             .NotNull()
             .WithMessage(CommentDtoValidationMessages.TEXT_NOT_NULL_MESSAGE)
             .NotEmpty()
             .WithMessage(CommentDtoValidationMessages.TEXT_NOT_EMPTY_MESSAGE)
             .MinimumLength(CommentDtoValidationMessages.TEXT_MINIMUM_LENGTH_VALUE)
             .WithMessage(CommentDtoValidationMessages.TEXT_MINIMUM_LENGTH_MESSAGE)
             .MaximumLength(CommentDtoValidationMessages.TEXT_MAXIMUM_LENGTH_VALUE)
             .WithMessage(CommentDtoValidationMessages.TEXT_MAXIMUM_LENGTH_MESSAGE);

            RuleFor(x => x.Score)
              .Must(score => CommentDtoValidationMessages.SCORE_MINIMUM_VALUE < 0 || CommentDtoValidationMessages.SCORE_MAXIMUM_VALUE> 5)
              .WithMessage("Puan 0 - 5 arasında olmalıdır");

        }
    }
}
