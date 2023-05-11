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
        List<Vuelos>? vuelos;
        public FrmVentaViaje()
        {
            InitializeComponent();
            vuelos = new List<Vuelos>();
            vuelos = Deserializadores.DeserializarVuelosJson();
            btnVolver.Visible = false;
            btnSeleccionar.Visible = false;
            RellenarGrid();
        }

        private void FrmVentaViaje_Load(object sender, EventArgs e)
        {

        }
        private void RellenarGrid()
        {
            dataGVVuelos.Rows.Clear();
            vuelos = Deserializadores.DeserializarVuelosJson();
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
                row.Cells[8].Value = item.Avion.CantidadAsientos;
            }
        }

        private void checkBInternet_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBInternet.Checked)
            {
                ;
                RellenarGridInternet();
            }
            else
            {
                RellenarGrid();
            }
        }

        private void RellenarGridInternet()
        {
            dataGVVuelos.Rows.Clear();

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
                    row.Cells[8].Value = item.Avion.CantidadAsientos;
                }

            }
        }

        private void RellenarGridComida()
        {
            dataGVVuelos.Rows.Clear();

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
                    row.Cells[8].Value = item.Avion.CantidadAsientos;
                }

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBComida.Checked)
            {
                RellenarGridComida();
            }
            else
            {
                RellenarGrid();
            }
        }

        private void dataGVVuelos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice;
            indice = e.RowIndex;

            if (indice >= 0 && indice < vuelos.Count)
            {
                Vuelos vueloSeleccionado = vuelos[indice];
                dataGVVuelos.Rows.Clear();
                btnVolver.Visible = true;
                btnSeleccionar.Visible = true;
                checkBComida.Visible = false;
                checkBInternet.Visible = false;

                int rowIndex = dataGVVuelos.Rows.Add();
                DataGridViewRow row = dataGVVuelos.Rows[rowIndex];
                row.Cells[0].Value = vueloSeleccionado.FechaVuelo;
                row.Cells[1].Value = vueloSeleccionado.CiudadPartida;
                row.Cells[2].Value = vueloSeleccionado.CiudadDestino;
                row.Cells[3].Value = "$" + vueloSeleccionado.PrecioTurista;
                row.Cells[4].Value = "$" + vueloSeleccionado.PrecioPrem;
                row.Cells[5].Value = vueloSeleccionado.Avion.Matricula;
                row.Cells[6].Value = vueloSeleccionado.Avion.BoolAString(vueloSeleccionado.Avion.Internet);
                row.Cells[7].Value = vueloSeleccionado.Avion.BoolAString(vueloSeleccionado.Avion.Comida);
                row.Cells[8].Value = vueloSeleccionado.Avion.CantidadAsientos;
                Serializadores.SerializarJson("VueloSeleccionado.json", vueloSeleccionado);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            RellenarGrid();
            btnVolver.Visible = false;
            btnSeleccionar.Visible = false;
            checkBComida.Visible = true;
            checkBInternet.Visible = true;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            FrmAgregarPasajero frmAgregarPasajero = new FrmAgregarPasajero();
            frmAgregarPasajero.ShowDialog();
            RellenarGrid();
        }
    }
}


