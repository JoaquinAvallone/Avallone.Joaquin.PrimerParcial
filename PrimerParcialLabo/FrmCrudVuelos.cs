using System;
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
    public partial class FrmCrudVuelos : Form
    {
        List<Vuelos>? vuelos;
        Vuelos? vueloSeleccionado;
        bool seleccionado = false;
        public FrmCrudVuelos()
        {
            InitializeComponent();
        }

        private void FrmCrudVuelos_Load(object sender, EventArgs e)
        {
            vuelos = new List<Vuelos>();
            btnVolver.Visible = false;
            RellenarGrid();
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
                row.Cells[5].Value = item.CantidadAsientosTuris;
                row.Cells[6].Value = item.CantidadAsientosPrem;
                row.Cells[7].Value = item.Avion.Matricula;
            }
        }

        private void dataGVVuelos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice;
            indice = e.RowIndex;
            btnVolver.Visible = true;
            txtBMatricula.Visible = false;

            if (indice >= 0 && indice < vuelos.Count)
            {
                vueloSeleccionado = vuelos[indice];
                dataGVVuelos.Rows.Clear();

                int rowIndex = dataGVVuelos.Rows.Add();
                DataGridViewRow row = dataGVVuelos.Rows[rowIndex];
                row.Cells[0].Value = vueloSeleccionado.FechaVuelo;
                row.Cells[1].Value = vueloSeleccionado.CiudadPartida;
                row.Cells[2].Value = vueloSeleccionado.CiudadDestino;
                row.Cells[3].Value = "$" + vueloSeleccionado.PrecioTurista;
                row.Cells[4].Value = "$" + vueloSeleccionado.PrecioPrem;
                row.Cells[5].Value = vueloSeleccionado.CantidadAsientosTuris;
                row.Cells[6].Value = vueloSeleccionado.CantidadAsientosPrem;
                row.Cells[7].Value = vueloSeleccionado.Avion.Matricula;
                seleccionado = true;
                Serializadores.SerializarJson("VueloSeleccionado.json", vueloSeleccionado);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            btnVolver.Visible = false;
            seleccionado = false;
            txtBMatricula.Visible = true;
            RellenarGrid();
        }

        private void FiltrarPorMatricula()
        {
            dataGVVuelos.Rows.Clear();
            string filtro = txtBMatricula.Text.ToUpper();
            vuelos = Deserializadores.DeserializarVuelosJson();

            foreach (Vuelos item in vuelos)
            {
                string matricula = item.Avion.Matricula.ToString();
                bool empiezaCon = true;

                for (int i = 0; i < filtro.Length; i++)
                {
                    if (matricula[i] != filtro[i])
                    {
                        empiezaCon = false;
                        break;
                    }
                }

                if (empiezaCon)
                {
                    int rowIndex = dataGVVuelos.Rows.Add();
                    DataGridViewRow row = dataGVVuelos.Rows[rowIndex];
                    row.Cells[0].Value = item.FechaVuelo;
                    row.Cells[1].Value = item.CiudadPartida;
                    row.Cells[2].Value = item.CiudadDestino;
                    row.Cells[3].Value = "$" + item.PrecioTurista;
                    row.Cells[4].Value = "$" + item.PrecioPrem;
                    row.Cells[5].Value = item.CantidadAsientosTuris;
                    row.Cells[6].Value = item.CantidadAsientosPrem;
                    row.Cells[7].Value = item.Avion.Matricula;
                }
            }
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form? formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault(); // busca en la coleccion el formulario
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                panelFormularios.BringToFront();
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
                panelFormularios.BringToFront();
            }
        }

        private void txtBMatricula_TextChanged(object sender, EventArgs e)
        {
            FiltrarPorMatricula();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmAgregarVuelo>();
        }
    }
}
