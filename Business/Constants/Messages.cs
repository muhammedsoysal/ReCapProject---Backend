using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string AuthorizationDenied = "Yetkiniz Yok";
        public static string MaintenanceTime = "Sistem Bakımda Sonra Gel =>Soysal ";
        public static string SuccessAdded = "Ekleme başarılı.";
        public static string SuccessUpdated = "Güncelleme başarılı.";
        public static string SuccessDeleted = "Silme başarılı.";
        public static string SuccessListed = "Listeleme başarılı.";

        public static string RentalInvalid = "Kiralama başarısız.";


        public static string CarImageLimit = "Bir arabaya 5'ten fazla resim eklenemez.";
        public static string CarCountOfBrandLimit = "Bu markaya daha fazla araba eklenmez.";
        public static string CarAdded = "Araba Eklendi";
        public static string CarNameAndPriceInvalid = "Araba isimi 2 veya 2 karakterin üzerinde ve Günlük ücreti 0'ın üzerinde olmalıdır";
        public static string CardAdded = "Card eklendi";

        public static string findexPointMax = "Findeks Puanınız 1900";
        public static string findexPointAdd = "20 Findeks Puanı Eklendi";
        public static string SuccessfullyPaid = "Başarılı Ödeme";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Şifre Hatalı";

        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";

    }
}
