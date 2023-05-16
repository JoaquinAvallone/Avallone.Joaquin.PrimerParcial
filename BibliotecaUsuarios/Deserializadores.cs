using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Biblioteca
{
    public class Deserializadores
    {
        public static List<Pasajeros>? DeserializarPasajerosXml()
        {
            string rutaArchivo = "Pasajeros.xml";

            if (!File.Exists(rutaArchivo))
            {
                return null;
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<Pasajeros>));

            using (StreamReader reader = new StreamReader(rutaArchivo))
            {
                return (List<Pasajeros>)serializer.Deserialize(reader);
            }
        }

        public static List<Vuelos>? DeserializarVuelosXml()
        {
            string rutaArchivo = "Vuelos.xml";

            if (!File.Exists(rutaArchivo))
            {
                return null;
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<Vuelos>));

            using (StreamReader reader = new StreamReader(rutaArchivo))
            {
                return (List<Vuelos>)serializer.Deserialize(reader);
            }
        }

        public static List<Usuarios>? DeserializarUsuariosJson()
        {
            if (!File.Exists("Usuarios.json"))
            {
                return null;
            }
            using (StreamReader sr = new StreamReader("Usuarios.json"))
            {
                string stringJson = sr.ReadToEnd();

                List<Usuarios>? objeto = (List<Usuarios>?)JsonSerializer.Deserialize<List<Usuarios>>(stringJson);

                return objeto;
            }
        }

        public static List<Vuelos>? DeserializarVuelosJson()
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
        public static Vuelos? DeserializarUnVueloJson()
        {
            if (!File.Exists("VueloSeleccionado.json"))
            {
                return null;
            }
            using (StreamReader sr = new StreamReader("VueloSeleccionado.json"))
            {
                string stringJson = sr.ReadToEnd();

                Vuelos? objeto = (Vuelos?)JsonSerializer.Deserialize<Vuelos>(stringJson);

                return objeto;
            }
        }

        public static List<Aeronaves>? DeserializarAeronavesJson()
        {
            if (!File.Exists("Aeronaves.json"))
            {
                return null;
            }
            using (StreamReader sr = new StreamReader("Aeronaves.json"))
            {
                string stringJson = sr.ReadToEnd();

                List<Aeronaves>? objeto = (List<Aeronaves>?)JsonSerializer.Deserialize<List<Aeronaves>>(stringJson);

                return objeto;
            }
        }

        public static Aeronaves? DeserializarUnaAeronavesJson()
        {
            if (!File.Exists("AvionSeleccionado.json"))
            {
                return null;
            }
            using (StreamReader sr = new StreamReader("AvionSeleccionado.json"))
            {
                string stringJson = sr.ReadToEnd();

                Aeronaves? objeto = (Aeronaves?)JsonSerializer.Deserialize<Aeronaves>(stringJson);

                return objeto;
            }
        }



        public static List<Pasajeros>? DeserializarPasajerosJson()
        {
            if (!File.Exists("Pasajeros.json"))
            {
                return null;
            }
            using (StreamReader sr = new StreamReader("Pasajeros.json"))
            {
                string stringJson = sr.ReadToEnd();

                List<Pasajeros>? objeto = (List<Pasajeros>?)JsonSerializer.Deserialize<List<Pasajeros>>(stringJson);

                return objeto;
            }
        }

        public static Pasajeros? DeserializarUnPasajeroJson()
        {
            if (!File.Exists("PasajeroSeleccionado.json"))
            {
                return null;
            }
            using (StreamReader sr = new StreamReader("PasajeroSeleccionado.json"))
            {
                string stringJson = sr.ReadToEnd();

                Pasajeros? objeto = (Pasajeros?)JsonSerializer.Deserialize<Pasajeros>(stringJson);

                return objeto;
            }
        }

        public static Usuarios? DeserializarUsuarioActualJson()
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

        public static string? DeserializarFotoJson(Usuarios usuario)
        {
            string path = usuario.Nombre + "Foto.json";
            string? nuevoPath = null;

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
        private static string? DeserializarFotoConPathJson(string path)
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
