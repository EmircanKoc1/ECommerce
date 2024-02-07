using CoreLayer.DataTransferObjects.Base;
using CoreLayer.DataTransferObjects.Order;
using CoreLayer.DataTransferObjects.User;

namespace CoreLayer.DataTransferObjects.Address
{
    public record AddressForAddDto : BaseDtoForAdd
    {
        public string City { get; init; }
        public string Street { get; init; }
        public string Zipcode { get; init; }
        public string AddresDescription { get; init; }
        public long? UserId { get; init; }

        public UserForReadDto UserForReadDto { get; init; }
        public ICollection<OrderForReadDto> Orders { get; init; }

    }
}
