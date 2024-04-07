using BusinessLogicLayer.CQRS.Queries.Responses.Tag;
using MediatR;

namespace BusinessLogicLayer.CQRS.Queries.Requests.Tag
{
    public class TagGetByIdRequest : IRequest<TagGetByIdResponse>
    {
        public long Id { get; set; }
    }

}
