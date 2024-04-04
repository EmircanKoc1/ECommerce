using BusinessLogicLayer.CQRS.Commands.Requests.Base;
using BusinessLogicLayer.CQRS.Commands.Responses.Category;
using MediatR;
namespace BusinessLogicLayer.CQRS.Commands.Requests.Category
{
    public class DeleteCategoryCommandRequest : BaseRequest, IRequest<DeleteCategoryCommandResponse>
    {

    }
}
