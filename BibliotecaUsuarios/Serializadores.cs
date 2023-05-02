using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Serializadores
    {    

        public static void SerializarJson<T>(string path, T obj)
        {
            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
            jsonSerializerOptions.WriteIndented = true;
         
            string json = JsonSerializer.Serialize(obj, jsonSerializerOptions);

            File.WriteAllText(path, json);
        }

       
    }

}
