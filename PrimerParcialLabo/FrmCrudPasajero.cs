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
using Biblioteca;

namespace PrimerParcialLabo
{
    public partial class FrmCrudPasajero : Form
    {
        List<Pasajeros>? pasajeros;
        Pasajeros? pasajeroSeleccionado;
        public FrmCrudPasajero()
        {
            InitializeComponent();
        }

        private void FrmCrudPasajero_Load(object sender, EventArgs e)
        {
            pasajeros = new List<Pasajeros>();
            Serializadores.HardCodeoPasajeros(0, 16, pasajeros);
            btnVolver.Visible = false;

            RellenarGrid();
        }

        private void RellenarGrid()
        {
            dataGVPasajeros.Rows.Clear();
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

        private void dataGVPasajeros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice;
            indice = e.RowIndex;
            btnVolver.Visible = true;

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
            }
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? dni = pasajeroSeleccionado?.Dni;

            DialogResult result = MessageBox.Show("Esta seguro de eliminar el pasajero?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                foreach (Pasajeros item in pasajeros)
                {
                    if (item.Dni == dni)
                    {
                        pasajeros.Remove(item);
                        Serializadores.SerializarJson("Pasajeros.json", pasajeros);
                        btnVolver.Visible = false;
                        RellenarGrid();
                        break;
                    }
                }
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarPasajero frmAgregarPasajero = new FrmAgregarPasajero();
            frmAgregarPasajero.ShowDialog();

            
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            btnVolver.Visible = false;
            RellenarGrid();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
