using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.WebApp.SessionExtensionMethods
{
    public static class SessionExtensionMethods
    {
        // Bir istek yaptıktan sonra ardından 2. isteği yaptığımız da 2. iste yeni bir istektir 1. istekle alakası yoktur
        // Bunun için session mimarisi kullanılır.
        // OBJELERİ SESSİON DA TUTARIZ
        public static void SetObject(this ISession session, string key, object value)
        {
            string objectString = JsonConvert.SerializeObject(value);
            session.SetString(key, objectString);
        }

        public static T GetObject<T>(this ISession session, string key) where T : class
        {
            string objectString = session.GetString(key);
            if (string.IsNullOrEmpty(objectString))
            {
                return null;
            }
            T value = JsonConvert.DeserializeObject<T>(objectString);
            return value;
        }
    }
}
