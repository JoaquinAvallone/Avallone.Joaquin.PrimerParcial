using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Destinos
    {
        private string destino;
        private float recaudacion;
        private int vecesElegido;

        public Destinos(string destino, float recaudacion)
        {
            Destino = destino;
            Recaudacion = recaudacion;
        }


        public string Destino { get => destino; set => destino = value; }
        public float Recaudacion { get => recaudacion; set => recaudacion = value; }
        public int VecesElegido { get => vecesElegido; set => vecesElegido = value; }

        public static int RecaudacionDestinosDescendente(Destinos a, Destinos b)
        {
            return (int)(b.recaudacion - a.recaudacion);
        }

        public static Destinos DestinoMasElegido()
        {
            Dictionary<string, int> contadorDestinos = new Dictionary<string, int>();
            List<Vuelos>? vuelos = new List<Vuelos>();
            vuelos = Deserializadores.DeserializarVuelosJson();

            foreach (Vuelos item in vuelos)
            {
                string destino = item.CiudadDestino.ToString();
                int cantidadPasajeros = item.Pasajeros.Count();

                if (contadorDestinos.ContainsKey(destino))
                {
                    contadorDestinos[destino] += cantidadPasajeros;
                }
                else
                {
                    contadorDestinos[destino] = cantidadPasajeros;
                }
            }

            string destinoMasElegido = null;
            int maxCantidadElegido = 0;

            foreach (KeyValuePair<string, int> item in contadorDestinos)
            {
                string destino = item.Key;
                int recuento = item.Value;

                if (recuento > maxCantidadElegido)
                {
                    destinoMasElegido = destino;
                    maxCantidadElegido = recuento;
                }
            }
            List<Destinos> recaudacionDestinos = new List<Destinos>();
            recaudacionDestinos = Vuelos.DestinosOrdenadosPorRecaudacion();
            float recaudacion = 0;

            foreach (Destinos destino in recaudacionDestinos)
            {
                if(destinoMasElegido == destino.destino)
                {
                    recaudacion = destino.recaudacion;
                }
            }           
            Destinos masElegido = new Destinos(destinoMasElegido, recaudacion);
            masElegido.vecesElegido = maxCantidadElegido;

            return masElegido;
        }

        public enum Nacional
        {
            BuenosAires,
            SantaRosa,
            Bariloche,
            Corrientes,
            Córdoba,
            Jujuy,
            Mendoza,
            Neuquén,
            Posadas,
            Iguazú,
            Salta,
            SantiagoDelEstero,
            Trelew,
            Tucumán,
            PuertoMadryn,
            Ushuaia, 
        }

        public enum origenInternacional
        {
            BuenosAires
        }

        public enum DestinoInternacional
        {
            Recife,
            Roma,
            Acapulco,
            Miami
        }

    }
}
