using Biblioteca;
using System.ComponentModel;
using System.Text.Json;

namespace Main
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<Aeronaves> aviones = Serializadores.HardCodeoAeronaves();
            string pathApplication = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = Path.Combine(pathApplication, "Aviones.json");
            List<Pasajeros> pasajeros = new List<Pasajeros>();
            Serializadores.HardCodeoPasajeros(0, 15, pasajeros);
            List<Vuelos> vuelos = Serializadores.HardCodeoVuelos();

            Serializadores.SerializarJson("Vuelos.json", vuelos);
            foreach (Vuelos item in vuelos)
            {
                Console.WriteLine(item.ToString());
            }
            Serializadores.SerializarJson("Pasajeros.json", pasajeros);
            Serializadores.SerializarJson(path, aviones);

        }
    }
}