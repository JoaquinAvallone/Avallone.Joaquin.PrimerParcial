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
    public partial class FrmModificarVuelo : Form
    {
        List<Aeronaves>? aviones;
        Aeronaves? avionSeleccionado;
        List<Vuelos>? vuelos;
        Vuelos? vueloSeleccionado;
        bool seleccionado = false;
        string destinoInicial;
        string partidaInicial;
        public FrmModificarVuelo()
        {
            InitializeComponent();
        }

        private void FrmModificarVuelo_Load(object sender, EventArgs e)
        {
            aviones = new List<Aeronaves>();
            vuelos = new List<Vuelos>();
            vuelos = Deserializadores.DeserializarVuelosJson();
            vueloSeleccionado = Deserializadores.DeserializarUnVueloJson();
            partidaInicial = vueloSeleccionado.CiudadPartida;
            destinoInicial = vueloSeleccionado.CiudadDestino;
            RellenarGrid();
            VerificarTipoVuelo();
            comboBDestino.Text = vueloSeleccionado.CiudadDestino;
            comboBPartida.Text = vueloSeleccionado.CiudadPartida;
            dateTPFechaVuelo.Value = vueloSeleccionado.FechaVuelo;
            numericUDHora.Value = vueloSeleccionado.FechaVuelo.Hour;
            numericUDMinutos.Value = vueloSeleccionado.FechaVuelo.Minute;
            txtBMatricula.Text = vueloSeleccionado.Avion.Matricula;
            RellenarComboBox();
        }

        private void VerificarTipoVuelo()
        {
            if (vueloSeleccionado.CiudadDestino == "Recife" || vueloSeleccionado.CiudadDestino == "Roma" || vueloSeleccionado.CiudadDestino == "Acapulco" || vueloSeleccionado.CiudadDestino == "Miami")
            {
                checkBInternacional.Checked = true;
            }
            else
            {
                checkBInternacional.Checked = false;
            }
        }
        private void RellenarComboBox()
        {
            comboBPartida.Items.Clear();
            comboBDestino.Items.Clear();
            if (checkBInternacional.Checked)
            {
                foreach (Enumerados.origenInternacional item in Enum.GetValues(typeof(Enumerados.origenInternacional)))
                {
                    comboBPartida.Items.Add(item);
                }
                foreach (Enumerados.DestinoInternacional item in Enum.GetValues(typeof(Enumerados.DestinoInternacional)))
                {
                    comboBDestino.Items.Add(item);
                }
            }
            else
            {
                foreach (Enumerados.Nacional item in Enum.GetValues(typeof(Enumerados.Nacional)))
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


        private void checkBInternacional_CheckedChanged(object sender, EventArgs e)
        {

            comboBPartida.Items.Clear();
            comboBDestino.Items.Clear();
            comboBPartida.Text = string.Empty;
            comboBDestino.Text = string.Empty;

            if (checkBInternacional.Checked)
            {
                foreach (Enumerados.origenInternacional item in Enum.GetValues(typeof(Enumerados.origenInternacional)))
                {
                    comboBPartida.Items.Add(item);
                }
                foreach (Enumerados.DestinoInternacional item in Enum.GetValues(typeof(Enumerados.DestinoInternacional)))
                {
                    comboBDestino.Items.Add(item);
                }
            }
            else
            {
                foreach (Enumerados.Nacional item in Enum.GetValues(typeof(Enumerados.Nacional)))
                {
                    comboBPartida.Items.Add(item);
                    comboBDestino.Items.Add(item);
                }
            }
        }

        private void comboBDestino_TextChanged(object sender, EventArgs e)
        {
            if(!checkBInternacional.Checked)
            {
                foreach(Enumerados.Nacional item in comboBPartida.Items)
                {
                    if(comboBDestino.Text == item.ToString())
                    {
                        comboBPartida.Items.Remove(item);
                    }
                }
            }
        }

        private void dataGVAviones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice;
            indice = e.RowIndex;

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

        private void txtBMatricula_TextChanged(object sender, EventArgs e)
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
            float precioTurista = vueloSeleccionado.PrecioTurista;
            float precioPrem = vueloSeleccionado.PrecioPrem;
            int duracion = vueloSeleccionado.DuracionVuelo;
            bool todoOk = true;
            Aeronaves? avionSelect = null;

            if(destinoInicial != comboBDestino.Text || partidaInicial != comboBPartida.Text)
            {
                if (checkBInternacional.Checked)
                {
                    duracion = Vuelos.GenerarDuracionIntenacional();
                    precioTurista = Vuelos.GenerarPrecioInternacional(false, duracion);
                    precioPrem = Vuelos.GenerarPrecioInternacional(true, duracion); ;
                }
                else
                {
                    duracion = Vuelos.GenerarDuracionNacional();
                    precioTurista = Vuelos.GenerarPrecioNacional(false, duracion);
                    precioPrem = Vuelos.GenerarPrecioNacional(true, duracion);
                }
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
                    if (item.Avion.Matricula == txtBMatricula.Text && item.FechaVuelo != dateTime)
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
                foreach (Vuelos vuelo in vuelos)
                {
                    if (vuelo.Avion.Matricula == vueloSeleccionado.Avion.Matricula && vuelo.FechaVuelo == vueloSeleccionado.FechaVuelo)
                    {
                        vuelo.CiudadPartida = partida;
                        vuelo.CiudadDestino = destino;
                        vuelo.Avion = avionSelect;
                        vuelo.FechaVuelo = dateTime;
                        vuelo.CantidadAsientosPrem = cantidadAsientosPrem;
                        vuelo.CantidadAsientosTuris = cantidadAsientosTuris;
                        vuelo.PrecioPrem = precioPrem;
                        vuelo.PrecioTurista = precioTurista;
                        vuelo.DuracionVuelo = duracion;
                        break;
                    }
                }
                Serializadores.SerializarJson("Vuelos.json", vuelos);
                this.Close();
            }
        }

    }
}
