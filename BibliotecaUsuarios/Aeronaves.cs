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

        public Aeronaves( int cantidadAsientos, int cantidadBaños, bool internet, bool comida, int capacidadBodega)
        {
            this.matricula = Matricula;
            this.cantidadAsientos = cantidadAsientos;
            this.cantidadBaños = cantidadBaños;
            this.internet = internet;
            this.comida = comida;
            this.capacidadBodega = capacidadBodega;
        }

        public string Matricula { get => GenerateMatricula();}
        public int CantidadAsientos { get => cantidadAsientos;}
        public int CantidadBaños { get => cantidadBaños;}
        public bool Internet { get => internet; }
        public bool Comida { get => comida; }
        public int CapacidadBodega { get => capacidadBodega; }

        private string GenerateMatricula()
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
