﻿using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoriye en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists ="Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied ="Yetkiniz yok";
        public static string UserRegistered="Kayıt oldu";
        public static string UserNotFound="Kullanıcı Bulunamadı";
        public static string PasswordError="Parola hatası";
        public static string SuccessfulLogin="Başarılı giriş";
        public static string UserAlreadyExists="Kullanıcı mevcut";
        public static string AccessTokenCreated="Access token başarıyla oluşturuldu";
    }
}
