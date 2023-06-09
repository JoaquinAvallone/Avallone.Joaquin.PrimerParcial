﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class HardCodeo
    {
        public static List<Usuarios> HardCodeoUsuarios()
        {
            List<Usuarios> lista = new List<Usuarios>();
            Usuarios usuario1 = new Usuarios("Gorgen", "Corey", 1, "cgorgen@vendedor.com", "123abc45", "vendedor");
            Usuarios usuario2 = new Usuarios("Harroll", "Ingrid", 2, "iharroll@vendedor.com", "qweasdzx", "vendedor");
            Usuarios usuario3 = new Usuarios("Harris", "Steve", 3, "sharris@maiden.com.uk", "eddie666", "vendedor");
            Usuarios usuario4 = new Usuarios("Robinson", "Tilda", 4, "trobinson@super.com", "12345678", "supervisor");
            Usuarios usuario5 = new Usuarios("Jordan", "Michael", 5, "admin@admin.com", "12345678", "administrador");

            lista.Add(usuario1);
            lista.Add(usuario2);
            lista.Add(usuario3);
            lista.Add(usuario4);
            lista.Add(usuario5);

            return lista;
        }
        public static List<Pasajeros> HardCodeoPasajeros()
        {
            List<Pasajeros> lista = new List<Pasajeros>();

            Pasajeros pasajero1 = new Pasajeros("Avallone", "Joaquin", 40796568, 25, true, false, 30, "Premium");
            Pasajeros pasajero2 = new Pasajeros("Fernando", "Gago", 44157922, 30, true, true, 40, "Premium");
            Pasajeros pasajero3 = new Pasajeros("Martinez", "Dibu", 40456568, 27, true, false, 22, "Turista");
            Pasajeros pasajero4 = new Pasajeros("Messi", "Leonel", 44157652, 22, true, true, 27, "Premium");
            Pasajeros pasajero5 = new Pasajeros("Jenner", "Kendall", 41796568, 27, true, false, 21, "Turista");
            Pasajeros pasajero6 = new Pasajeros("Holland", "Tom", 44327922, 24, true, true, 38, "Premium");
            Pasajeros pasajero7 = new Pasajeros("Lopez", "Zendaya", 43196568, 25, true, false, 15, "Turista");
            Pasajeros pasajero8 = new Pasajeros("Hadid", "Bella", 40787922, 28, true, true, 23, "Premium");
            Pasajeros pasajero9 = new Pasajeros("Hadid", "Gigi", 42795468, 27, true, false, 20, "Turista");
            Pasajeros pasajero10 = new Pasajeros("Jackie", "Chan", 38108922, 40, true, true, 32, "Premium");
            Pasajeros pasajero11 = new Pasajeros("Potato", "Hernan", 37719568, 40, true, false, 16, "Turista");
            Pasajeros pasajero12 = new Pasajeros("Forti", "Agustin", 45157002, 17, true, true, 20, "Premium");
            Pasajeros pasajero13 = new Pasajeros("Smith", "Ignacio", 38754768, 25, true, false, 17, "Turista");
            Pasajeros pasajero14 = new Pasajeros("Marini", "Nicolas", 42970922, 28, true, true, 39, "Premium");
            Pasajeros pasajero15 = new Pasajeros("Garcia", "Bautista", 40796888, 27, true, false, 15, "Turista");
            Pasajeros pasajero16 = new Pasajeros("Avallone", "Paloma", 46149922, 18, true, true, 32, "Premium");

            lista.Add(pasajero1);
            lista.Add(pasajero2);
            lista.Add(pasajero3);
            lista.Add(pasajero4);
            lista.Add(pasajero5);
            lista.Add(pasajero6);
            lista.Add(pasajero7);
            lista.Add(pasajero8);
            lista.Add(pasajero9);
            lista.Add(pasajero10);
            lista.Add(pasajero11);
            lista.Add(pasajero12);
            lista.Add(pasajero13);
            lista.Add(pasajero14);
            lista.Add(pasajero15);
            lista.Add(pasajero16);

            return lista;
        }

        public static List<Aeronaves> HardCodeoAeronaves()
        {
            List<Aeronaves> aviones = new List<Aeronaves>();

            Aeronaves avion1 = new Aeronaves("M2AF45SE", 150, 4, true, true, 1600);
            Aeronaves avion2 = new Aeronaves("Y45TS67M",250, 6, false, true, 3100);
            Aeronaves avion3 = new Aeronaves("LA31YTE6",170, 5, true, true, 5000);
            Aeronaves avion4 = new Aeronaves("UTR43Y21",120, 3, false, false, 4600);
            Aeronaves avion5 = new Aeronaves("8S7HY5A3",200, 5, true, true, 7000);
            Aeronaves avion6 = new Aeronaves("76TS4SRA",150, 4, false, false, 8000);

            aviones.Add(avion1);
            aviones.Add(avion2);
            aviones.Add(avion3);
            aviones.Add(avion4);
            aviones.Add(avion5);
            aviones.Add(avion6);

            return aviones;
        }

        public static List<Vuelos> HardCodeoVuelos()
        {
            List<Vuelos> vuelos = new List<Vuelos>();
            List<Aeronaves>? aviones = new List<Aeronaves>();
            aviones = Deserializadores.DeserializarAeronavesJson();
            List<Pasajeros> pasajeros = new List<Pasajeros>();
            pasajeros = HardCodeoPasajeros();
            foreach(Pasajeros item in pasajeros)
            {
                item.CantidadVuelos++;
            }

            Vuelos vuelo1 = new Vuelos("Salta", "BuenosAires", new DateTime(2023, 4, 22, 06, 10, 00), aviones[0], 30, 120, 181.5F, 248.65F, 3);
            Vuelos vuelo2 = new Vuelos("Córdoba", "BuenosAires", new DateTime(2023, 6, 12, 14, 40, 00), aviones[1], 50, 200, 121, 163.35F, 2);
            Vuelos vuelo3 = new Vuelos("BuenosAires", "Roma", new DateTime(2023, 5, 24, 16, 20, 00), aviones[2], 34, 136, 1452, 1960.2F, 12);
            Vuelos vuelo4 = new Vuelos("BuenosAires", "Miami", new DateTime(2023, 9, 10, 20, 30, 00), aviones[3], 24, 96, 1210, 1633.5F, 10);
            Vuelos vuelo5 = new Vuelos("Tucumán", "Bariloche", new DateTime(2023, 6, 15, 10, 00, 00), aviones[4], 40, 160, 181.5F, 248.65F, 3);
            Vuelos vuelo6 = new Vuelos("BuenosAires", "Ushuaia", new DateTime(2023, 5, 16, 08, 00, 00), aviones[5], 30, 120, 242, 326.7F, 4);

            vuelo1.Pasajeros.Add(pasajeros[0]);
            vuelo1.Pasajeros.Add(pasajeros[1]);
            vuelo1.GananciasPrem = 248.65F * 2;
            vuelo2.Pasajeros.Add(pasajeros[2]);
            vuelo2.Pasajeros.Add(pasajeros[3]);
            vuelo2.GananciasPrem = 163.35F;
            vuelo2.GananciasTuris = 121;
            vuelo3.Pasajeros.Add(pasajeros[4]);
            vuelo3.Pasajeros.Add(pasajeros[5]);
            vuelo3.Pasajeros.Add(pasajeros[6]);
            vuelo3.GananciasPrem = 1960.2F;
            vuelo3.GananciasTuris = 1452 * 2;
            vuelo4.Pasajeros.Add(pasajeros[7]);
            vuelo4.Pasajeros.Add(pasajeros[8]);
            vuelo4.Pasajeros.Add(pasajeros[9]);
            vuelo4.GananciasPrem = 1633.5F * 2;
            vuelo4.GananciasTuris = 1210;
            vuelo5.Pasajeros.Add(pasajeros[10]);
            vuelo5.Pasajeros.Add(pasajeros[11]);
            vuelo5.Pasajeros.Add(pasajeros[12]);
            vuelo5.GananciasPrem = 248.65F;
            vuelo5.GananciasTuris = 181.5F * 2;
            vuelo6.Pasajeros.Add(pasajeros[13]);
            vuelo6.Pasajeros.Add(pasajeros[14]);
            vuelo6.Pasajeros.Add(pasajeros[15]);
            vuelo6.GananciasPrem = 326.7F * 2;
            vuelo6.GananciasTuris = 242;


            vuelos.Add(vuelo1);
            vuelos.Add(vuelo2);
            vuelos.Add(vuelo3);
            vuelos.Add(vuelo4);
            vuelos.Add(vuelo5);
            vuelos.Add(vuelo6);

            Serializadores.SerializarXML("Pasajeros.xml", pasajeros);

            return vuelos;
        }
    }
}
