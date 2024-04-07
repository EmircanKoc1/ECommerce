using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Constants.ValidationMessagesConstants
{
    public static class ShipmentCompanyDtoValidationMessages
    {
        public const string NAME_NOT_NULL_MESSAGE = "Kargo firması ismi boş olamaz";
        public const string NAME_NOT_EMPTY_MESSAGE = "Kargo firması ismi boş olamaz";
        public const string NAME_MINIMUM_LENGTH_MESSAGE = "Kargo firması ismi en az 3 karakter olmalıdır";
        public const string NAME_MAXIMUM_LENGTH_MESSAGE = "Kargo firması ismi en fazla 100 karakter olmalıdır";
        public const int NAME_MINIMUM_LENGTH_VALUE = 3;
        public const int NAME_MAXIMUM_LENGTH_VALUE = 100;


    }
}
