namespace CoreLayer.Constants.ValidationMessagesConstants
{
    public static class CategoryDtoValidationMessages
    {
        public const string NAME_NOT_NULL_MESSAGE = "Kategori adı boş bırakılamaz";
        public const string NAME_NOT_EMPTY_MESSAGE = "Kategori adı boş bırakılamaz";
        public const string NAME_MINIMUM_LENGTH_MESSAGE = "Kategori adı en az 3 karakter olmalıdır";
        public const string NAME_MAXIMUM_LENGTH_MESSAGE = "Kategori adı en fazla 3 karakter olmalıdır";
        public const int NAME_MINIMUM_LENGTH_VALUE = 3;
        public const int NAME_MAXIMUM_LENGTH_VALUE = 100;

        public const string DESCRIPTION_NOT_EMPTY_MESSAGE = "Kategori açıklaması boş bırakılamaz";
        public const string DESCRIPTION_NOT_NULL_MESSAGE = "Kategori açıklaması boş bırakılamaz";
        public const string DESCRIPTION_MAXIMUM_LENGTH_MESSAGE = "Kategori açıklaması en az 3 karakter olmalıdır";
        public const string DESCRIPTION_MINIMUM_LENGTH_MESSAGE = "Kategori açıklaması en fazla 100 karakter olmalıdır";
        public const int DESCRIPTION_MINIMUM_LENGTH_VALUE = 3;
        public const int DESCRIPTION_MAXIMUM_LENGTH_VALUE = 100;

    }
}
