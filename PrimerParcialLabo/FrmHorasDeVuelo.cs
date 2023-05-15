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
    public partial class FrmHorasDeVuelo : Form
    {
        List<Aeronaves>? aviones;
        public FrmHorasDeVuelo()
        {
            InitializeComponent();
        }

        private void FrmHorasDeVuelo_Load(object sender, EventArgs e)
        {
            aviones = new List<Aeronaves>();
            RellenarGrid();
        }

        private void RellenarGrid()
        {
            dataGVAviones.Rows.Clear();
            aviones = Aeronaves.DictionaryHorasDeVuelo();
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
                row.Cells[6].Value = item.HorasDeVuelo;
            }
        }
    }
}
