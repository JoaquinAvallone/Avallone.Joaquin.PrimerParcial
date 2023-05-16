using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Persona
    {
        private string apellido;
        private string nombre;

        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Persona() { }
        public Persona(string apellido, string nombre)
        {
            this.apellido = apellido;
            this.nombre = nombre;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Apellido: {apellido}");
            sb.AppendLine($"Nombre: {nombre}");

            return sb.ToString();
        }
    }
}
