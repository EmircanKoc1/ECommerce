using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DTOs;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts
{
    public interface IClaimService : IBaseReadService<ClaimDto, Claim>, IBaseWriteService<ClaimDto, Claim>
    {

        IEnumerable<ClaimDto> GetUserClaims(UserDto dto);

    }
}
