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
    public partial class FrmAdmin : Form
    {
        Usuarios? usuarioActual;
        string? pathFotoUsuario;
        Form? formularioAbierto = null;
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            SubMenuVisibility();
            usuarioActual = Deserializadores.DeserializarUsuarioActualJson();
            lblNombreUsuario.Text = usuarioActual.Nombre + " " + usuarioActual.Apellido;
            lblPerfil.Text = usuarioActual.Perfil;
            DateTime fechaActual = DateTime.Today;
            lblFecha.Text = "Fecha: " + fechaActual.ToString("dd/MM/yyyy");
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

        private void btnModificaciones_Click(object sender, EventArgs e)
        {
            CerrarFormularioAbierto();
            ShowSubMenu(panelSubMenuModif);
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

        private void FrmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serializadores.SerializarFotoperfilJson(usuarioActual, pathFotoUsuario);
            DialogResult result = MessageBox.Show("¿Está seguro de abandonar la aplicación?", "Confirmar cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnModifAeronaves_Click(object sender, EventArgs e)
        {
            CerrarFormularioAbierto();
            AbrirFormulario<FrmCrudAeronaves>();
        }

        private void btnModifViajes_Click(object sender, EventArgs e)
        {
            CerrarFormularioAbierto();
            AbrirFormulario<FrmCrudVuelos>();
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

                formularioAbierto = formulario;
            }
            else
            {
                formulario.BringToFront();
                formularioAbierto = formulario;
            }
        }

        private void CerrarFormularioAbierto()
        {
            if (formularioAbierto != null)
            {
                formularioAbierto.Close();
                formularioAbierto = null;
            }
        }
    }
}
