namespace CoreLayer.DataTransferObjects.Address
{
    public record AddressForAddDto
    {
        public string City { get; init; }
        public string Street { get; init; }
        public string Zipcode { get; init; }
        public string AddresDescription { get; init; }
        public long? UserId { get; init; }
     
    }
}
