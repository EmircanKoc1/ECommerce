using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Constants.ValidationMessagesConstants
{
    public static  class ShipmentCompanyDetailDtoValidationMessages
    {
        public const string DESCRIPTON_NOT_EMPTY_MESSAGE = "Kargo firması açıklaması boş olamaz";
        public const string DESCRIPTON_NOT_NULL_MESSAGE = "Kargo firması açıklaması boş olamaz";
        public const string DESCRIPTON_MINUMUM_LENGTH_MESSAGE = "Kargo firması açıklaması en az 3 karakter olabilir";
        public const string DESCRIPTON_MAXIMUM_LENGTH_MESSAGE = "Kargo firması açıklaması en fazla 300 karakter olabilir";
        public const int DESCRIPTION_MAXIMUM_LENGTH_VALUE = 300;
        public const int DESCRIPTION_MINIMUM_LENGTH_VALUE = 3;

        public const string FOUNDEDYEAR_NOT_EMPTY_MESSAGE = "Kuruluş yılı boş olamaz";
        public const string FOUNDEDYEAR_NOT_NULL_MESSAGE = "Kuruluş yılı boş olamaz";
        public const string FOUNDEDYEAR_MESSAGE = "Geçerli bir kuruluş tarihi girilmelidir";

        public const string TOTALFAILEDSHIPMENTCOUNT_MESSAGE = "Toplam başarısız kargo sayısı en az 0 olabilir";
        public const string TOTALSUCCESFULSHIPMENTCOUNT_MESSAGE = "Toplam başarılı kargo sayısı en az 0 olabilir";
        public const string TOTALSHIPMENTCOUNT_MESSAGE = "Toplam kargo sayısı en az 0 olabilir";
      



    }
}
