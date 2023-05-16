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
    public partial class FrmCrudAeronaves : Form
    {
        List<Aeronaves>? aviones;
        List<Aeronaves>? avionesPorMatricula;
        Aeronaves? avionSeleccionado;
        List<Vuelos>? vuelos;
        bool seleccionado = false;
        public FrmCrudAeronaves()
        {
            InitializeComponent();
        }


        private void FrmCrudAeronaves_Load(object sender, EventArgs e)
        {
            aviones = new List<Aeronaves>();
            avionesPorMatricula = new List<Aeronaves>();
            vuelos = new List<Vuelos>();
            vuelos = Deserializadores.DeserializarVuelosXml();
            btnVolver.Visible = false;
            RellenarGrid();
        }

        private void RellenarGrid()
        {
            dataGVAviones.Rows.Clear();
            aviones = Deserializadores.DeserializarAeronavesJson();
            foreach (Aeronaves item in aviones)
            {
                int rowIndex = dataGVAviones.Rows.Add();
                DataGridViewRow row = dataGVAviones.Rows[rowIndex];
                row.Cells[0].Value = item.Matricula;
                row.Cells[1].Value = item.CantidadAsientos;
                row.Cells[2].Value = item.CantidadBaños;
                row.Cells[3].Value = item.BoolAString(item.Internet);
                row.Cells[4].Value = item.BoolAString(item.Comida);
                row.Cells[5].Value = item.CapacidadBodega + "Kg.";
            }
        }

        private void FiltrarPorMatricula()
        {
            dataGVAviones.Rows.Clear();
            string filtro = txtBMatricula.Text.ToUpper();
            aviones = Deserializadores.DeserializarAeronavesJson();

            for (int i = avionesPorMatricula.Count - 1; i >= 0; i--)
            {
                Aeronaves item = avionesPorMatricula[i];
                avionesPorMatricula.Remove(item);
            }

            foreach (Aeronaves item in aviones)
            {
                string matricula = item.Matricula.ToString();
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
                    int rowIndex = dataGVAviones.Rows.Add();
                    DataGridViewRow row = dataGVAviones.Rows[rowIndex];
                    row.Cells[0].Value = item.Matricula;
                    row.Cells[1].Value = item.CantidadAsientos;
                    row.Cells[2].Value = item.CantidadBaños;
                    row.Cells[3].Value = item.BoolAString(item.Internet);
                    row.Cells[4].Value = item.BoolAString(item.Comida);
                    row.Cells[5].Value = item.CapacidadBodega + "Kg.";
                    avionSeleccionado = item;
                    avionesPorMatricula.Add(item);
                }
            }

            if (dataGVAviones.Rows.Count == 1)
            {
                seleccionado = true;
                Serializadores.SerializarJson("AvionSeleccionado.json", avionSeleccionado);
            }
        }
        private void dataGVAviones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice;
            indice = e.RowIndex;
            btnVolver.Visible = true;
            txtBMatricula.Visible = false;

            if (indice == -1)
            {
                return;
            }

            if (dataGVAviones.Rows.Count == aviones.Count)
            {
                if (indice >= 0 && indice < aviones.Count)
                {
                    avionSeleccionado = aviones[indice];
                    dataGVAviones.Rows.Clear();

                    int rowIndex = dataGVAviones.Rows.Add();
                    DataGridViewRow row = dataGVAviones.Rows[rowIndex];
                    row.Cells[0].Value = avionSeleccionado.Matricula;
                    row.Cells[1].Value = avionSeleccionado.CantidadAsientos;
                    row.Cells[2].Value = avionSeleccionado.CantidadBaños;
                    row.Cells[3].Value = avionSeleccionado.BoolAString(avionSeleccionado.Internet);
                    row.Cells[4].Value = avionSeleccionado.BoolAString(avionSeleccionado.Comida);
                    row.Cells[5].Value = avionSeleccionado.CapacidadBodega + "Kg.";
                    seleccionado = true;
                    Serializadores.SerializarJson("AvionSeleccionado.json", avionSeleccionado);
                }
            }
            else
            {
                if (indice >= 0 && indice < avionesPorMatricula.Count)
                {
                    avionSeleccionado = avionesPorMatricula[indice];
                    dataGVAviones.Rows.Clear();

                    int rowIndex = dataGVAviones.Rows.Add();
                    DataGridViewRow row = dataGVAviones.Rows[rowIndex];
                    row.Cells[0].Value = avionSeleccionado.Matricula;
                    row.Cells[1].Value = avionSeleccionado.CantidadAsientos;
                    row.Cells[2].Value = avionSeleccionado.CantidadBaños;
                    row.Cells[3].Value = avionSeleccionado.BoolAString(avionSeleccionado.Internet);
                    row.Cells[4].Value = avionSeleccionado.BoolAString(avionSeleccionado.Comida);
                    row.Cells[5].Value = avionSeleccionado.CapacidadBodega + "Kg.";
                    seleccionado = true;
                    Serializadores.SerializarJson("AvionSeleccionado.json", avionSeleccionado);
                }
            }
        }

        private void txtBMatricula_TextChanged(object sender, EventArgs e)
        {
            FiltrarPorMatricula();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            btnVolver.Visible = false;
            seleccionado = false;
            txtBMatricula.Visible = true;
            RellenarGrid();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarAeronave frmAgregarAeronave = new FrmAgregarAeronave();
            frmAgregarAeronave.ShowDialog();
            seleccionado = false;
            RellenarGrid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string? matricula = avionSeleccionado?.Matricula;
            bool avionEnUso = false;

            if (!seleccionado)
            {
                MessageBox.Show("Primero debe seleccionar un avion", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (Vuelos vuelo in vuelos)
                {
                    if (vuelo.Avion.Matricula == matricula)
                    {
                        avionEnUso = true;
                        break;
                    }
                }

                if (avionEnUso)
                {
                    MessageBox.Show("El avion que desea eliminar tiene vuelos aderidos. No se puede eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach (Aeronaves item in aviones)
                    {
                        if (item.Matricula == matricula)
                        {
                            DialogResult result = MessageBox.Show("Esta seguro de eliminar el avion?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result == DialogResult.Yes)
                            {
                                aviones.Remove(item);
                                Serializadores.SerializarJson("Aeronaves.json", aviones);
                                btnVolver.Visible = false;
                                seleccionado = false;
                                RellenarGrid();
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (!seleccionado)
            {
                MessageBox.Show("Primero debe seleccionar un avion", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FrmModificarAeronave frmModificarAeronave = new FrmModificarAeronave();
                frmModificarAeronave.ShowDialog();
                RellenarGrid();
                txtBMatricula.Visible = true;
            }
            btnVolver.Visible = false;
            seleccionado = false;
        }
    }
}
