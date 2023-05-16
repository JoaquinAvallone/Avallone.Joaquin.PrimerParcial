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
        private int duracionVuelo;
        private List<Pasajeros> pasajeros;
        private float gananciasTuris;
        private float gananciasPrem;

        public Vuelos()
        {
            Pasajeros = new List<Pasajeros>();
        }
        public Vuelos(string ciudadPartida, string ciudadDestino, DateTime fechaVuelo, Aeronaves aeronaves, int cantidadAsientosPrem, int cantidadAsientosTuris, float precioTurista, float precioPrem, int duracionVuelo):this()
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
        public int DuracionVuelo { get => duracionVuelo; set => duracionVuelo = value; }
        public List<Pasajeros> Pasajeros { get => pasajeros; set => pasajeros = value; }
        public float GananciasTuris { get => gananciasTuris; set => gananciasTuris = value; }
        public float GananciasPrem { get => gananciasPrem; set => gananciasPrem = value; }

        public static int GeneradorCantidadAsientos(bool premium, int asientosTotales)
        {
            int asientosPrem;
            int asientosTuris;

            asientosPrem = (20 * asientosTotales) / 100;
            if (!premium)
            {
                asientosTuris = asientosTotales - asientosPrem;
                return asientosTuris;
            }

            return asientosPrem;            
        }

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

        public static float GenerarPrecioNacional(bool premium, int duracion)
        {
            float precioTurista;
            float precioPremium;
            float porcentaje;

            precioTurista = duracion * 50;
            if (premium)
            {
                porcentaje = (35 * precioTurista) / 100;
                precioPremium = precioTurista + porcentaje;
                return precioPremium;
            }            
            return precioTurista;
        }

        public static float GenerarPrecioNacionalConIva(bool premium, int duracion)
        {
            float precioTurista;
            float precioPremium;
            float porcentajePremium;
            float porcentajeIva;
            float precioPremIva;
            float precioTurisIva;

            precioTurista = duracion * 50;
            porcentajeIva = (21 * precioTurista) / 100;
            precioTurisIva = precioTurista + porcentajeIva;
            if (premium)
            {
                porcentajePremium = (35 * precioTurista) / 100;
                precioPremium = precioTurista + porcentajePremium;
                porcentajeIva = (21 * precioPremium) / 100;
                precioPremIva = porcentajeIva + precioPremium;

                return precioPremium;
            }
            return precioTurisIva;
        }

        public static float GenerarPrecioInternacional(bool premium, int duracion)
        {
            float precioTurista;
            float precioPremium;
            float porcentaje;

            precioTurista = duracion * 100;
            if (premium)
            {
                porcentaje = (35 * precioTurista) / 100;
                precioPremium = precioTurista + porcentaje;
                return precioPremium;
            }

            return precioTurista;
        }

        public static float GenerarPrecioInternacionalConIva(bool premium, int duracion)
        {
            float precioTurista;
            float precioPremium;
            float porcentajePremium;
            float porcentajeIva;
            float precioPremIva;
            float precioTurisIva;

            precioTurista = duracion * 50;
            porcentajeIva = (21 * precioTurista) / 100;
            precioTurisIva = precioTurista + porcentajeIva;
            if (premium)
            {
                porcentajePremium = (35 * precioTurista) / 100;
                precioPremium = precioTurista + porcentajePremium;
                porcentajeIva = (21 * precioPremium) / 100;
                precioPremIva = porcentajeIva + precioPremium;

                return precioPremIva;
            }
            return precioTurisIva;
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

        public static bool operator +(Vuelos vuelo, Pasajeros pasajero)
        {
            if (vuelo is null || pasajero is null)
            {
                return false;
            }
            else if (pasajero != vuelo)
            {
                vuelo.Pasajeros.Add(pasajero);
                return true;
            }
            return false;
        }

        public static bool operator -(Vuelos vuelo, Pasajeros pasajero)
        {
            if (vuelo is null || pasajero is null)
            {
                return false;
            }
            if (pasajero == vuelo)
            {
                vuelo.Pasajeros.Remove(pasajero);
                return true;
            }
            return false;
        }

        public static List<Destinos> DestinosOrdenadosPorRecaudacion()
        {
            Dictionary<string, float> acumuladorGanancias = new Dictionary<string, float>();
            List<Vuelos> vuelos = Deserializadores.DeserializarVuelosXml();

            foreach (Vuelos item in vuelos)
            {
                string destino = item.ciudadDestino.ToString();
                float ganancias = item.GananciasTuris + item.GananciasPrem;

                if (acumuladorGanancias.ContainsKey(destino))
                {
                    acumuladorGanancias[destino] += ganancias;
                }
                else
                {
                    acumuladorGanancias[destino] = ganancias;
                }
            }

            List<Destinos> destinosOrdenados = new List<Destinos>();

            foreach (KeyValuePair<string, float> item in acumuladorGanancias)
            {
                string destino = item.Key;
                float recaudacion = item.Value;

                destinosOrdenados.Add(new Destinos(destino, recaudacion));
            }

            destinosOrdenados.Sort(Destinos.RecaudacionDestinosDescendente);

            return destinosOrdenados;
        }

        public static float RecaudacionInternacional()
        {
            List<Vuelos>? vuelos = new List<Vuelos>();
            vuelos = Deserializadores.DeserializarVuelosXml();
            float acumuladorGanancias = 0;

            foreach (Destinos.DestinoInternacional destino in Enum.GetValues(typeof(Destinos.DestinoInternacional)))
            {
                foreach (Vuelos item in vuelos)
                {
                    if (item.ciudadDestino == destino.ToString())
                    {
                        float ganancias = item.GananciasTuris + item.gananciasPrem;
                        acumuladorGanancias += ganancias;
                    }
                }
            }

            return acumuladorGanancias;
        }

        public static float RecaudacionNacional()
        {
            List<Vuelos>? vuelos = new List<Vuelos>();
            vuelos = Deserializadores.DeserializarVuelosXml();
            float acumuladorGanancias = 0;

            foreach (Destinos.Nacional destino in Enum.GetValues(typeof(Destinos.Nacional)))
            {
                foreach (Vuelos item in vuelos)
                {
                    if (item.ciudadDestino == destino.ToString())
                    {
                        float ganancias = item.GananciasTuris + item.gananciasPrem;
                        acumuladorGanancias += ganancias;
                    }
                }
            }

            return acumuladorGanancias;
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
