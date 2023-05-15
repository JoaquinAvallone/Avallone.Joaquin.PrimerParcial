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
            pasajeros = Deserializadores.DeserializarPasajerosJson();

        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string apellido = txtBApellido.Text;
            string nombre = txtBNombre.Text;
            int dni;
            int edad;
            bool equipajeMano = checkBEquipajeMano.Checked;
            bool equipajeBodega = checkBEquipajeBodega.Checked;
            int pesoEquipaje;
            string clase = "";

            bool todoOk = true;

            if (!int.TryParse(txtBDni.Text, out dni) || dni < 10000000)
            {
                MessageBox.Show("El DNI ingresado no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                todoOk = false;
            }

            if (!int.TryParse(txtBEdad.Text, out edad) || edad > 100)
            {
                MessageBox.Show("La edad ingresada no es válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                todoOk = false;
            }

            if (radioBTurista.Checked)
            {
                clase = "Turista";
            }
            else if (radioBPremium.Checked)
            {
                clase = "Premium";
            }
            else
            {
                MessageBox.Show("Debe elegir una clase", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                todoOk = false;
            }

            if (!int.TryParse(txtBPesoEquipaje.Text, out pesoEquipaje))
            {
                MessageBox.Show("El peso del equipaje es incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                todoOk = false;
            }
            else if (clase == "Turista" && pesoEquipaje > 25)
            {
                MessageBox.Show("El peso del equipaje es mayor al permitido para su clase", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                todoOk = false;
            }
            else if (clase == "Premium" && pesoEquipaje > 42)
            {
                MessageBox.Show("El peso del equipaje es mayor al permitido para su clase", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                todoOk = false;
            }

            if (todoOk)
            {
                Pasajeros newPasajero = new Pasajeros(apellido, nombre, dni, edad, equipajeMano, equipajeBodega, pesoEquipaje, clase);
                foreach (Pasajeros item in pasajeros)
                {
                    if (item.Dni == newPasajero.Dni)
                    {
                        MessageBox.Show("El pasajero que intenta agregar ya existe", "Alert", MessageBoxButtons.OK);
                        return;
                    }
                }
                pasajeros.Add(newPasajero);
                Serializadores.SerializarJson("Pasajeros.json", pasajeros);
                this.Close();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Solo se acepta el ingreso de letras.");
                e.Handled = true; 
            }
        }

        private void txtBNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Solo se acepta el ingreso de letras.");
                e.Handled = true;
            }
        }
    }
}
