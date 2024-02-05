using CoreLayer.DataTransferObjects.Base;
using FluentValidation;

namespace BusinessLogicLayer.Validations.ValidationRules.BaseDtos
{
    public abstract class BaseDtoValidator<T> : AbstractValidator<T>
    where T : BaseDto
    {

    }

}
