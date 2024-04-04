using BusinessLogicLayer.CQRS.Commands.Requests.Base;
using BusinessLogicLayer.CQRS.Commands.Responses.ProductFeature;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.ProductFeature
{
    public class DeleteProductFeatureCommandRequest : BaseRequest,IRequest<DeleteProductFeatureCommandResponse>
    {
    }
}
