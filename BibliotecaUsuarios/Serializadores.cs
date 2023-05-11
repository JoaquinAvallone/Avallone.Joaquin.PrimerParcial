using System;
using System.Collections.Generic;
using System.IO;
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

        public static void SerializarFotoperfilJson(Usuarios? usuario, string? item)
        {
            string path = usuario?.Nombre + "Foto.json";
            switch (usuario?.Nombre)
            {
                case "Corey":
                    SerializarJson(path,item);
                    break;
                case "Ingrid":
                    SerializarJson(path, item);
                    break;
                case "Steve":
                    SerializarJson(path, item);
                    break;
                case "Tilda":
                    SerializarJson(path, item);
                    break;
                case "Michael":
                    SerializarJson(path, item);
                    break;
            }
        }

       
    }

}
