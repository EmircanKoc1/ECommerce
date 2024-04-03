using BusinessLogicLayer.CQRS.Commands.Responses.Address;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.Address
{
    public class UpdateAddressCommandRequest : IRequest<(UpdateAddressCommandResponse, UpdateAddressCommandResponse)>
    {
        public long AddressId { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Zipcode { get; set; }
        public string AdressDescription { get; set; }


    }
}
