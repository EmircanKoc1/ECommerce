using CoreLayer.DataTransferObjects.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.DataTransferObjects.PaymentCard
{
    public record PaymentCardForAddDto : BaseDtoForAdd
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
