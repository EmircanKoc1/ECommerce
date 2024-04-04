using BusinessLogicLayer.CQRS.Commands.Requests.Base;
using BusinessLogicLayer.CQRS.Commands.Responses.ProductFeature;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.ProductFeature
{
    public class UpdateProductFeatureCommandRequest : BaseRequest, IRequest<(UpdateProductFeatureCommandResponse, UpdateProductFeatureCommandResponse)>
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public long? ProductId { get; set; }

    }
}
