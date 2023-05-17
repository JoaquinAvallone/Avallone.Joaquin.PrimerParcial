using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Aeronaves
    {
        private string matricula;
        private int cantidadAsientos;
        private int cantidadBaños;
        private bool internet;
        private bool comida;
        private int capacidadBodega;
        private int horasDeVuelo;

        public Aeronaves()
        {

        }
        public Aeronaves( string matricula, int cantidadAsientos, int cantidadBaños, bool internet, bool comida, int capacidadBodega)
        {
            this.matricula = matricula;
            this.cantidadAsientos = cantidadAsientos;
            this.cantidadBaños = cantidadBaños;
            this.internet = internet;
            this.comida = comida;
            this.capacidadBodega = capacidadBodega;
        }

        public string Matricula { get => matricula; set => matricula = value; }
        public int CantidadAsientos { get => cantidadAsientos; set => cantidadAsientos = value; }
        public int CantidadBaños { get => cantidadBaños; set => cantidadBaños = value; }
        public bool Internet { get => internet; set => internet = value; }
        public bool Comida { get => comida; set => comida = value; }
        public int CapacidadBodega { get => capacidadBodega; set => capacidadBodega = value; }
        public int HorasDeVuelo { get => horasDeVuelo; set => horasDeVuelo = value; }

        public static string GenerateMatricula()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            string numeros = "0123456789";
            char[] stringChars = new char[8];
            var random = new Random();
            string matricula = "";

            for (int i = 0; i < 4; i++)
            {
                for(int j = 1; j < 3; j++)
                {
                    stringChars[i] = chars[random.Next(8)];
                    stringChars[j] = numeros[random.Next(8)];
                    matricula += stringChars[i];
                }
            }
            return matricula;
        }
        public static bool operator ==(Aeronaves avion, Vuelos vuelo)
        {
            if (avion is null || vuelo is null)
            {
                return false;
            }
            if (avion.matricula == vuelo.Avion.Matricula)
            {
                return true;
            }
            
            return false;
        }

        public static bool operator !=(Aeronaves avion, Vuelos vuelo)
        {
            return !(avion == vuelo);
        }

        public override bool Equals(object? obj)
        {
            Vuelos? vuelo = obj as Vuelos;

            return vuelo is not null && this == vuelo;
        }

        public override int GetHashCode()
        {
            return matricula.GetHashCode();
        }

        public string BoolAString(bool booleano)
        {
            StringBuilder sb = new StringBuilder();


            if (booleano == true)
            {
                sb.AppendLine("Si");
            }
            else
            {
                sb.AppendLine("No");
            }
            return sb.ToString();
        }

        public static List<Aeronaves> DictionaryHorasDeVuelo()
        {
            Dictionary<string, int> contadorHorasVuelo = new Dictionary<string, int>();
            List<Vuelos>? vuelos = new List<Vuelos>();
            List<Aeronaves>? aviones = new List<Aeronaves>();
            aviones = Deserializadores.DeserializarAeronavesJson();
            vuelos = Deserializadores.DeserializarVuelosXml();

            foreach (Vuelos item in vuelos)
            {
                string matricula = item.Avion.Matricula.ToString();
                int cantidadHoras = item.DuracionVuelo;
                
                if (contadorHorasVuelo.ContainsKey(matricula))
                {
                    if (item.FechaVuelo < DateTime.Today)
                    {
                        contadorHorasVuelo[matricula] += cantidadHoras;
                    }
                }
                else
                {
                    if (item.FechaVuelo < DateTime.Today)
                    {
                        contadorHorasVuelo[matricula] = cantidadHoras;
                    }                    
                }                
            }

            List<Aeronaves> avionesHorasVuelo = new List<Aeronaves>();

            foreach (KeyValuePair<string, int> item in contadorHorasVuelo)
            {
                string matricula = item.Key;
                int horasDeVuelo = item.Value;

                foreach(Aeronaves avion in aviones)
                {
                    if(matricula == avion.Matricula)
                    {
                        avion.horasDeVuelo = horasDeVuelo;
                        avionesHorasVuelo.Add(avion);
                    }
                }
            }
            return avionesHorasVuelo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Matricula: {matricula}");
            sb.AppendLine($"Cantidad de Asientos: {cantidadAsientos}");
            sb.AppendLine($"Cantidad de Baños: {cantidadBaños}");
            sb.AppendLine($"Internet: {BoolAString(internet)}");
            sb.AppendLine($"Comida: {BoolAString(comida)}");
            sb.Append($"Capacidad de Bodega: {capacidadBodega}");

            return sb.ToString();
        }

    }
}
