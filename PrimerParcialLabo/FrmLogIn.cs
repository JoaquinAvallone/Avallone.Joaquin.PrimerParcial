using Biblioteca;
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

            foreach (Usuarios item in list)
            {
                if (item.clave == txtBContraseña.Text && item.correo == txtBMail.Text)
                {
                    if(item.perfil == "vendedor")
                    {
                        frmVendedor.ShowDialog();
                        Application.Exit();
                    }
                    else if(item.perfil == "supervisor")
                    {
                        frmSupervisor.ShowDialog();
                        Application.Exit();
                    }
                    else if (item.perfil =="administrador")
                    {
                        frmAdmin.ShowDialog();
                        Application.Exit();
                    }
                }
            }
        }

        private void txtBContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtBContraseña.Text == "Contraseña")
            {
                txtBContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                txtBContraseña.UseSystemPasswordChar = true;
            }
        }

        private void pictureBEscape_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}