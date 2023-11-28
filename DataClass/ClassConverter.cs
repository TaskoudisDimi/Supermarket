using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ClassConverter
    {

        // Serialization
        public byte[] SerializeObject<T>(T obj)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    formatter.Serialize(memoryStream, obj);
                    return memoryStream.ToArray();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Serialization Error: " + ex.Message);
                return null;
            }
        }

        // Deserialization
        public T DeserializeObject<T>(byte[] bytes)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (MemoryStream memoryStream = new MemoryStream(bytes))
                {
                    object obj = formatter.Deserialize(memoryStream);
                    if (obj is T result)
                    {
                        return result;
                    }
                    else
                    {
                        throw new InvalidOperationException($"Failed to convert bytes to {typeof(T).Name}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Deserialization Error: " + ex.Message);
                return default(T);
            }
        }



    }
}
