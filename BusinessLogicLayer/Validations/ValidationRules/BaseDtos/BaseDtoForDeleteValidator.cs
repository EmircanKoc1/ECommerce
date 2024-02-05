using CoreLayer.DataTransferObjects.Base;
using FluentValidation;

namespace BusinessLogicLayer.Validations.ValidationRules.BaseDtos
{
    public abstract class BaseDtoForDeleteValidator<T> : BaseDtoValidator<T>
    where T : BaseDtoForDelete
    {
        public BaseDtoForDeleteValidator()
        {
            RuleFor(x => x.Id)
               .NotEmpty()
               .WithMessage("Id alanı boş olamaz")
               .NotNull()
               .WithMessage("Id alanı boş olamaz");
        }
    }

}
