using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DTOs;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts
{
    public interface IUserService : IBaseReadService<UserDto, User>, IBaseWriteService<UserDto, User>
    {
    }
}
