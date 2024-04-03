using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.BrandDetail
{
    public class UpdateBrandDetailCommandRequest : IRequest<(UpdateBrandDetailCommandRequest, UpdateBrandDetailCommandRequest)>
    {

    }
}
