using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Constants.ValidationMessagesConstants
{
    public static class CommentDtoValidationMessages
    {
        public const string TITLE_NOT_NULL_MESSAGE = "başlık alanı boş bırakılamaz";
        public const string TITLE_NOT_EMPTY_MESSAGE = "başlık alanı boş bırakılamaz";
        public const string TITLE_MINIMUM_LENGTH_MESSAGE = "başlık alanı  en az 3 karakter olmalıdır";
        public const string TITLE_MAXIMUM_LENGTH_MESSAGE = "başlık alanı en fazla 100 karakter olmalıdır";
        public const int TITLE_MINIMUM_LENGTH_VALUE = 3;
        public const int TITLE_MAXIMUM_LENGTH_VALUE = 100;

        public const string TEXT_NOT_NULL_MESSAGE = "yourm alanı  boş bırakılamaz";
        public const string TEXT_NOT_EMPTY_MESSAGE = "yorum alanı  boş bırakılamaz";
        public const string TEXT_MINIMUM_LENGTH_MESSAGE = "yorum alanı en az 3 karakter olmalıdır";
        public const string TEXT_MAXIMUM_LENGTH_MESSAGE = "yorum alanı en fazla 100 karakter olmalıdır";
        public const int TEXT_MINIMUM_LENGTH_VALUE = 3;
        public const int TEXT_MAXIMUM_LENGTH_VALUE = 100;

        public const int SCORE_MINIMUM_VALUE = 0;
        public const int SCORE_MAXIMUM_VALUE = 5;


    }
}
