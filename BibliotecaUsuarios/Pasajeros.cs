using System.Text;

namespace Biblioteca
{
    public class Pasajeros : Persona
    {       
        private int dni;
        private int edad;
        private bool equipajeMano;
        private bool equipajeBodega;
        private float pesoEquipaje;
        private string clase;
        private int cantidadVuelos;

        public Pasajeros():base()
        {

        }
        public Pasajeros(string apellido, string nombre, int dni, int edad, bool equipajeMano, bool equipajeBodega, float pesoEquipaje, string clase) : base(apellido, nombre)
        {            
            this.dni = dni;
            this.edad = edad;
            this.equipajeMano = equipajeMano;
            this.equipajeBodega = equipajeBodega;
            this.pesoEquipaje = pesoEquipaje;
            this.clase = clase;
            cantidadVuelos = 0;
        }

        public int Dni { get => dni; set => dni = value; }
        public int Edad { get => edad; set => edad = value; }
        public bool EquipajeMano { get => equipajeMano; set => equipajeMano = value; }
        public bool EquipajeBodega { get => equipajeBodega; set => equipajeBodega = value; }
        public float PesoEquipaje { get => pesoEquipaje; set => pesoEquipaje = value; }
        public string Clase { get => clase; set => clase = value; }
        public int CantidadVuelos { get => cantidadVuelos; set => cantidadVuelos = value; }

        public string TipoEquipaje(bool equipaje)
        {
            StringBuilder sb = new StringBuilder();
            

            if (equipaje == true)
            {
                sb.AppendLine("Lleva");
            }
            else
            {
                sb.AppendLine("No lleva");
            }
            return sb.ToString();
        }

        private static int PasajerosFrecuentesDescendente(Pasajeros a, Pasajeros b)
        {
            return b.cantidadVuelos - a.cantidadVuelos;
        }

        public static List<Pasajeros> PasajerosFrecuentes()
        {
            List<Pasajeros> pasajerosOrdenados = new List<Pasajeros>();
            List<Vuelos> vuelos = Deserializadores.DeserializarVuelosXml();

            Dictionary<string, Pasajeros> diccionarioPasajeros = new Dictionary<string, Pasajeros>();

            foreach (Vuelos vuelo in vuelos)
            {
                foreach (Pasajeros pasajero in vuelo.Pasajeros)
                {
                    if (diccionarioPasajeros.ContainsKey(pasajero.Nombre))
                    {
                        diccionarioPasajeros[pasajero.Nombre].cantidadVuelos++;
                    }
                    else
                    {
                        diccionarioPasajeros.Add(pasajero.Nombre, pasajero);
                    }
                }
            }

            pasajerosOrdenados = diccionarioPasajeros.Values.ToList();
            pasajerosOrdenados.Sort(PasajerosFrecuentesDescendente);

            return pasajerosOrdenados;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{base.ToString()}");
            sb.AppendLine($"DNI: {dni}");
            sb.Append($"Equipaje de mano: {TipoEquipaje(equipajeMano)}");
            sb.Append($"Equipaje Bodega: {TipoEquipaje(equipajeBodega)}");
            sb.AppendLine($"Peso Equipaje: {pesoEquipaje}kg.");
            sb.AppendLine($"Clase: {clase}");

            return sb.ToString();
        }
    }
}
