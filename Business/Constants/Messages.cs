using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public class Messages
    {
        public static string TheCarIsNotReturned = "Araç teslim edilmemiş.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Şifre yanlış.";
        public static string UserRegistered = "Kullanıcı kayıt oldu.";
        public static string AccessTokenCreated = "Token oluşturuldu.";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string SuccessfulLogin = "Giriş başarılı.";
        public static string AuthorizationDenied = "Yetki hatası";
    }
}
