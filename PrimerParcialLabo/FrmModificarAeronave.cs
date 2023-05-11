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
    public partial class FrmModificarAeronave : Form
    {
        List<Aeronaves>? aeronaves;
        List<Vuelos>? vuelos;
        Aeronaves? avionSeleccionado;
        public FrmModificarAeronave()
        {
            InitializeComponent();
        }

        private void FrmModificarAeronave_Load(object sender, EventArgs e)
        {
            aeronaves = new List<Aeronaves>();
            aeronaves = Deserializadores.DeserializarAeronavesJson();
            vuelos = new List<Vuelos>();
            vuelos = Deserializadores.DeserializarVuelosJson();
            avionSeleccionado = Deserializadores.DeserializarUnaAeronavesJson();

            txtBMatricula.Text = avionSeleccionado.Matricula;
            numericUDAsientos.Value = avionSeleccionado.CantidadAsientos;
            numericUDBaños.Value = avionSeleccionado.CantidadBaños;
            numericUDBodega.Value = avionSeleccionado.CapacidadBodega;
            if (avionSeleccionado.Comida == true)
            {
                checkBComida.Checked = true;
            }
            if (avionSeleccionado.Internet == true)
            {
                checkBInternet.Checked = true;
            }
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
            bool todoOk = true;


            if (checkBInternet.Checked)
            {
                internet = true;
            }

            if (checkBComida.Checked)
            {
                comida = true;
            }

            foreach (Vuelos item in vuelos)
            {
                if (item.Avion.Matricula == avionSeleccionado.Matricula)
                {
                    MessageBox.Show("No se pueden modificar aviones con vuelos asignados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    todoOk = false;
                }
            }

            if (todoOk)
            {
                foreach (Vuelos item in vuelos)
                {
                    if (item.Avion.Matricula == avionSeleccionado.Matricula)
                    {
                        item.Avion.Matricula = matricula;
                        item.Avion.CantidadAsientos = cantidadAsientos;
                        item.Avion.CantidadBaños = cantidadBaños;
                        item.Avion.CapacidadBodega = capacidadBodega;
                        item.Avion.Internet = internet;
                        item.Avion.Comida = comida;
                    }
                }
                foreach (Aeronaves item in aeronaves)
                {
                    if (item.Matricula == avionSeleccionado.Matricula)
                    {
                        item.Matricula = matricula;
                        item.CantidadAsientos = cantidadAsientos;
                        item.CantidadBaños = cantidadBaños;
                        item.CapacidadBodega = capacidadBodega;
                        item.Internet = internet;
                        item.Comida = comida;
                    }
                }
                Serializadores.SerializarJson("Aeronaves.json", aeronaves);
                Serializadores.SerializarJson("Vuelos.json", vuelos);
                this.Close();
            }
            this.Close();
        }

    }
}
