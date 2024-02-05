using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DataTransferObjects.Token;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts.Write
{
    public interface ITokenWriteService : IWriteService<TokenForUpdateDto, TokenForDeleteDto, TokenForAddDto, Token>
    {
    }

}
