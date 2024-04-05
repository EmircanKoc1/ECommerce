using BusinessLogicLayer.CQRS.Commands.Responses.BrandDetail;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.BrandDetail
{
    public class UpdateBrandDetailCommandRequest : IRequest<(UpdateBrandDetailCommandResponse, UpdateBrandDetailCommandResponse)>
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public string LogoPath { get; set; }
        public DateTime? FoundedYear { get; set; }
       

    }
}
