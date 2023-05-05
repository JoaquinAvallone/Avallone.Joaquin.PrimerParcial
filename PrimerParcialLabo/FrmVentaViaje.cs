using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcialLabo
{
    public partial class FrmVentaViaje : Form
    {
        List<Vuelos> vuelos;
        public FrmVentaViaje()
        {
            InitializeComponent();
            vuelos = new List<Vuelos>();
            vuelos = Serializadores.HardCodeoVuelos();
            RellenarGrid();
        }

        private void FrmVentaViaje_Load(object sender, EventArgs e)
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
                row.Cells[3].Value = "$" + item.PrecioTurista;
                row.Cells[4].Value = "$" + item.PrecioPrem;
                row.Cells[5].Value = item.Avion.Matricula;
                row.Cells[6].Value = item.Avion.BoolAString(item.Avion.Internet);
                row.Cells[7].Value = item.Avion.BoolAString(item.Avion.Comida);
            }
        }

        private void checkBInternet_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBInternet.Checked)
            {
                dataGVVuelos.Rows.Clear();
                RellenarGridInternet();
            }
            else
            {
                dataGVVuelos.Rows.Clear();
                RellenarGrid();
            }
        }

        private void RellenarGridInternet()
        {
            foreach (Vuelos item in vuelos)
            {
                if (item.Avion.Internet)
                {
                    int rowIndex = dataGVVuelos.Rows.Add();
                    DataGridViewRow row = dataGVVuelos.Rows[rowIndex];
                    row.Cells[0].Value = item.FechaVuelo;
                    row.Cells[1].Value = item.CiudadPartida;
                    row.Cells[2].Value = item.CiudadDestino;
                    row.Cells[3].Value = "$" + item.PrecioTurista;
                    row.Cells[4].Value = "$" + item.PrecioPrem;
                    row.Cells[5].Value = item.Avion.Matricula;
                    row.Cells[6].Value = item.Avion.BoolAString(item.Avion.Internet);
                    row.Cells[7].Value = item.Avion.BoolAString(item.Avion.Comida);
                }

            }
        }

        private void RellenarGridComida()
        {
            foreach (Vuelos item in vuelos)
            {
                if (item.Avion.Comida)
                {
                    int rowIndex = dataGVVuelos.Rows.Add();
                    DataGridViewRow row = dataGVVuelos.Rows[rowIndex];
                    row.Cells[0].Value = item.FechaVuelo;
                    row.Cells[1].Value = item.CiudadPartida;
                    row.Cells[2].Value = item.CiudadDestino;
                    row.Cells[3].Value = "$" + item.PrecioTurista;
                    row.Cells[4].Value = "$" + item.PrecioPrem;
                    row.Cells[5].Value = item.Avion.Matricula;
                    row.Cells[6].Value = item.Avion.BoolAString(item.Avion.Internet);
                    row.Cells[7].Value = item.Avion.BoolAString(item.Avion.Comida);
                }

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBComida.Checked)
            {
                dataGVVuelos.Rows.Clear();
                RellenarGridComida();
            }
            else
            {
                dataGVVuelos.Rows.Clear();
                RellenarGrid();
            }
        }

        private void dataGVVuelos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice;
            indice = e.RowIndex;
        }


    }
}

