namespace CoreLayer.Constants.ValidationMessagesConstants
{
    public static class ProductDtoValidationMessages
    {
        public const string NAME_NOT_EMPTY_MESSAGE = "Kuruluş ismi boş olamaz";
        public const string NAME_NOT_NULL_MESSAGE = "Kuruluş ismi boş olamaz";
        public const string NAME_MINUMUM_LENGTH_MESSAGE = "Ürün ismi en az 2 karakter olabilir";
        public const string NAME_MAXIMUM_LENGTH_MESSAGE = "Ürün ismi en fazla 100 karakter olabilir";
        public const int NAME_MAXIMUM_LENGTH_VALUE = 100;
        public const int NAME_MINIMUM_LENGTH_VALUE = 2;

        public const string DESCRIPTION_NOT_EMPTY_MESSAGE = "Ürün açıklaması boş olamaz";
        public const string DESCRIPTION_NOT_NULL_MESSAGE = "Ürün açıklaması boş olamaz";
        public const string DESCRIPTION_MINUMUM_LENGTH_MESSAGE = "Ürün açıklaması en az 2 karakter olabilir";
        public const string DESCRIPTION_MAXIMUM_LENGTH_MESSAGE = "Ürün açıklaması en fazla 100 karakter olabilir";
        public const int DESCRIPTION_MAXIMUM_LENGTH_VALUE = 100;
        public const int DESCRIPTION_MINIMUM_LENGTH_VALUE = 2;

        public const int PRICE_VALUE = 0;
        public const string PRICE_MESSAGE = "Ürün fiyatı en az 0 olabilir ";

        public const int STOCKQUANTITY_VALUE = 0;
        public const string STOCKQUANTITY_MESSAGE = "Ürün stok miktarı en az 0 olabilir";

    }
}
