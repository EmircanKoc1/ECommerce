using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Constants.ValidationMessagesConstants
{
    public static class OrderDtoValidationMessages
    {
        public const int  TOTALAMOUNT_MINIMUM_VALUE = 0;
        public const string TOTALAMOUNT_MINIMUM_MESSAGE = "Sipariş tutarı en düşük 0 olabilir";

        public const int  DISCOUNT_MINIMUM_VALUE = 0;
        public const string DISCOUNT_MINIMUM_MESSAGE = "İndirim tutarı en düşük 0 olabilir";

    }
}
