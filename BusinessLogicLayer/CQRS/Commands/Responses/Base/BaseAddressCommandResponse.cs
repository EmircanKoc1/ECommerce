namespace BusinessLogicLayer.CQRS.Commands.Responses.Base
{
    public abstract class BaseAddressCommandResponse : BaseCommandResponse
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string Zipcode { get; set; }
        public string AdressDescription { get; set; }
        public long? UserId { get; set; }

    }
}
