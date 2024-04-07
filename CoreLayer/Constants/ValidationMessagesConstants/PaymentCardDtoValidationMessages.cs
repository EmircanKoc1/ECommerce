namespace CoreLayer.Constants.ValidationMessagesConstants
{
    public static class PaymentCardDtoValidationMessages
    {

        public const string COMPANY_NOT_EMPTY_MESSAGE = "Kuruluş ismi boş olamaz";
        public const string COMPANY_NOT_NULL_MESSAGE = "Kuruluş ismi boş olamaz";
        public const string COMPANY_MINUMUM_LENGTH_MESSAGE = "Kuruluş ismi en az 2 karakter olabilir";
        public const string COMPANY_MAXIMUM_LENGTH_MESSAGE = "Kuruluş ismi en fazla 100 karakter olabilir";
        public const int COMPANY_MAXIMUM_LENGTH_VALUE = 100;
        public const int COMPANY_MINIMUM_LENGTH_VALUE = 2;

        public const string NUMBER_NOT_EMPTY_MESSAGE = "Kart numarası boş olamaz";
        public const string NUMBER_NOT_NULL_MESSAGE = "Kart numarası boş olamaz";
        public const string NUMBER_MINUMUM_LENGTH_MESSAGE = "Kart numarası en fazla 100 karakter olabilir";
        public const string NUMBER_MAXIMUM_LENGTH_MESSAGE = "Kart numarası en az 2 karakter olabilir";
        public const int NUMBER_MAXIMUM_LENGTH_VALUE = 100;
        public const int NUMBER_MINIMUM_LENGTH_VALUE = 2;

        public const string PERSONNAME_NOT_EMPTY_MESSAGE = "Kart sahibi adıboş olamaz";
        public const string PERSONNAME_NOT_NULL_MESSAGE = "Kart sahibi adıboş olamaz";
        public const string PERSONNAME_MINUMUM_LENGTH_MESSAGE = "Kart sahibi adı en az 10 karakter olabilir";
        public const string PERSONNAME_MAXIMUM_LENGTH_MESSAGE = "Kart sahibi adı en fazla 100 karakter olabilir";
        public const int PERSONNAME_MAXIMUM_LENGTH_VALUE = 100;
        public const int PERSONNAME_MINIMUM_LENGTH_VALUE = 2;

        public const string PERSONSURNAME_NOT_EMPTY_MESSAGE = "Kart sahibi soyadı boş olamaz";
        public const string PERSONSURNAME_NOT_NULL_MESSAGE = "Kart sahibi soyadı boş olamaz";
        public const string PERSONSURNAME_MINUMUM_LENGTH_MESSAGE = "Kart sahibi soyaadı en az 10 karakter olabilir";
        public const string PERSONSURNAME_MAXIMUM_LENGTH_MESSAGE = "Kart sahibi soyadı en fazla 100 karakter olabilir";
        public const int PERSONSURNAME_MAXIMUM_LENGTH_VALUE = 100;
        public const int PERSONSURNAME_MINIMUM_LENGTH_VALUE = 2;

        public const string CCV_NOT_EMPTY_MESSAGE = "CCV boş olamaz";
        public const string CCV_NOT_NULL_MESSAGE = "CCV boş olamaz";
        public const string CCV_MINUMUM_LENGTH_MESSAGE = "CCV en az 3 karakter olabilir";
        public const string CCV_MAXIMUM_LENGTH_MESSAGE = "CCV en az 3 fazla olabilir";
        public const int CCV_MAXIMUM_LENGTH_VALUE = 3;
        public const int CCV_MINIMUM_LENGTH_VALUE = 3;

        public const string EXPIREDATE_NOT_EMPTY_MESSAGE = "Kartın son kullanma tarihi boş olamaz";
        public const string EXPIREDATE_NOT_NULL_MESSAGE = "Kartın son kullanma tarihi boş olamaz";
        public const string EXPIREDATE_MESSAGE = "Kartın son kullanma tarihi geçersiz";
        
   


    }
}
