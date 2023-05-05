using Biblioteca;
using Microsoft.VisualBasic.ApplicationServices;

namespace PrimerParcialLabo
{
    public partial class FrmLogIn : Form
    {
        protected List<Usuarios> list;
        public FrmLogIn()
        {
            InitializeComponent();
            list = new List<Usuarios>();
            list = Deserializadores.DeserializarUsuariosJson();
        }

        public void FrmLogIn_Load(object sender, EventArgs e)
        {
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