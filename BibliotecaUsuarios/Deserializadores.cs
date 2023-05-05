using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Deserializadores
    {
        public static List<Usuarios> DeserializarUsuariosJson()
        {
            if (!File.Exists("MOCK_DATA.json"))
            {
                return null;
            }
            using (StreamReader sr = new StreamReader("MOCK_DATA.json"))
            {
                string stringJson = sr.ReadToEnd();

                List<Usuarios>? objeto = (List<Usuarios>?)JsonSerializer.Deserialize<List<Usuarios>>(stringJson);

                return objeto;
            }
        }

        public static List<Vuelos> DeserializarVuelosJson()
        {
            if (!File.Exists("Vuelos.json"))
            {
                return null;
            }
            using (StreamReader sr = new StreamReader("Vuelos.json"))
            {
                string stringJson = sr.ReadToEnd();

                List<Vuelos>? objeto = (List<Vuelos>?)JsonSerializer.Deserialize<List<Vuelos>>(stringJson);

                return objeto;
            }
        }


        public static Usuarios DeserializarUsuarioActualJson()
        {
            if (!File.Exists("UsuarioActual.json"))
            {
                return null;
            }
            using (StreamReader sr = new StreamReader("UsuarioActual.json"))
            {
                string stringJson = sr.ReadToEnd();

                Usuarios? objeto = (Usuarios?)JsonSerializer.Deserialize<Usuarios>(stringJson);

                return objeto;
            }
        }

        public static string DeserializarFotoJson(Usuarios usuario)
        {
            string? pathFoto = null;
            string path = usuario.Nombre + "Foto.json";
            string nuevoPath = null;

            switch (usuario.Nombre)
            {
                case "Corey":
                   nuevoPath = DeserializarFotoConPathJson(path);
                    break;
                case "Ingrid":
                    nuevoPath = DeserializarFotoConPathJson(path);
                    break;
                case "Steve":
                    nuevoPath = DeserializarFotoConPathJson(path);
                    break;
                case "Tilda":
                    nuevoPath = DeserializarFotoConPathJson(path);
                    break;
                case "Michael":
                    nuevoPath = DeserializarFotoConPathJson(path);
                    break;
            }
            return nuevoPath;            
        }
        private static string DeserializarFotoConPathJson(string path)
        {
            if (!File.Exists(path))
            {
                return null;
            }
            using (StreamReader sr = new StreamReader(path))
            {
                string stringJson = sr.ReadToEnd();

                string? pathFoto = JsonSerializer.Deserialize<string>(stringJson);

                return pathFoto;
            }
        }
    }
}
