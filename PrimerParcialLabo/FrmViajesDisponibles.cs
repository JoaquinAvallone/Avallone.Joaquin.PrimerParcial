using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace PrimerParcialLabo
{
    public partial class FrmViajesDisponibles : Form
    {
        List<Vuelos>? vuelos;
        public FrmViajesDisponibles()
        {
            InitializeComponent();

        }

        private void FrmViajesDisponibles_Load(object sender, EventArgs e)
        {
            vuelos = new List<Vuelos>();
            RellenarGrid();
            dataGVInfoPasajeros.Visible = false;
            btnVolver.Visible = false;
        }

        private void RellenarGrid()
        {
            dataGVVuelos.Rows.Clear();
            vuelos = Deserializadores.DeserializarVuelosXml();
            foreach (Vuelos item in vuelos)
            {
                int rowIndex = dataGVVuelos.Rows.Add();
                DataGridViewRow row = dataGVVuelos.Rows[rowIndex];
                row.Cells[0].Value = item.FechaVuelo;
                row.Cells[1].Value = item.CiudadPartida;
                row.Cells[2].Value = item.CiudadDestino;
                row.Cells[3].Value = "$" + item.PrecioTurista;
                row.Cells[4].Value = "$" + item.PrecioPrem;
                row.Cells[5].Value = item.Avion.Matricula;
                row.Cells[6].Value = item.DuracionVuelo;
            }
        }
        private void dataGVVuelos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice;
            indice = e.RowIndex;
            if (indice == -1)
            {
                return;
            }
            RellenarGridPasajeross(indice);
        }

        private void RellenarGridPasajeross(int indice)
        {
            int auxIndice = indice;
            dataGVVuelos.Visible = false;
            dataGVInfoPasajeros.Visible = true;
            btnVolver.Visible = true;
            dataGVInfoPasajeros.Rows.Clear();

            for (int i = auxIndice; i < vuelos.Count(); i++)
            {
                foreach (Pasajeros items in vuelos[i].Pasajeros)
                {
                    int rowIndex = dataGVInfoPasajeros.Rows.Add();
                    DataGridViewRow row = dataGVInfoPasajeros.Rows[rowIndex];
                    row.Cells[0].Value = items.Apellido;
                    row.Cells[1].Value = items.Nombre;
                    row.Cells[2].Value = items.Dni;
                    row.Cells[3].Value = items.Edad;
                    row.Cells[4].Value = items.TipoEquipaje(items.EquipajeMano);
                    row.Cells[5].Value = items.TipoEquipaje(items.EquipajeBodega);
                    row.Cells[6].Value = items.PesoEquipaje + "kg.";
                    row.Cells[7].Value = items.Clase;
                }
                break;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            dataGVInfoPasajeros.Visible = false;
            dataGVVuelos.Visible = true;
            btnVolver.Visible = false;
        }

    }
}
