using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem bakımda";
        public static string ProductListed="Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Ürün sayısını 15'ten fazla olamaz";
        public static string ProductNameAlreaydExist = "Bu isimde zaten başka bir ürün var";
        public static string AuthorizationDenied = "Yetkiniz yok";
    }
}
//Public değişken isimleri PascalCase kuralı ile yazılır 
//Private değişken isimleri ise camelCase kuralı ile yazılır