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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PrimerParcialLabo
{
    public partial class FrmAgregarAeronave : Form
    {
        List<Aeronaves>? aeronaves;
        public FrmAgregarAeronave()
        {
            InitializeComponent();
        }

        private void FrmAgregarAeronave_Load(object sender, EventArgs e)
        {
            aeronaves = new List<Aeronaves>();
            aeronaves = Deserializadores.DeserializarAeronavesJson();
            ToolTip toolTip = new ToolTip();
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(picBGenerar, "Generar Matricula");
        }

        private void picBGenerar_Click(object sender, EventArgs e)
        {
            string auxMatricula = Aeronaves.GenerateMatricula();
            foreach (Aeronaves item in aeronaves)
            {
                while (item.Matricula == auxMatricula)
                {
                    auxMatricula = Aeronaves.GenerateMatricula();
                }
            }
            txtBMatricula.Text = auxMatricula;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string matricula = txtBMatricula.Text;
            int cantidadAsientos = (int)numericUDAsientos.Value;
            int cantidadBaños = (int)numericUDBaños.Value;
            bool internet = false;
            bool comida = false;
            int capacidadBodega = (int)numericUDBodega.Value;


            if (checkBInternet.Checked)
            {
                internet = true;
            }

            if (checkBComida.Checked)
            {
                comida = true;
            }

            Aeronaves newAeronave = new Aeronaves(matricula, cantidadAsientos, cantidadBaños, internet, comida, capacidadBodega);
            foreach (Aeronaves item in aeronaves)
            {
                if (item.Matricula == newAeronave.Matricula)
                {
                    MessageBox.Show("El avion que intenta agregar ya existe", "Alert", MessageBoxButtons.OK);
                    return;
                }
            }
            aeronaves.Add(newAeronave);
            Serializadores.SerializarJson("Aeronaves.json", aeronaves);
            this.Close();

        }
    }
}
