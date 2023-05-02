using System.Text;

namespace Biblioteca
{
    public class Usuarios
    {
        public string apellido { get; set; }
        public string nombre { get; set; }
        public int legajo { get; set; }
        public string correo { get; set; }
        public string clave { get; set; }
        public string perfil { get; set; }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Apellido: {apellido}");
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Legajo: {legajo}");
            sb.AppendLine($"Correo: {correo}");
            sb.AppendLine($"Clave: {clave}");
            sb.AppendLine($"Perfil: {perfil}");
            return sb.ToString();
        }


    }
}