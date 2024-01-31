using DataAccessLayer.Entities.Base.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class PaymentCard : BaseEntity
    {
        public string Company { get; set; }
        public string Number { get; set; }
        public string PersonName { get; set; }
        public string PersonSurname { get; set; }
        public DateTime ExpireDate { get; set; }
        public string CCV { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }


    }
}
