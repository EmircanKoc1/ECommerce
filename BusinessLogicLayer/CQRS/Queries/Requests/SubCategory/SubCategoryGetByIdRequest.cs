using BusinessLogicLayer.CQRS.Queries.Responses.SubCategory;
using MediatR;

namespace BusinessLogicLayer.CQRS.Queries.Requests.SubCategory
{
    public class SubCategoryGetByIdRequest : IRequest<SubCategoryGetByIdResponse>
    {
        public long Id { get; set; }
    }

}
