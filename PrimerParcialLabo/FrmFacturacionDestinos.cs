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
    public partial class FrmFacturacionDestinos : Form
    {
        List<Destinos>? destinos;
        public FrmFacturacionDestinos()
        {
            InitializeComponent();
        }

        private void FrmFacturacionDestinos_Load(object sender, EventArgs e)
        {
            destinos = new List<Destinos>();
            float recaudacionInter = Vuelos.RecaudacionInternacional();
            float recaudacionNacional = Vuelos.RecaudacionNacional();
            lblGananciaInter.Text = "GANANCIA TOTAL INTERNACIONAL: $" + recaudacionInter.ToString("0.00");
            lblGananciaNacional.Text = "GANANCIA TOTAL NACIONAL: $" + recaudacionNacional.ToString("0.00");
            RellenarGridFactiracionDestinos();
        }

        public void RellenarGridFactiracionDestinos()
        {
            dataGVFacturacionDestinos.Rows.Clear();
            destinos = Vuelos.DestinosOrdenadosPorRecaudacion();

            foreach (Destinos item in destinos)
            {
                int rowIndex = dataGVFacturacionDestinos.Rows.Add();
                DataGridViewRow row = dataGVFacturacionDestinos.Rows[rowIndex];
                row.Cells[0].Value = item.Destino;
                row.Cells[1].Value = "$" + item.Recaudacion;
            }
        }
    }
}
