using BusinessLogicLayer.CQRS.Queries.Responses.Token;
using MediatR;

namespace BusinessLogicLayer.CQRS.Queries.Requests.Token
{
    public class TokenGetByIdRequest : IRequest<TokenGetByIdResponse>
    {
        public long Id { get; set; }
    }

}
