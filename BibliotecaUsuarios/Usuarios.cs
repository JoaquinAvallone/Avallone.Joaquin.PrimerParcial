using System.Text;

namespace Biblioteca
{
    public class Usuarios : Persona
    {
        private int legajo;
        private string correo;
        private string clave;
        private string perfil;

        public int Legajo { get => legajo; set => legajo = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Clave { get => clave; set => clave = value; }
        public string Perfil { get => perfil; set => perfil = value; }

        public Usuarios( string apellido, string nombre, int legajo, string correo, string clave, string perfil) : base(apellido, nombre)
        {
            this.legajo = legajo;
            this.correo = correo;
            this.clave = clave;
            this.perfil = perfil;
        }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.ToString()}");
            sb.AppendLine($"Legajo: {legajo}");
            sb.AppendLine($"Correo: {correo}");
            sb.AppendLine($"Clave: {clave}");
            sb.AppendLine($"Perfil: {perfil}");
            return sb.ToString();
        }


    }
}