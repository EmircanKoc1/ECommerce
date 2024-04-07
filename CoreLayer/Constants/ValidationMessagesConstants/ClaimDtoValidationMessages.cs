namespace CoreLayer.Constants.ValidationMessagesConstants
{
    public static class ClaimDtoValidationMessages
    {
        public const string CLAIMTYPE_NOT_NULL_MESSAGE = "Claim türü boş bırakılamaz";
        public const string CLAIMTYPE_NOT_EMPTY_MESSAGE = "Claim türü boş bırakılamaz";
        public const string CLAIMTYPE_MINIMUM_LENGTH_MESSAGE = "Claim türü en az 3 karakter olmalıdır";
        public const string CLAIMTYPE_MAXIMUM_LENGTH_MESSAGE = "Claim türü en fazla 100 karakter olmalıdır";
        public const int CLAIMTYPE_MINIMUM_LENGTH_VALUE = 3;
        public const int CLAIMTYPE_MAXIMUM_LENGTH_VALUE = 100;

        public const string CLAIMNAME_NOT_NULL_MESSAGE = "Claim  adı boş bırakılamaz";
        public const string CLAIMNAME_NOT_EMPTY_MESSAGE = "Claim adı  boş bırakılamaz";
        public const string CLAIMNAME_MINIMUM_LENGTH_MESSAGE = "Claim adı en az 3 karakter olmalıdır";
        public const string CLAIMNAME_MAXIMUM_LENGTH_MESSAGE = "Claim adı en fazla 100 karakter olmalıdır";
        public const int CLAIMNAME_MINIMUM_LENGTH_VALUE = 3;
        public const int CLAIMNAME_MAXIMUM_LENGTH_VALUE = 100;

    }
}
