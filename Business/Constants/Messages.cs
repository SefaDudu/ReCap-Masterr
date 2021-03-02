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
        public static string UserAdded = "User Added";
        public static string UserUpdated = "User Updated";
        public static string UserDeleted = "User Deleted";
        public static string UsersListed = "Users Listed";
        //Error Messages
        public static string BrandNameInvalid = "Brand Name is Invalid";
        public static string ColorNameInvalid = "Color Name is Invalid";
        public static string RentalInvalid = "The Car That You Wanted Isn't Available";
        public static string MaintenanceTime = "Maintenance Mode";
        public static string CarImageCountOfCarIdError = "A car can have only 5 photos";
        public static string CarImagePathAlreadyExists = "Car path is already existed";
      
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Parola hatası.";
        public static string SuccessfulLogin = "Başarılı giriş.";
        public static string UserAlreadyExists = "Kullanıcı mevcut.";
        public static string AccessTokenCreated = "Token oluşturuldu.";
        public static string CountOfCarImagesCorrect = "Bir arabanın en fazla 5 resmi olabilir";
        public static string CarImageAdded = "Araba resmi eklendi";
        public static string CarImageUpdated = "Araba resmi güncellendi";
        public static string CarImageDeleted = "Araba resmi silindi";
        public static string IncorrectFileExtension = "Resim uzantısı hatalı";
        public static string FileNotFound = "Dosya belirtilen yolda bulunamadı";
       
        public static string CarNameAndPriceInvalid = "Araç eklendi";
        public static string OutUse = "Mesai saatleri dışındasın. Sistem kullanım dışı";
        public static string CarListed = "Araç Listelendi";

        public static string CarDetailed = "Araç detaylandırıldı";
       
        public static string BrandAdded = "Marka Eklendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorAdded = "Renk eklendi";
        public static string RentalAdded = "Kiralama işlemi başarılı";
        public static string ImagesAdded = "Fotoğraf eklendi";
        public static string FailAddedImageLimit = "Fotoğraf ekleyemezsiniz limite ulaşıldı";
       

    }
}
