using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrimerParcialLabo
{
    public partial class FrmAgregarVuelo : Form
    {
        List<Aeronaves>? aviones;
        Aeronaves? avionSeleccionado;
        List<Vuelos>? vuelos;
        bool seleccionado = false;
        public FrmAgregarVuelo()
        {
            InitializeComponent();
        }

        private void FrmAgregarVuelo_Load(object sender, EventArgs e)
        {
            aviones = new List<Aeronaves>();
            vuelos = new List<Vuelos>();
            vuelos = Deserializadores.DeserializarVuelosJson();
            RellenarComboBox();
            comboBPartida.Enabled = false;
            RellenarGrid();
            dateTPFechaVuelo.MinDate = DateTime.Now;
        }

        private void RellenarComboBox()
        {
            foreach (Destinos.Nacional item in Enum.GetValues(typeof(Destinos.Nacional)))
            {
                comboBDestino.Items.Add(item);
                comboBPartida.Items.Add(item);
            }
        }

        private void comboBDestino_TextChanged(object sender, EventArgs e)
        {
            comboBPartida.Enabled = true;

            if (!checkBInternacional.Checked)
            {
                foreach (Destinos.Nacional item in comboBPartida.Items)
                {
                    if (comboBDestino.Text == item.ToString())
                    {
                        comboBPartida.Items.Remove(item);
                    }
                }
            }
        }

        private void checkBInternacional_CheckedChanged(object sender, EventArgs e)
        {
            comboBPartida.Items.Clear();
            comboBDestino.Items.Clear();
            comboBPartida.Text = string.Empty;
            comboBDestino.Text = string.Empty;

            if (checkBInternacional.Checked)
            {
                foreach (Destinos.origenInternacional item in Enum.GetValues(typeof(Destinos.origenInternacional)))
                {
                    comboBPartida.Items.Add(item);
                }
                foreach (Destinos.DestinoInternacional item in Enum.GetValues(typeof(Destinos.DestinoInternacional)))
                {
                    comboBDestino.Items.Add(item);
                }
            }
            else
            {
                foreach (Destinos.Nacional item in Enum.GetValues(typeof(Destinos.Nacional)))
                {
                    comboBPartida.Items.Add(item);
                    comboBDestino.Items.Add(item);
                }
            }
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
                }
            }
        }

        private void dataGVAviones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice;
            indice = e.RowIndex;

            if (indice == -1)
            {
                return;
            }

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
                txtBMatricula.Text = avionSeleccionado.Matricula;
            }
        }

        private void txtBMatricula_TextChanged_1(object sender, EventArgs e)
        {
            FiltrarPorMatricula();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string? partida;
            string? destino;
            DateTime dateTime;
            int cantidadAsientosTuris = 0;
            int cantidadAsientosPrem = 0;
            float precioTurista;
            float precioPrem;
            int duracion;
            bool todoOk = true;
            Aeronaves? avionSelect = null;

            if (checkBInternacional.Checked)
            {
                duracion = Vuelos.GenerarDuracionIntenacional();
                precioTurista = Vuelos.GenerarPrecioInternacionalConIva(false, duracion);
                precioPrem = Vuelos.GenerarPrecioInternacionalConIva(true, duracion); ;
            }
            else
            {
                duracion = Vuelos.GenerarDuracionNacional();
                precioTurista = Vuelos.GenerarPrecioNacionalConIva(false, duracion);
                precioPrem = Vuelos.GenerarPrecioNacionalConIva(true, duracion);
            }

            foreach (Aeronaves item in aviones)
            {
                if (item.Matricula == txtBMatricula.Text)
                {
                    cantidadAsientosPrem = Vuelos.GeneradorCantidadAsientos(true, item.CantidadAsientos);
                    cantidadAsientosTuris = Vuelos.GeneradorCantidadAsientos(false, item.CantidadAsientos);
                    avionSelect = item;
                }
            }

            dateTime = dateTPFechaVuelo.Value;
            dateTime = dateTime.Date.AddHours((int)numericUDHora.Value).AddMinutes((int)numericUDMinutos.Value);

            if (txtBMatricula.Text != "")
            {
                foreach (Vuelos item in vuelos)
                {
                    if (item.Avion.Matricula == txtBMatricula.Text)
                    {
                        if (item.FechaVuelo == dateTime)
                        {
                            MessageBox.Show("El avion seleccionado tiene un vuelo en la fecha asignada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            todoOk = false;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar la matricula del avion a asignar el viaje", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                todoOk = false;
            }

            if (dateTime <= DateTime.Now)
            {
                MessageBox.Show("El horario seleccionado es invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                todoOk = false;
            }


            if (comboBDestino.Text == "")
            {
                MessageBox.Show("Debe elegir un destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                todoOk = false;
            }
            if (comboBPartida.Text == "")
            {
                MessageBox.Show("Debe elegir el lugar de partida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                todoOk = false;
            }

            if (todoOk)
            {
                partida = comboBPartida.Text;
                destino = comboBDestino.Text;
                Vuelos newVuelo = new Vuelos(partida, destino, dateTime, avionSelect, cantidadAsientosPrem, cantidadAsientosTuris, precioTurista, precioPrem, duracion);
                vuelos.Add(newVuelo);
                Serializadores.SerializarJson("Vuelos.json", vuelos);
                this.Close();
            }
        }
    }
}
