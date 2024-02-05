using CoreLayer.DataTransferObjects.Base;
using FluentValidation;

namespace BusinessLogicLayer.Validations.ValidationRules.BaseDtos
{
    public abstract class BaseDtoForUpdateValidator<T> : BaseDtoValidator<T>
    where T : BaseDtoForUpdate
    {
        public BaseDtoForUpdateValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("Id alanı boş olamaz")
                .NotNull()
                .WithMessage("Id alanı boş olamaz");
        }
    }

}
