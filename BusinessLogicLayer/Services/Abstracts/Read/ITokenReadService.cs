using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DataTransferObjects.Token;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts.Read
{
    public interface ITokenReadService : IReadService<TokenForReadDto,Token>
    {
    }
}
