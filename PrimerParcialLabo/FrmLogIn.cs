using Biblioteca;
using Microsoft.VisualBasic.ApplicationServices;

namespace PrimerParcialLabo
{
    public partial class FrmLogIn : Form
    {
        List<Usuarios>? list;
        List<Aeronaves>? listA;
        List<Pasajeros>? listP;
        List<Vuelos>? listV;

        public FrmLogIn()
        {
            InitializeComponent();

        }

        public void FrmLogIn_Load(object sender, EventArgs e)
        {
            list = new List<Usuarios>();
            list = Deserializadores.DeserializarUsuariosJson();
            
            listA = new List<Aeronaves>();
            listP = new List<Pasajeros>();
            listV = new List<Vuelos>();
            if(!File.Exists("Aeronaves.json"))
            {
                listA = HardCodeo.HardCodeoAeronaves();
                Serializadores.SerializarJson("Aeronaves.json", listA);
            }
            if(!File.Exists("Vuelos.json"))
            {
                listV = HardCodeo.HardCodeoVuelos();
                Serializadores.SerializarJson("Vuelos.json", listV);
            }
            if(!File.Exists("Pasajeros.json"))
            {
                listP = HardCodeo.HardCodeoPasajeros();
                Serializadores.SerializarJson("Pasajeros.json", listP);
            }           
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            FrmVendedor frmVendedor = new FrmVendedor();
            FrmSupervisor frmSupervisor = new FrmSupervisor();
            FrmAdmin frmAdmin = new FrmAdmin();
            bool flagIngreso = false;

            foreach (Usuarios item in list)
            {
                if (item.Clave == txtBContraseña.Text && item.Correo == txtBMail.Text)
                {
                    Serializadores.SerializarJson("UsuarioActual.json", item);
                    if (item.Perfil == "vendedor")
                    {
                        this.Hide();
                        frmVendedor.ShowDialog();
                        this.Close();
                        flagIngreso = true;
                    }
                    else if (item.Perfil == "supervisor")
                    {
                        this.Hide();
                        frmSupervisor.ShowDialog();
                        this.Close();
                        flagIngreso = true;
                    }
                    else if (item.Perfil == "administrador")
                    {
                        this.Hide();
                        frmAdmin.ShowDialog();
                        this.Close();
                        flagIngreso = true;
                    }
                }
            }
            if (!flagIngreso)
            {
                MessageBox.Show("Email o contraseña incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBEscape_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea abandonar la aplicacion?", "AirlinesLogIn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            };
        }

        private void pictureBMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtBContraseña_TextChanged(object sender, EventArgs e)
        {
            if (Text != null)
            {
                picBEye.Visible = true;
            }
        }

        private void picBEye_Click(object sender, EventArgs e)
        {
            txtBContraseña.UseSystemPasswordChar = false;
            picBEye.Visible = false;
            picBEyeBlind.Visible = true;
        }

        private void picBEyeBlind_Click(object sender, EventArgs e)
        {
            txtBContraseña.UseSystemPasswordChar = true;
            picBEye.Visible = true;
            picBEyeBlind.Visible = false;
        }
    }
}