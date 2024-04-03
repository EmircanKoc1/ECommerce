using BusinessLogicLayer.CQRS.Commands.Responses.Brand;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.Brand
{
    public class UpdateBrandCommandRequest : IRequest<(UpdateBrandCommandResponse, UpdateBrandCommandResponse)>
    {
        public long Id { get; set; }

    }
}
