using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Constants.ValidationMessagesConstants
{
    public static class TagDtoValidationMessages
    {
        public const string NAME_NOT_NULL_MESSAGE = "Etiket adı boş olamaz";
        public const string NAME_NOT_EMPTY_MESSAGE = "Etiket adı boş olamaz";
        public const string NAME_MINIMUM_LENGTH_MESSAGE = "Etiket adı en az 3 karakter olabilir";
        public const string NAME_MAXIMUM_LENGTH_MESSAGE = "Etiket adı en fazla 100 karakter olabilir";
        public const int NAME_MINIMUM_LENGTH_VALUE = 3;
        public const int NAME_MAXIMUM_LENGTH_VALUE = 100;

        public const string DESCRIPTION_NOT_NULL_MESSAGE = "Etiket açıklaması boş olamaz";
        public const string DESCRIPTION_NOT_EMPTY_MESSAGE = "Etiket açıklaması boş olamaz";
        public const string DESCRIPTION_MINIMUM_LENGTH_MESSAGE = "Etiket açıklaması en az 3 karakter olabilir";
        public const string DESCRIPTION_MAXIMUM_LENGTH_MESSAGE = "Etiket açıklaması en fazla 100 karakter olabilir";
        public const int DESCRIPTION_MINIMUM_LENGTH_VALUE = 3;
        public const int DESCRIPTION_MAXIMUM_LENGTH_VALUE = 100;

    }
}
