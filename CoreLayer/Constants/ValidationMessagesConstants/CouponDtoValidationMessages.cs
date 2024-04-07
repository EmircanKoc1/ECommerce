namespace CoreLayer.Constants.ValidationMessagesConstants
{
    public static class CouponDtoValidationMessages
    {
        public const string NAME_NOT_NULL_MESSAGE = "Kupon Adı boş bırakılamaz";
        public const string NAME_NOT_EMPTY_MESSAGE = "Kupon Adı boş bırakılamaz";
        public const string NAME_MINIMUM_LENGTH_MESSAGE = "Kupon Adı en az 3 karakter olmalıdır";
        public const string NAME_MAXIMUM_LENGTH_MESSAGE = "Kupon Adı en fazla 100 karakter olmalıdır";
        public const int NAME_MINIMUM_LENGTH_VALUE = 3;
        public const int NAME_MAXIMUM_LENGTH_VALUE = 100;

        public const string DESCRIPTION_NOT_NULL_MESSAGE = "Kupon açıklaması boş bırakılamaz";
        public const string DESCRIPTION_NOT_EMPTY_MESSAGE = "Kupon açıklaması boş bırakılamaz";
        public const string DESCRIPTION_MINIMUM_LENGTH_MESSAGE = "Kupon açıklaması en az 3 karakter olmalıdır";
        public const string DESCRIPTION_MAXIMUM_LENGTH_MESSAGE = "Kupon açıklaması en fazla 100 karakter olmalıdır";
        public const int DESCRIPTION_MINIMUM_LENGTH_VALUE = 3;
        public const int DESCRIPTION_MAXIMUM_LENGTH_VALUE = 100;

        public const string CODE_NOT_NULL_MESSAGE = "Kupon kodu boş bırakılamaz";
        public const string CODE_NOT_EMPTY_MESSAGE = "başlık alanı boş bırakılamaz";
        public const string CODE_MINIMUM_LENGTH_MESSAGE = "Kupon kodu en az 3 karakter olmalıdır";
        public const string CODE_MAXIMUM_LENGTH_MESSAGE = "Kupon kodu en fazla 100 karakter olmalıdır";
        public const int CODE_MINIMUM_LENGTH_VALUE = 3;
        public const int CODE_MAXIMUM_LENGTH_VALUE = 100;

        public const int MINIMUMPRICE = 0;
        public const string MINIMUMPRICE_MESSAGE = "Kupon için gereken minimum tutar en az 0 olmalıdır";

        public const int DISCOUNTAMOUNT = 0;
        public const string DISCOUNTAMOUNT_MESSAGE = "Kupon indirim tutarı en az 1 olmalıdır";

        public const string EXPIRATIONDATE_MESSAGE = "Kupon artık geçerli değil";


    }
}
