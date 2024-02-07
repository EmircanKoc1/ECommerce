using CoreLayer.DTOs;
using FluentValidation;

namespace BusinessLogicLayer.Validations.DTOsValidationRules.Base
{
    public abstract class BaseDtoValidator<T> : AbstractValidator<T>
    where T : BaseDto
    {
        public BaseDtoValidator()
        {
            
        }

    }
}
