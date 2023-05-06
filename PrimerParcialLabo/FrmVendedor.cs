using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Biblioteca;
namespace PrimerParcialLabo
{
    public partial class FrmVendedor : Form
    {
        Usuarios? usuarioActual;
        string? pathFotoUsuario;
        public FrmVendedor()
        {
            InitializeComponent();

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            SubMenuVisibility();
            usuarioActual = Deserializadores.DeserializarUsuarioActualJson();
            lblNombreUsuario.Text = usuarioActual.Nombre + " " + usuarioActual.Apellido;
            lblPerfil.Text = usuarioActual.Perfil;
            pathFotoUsuario = Deserializadores.DeserializarFotoJson(usuarioActual);
            if (pathFotoUsuario != null)
            {
                picBoxUser.ImageLocation = pathFotoUsuario;
            }

            ToolTip toolTip = new ToolTip();
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(picBoxUser, "Cambiar Foto");
        }

        private void SubMenuVisibility()
        {
            if (panelSubmenuVenta.Visible == true)
            {
                panelSubmenuVenta.Visible = false;
            }
            if (panelSubMenuModif.Visible == true)
            {
                panelSubMenuModif.Visible = false;
            }
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubmenuVenta);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuModif);
        }

        private void picBEscape_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea abandonar la aplicacion?", "AirlinesApp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void picbMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picBoxUser_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string pathImagen;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pathImagen = ofd.FileName;
                picBoxUser.ImageLocation = pathImagen;
                pathFotoUsuario = pathImagen;
            }
        }

        private void picBMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            picBRestore.Visible = true;
            picBMaximize.Visible = false;
        }

        private void picBRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            picBRestore.Visible = false;
            picBMaximize.Visible = true;
        }

        private void FrmVendedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serializadores.SerializarFotoperfilJson(usuarioActual, pathFotoUsuario);
        }

        private void btnViajesDispon_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmViajesDisponibles>();

        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmVentaViaje>();
        }

        private void btnModPasa_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmCrudPasajero>();
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form? formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault(); // busca en la coleccion el formulario
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();

            }
        }
    }
}
