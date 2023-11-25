using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Contants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string ProductListed = "Ürünler Listelendi.";
        public static string MaintenanceTime = "Bakım Zamanı.";

        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
        public static string ProductCountOfCategoryError = "Bir kategori içerisinde en fazla 10 ürün olabilir";
        public static string CategoryLimitExceded = "Kategori sayısı 15'i geçtiği için ürün ekleyemezsiniz.";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
        public static string AuthorizationDenied = "Yetkiniz yok";
    }
}
