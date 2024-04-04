using BusinessLogicLayer.CQRS.Commands.Responses.ProductFeature;
using CoreLayer.DTOs;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.ProductFeature
{
    public class CreateProductFeatureCommandRequest : IRequest<CreateProductFeatureCommandResponse>
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public long? ProductId { get; set; }

    }
}
