using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Constants.ValidationMessagesConstants
{
    public static class BrandDtoValidationMessages
    {
        public const string NAME_NOT_EMPTY_MESSAGE = "Marka adı boş bırakılamaz";
        public const string NAME_NOT_NULL_MESSAGE = "Marka adı boş bırakılamaz";
        public const string NAME_MAXIMUM_LENGTH_MESSAGE = "Sehir adı en fazla 100 karakter olmalıdır";
        public const string NAME_MINIMUM_LENGTH_MESSAGE = "Sehir adı en az 3 karakter olmalıdır";
        public const int NAME_MINIMUM_LENGTH_VALUE = 3;
        public const int NAME_MAXIMUM_LENGTH_VALUE = 100;

    }
}
