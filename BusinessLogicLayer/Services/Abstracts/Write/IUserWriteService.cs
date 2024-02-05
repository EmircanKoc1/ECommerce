using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DataTransferObjects.User;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts.Write
{
    public interface IUserWriteService : IWriteService<UserForUpdateDto, UserForDeleteDto, UserForAddDto, User>
    {
    }

}
