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

namespace PrimerParcialLabo
{
    public partial class FrmAgregarPasajero : Form
    {
        List<Pasajeros>? pasajeros;
        public FrmAgregarPasajero()
        {
            InitializeComponent();
        }

        private void FrmAgregarPasajero_Load(object sender, EventArgs e)
        {
            pasajeros = new List<Pasajeros>();
            Serializadores.HardCodeoPasajeros(0, 16, pasajeros);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int dniAux;
            if (int.TryParse(txtBDni.Text, out dniAux))
            {
                foreach (Pasajeros item in pasajeros)
                {
                    if (item.Dni == dniAux)
                    {
                        MessageBox.Show("El pasajero que intenta agregar ya existe", "Alert", MessageBoxButtons.OK);
                        break;
                    }
                    else
                    {
                        pasajeros.Add(item);
                        Serializadores.SerializarJson("Pasajeros.json", pasajeros);
                    }
                }
            }
            else
            {
                MessageBox.Show("El dni ingresado es invalido", "Alert", MessageBoxButtons.OK);
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
