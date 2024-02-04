using CoreLayer.DataTransferObjects.Base;

namespace BusinessLogicLayer.Services.Abstracts.Base
{
    public interface IGenericService<T> : IReadService<T>, IWriteService<T>
    where T : BaseDto
    {



    }
}
