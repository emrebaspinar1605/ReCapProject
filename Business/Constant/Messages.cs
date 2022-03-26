using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constant
{
    public static class Messages
    {
        public static string CarAdded = "Araç Başarıyla eklenmiştir";
        public static string CarNameInValid = "Araba eklenememiştir.Lütfen Açıklamayı uzun tutun veya günlük kirasını 0'dan büyük tutun";    
        public static string CarDeleted="Araç Başarıyla Silinmiştir";
        public static string CarUpdated = "Araç Başarıyla güncellenmiştir";
        public static string ColorAdded = "Renk Başarıyla eklenmiştir";
        public static string ColorDeleted = "Renk Başarıyla Silinmiştir";
        public static string ColorUpdated = "Renk Başarıyla güncellenmiştir";
        public static string BrandAdded = "Brand Başarıyla eklenmiştir";
        public static string BrandDeleted = "Brand Başarıyla Silinmiştir";
        public static string BrandUpdated = "Brand Başarıyla güncellenmiştir";
        public static string UserAdded = "User Başarıyla eklenmiştir";
        public static string UserDeleted = "User Başarıyla Silinmiştir";
        public static string UserUpdated = "User Başarıyla güncellenmiştir";
        public static string CustomerAdded = "Customer Başarıyla eklenmiştir";
        public static string CustomerDeleted = "Customer Başarıyla Silinmiştir";
        public static string CustomerUpdated = "Customer Başarıyla güncellenmiştir";
        public static string RentalAdded = "Rental Başarıyla eklenmiştir";
        public static string RentalDeleted = "Rental Başarıyla Silinmiştir";
        public static string RentalUpdated = "Rental Başarıyla güncellenmiştir";
        public static string CarListed = "Araçlar listelenmiştir";
        public static string BrandListed = "Brands listelenmiştir";
        public static string ColorListed = "Colors listelenmiştir";
        public static string UserListed = "Users listelenmiştir";
        public static string CustomerListed = "Customers listelenmiştir";
        public static string RentalListed = "Rentals listelenmiştir";
        public static string CustomerNameInValid = "Müşteri eklenememiştir.Lütfen Açıklamayı uzun tutun ";
        public static string UserNameInValid = "Kullanıcı eklenememiştir.Lütfen Açıklamayı uzun tutun ";
        public static string RentalInValid = "Böyle bir kayıt bulunmamaktadır lütfen doğru kayıt giriniz";
        public static string CarRentable = "Araç kiralanabilir ";
        public static string CarUnRentable = "Araç Kiralanamaz";
        public static string StartA = "Açıklama 'A' harfi ile başlamalıdır!!!";
        public static string CarImagesNotfound="Araba Resmi bulunamadı";
        public static string CarImageLimitExceded="Araba resim limiti aşıldı";
        public static string CarImageAdded="Araba Resmi Eklendi";
        public static string CarImageUpdated="Araba Resmi güncellendi";
        public static string CarImageDeleted="Araba Resmi silinmiştir";
        public static string CarImageListed="Araba Resimleri Listelendi";
        public static string CarImageIdFound="Araba Resim Id'si bulundu";
        public static string CarIdFoun="Araba Id'si Bulundu";
        public static string AccessTokenCreated="Erişim Jetonu Oluşturuldu";
        public static string UserAlreadyExists="Kullanıcı Zaten Mevcut";
        public static string PasswordError="Şifre Hatalı";
        public static string SuccessfulLogin="Giriş Başarılı";
        public static string UserNotFound="Kullanıcı Bulunamadı";
        public static string UserRegistered="Kullanıcı Kayıt Edildi";
        public static string AuthorizationDenied="Yetkiniz Yok";
    }
}
