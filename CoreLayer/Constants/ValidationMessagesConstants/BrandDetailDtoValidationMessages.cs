using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Constants.ValidationMessagesConstants
{
    public static class BrandDetailDtoValidationMessages
    {
        public const string DESCRIPTION_NOT_EMPTY_MESSAGE = "Marka açıklaması boş bırakılamaz";
        public const string DESCRIPTION_NOT_NULL_MESSAGE = "Marka açıklaması boş bırakılamaz";
        public const string DESCRIPTION_MINIMUM_LENGTH_MESSAGE = "Marka açıklaması en az 3 karakter olmalıdır";
        public const string DESCRIPTION_MAXIMUM_LENGTH_MESSAGE = "Marka açıklaması en fazla 100 karakter olmalıdır";
        public const int DESCRIPTON_MINIMUM_LENGTH_VALUE = 3;
        public const int DESCRIPTON_MAXIMUM_LENGTH_VALUE = 100;

        public const string LOGOPATH_NOT_EMPTY_MESSAGE = "Logo linki boş bırakılamaz";
        public const string LOGOPATH_NOT_NULL_MESSAGE = "Logo linki boş bırakılamaz";
        public const string LOGOPATH_MINIMUM_LENGTH_MESSAGE = "Logo linki en az 3 karakter olmalıdır";
        public const string LOGOPATH_MAXIMUM_LENGTH_MESSAGE = "Logo linki en fazla 100 karakter olmalıdır";
        public const int LOGOPATH_MINIMUM_LENGTH_VALUE = 3;
        public const int LOGOPATH_MAXIMUM_LENGTH_VALUE = 100;

        public const string FOUNDEDYEAR_NOT_EMPTY_MESSAGE = "Kuruluş tarihi boş bırakılamaz";
        public const string FOUNDEDYEAR_NOT_NULL_MESSAGE = "Kuruluş tarihi boş bırakılamaz";
        public const string FOUNDEDYEAR_MUST_MESSAGE = "Lütfen geçerli bir kuruluş tarihi giriniz";
    }
}
