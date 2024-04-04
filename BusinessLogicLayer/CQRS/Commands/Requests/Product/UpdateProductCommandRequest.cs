using BusinessLogicLayer.CQRS.Commands.Requests.Base;
using BusinessLogicLayer.CQRS.Commands.Responses.Product;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.Product
{
    public class UpdateProductCommandRequest : BaseRequest, IRequest<(UpdateProductCommandResponse, UpdateProductCommandResponse)>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int StockQuantity { get; set; }
        public long? CategoryId { get; set; }
        public long? SubCategoryId { get; set; }
        public long? BrandId { get; set; }


    }
}
