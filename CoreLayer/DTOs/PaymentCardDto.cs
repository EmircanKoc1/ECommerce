namespace CoreLayer.DTOs
{
    public class PaymentCardDto : BaseDto
    {
        public string Company { get; set; }
        public string Number { get; set; }
        public string PersonName { get; set; }
        public string PersonSurname { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string CCV { get; set; }
        public long? UserId { get; set; }
        public UserDto User { get; set; }


    }
}
