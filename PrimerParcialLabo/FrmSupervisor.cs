﻿using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcialLabo
{
    public partial class FrmSupervisor : Form
    {
        Usuarios? usuarioActual;
        List<Usuarios>? historialUsuarios;
        DateTime fechaSalida;
        string? pathFotoUsuario;
        Form? formularioAbierto = null;
        public FrmSupervisor()
        {
            InitializeComponent();
        }

        private void FrmSupervisor_Load(object sender, EventArgs e)
        {
            historialUsuarios = new List<Usuarios>();
            historialUsuarios = Deserializadores.DeserializarHistorialUsuarioJson();
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
            if (panelEstadisticas.Visible == true)
            {
                panelEstadisticas.Visible = false;
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
            panelEstadisticas.Visible = false;
        }
        private void btnModPasa_Click(object sender, EventArgs e)
        {
            CerrarFormularioAbierto();
            AbrirFormulario<FrmCrudPasajero>();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            CerrarFormularioAbierto();
            ShowSubMenu(panelEstadisticas);
            panelSubMenuModif.Visible = false;
        }

        private void btnFacturacionDestinos_Click(object sender, EventArgs e)
        {
            CerrarFormularioAbierto();
            AbrirFormulario<FrmFacturacionDestinos>();
        }

        private void btnPasajerosFrecuentes_Click(object sender, EventArgs e)
        {
            CerrarFormularioAbierto();
            AbrirFormulario<FrmPasajerosFrecuentes>();
        }

        private void btnDestinoMasElegido_Click(object sender, EventArgs e)
        {
            CerrarFormularioAbierto();
            AbrirFormulario<FrmDestinoMasElegido>();
        }

        private void btnHorasVuelos_Click(object sender, EventArgs e)
        {
            CerrarFormularioAbierto();
            AbrirFormulario<FrmHorasDeVuelo>();
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

        private void FrmSupervisor_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de abandonar la aplicación?", "Confirmar cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            fechaSalida = DateTime.Now;
            usuarioActual.FechaSalida = fechaSalida;
            historialUsuarios.Add(usuarioActual);
            Serializadores.SerializarJson("usuarios.log", historialUsuarios);
            Serializadores.SerializarFotoperfilJson(usuarioActual, pathFotoUsuario);
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
