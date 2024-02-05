using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DataTransferObjects.Claim;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts.Write
{
    public interface IClaimWriteService : IWriteService<ClaimForUpdateDto, ClaimForDeleteDto, ClaimForAddDto, Claim>
    {
    }

}
