namespace CoreLayer.Constants.ValidationMessagesConstants
{
    public static class AddressValidationMessages
    {
        
        public const string CITY_NOT_EMPTY_MESSAGE = "Sehir adı boş bırakılamaz";
        public const string CITY_NOT_NULL_MESSAGE = "Sehir adı boş bırakılamaz";
        public const string CITY_MINUMUM_LENGTH_MESSAGE = "Sehir adı en az 3 karakter olmalıdır";
        public const string CITY_MAXIMUM_LENGTH_MESSAGE = $"Sehir adı en fazla 100 karakter olmalıdır";
        public const int CITY_MAXIMUM_LENGTH_VALUE = 100;
        public const int CITY_MINIMUM_LENGTH_VALUE = 3;

        public const string STREET_NOT_EMPTY_MESSAGE = "Sokak adı boş bırakılamaz";
        public const string STREET_NOT_NULL_MESSAGE = "Sokak adı boş bırakılamaz";
        public const string STREET_MINIMUM_LENGTH_MESSAGE = "Sokak adı en az 3 karakter olmalıdır";
        public const string STREET_MAXIMUM_LENGTH_MESSAGE = "Sokak adı en fazla 100 karakter olmalıdır";
        public const int STREET_MAXIMUM_LENGTH_VALUE = 100;
        public const int STREET_MINIMUM_LENGTH_VALUE = 3;

        public const string ZIPCODE_NOT_EMPTY_MESSAGE = "Posta kodu adı boş bırakılamaz";
        public const string ZIPCODE_NOT_NULL_MESSAGE = "Posta kodu boş bırakılamaz";
        public const string ZIPCODE_MINUMUM_LENGTH_MESSAGE = "Posta kodu en az 3 karakter olmalıdır";
        public const string ZIPCODE_MAXİMUM_LENGTH_MESSAGE = "Posta kodu en fazla 100 karakter olmalıdır";
        public const int ZIPCODE_MAXIMUM_LENGTH_VALUE = 100;
        public const int ZIPCODE_MINIMUM_LENGTH_VALUE = 3;

        public const string ADDRESSDESCRIPTION_NOT_EMPTY_MESSAGE = "Address açıklaması boş bırakılamaz";
        public const string ADDRESSDESCRIPTION_NOT_NULL_MESSAGE = "Address açıklaması boş bırakılamaz";
        public const string ADDRESSDESCRIPTION_MINIMUM_LENGTH_MESSAGE = "Address açıklaması en az 3 karakter olmalıdır";
        public const string ADDRESSDESCRIPTION_MAXİMUM_LENGTH_MESSAGE = "Address açıklaması en fazla 100 karakter olmalıdır";
        public const int ADDRESSDESCRIPTION_MAXIMUM_LENGTH_VALUE = 100;
        public const int ADDRESSDESCRIPTION_MINIMUM_LENGTH_VALUE = 3;

    }
}
