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
        List<Vuelos>? vuelosPorMatricula;
        Vuelos? vueloSeleccionado;
        bool seleccionado = false;
        public FrmCrudVuelos()
        {
            InitializeComponent();
        }

        private void FrmCrudVuelos_Load(object sender, EventArgs e)
        {
            vuelos = new List<Vuelos>();
            vuelosPorMatricula = new List<Vuelos>();
            btnVolver.Visible = false;
            RellenarGrid();
        }

        private void RellenarGrid()
        {
            dataGVVuelos.Rows.Clear();
            vuelos = Deserializadores.DeserializarVuelosXml();
            foreach (Vuelos item in vuelos)
            {
                float precioTSinIva = (item.PrecioTurista * 100) / 121;
                float precioPSinIva = (item.PrecioPrem * 100) / 121;

                int rowIndex = dataGVVuelos.Rows.Add();
                DataGridViewRow row = dataGVVuelos.Rows[rowIndex];
                row.Cells[0].Value = item.FechaVuelo;
                row.Cells[1].Value = item.CiudadPartida;
                row.Cells[2].Value = item.CiudadDestino;
                row.Cells[3].Value = "$" + item.PrecioTurista;
                row.Cells[4].Value = "$" + item.PrecioPrem;
                row.Cells[5].Value = "$" + precioTSinIva.ToString("0.00");
                row.Cells[6].Value = "$" + precioPSinIva.ToString("0.00");
                row.Cells[7].Value = item.CantidadAsientosTuris;
                row.Cells[8].Value = item.CantidadAsientosPrem;
                row.Cells[9].Value = item.DuracionVuelo;
                row.Cells[10].Value = item.Avion.Matricula;
            }
        }
        private void dataGVVuelos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int indice;
            indice = e.RowIndex;
            btnVolver.Visible = true;
            txtBMatricula.Visible = false;

            if (indice == -1)
            {
                return;
            }

            if (dataGVVuelos.Rows.Count == vuelos.Count)
            {
                if (indice >= 0 && indice < vuelos.Count)
                {
                    vueloSeleccionado = vuelos[indice];
                    dataGVVuelos.Rows.Clear();
                    float precioTSinIva = (vueloSeleccionado.PrecioTurista * 100) / 121;
                    float precioPSinIva = (vueloSeleccionado.PrecioPrem * 100) / 121;

                    int rowIndex = dataGVVuelos.Rows.Add();
                    DataGridViewRow row = dataGVVuelos.Rows[rowIndex];
                    row.Cells[0].Value = vueloSeleccionado.FechaVuelo;
                    row.Cells[1].Value = vueloSeleccionado.CiudadPartida;
                    row.Cells[2].Value = vueloSeleccionado.CiudadDestino;
                    row.Cells[3].Value = "$" + vueloSeleccionado.PrecioTurista;
                    row.Cells[4].Value = "$" + vueloSeleccionado.PrecioPrem;
                    row.Cells[5].Value = "$" + precioTSinIva.ToString("0.00");
                    row.Cells[6].Value = "$" + precioPSinIva.ToString("0.00");
                    row.Cells[7].Value = vueloSeleccionado.CantidadAsientosTuris;
                    row.Cells[8].Value = vueloSeleccionado.CantidadAsientosPrem;
                    row.Cells[9].Value = vueloSeleccionado.DuracionVuelo;
                    row.Cells[10].Value = vueloSeleccionado.Avion.Matricula;
                    seleccionado = true;
                    Serializadores.SerializarJson("VueloSeleccionado.json", vueloSeleccionado);
                }
            }
            else
            {
                if (indice >= 0 && indice < vuelosPorMatricula.Count)
                {
                    vueloSeleccionado = vuelosPorMatricula[indice];
                    dataGVVuelos.Rows.Clear();
                    float precioTSinIva = (vueloSeleccionado.PrecioTurista * 100) / 121;
                    float precioPSinIva = (vueloSeleccionado.PrecioPrem * 100) / 121;

                    int rowIndex = dataGVVuelos.Rows.Add();
                    DataGridViewRow row = dataGVVuelos.Rows[rowIndex];
                    row.Cells[0].Value = vueloSeleccionado.FechaVuelo;
                    row.Cells[1].Value = vueloSeleccionado.CiudadPartida;
                    row.Cells[2].Value = vueloSeleccionado.CiudadDestino;
                    row.Cells[3].Value = "$" + vueloSeleccionado.PrecioTurista;
                    row.Cells[4].Value = "$" + vueloSeleccionado.PrecioPrem;
                    row.Cells[5].Value = "$" + precioTSinIva.ToString("0.00");
                    row.Cells[6].Value = "$" + precioPSinIva.ToString("0.00");
                    row.Cells[7].Value = vueloSeleccionado.CantidadAsientosTuris;
                    row.Cells[8].Value = vueloSeleccionado.CantidadAsientosPrem;
                    row.Cells[9].Value = vueloSeleccionado.DuracionVuelo;
                    row.Cells[10].Value = vueloSeleccionado.Avion.Matricula;
                    seleccionado = true;
                    Serializadores.SerializarJson("VueloSeleccionado.json", vueloSeleccionado);
                }
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
            vuelos = Deserializadores.DeserializarVuelosXml();

            for (int i = vuelosPorMatricula.Count - 1; i >= 0; i--)
            {
                Vuelos item = vuelosPorMatricula[i];
                vuelosPorMatricula.Remove(item);
            }

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
                    float precioTSinIva = (item.PrecioTurista * 100) / 121;
                    float precioPSinIva = (item.PrecioPrem * 100) / 121;

                    int rowIndex = dataGVVuelos.Rows.Add();
                    DataGridViewRow row = dataGVVuelos.Rows[rowIndex];
                    row.Cells[0].Value = item.FechaVuelo;
                    row.Cells[1].Value = item.CiudadPartida;
                    row.Cells[2].Value = item.CiudadDestino;
                    row.Cells[3].Value = "$" + item.PrecioTurista;
                    row.Cells[4].Value = "$" + item.PrecioPrem;
                    row.Cells[5].Value = "$" + precioTSinIva.ToString("0.00");
                    row.Cells[6].Value = "$" + precioPSinIva.ToString("0.00");
                    row.Cells[7].Value = item.CantidadAsientosTuris;
                    row.Cells[8].Value = item.CantidadAsientosPrem;
                    row.Cells[9].Value = item.DuracionVuelo;
                    row.Cells[10].Value = item.Avion.Matricula;
                    vueloSeleccionado = item;
                    vuelosPorMatricula.Add(item);
                }
            }

            if (dataGVVuelos.Rows.Count == 1)
            {
                seleccionado = true;
                Serializadores.SerializarJson("VueloSeleccionado.json", vueloSeleccionado);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarVuelo frmAgregarVuelo = new FrmAgregarVuelo();
            frmAgregarVuelo.ShowDialog();
            RellenarGrid();
        }

        private void txtBMatricula_TextChanged(object sender, EventArgs e)
        {
            FiltrarPorMatricula();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string matricula = vueloSeleccionado.Avion.Matricula;
            bool vueloRealizado = true;

            if (!seleccionado)
            {
                MessageBox.Show("Primero debe seleccionar un vuelo", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (Vuelos vuelo in vuelos)
                {
                    if (vuelo.FechaVuelo > DateTime.Today)
                    {
                        vueloRealizado = false;
                        break;
                    }
                }
                if (vueloRealizado)
                {
                    MessageBox.Show("No se puede eliminar un vuelo realizado.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach (Vuelos vuelo in vuelos)
                    {
                        if (vuelo.Avion.Matricula == matricula && vuelo.FechaVuelo == vueloSeleccionado.FechaVuelo)
                        {
                            DialogResult result = MessageBox.Show("Esta seguro de eliminar el vuelo?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result == DialogResult.Yes)
                            {
                                vuelos.Remove(vuelo);
                                Serializadores.SerializarXML("Vuelos.xml", vuelos);
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
            FrmModificarVuelo frmModificarVuelo = new FrmModificarVuelo();
            bool vueloRealizado = true;

            if (!seleccionado)
            {
                MessageBox.Show("Primero debe seleccionar un vuelo", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (Vuelos vuelo in vuelos)
                {
                    if (vuelo.FechaVuelo > DateTime.Today)
                    {
                        vueloRealizado = false;
                        break;
                    }
                }
                if (vueloRealizado)
                {
                    MessageBox.Show("No se puede modificar un vuelo realizado.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    frmModificarVuelo.ShowDialog();
                    RellenarGrid();
                    txtBMatricula.Visible = true;
                }
            }
            btnVolver.Visible = false;
            seleccionado = false;
        }

       
    }
}
