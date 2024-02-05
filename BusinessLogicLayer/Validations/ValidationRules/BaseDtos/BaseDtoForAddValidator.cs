using CoreLayer.DataTransferObjects.Base;

namespace BusinessLogicLayer.Validations.ValidationRules.BaseDtos
{
    public abstract class BaseDtoForAddValidator<T> : BaseDtoValidator<T>
     where T : BaseDtoForAdd
    {
    }

}
