using BusinessLogicLayer.CQRS.Queries.Responses.User;
using MediatR;

namespace BusinessLogicLayer.CQRS.Queries.Requests.User
{
    public class UserGetByIdRequest : IRequest<UserGetByIdResponse>
    {
        public long Id { get; set; }
    }

}
