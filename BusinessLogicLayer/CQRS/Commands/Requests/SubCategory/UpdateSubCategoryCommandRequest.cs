using BusinessLogicLayer.CQRS.Commands.Responses.Address;
using BusinessLogicLayer.CQRS.Commands.Responses.SubCategory;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.SubCategory
{
    public class UpdateSubCategoryCommandRequest : IRequest<(UpdateSubCategoryCommandResponse, UpdateSubCategoryCommandResponse)>
    {
    }
}
