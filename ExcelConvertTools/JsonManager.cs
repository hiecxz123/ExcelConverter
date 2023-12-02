using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExcelConvertTools
{
    class JsonManager
    {
        public static string ConertToJson<T>(T obj)
        {
            string json = JsonConvert.SerializeObject(obj);
            return json;
        }

        public static T ConvertToObj<T>(string json)
        {
            T obj = JsonConvert.DeserializeObject<T>(json);
            return obj;
        }

        
    }

    
}
