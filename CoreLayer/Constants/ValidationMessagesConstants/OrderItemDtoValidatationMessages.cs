using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Constants.ValidationMessagesConstants
{
    public static class OrderItemDtoValidatationMessages
    {
        public const int PRICE_MINIMUM_VALUE = 0;
        public const string PRICE_MINIMUM_MESSAGE = "Ürün fiyatı en az 0 olabilir";

        public const int QUANTITY_MINIMUM_VALUE = 0;
        public const string QUANTITY_MINIMUM_MESSAGE = "Alınan ürün miktarı en az 1 olmalıdır";

        public const int TOTALPRICE_MINIMUM_VALUE = 0;
        public const string TOTALPRICE_MINIMUM_MESSAGE = "Toplam tutar en az 0 olabilir";

    }
}
