using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Constants.ValidationMessagesConstants
{
    public static class ProductFeatureDtoValidationMessages
    {
        public const string KEY_NOT_EMPTY_MESSAGE = "Ürün özelliği kısmı boş olamaz";
        public const string KEY_NOT_NULL_MESSAGE = "Ürün özelliği kısmı boş olamaz";
        public const string KEY_MINUMUM_LENGTH_MESSAGE = "Ürün özelliği en az 3 karakter olabilir";
        public const string KEY_MAXIMUM_LENGTH_MESSAGE = "Ürün özelliği en fazla 100 karakter olabilir";
        public const int KEY_MAXIMUM_LENGTH_VALUE = 100;
        public const int KEY_MINIMUM_LENGTH_VALUE = 3;

        public const string VALUE_NOT_EMPTY_MESSAGE = "Ürün özelliği kısmı boş olamaz";
        public const string VALUE_NOT_NULL_MESSAGE = "Ürün özelliği kısmı boş olamaz";
        public const string VALUE_MINUMUM_LENGTH_MESSAGE = "Ürün özelliği en az 3 karakter olabilir";
        public const string VALUE_MAXIMUM_LENGTH_MESSAGE = "Ürün özelliği en fazla 100 karakter olabilir";
        public const int VALUE_MAXIMUM_LENGTH_VALUE = 100;
        public const int VALUE_MINIMUM_LENGTH_VALUE = 3;


    }
}
