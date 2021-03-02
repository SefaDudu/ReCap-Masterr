using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {
        public static string CarAdded = "Ürün Eklendi";
        public static string CarNameInvalid = "Ürün en az iki harften oluşmalıdır";
        public static string CarDeleted = "Ürün başarıyla silindi";
        public static string CarUpdated = "Ürün başarıyla Güncellendi";
        public static string MaintenonceTime = "Bakım";
        public static string CarsAll = "Ürünler Listelendi";
        public static string CarRentalInvalid = "Araba Teslim Edilmedi";
        public static string CarRentalAdded = "Araba Teslim Edildi";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserAddSuccess = "Kullanıcı başarılı bir şekilde eklendi.";
        public static string UserAddErrorName = "İsim uzunluğu minimum 3 harften oluşmalıdır.";
        public static string UserAddErrorPassword = "Şifre en az 4, en fazla 16 karakterden oluşmalıdır. Büyük, küçük harf, sayı, şekil içermelidir.";
        public static string UserUpdateSuccess = "Kullanıcı başarılı bir şekilde güncellendi.";
        public static string UserUpdateError = "Geçerli bir kullanıcı seçiniz.";
        public static string UserDeleteSuccess = "Kullanıcı başarılı bir şekilde silindi.";
        public static string UserDeleteError = "Geçerli bir kullanıcı seçiniz.";
        public static string UserGetAllSuccess = "Kullanıcı listesi başarılı bir şekilde getirildi.";
        public static string UserGetAllError = "Kullanıcılar getirilemedi, acaba hiç kullanıcı yok mu?";
        public static string UserGetByIdSuccess = "Kullanıcıya başarıyla erişildi.";
        public static string UserGetByIdError = "Geçerli bir kullanıcı seçiniz.";
        public static string UserCheckUserExistsError = "Kullanıcı bulunamadı gibi duruyor.";
        public static string UserNotFoundError = "Kullanıcı bulunamadı";
        public static string UserPasswordError = "Şifre hatalı.";
        public static string UserLoginSuccessful = "Giriş başarılı.";
        public static string UserEmailAlreadyExists = "Bu email adresine sahip bir kullanıcı zaten bulunuyor.";
        public static string UserRegistered = "Kullanıcı başarıyla kayıt edildi.";
        public static string UserAccessTokenCreatedSuccessful = "Access token başarıyla oluşturuldu.";

    }
}
