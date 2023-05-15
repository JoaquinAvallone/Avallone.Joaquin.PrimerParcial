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
    public partial class FrmDestinoMasElegido : Form
    {
        Destinos destinoMasElegido;
        public FrmDestinoMasElegido()
        {
            InitializeComponent();
        }

        private void FrmDestinoMasElegido_Load(object sender, EventArgs e)
        {
            RellenarGridFactiracionDestinos();
        }

        public void RellenarGridFactiracionDestinos()
        {
            dataGVFacturacionDestinos.Rows.Clear();
            destinoMasElegido = Destinos.DestinoMasElegido();

            int rowIndex = dataGVFacturacionDestinos.Rows.Add();
            DataGridViewRow row = dataGVFacturacionDestinos.Rows[rowIndex];
            row.Cells[0].Value = destinoMasElegido.Destino;
            row.Cells[1].Value = destinoMasElegido.Recaudacion;
            row.Cells[2].Value = destinoMasElegido.VecesElegido;

        }
    }
}
