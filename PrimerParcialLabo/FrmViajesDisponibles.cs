using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace PrimerParcialLabo
{
    public partial class FrmViajesDisponibles : Form
    {
        List<Vuelos> vuelos;
        public FrmViajesDisponibles()
        {
            InitializeComponent();
            vuelos = new List<Vuelos>();
            vuelos = Serializadores.HardCodeoVuelos();
            RellenarGrid();
        }

        private void FrmViajesDisponibles_Load(object sender, EventArgs e)
        {
        }

        private void RellenarGrid()
        {
            foreach (Vuelos item in vuelos)
            {
                int rowIndex = dataGVVuelos.Rows.Add();
                DataGridViewRow row = dataGVVuelos.Rows[rowIndex];
                row.Cells[0].Value = item.FechaVuelo;
                row.Cells[1].Value = item.CiudadPartida;
                row.Cells[2].Value = item.CiudadDestino;
                row.Cells[3].Value = item.Avion.Matricula;
            }
        }
        private void dataGVVuelos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice;
            indice = e.RowIndex;
            RellenarGridPasajeros(indice);
        }

        private void RellenarGridPasajeros(int indice)
        {
            FrmInfoVuelo frmInfoVuelo = new FrmInfoVuelo();
            int auxIndice = indice;

            foreach (Control item in frmInfoVuelo.Controls)
            {
                if (item is DataGridView)
                {
                    DataGridView? dgv = item as DataGridView;
                    if (dgv?.Name == "dataGVInfoVuelos")
                    {
                        for (int i = auxIndice; i < vuelos.Count(); i++)
                        {
                            foreach (Pasajeros items in vuelos[i].Pasajeros)
                            {
                                int rowIndex = dgv.Rows.Add();
                                DataGridViewRow row = dgv.Rows[rowIndex];
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
                }
            }
            frmInfoVuelo.ShowDialog();
        }

    }
}
