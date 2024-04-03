using BusinessLogicLayer.CQRS.Commands.Responses.ProductFeature;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.ProductFeature
{
    public class UpdateProductFeatureCommandRequest : IRequest<(UpdateProductFeatureCommandResponse, UpdateProductFeatureCommandResponse)>
    {
    }
}
