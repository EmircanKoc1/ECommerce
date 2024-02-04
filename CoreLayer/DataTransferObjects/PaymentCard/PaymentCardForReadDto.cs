using CoreLayer.DataTransferObjects.Base;

namespace CoreLayer.DataTransferObjects.PaymentCard
{
    public record PaymentCardForReadDto : BaseDtoForRead
    {
        public string Company { get; init; }
        public string Number { get; init; }
        public string PersonName { get; init; }
        public string PersonSurname { get; init; }
        public DateTime? ExpireDate { get; init; }
        public string CCV { get; init; }
        public long? UserId { get; init; }
    }
}
