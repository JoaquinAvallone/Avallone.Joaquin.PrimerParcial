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
    public partial class FrmPasajerosFrecuentes : Form
    {
        List<Pasajeros>? pasajerosFrecuentes;
        public FrmPasajerosFrecuentes()
        {
            InitializeComponent();
        }

        private void FrmPasajerosFrecuentes_Load(object sender, EventArgs e)
        {
            pasajerosFrecuentes = new List<Pasajeros>();
            RellenarGridPasajerosFrecuentes();
        }

        public void RellenarGridPasajerosFrecuentes()
        {
            dataGVPasajeros.Rows.Clear();
            pasajerosFrecuentes = Pasajeros.PasajerosFrecuentes();

            foreach (Pasajeros item in pasajerosFrecuentes)
            {
                int rowIndex = dataGVPasajeros.Rows.Add();
                DataGridViewRow row = dataGVPasajeros.Rows[rowIndex];
                row.Cells[0].Value = item.Apellido;
                row.Cells[1].Value = item.Nombre;
                row.Cells[2].Value = item.Dni;
                row.Cells[3].Value = item.Edad;
                row.Cells[4].Value = item.CantidadVuelos;
            }
        }
    }
}
