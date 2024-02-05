using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DataTransferObjects.User;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts.Read
{
    public interface IUserReadService : IReadService<UserForReadDto,User>
    {
    }
}
