using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DataTransferObjects.Claim;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts.Read
{
    public interface IClaimReadService : IReadService<ClaimForReadDto,Claim>
    {
    }
}
