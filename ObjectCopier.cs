using Newtonsoft.Json;
using ShopPhone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPhone
{
    public static class ObjectCopier
    {
        public static Khachhang Clone<T>(this String source)
        {
            if (Object.ReferenceEquals(source, null))
            {
                return default(Khachhang);
            }

            var deserializeSettings = new JsonSerializerSettings { ObjectCreationHandling = ObjectCreationHandling.Replace };

            return JsonConvert.DeserializeObject<Khachhang>(JsonConvert.SerializeObject(source), deserializeSettings);
        }

        /*Nếu cần tốc độ cao và performance cao. Nhưng object phải serialize được*/

        //if (!typeof(T).IsSerializable)
        //{
        //    throw new ArgumentException("The type must be serializable.", "source");
        //}

        //if (Object.ReferenceEquals(source, null))
        //{
        //    return default(T);
        //}

        //IFormatter formatter = new BinaryFormatter();
        //Stream stream = new MemoryStream();
        //using (stream)
        //{
        //    formatter.Serialize(stream, source);
        //    stream.Seek(0, SeekOrigin.Begin);
        //    return (T)formatter.Deserialize(stream);
        //}

    }
}
