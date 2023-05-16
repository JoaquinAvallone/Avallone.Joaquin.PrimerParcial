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
        Vuelos? vueloSeleccionado;
        List<Pasajeros>? pasajeros;
        Pasajeros? pasajeroSeleccionado;
        List<Pasajeros>? pasajerosPorDni;
        bool seleccionadoP = false;
        bool seleccionadoV = false;
        public FrmVentaViaje()
        {
            InitializeComponent();

        }

        private void FrmVentaViaje_Load(object sender, EventArgs e)
        {
            vuelos = new List<Vuelos>();
            pasajerosPorDni = new List<Pasajeros>();
            vuelos = Deserializadores.DeserializarVuelosXml();
            btnVolver.Visible = false;
            btnCrear.Visible = false;
            btnAsignar.Visible = false;
            dataGVPasajeros.Visible = false;
            txtBDni.Visible = false;
            btnCancelar.Visible = false;
            btnAceptar.Visible = false;
            btnVolverPasajeros.Visible = false;
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
                row.Cells[9].Value = item.Avion.BoolAString(item.Avion.Internet);
                row.Cells[10].Value = item.Avion.BoolAString(item.Avion.Comida);
                row.Cells[11].Value = item.Avion.Matricula;
            }
        }

        private void RellenarGridPasajeros()
        {
            dataGVPasajeros.Rows.Clear();
            pasajeros = Deserializadores.DeserializarPasajerosXml();
            foreach (Pasajeros item in pasajeros)
            {
                int rowIndex = dataGVPasajeros.Rows.Add();
                DataGridViewRow row = dataGVPasajeros.Rows[rowIndex];
                row.Cells[0].Value = item.Apellido;
                row.Cells[1].Value = item.Nombre;
                row.Cells[2].Value = item.Dni;
                row.Cells[3].Value = item.Edad;
                row.Cells[4].Value = item.TipoEquipaje(item.EquipajeMano);
                row.Cells[5].Value = item.TipoEquipaje(item.EquipajeBodega);
                row.Cells[6].Value = item.PesoEquipaje + "kg.";
                row.Cells[7].Value = item.Clase;
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
                    row.Cells[9].Value = item.Avion.BoolAString(item.Avion.Internet);
                    row.Cells[10].Value = item.Avion.BoolAString(item.Avion.Comida);
                    row.Cells[11].Value = item.Avion.Matricula;
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
                    row.Cells[9].Value = item.Avion.BoolAString(item.Avion.Internet);
                    row.Cells[10].Value = item.Avion.BoolAString(item.Avion.Comida);
                    row.Cells[11].Value = item.Avion.Matricula;
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

            if (indice == -1)
            {
                return;
            }

            if (indice >= 0 && indice < vuelos.Count)
            {
                vueloSeleccionado = vuelos[indice];
                float precioTSinIva = (vueloSeleccionado.PrecioTurista * 100) / 121;
                float precioPSinIva = (vueloSeleccionado.PrecioPrem * 100) / 121;
                dataGVVuelos.Rows.Clear();
                btnVolver.Visible = true;
                btnCrear.Visible = true;
                btnAsignar.Visible = true;
                checkBComida.Visible = false;
                checkBInternet.Visible = false;

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
                row.Cells[9].Value = vueloSeleccionado.Avion.BoolAString(vueloSeleccionado.Avion.Internet);
                row.Cells[10].Value = vueloSeleccionado.Avion.BoolAString(vueloSeleccionado.Avion.Comida);
                row.Cells[11].Value = vueloSeleccionado.Avion.Matricula;
                Serializadores.SerializarJson("VueloSeleccionado.json", vueloSeleccionado);
                seleccionadoV = true;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (!seleccionadoV)
            {
                MessageBox.Show("Primero debe seleccionar un vuelo", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                RellenarGrid();
                btnVolver.Visible = false;
                btnCrear.Visible = false;
                btnAsignar.Visible = false;
                checkBComida.Visible = true;
                checkBInternet.Visible = true;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FrmPasajeroAVuelo frmPasajeroAVuelo = new FrmPasajeroAVuelo();
            frmPasajeroAVuelo.ShowDialog();
            RellenarGrid();
            btnVolver.Visible = false;
            btnCrear.Visible = false;
            btnAsignar.Visible = false;
        }
        private void btnAsignar_Click_1(object sender, EventArgs e)
        {
            dataGVVuelos.Visible = false;
            dataGVPasajeros.Visible = true;
            txtBDni.Visible = true;
            btnCrear.Visible = false;
            btnVolver.Visible = false;
            btnAceptar.Visible = true;
            btnAsignar.Visible = false;
            btnVolverPasajeros.Visible = true;
            RellenarGridPasajeros();
        }

        private void dataGVPasajeros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice;
            indice = e.RowIndex;
            btnVolver.Visible = false;
            txtBDni.Visible = false;
            btnCancelar.Visible = true;
            btnVolverPasajeros.Visible = false;
            btnAsignar.Visible = false;
            btnCrear.Visible = false;

            if (indice == -1)
            {
                return;
            }

            if (dataGVPasajeros.Rows.Count == pasajeros.Count)
            {
                if (indice >= 0 && indice < pasajeros.Count)
                {
                    pasajeroSeleccionado = pasajeros[indice];
                    dataGVPasajeros.Rows.Clear();

                    int rowIndex = dataGVPasajeros.Rows.Add();
                    DataGridViewRow row = dataGVPasajeros.Rows[rowIndex];
                    row.Cells[0].Value = pasajeroSeleccionado.Apellido;
                    row.Cells[1].Value = pasajeroSeleccionado.Nombre;
                    row.Cells[2].Value = pasajeroSeleccionado.Dni;
                    row.Cells[3].Value = pasajeroSeleccionado.Edad;
                    row.Cells[4].Value = pasajeroSeleccionado.TipoEquipaje(pasajeroSeleccionado.EquipajeMano);
                    row.Cells[5].Value = pasajeroSeleccionado.TipoEquipaje(pasajeroSeleccionado.EquipajeBodega);
                    row.Cells[6].Value = pasajeroSeleccionado.PesoEquipaje + "kg.";
                    row.Cells[7].Value = pasajeroSeleccionado.Clase;
                    seleccionadoP = true;
                }
            }
            else
            {
                if (indice >= 0 && indice < pasajerosPorDni.Count)
                {
                    pasajeroSeleccionado = pasajerosPorDni[indice];
                    dataGVPasajeros.Rows.Clear();

                    int rowIndex = dataGVPasajeros.Rows.Add();
                    DataGridViewRow row = dataGVPasajeros.Rows[rowIndex];
                    row.Cells[0].Value = pasajeroSeleccionado.Apellido;
                    row.Cells[1].Value = pasajeroSeleccionado.Nombre;
                    row.Cells[2].Value = pasajeroSeleccionado.Dni;
                    row.Cells[3].Value = pasajeroSeleccionado.Edad;
                    row.Cells[4].Value = pasajeroSeleccionado.TipoEquipaje(pasajeroSeleccionado.EquipajeMano);
                    row.Cells[5].Value = pasajeroSeleccionado.TipoEquipaje(pasajeroSeleccionado.EquipajeBodega);
                    row.Cells[6].Value = pasajeroSeleccionado.PesoEquipaje + "kg.";
                    row.Cells[7].Value = pasajeroSeleccionado.Clase;
                    seleccionadoP = true;
                }
            }
        }

        private void FiltrarPorDni()
        {
            dataGVPasajeros.Rows.Clear();
            string filtro = txtBDni.Text;
            pasajeros = Deserializadores.DeserializarPasajerosJson();

            for (int i = pasajerosPorDni.Count - 1; i >= 0; i--)
            {
                Pasajeros item = pasajerosPorDni[i];
                pasajerosPorDni.Remove(item);
            }

            foreach (Pasajeros item in pasajeros)
            {
                string dni = item.Dni.ToString();
                bool empiezaCon = true;

                for (int i = 0; i < filtro.Length; i++)
                {
                    if (dni[i] != filtro[i])
                    {
                        empiezaCon = false;
                        break;
                    }
                }

                if (empiezaCon)
                {
                    int rowIndex = dataGVPasajeros.Rows.Add();
                    DataGridViewRow row = dataGVPasajeros.Rows[rowIndex];
                    row.Cells[0].Value = item.Apellido;
                    row.Cells[1].Value = item.Nombre;
                    row.Cells[2].Value = item.Dni;
                    row.Cells[3].Value = item.Edad;
                    row.Cells[4].Value = item.TipoEquipaje(item.EquipajeMano);
                    row.Cells[5].Value = item.TipoEquipaje(item.EquipajeBodega);
                    row.Cells[6].Value = item.PesoEquipaje + "kg.";
                    row.Cells[7].Value = item.Clase;
                    pasajeroSeleccionado = item;
                    pasajerosPorDni.Add(item);
                }
            }

            if (dataGVPasajeros.Rows.Count == 1)
            {
                seleccionadoP = true;
                Serializadores.SerializarJson("PasajeroSeleccionado.json", pasajeroSeleccionado);
            }
        }

        private void txtBDni_TextChanged(object sender, EventArgs e)
        {
            FiltrarPorDni();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!seleccionadoP)
            {
                MessageBox.Show("Primero debe seleccionar un pasajero", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (pasajeroSeleccionado != vueloSeleccionado)
                {
                    foreach (Vuelos item in vuelos)
                    {
                        if (item.Avion.Matricula == vueloSeleccionado.Avion.Matricula)
                        {
                            if (pasajeroSeleccionado.Clase == "Premium" && item.CantidadAsientosPrem > 0 && item.Avion.CapacidadBodega > pasajeroSeleccionado.PesoEquipaje)
                            {
                                item.Avion.CapacidadBodega = (int)(item.Avion.CapacidadBodega - pasajeroSeleccionado.PesoEquipaje);
                                item.CantidadAsientosPrem--;
                                item.Pasajeros.Add(pasajeroSeleccionado);
                                pasajeroSeleccionado.CantidadVuelos++;
                                item.GananciasPrem += item.PrecioPrem;
                                Serializadores.SerializarXML("Vuelos.xml", vuelos);
                                MessageBox.Show("Pasajero agregado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dataGVVuelos.Visible = true;
                                dataGVPasajeros.Visible = false;
                                txtBDni.Visible = false;
                                btnCrear.Visible = false;
                                btnVolver.Visible = false;
                                btnAceptar.Visible = false;
                                btnCancelar.Visible = false;
                                RellenarGrid();
                                break;
                            }
                            else if (item.CantidadAsientosPrem == 0)
                            {
                                MessageBox.Show("No quedan mas asientos de clase premium en el vuelo seleccionado", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            if (pasajeroSeleccionado.Clase == "Turista" && item.CantidadAsientosTuris > 0 && item.Avion.CapacidadBodega > pasajeroSeleccionado.PesoEquipaje)
                            {
                                item.Avion.CapacidadBodega = (int)(item.Avion.CapacidadBodega - pasajeroSeleccionado.PesoEquipaje);
                                item.CantidadAsientosTuris--;
                                item.Pasajeros.Add(pasajeroSeleccionado);
                                pasajeroSeleccionado.CantidadVuelos++;
                                item.GananciasTuris += item.PrecioTurista;
                                Serializadores.SerializarXML("Vuelos.xml", vuelos);
                                MessageBox.Show("Pasajero agregado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dataGVVuelos.Visible = true;
                                dataGVPasajeros.Visible = false;
                                txtBDni.Visible = false;
                                btnCrear.Visible = false;
                                btnVolver.Visible = false;
                                btnAceptar.Visible = false;
                                btnCancelar.Visible = false;
                                btnVolverPasajeros.Visible = false;
                                RellenarGrid();
                                break;
                            }
                            else if (item.CantidadAsientosTuris == 0)
                            {
                                MessageBox.Show("No quedan mas asientos de clase turista en el vuelo seleccionado", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El pasajero que desea agregar ya esta asignado a este vuelo", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Visible = false;
            btnVolverPasajeros.Visible = true;
            txtBDni.Visible = true;
            RellenarGridPasajeros();
        }

        private void btnVolverPasajeros_Click(object sender, EventArgs e)
        {
            btnVolverPasajeros.Visible = false;
            dataGVVuelos.Visible = true;
            dataGVPasajeros.Visible = false;
            txtBDni.Visible = false;
            btnCrear.Visible = true;
            btnVolver.Visible = true;
            btnAsignar.Visible = true;
            btnAceptar.Visible = false;
            btnCancelar.Visible = false;
        }
    }
}


