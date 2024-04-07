using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Constants.ValidationMessagesConstants
{
    public static class UserDtoValidationMessages
    {
        public const string USERNAME_NOT_NULL_MESSAGE = "kullanıcı adı boş olamaz";
        public const string USERNAME_NOT_EMPTY_MESSAGE = "kullanıcı adı boş olamaz";
        public const string USERNAME_MINIMUM_LENGTH_MESSAGE = "Kullanıcı adı en az 100 karakter olabililr";
        public const string USERNAME_MAXIMUM_LENGTH_MESSAGE = "Kullanıcı adı en fazla 100 karakter olabilir";
        public const int USERNAME_MINIMUM_LENGTH_VALUE = 3;
        public const int USERNAME_MAXIMUM_LENGTH_VALUE = 100;

        public const string NAME_NOT_NULL_MESSAGE = "Kullanıcının adı boş olamaz";
        public const string NAME_NOT_EMPTY_MESSAGE = "Kullanıcının adı boş olamaz";
        public const string NAME_MINIMUM_LENGTH_MESSAGE = "Kullanıcının adı en az 2 karakter olabilir";
        public const string NAME_MAXIMUM_LENGTH_MESSAGE = "Kullanıcının adı en fazla 30 karakter olabilir";
        public const int NAME_MINIMUM_LENGTH_VALUE = 3;
        public const int NAME_MAXIMUM_LENGTH_VALUE = 100;

        public const string SURNAME_NOT_NULL_MESSAGE = "Kullanıcının soyadı boş olamaz";
        public const string SURNAME_NOT_EMPTY_MESSAGE = "Kullanıcının soyadı boş olamaz";
        public const string SURNAME_MINIMUM_LENGTH_MESSAGE = "Kullanıcının soyadı en az 2 karakter olabilir";
        public const string SURNAME_MAXIMUM_LENGTH_MESSAGE = "Kullanıcının soyadı en fazla 30 karakter olabilir";
        public const int SURNAME_MINIMUM_LENGTH_VALUE = 3;
        public const int SURNAME_MAXIMUM_LENGTH_VALUE = 30;

        public const string EMAIL_NOT_NULL_MESSAGE = "Kullanıcının adı boş olamaz";
        public const string EMAIL_NOT_EMPTY_MESSAGE = "Kullanıcının adı boş olamaz";
        public const string EMAIL_MINIMUM_LENGTH_MESSAGE = "Kullanıcının email adresi en az 5 karakter olabilir";
        public const string EMAIL_MAXIMUM_LENGTH_MESSAGE = "Kullanıcının email adresi  en fazla 50 karakter olabilir";
        public const string EMAIL_INVALID_MESSAGE = "Lütfen geçerli bir mail adresi giriniz";
        public const int EMAIL_MINIMUM_LENGTH_VALUE = 3;
        public const int EMAIL_MAXIMUM_LENGTH_VALUE = 100;

        public const string PHONENUMBER_NOT_NULL_MESSAGE = "Kullanıcının telefon numarası boş olamaz";
        public const string PHONENUMBER_NOT_EMPTY_MESSAGE = "Kullanıcının telefon numarası boş olamaz";
        public const string PHONENUMBER_MINIMUM_LENGTH_MESSAGE = "Kullanıcının telefon numarası en az 11 karakter olabilir";
        public const string PHONENUMBER_MAXIMUM_LENGTH_MESSAGE = "Kullanıcının telefon numarası en fazla 11 karakter olabilir";
        public const int PHONENUMBER_MINIMUM_LENGTH_VALUE = 11;
        public const int PHONENUMBER_MAXIMUM_LENGTH_VALUE = 11;

        public const string PASSWORD_NOT_NULL_MESSAGE = "Kullanıcının şifresi  boş olamaz";
        public const string PASSWORD_NOT_EMPTY_MESSAGE = "Kullanıcının şifresi  boş olamaz";
        public const string PASSWORD_MINIMUM_LENGTH_MESSAGE = "Kullanıcının şifresi  en az 8 karakter olabilir";
        public const string PASSWORD_MAXIMUM_LENGTH_MESSAGE = "Kullanıcının şifresi  en fazla 16 karakter olabilir";
        public const int PASSWORD_MINIMUM_LENGTH_VALUE = 8;
        public const int PASSWORD_MAXIMUM_LENGTH_VALUE = 16;

        public const string BIRTHDATE_NOT_NULL_MESSAGE = "Doğum tarihi boş bırakılamaz";
        public const string BIRTHDATE_NOT_EMPTY_MESSAGE = "Doğum tarihi boş bırakılamaz";
        public const string BIRTHDATE_INVALID_MESSAGE = "Lütfen geçerli bir tarih girin";


    }
}
