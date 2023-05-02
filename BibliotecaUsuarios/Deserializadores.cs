using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Deserializadores
    {
        public static List<Usuarios> DeserializarUsuariosJson()
        {
            //string pathEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //string pathArchivo = Path.Combine(pathEscritorio, "MOCK_DATA.json");


            if (File.Exists("MOCK_DATA.json"))
            {
                using (StreamReader sr = new StreamReader("MOCK_DATA.json"))
                {
                    string stringJson = sr.ReadToEnd();

                    List<Usuarios>? objeto = (List<Usuarios>?)JsonSerializer.Deserialize<List<Usuarios>>(stringJson);

                    return objeto;               
                }
            }
            return null;

        }
    }
}
