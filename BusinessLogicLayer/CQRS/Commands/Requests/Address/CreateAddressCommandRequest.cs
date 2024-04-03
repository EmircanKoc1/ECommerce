using BusinessLogicLayer.CQRS.Commands.Responses.Address;
using CoreLayer.DTOs;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.Address
{
    public record CreateAddressCommandRequest : IRequest<CreateAddressCommandResponse>
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string Zipcode { get; set; }
        public string AdressDescription { get; set; }
        public long? UserId { get; set; }

    }
}
