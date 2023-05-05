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

        public Pasajeros(string apellido, string nombre, int dni, int edad, bool equipajeMano, bool equipajeBodega, float pesoEquipaje, string clase) : base(apellido, nombre)
        {            
            this.dni = dni;
            this.edad = edad;
            this.equipajeMano = equipajeMano;
            this.equipajeBodega = equipajeBodega;
            this.pesoEquipaje = pesoEquipaje;
            this.clase = clase;
        }
        
        public int Dni { get => dni; }
        public int Edad { get => edad;  }
        public bool EquipajeMano { get => equipajeMano;  }
        public bool EquipajeBodega { get => equipajeBodega; }
        public float PesoEquipaje { get => pesoEquipaje; }
        public string Clase { get => clase; }

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
