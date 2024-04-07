using BusinessLogicLayer.CQRS.Queries.Responses.Category;
using MediatR;

namespace BusinessLogicLayer.CQRS.Queries.Requests.Category
{
    public class CategoryGetByIdRequest : IRequest<CategoryGetByIdResponse>
    {
        public long Id { get; set; }
    }

}
