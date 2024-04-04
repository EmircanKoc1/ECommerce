using BusinessLogicLayer.CQRS.Commands.Requests.Base;
using BusinessLogicLayer.CQRS.Commands.Responses.Address;
using BusinessLogicLayer.CQRS.Commands.Responses.SubCategory;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.SubCategory
{
    public class UpdateSubCategoryCommandRequest : BaseRequest,IRequest<(UpdateSubCategoryCommandResponse, UpdateSubCategoryCommandResponse)>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public long? CategoryId { get; set; }
    }
}
