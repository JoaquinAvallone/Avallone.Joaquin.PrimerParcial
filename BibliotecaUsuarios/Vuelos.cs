using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Vuelos
    {       
        private string ciudadPartida;
        private string ciudadDestino;
        private DateTime fechaVuelo;
        private Aeronaves avion;
        private int cantidadAsientosPrem;
        private int cantidadAsientosTuris;
        private float precioTurista;
        private float precioPrem;
        private float duracionVuelo;
        private List<Pasajeros> pasajeros;

        public Vuelos()
        {
            Pasajeros = new List<Pasajeros>();
        }
        public Vuelos(string ciudadPartida, string ciudadDestino, DateTime fechaVuelo, Aeronaves aeronaves, int cantidadAsientosPrem, int cantidadAsientosTuris, float precioTurista, float precioPrem, float duracionVuelo,List<Pasajeros> pasajeros):this()
        {
            this.ciudadPartida = ciudadPartida;
            this.ciudadDestino = ciudadDestino;
            this.fechaVuelo = fechaVuelo;
            this.avion = aeronaves;
            this.cantidadAsientosPrem = cantidadAsientosPrem;
            this.cantidadAsientosTuris = cantidadAsientosTuris;
            this.precioTurista = precioTurista;
            this.precioPrem = precioPrem;
            this.duracionVuelo = duracionVuelo;
            this.Pasajeros = pasajeros;
        }


        public string CiudadPartida { get => ciudadPartida; set => ciudadPartida = value; }
        public string CiudadDestino { get => ciudadDestino; set => ciudadDestino = value; }
        public DateTime FechaVuelo { get => fechaVuelo; set => fechaVuelo = value; }
        public Aeronaves Avion { get => avion; set => avion = value; }
        public int CantidadAsientosPrem { get => cantidadAsientosPrem; set => cantidadAsientosPrem = value; }
        public int CantidadAsientosTuris { get => cantidadAsientosTuris; set => cantidadAsientosTuris = value; }
        public float PrecioTurista { get => precioTurista; set => precioTurista = value; }
        public float PrecioPrem { get => precioPrem; set => precioPrem = value; }
        public float DuracionVuelo { get => duracionVuelo; set => duracionVuelo = value; }
        public List<Pasajeros> Pasajeros { get => pasajeros; set => pasajeros = value; }

       
        public static int GenerarDuracionNacional()
        {
            Random random = new Random();

            return random.Next(2, 4 + 1);
        }

        public static int GenerarDuracionIntenacional()
        {
            Random random = new Random();

            return random.Next(8, 12 + 1);
        }

        public static int GenerarPrecioNacional(bool premium, int duracion)
        {
            int precioTurista;
            int precioPremium;
            int porcentaje;

            precioTurista = duracion * 50;
            if (premium)
            {
                porcentaje = (35 * precioTurista) / 100;
                precioPremium = precioTurista + porcentaje;
                return precioPremium;
            }            
            return precioTurista;
        }

        public static int GenerarPrecioInternacional(bool premium, int duracion)
        {
            int precioTurista;
            int precioPremium;
            int porcentaje;

            precioTurista = duracion * 100;
            if (premium)
            {
                porcentaje = (35 * precioTurista) / 100;
                precioPremium = precioTurista + porcentaje;
                return precioPremium;
            }

            return precioTurista;
        }

        public static bool operator ==(Pasajeros pasajero, Vuelos vuelo)
        {
            if(pasajero is null || vuelo is null)
            {
                return false;
            }
            foreach(Pasajeros item in vuelo.Pasajeros)
            {
                if(pasajero.Dni == item.Dni && pasajero.Nombre == item.Nombre)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Pasajeros pasajero, Vuelos vuelo)
        {
            return !(pasajero == vuelo);
        }

        public static Vuelos? operator +(Vuelos vuelo, Pasajeros pasajero)
        {
            if (vuelo is null || pasajero is null)
            {
                return null;
            }
            else if (pasajero == vuelo)
            {
                vuelo.Pasajeros.Add(pasajero);
                return vuelo;
            }
            return null;
        }

        public static Vuelos? operator -(Vuelos vuelo, Pasajeros pasajero)
        {
            if (vuelo is null || pasajero is null)
            {
                return null;
            }
            if (pasajero == vuelo)
            {
                vuelo.Pasajeros.Remove(pasajero);
                return vuelo;
            }
            return null;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Ciudad de Partida: {ciudadPartida}");
            sb.AppendLine($"Ciudad de Destino: {ciudadDestino}");
            sb.AppendLine($"Fecha del Vuelo: {fechaVuelo}");
            sb.AppendLine($"Avion:\n{avion.ToString()}");
            sb.AppendLine($"Cantidad de Asientos Premium:{cantidadAsientosPrem}");
            sb.AppendLine($"Cantidad de Asientos Turista:{cantidadAsientosTuris}");
            sb.AppendLine($"Precio Turista: {precioTurista}");
            sb.AppendLine($"Precio Premium: {precioPrem}");
            sb.AppendLine($"Duracion del Vuelo: {duracionVuelo}hs");
            sb.AppendLine($"Lista de pasajeros: ");
            foreach ( Pasajeros pasajero in Pasajeros)
            {
                sb.AppendLine($"{pasajero.ToString()}");
            }

            return sb.ToString();
        }
    }
}
