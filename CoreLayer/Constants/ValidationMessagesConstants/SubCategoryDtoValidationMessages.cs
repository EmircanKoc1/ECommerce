namespace CoreLayer.Constants.ValidationMessagesConstants
{
    public static class SubCategoryDtoValidationMessages
    {
        public const string NAME_NOT_NULL_MESSAGE = "Alt kategori ismi boş olamaz";
        public const string NAME_NOT_EMPTY_MESSAGE = "Alt kategori ismi boş olamaz";
        public const string NAME_MINIMUM_LENGTH_MESSAGE = "Alt kategori ismi en az 3 karakter olmalıdır ";
        public const string NAME_MAXIMUM_LENGTH_MESSAGE = "Alt kategori ismi en fazla 100 karakter olmalıdır";
        public const int NAME_MINIMUM_LENGTH_VALUE = 3;
        public const int NAME_MAXIMUM_LENGTH_VALUE = 100;

        public const string DESCRIPTION_NOT_NULL_MESSAGE = "Alt kategori açıklaması boş olamaz";
        public const string DESCRIPTION_NOT_EMPTY_MESSAGE = "Alt kategori açıklaması  boş olamaz";
        public const string DESCRIPTION_MINIMUM_LENGTH_MESSAGE = "Alt kategori açıklaması en az 3 karakter olmalıdır";
        public const string DESCRIPTION_MAXIMUM_LENGTH_MESSAGE = "Alt kategori açıklaması en fazla 100 karakter olmalıdır";
        public const int DESCRIPTION_MINIMUM_LENGTH_VALUE = 3;
        public const int DESCRIPTION_MAXIMUM_LENGTH_VALUE = 100;


    }
}
