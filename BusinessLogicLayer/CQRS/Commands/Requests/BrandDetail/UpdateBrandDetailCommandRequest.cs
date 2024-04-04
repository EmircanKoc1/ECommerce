using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.BrandDetail
{
    public class UpdateBrandDetailCommandRequest : IRequest<(UpdateBrandDetailCommandRequest, UpdateBrandDetailCommandRequest)>
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public string LogoPath { get; set; }
        public DateTime? FoundedYear { get; set; }
       

    }
}
