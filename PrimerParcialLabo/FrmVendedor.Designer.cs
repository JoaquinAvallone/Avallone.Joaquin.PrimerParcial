namespace PrimerParcialLabo
{
    partial class FrmVendedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelSideMenu = new Panel();
            btnEstadisticas = new Button();
            panelSubMenuModif = new Panel();
            btnModPasa = new Button();
            btnModificaciones = new Button();
            panelUsuario = new Panel();
            txtBPerfil = new TextBox();
            txtBNomUsuario = new TextBox();
            picBoxUser = new PictureBox();
            picBEscape = new PictureBox();
            picBoxLogo = new PictureBox();
            picBSettings = new PictureBox();
            panelTop = new Panel();
            picbMini = new PictureBox();
            btnVenta = new Button();
            panelSubmenuVenta = new Panel();
            btnViajesDispon = new Button();
            btnVender = new Button();
            panelSideMenu.SuspendLayout();
            panelSubMenuModif.SuspendLayout();
            panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBEscape).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBSettings).BeginInit();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picbMini).BeginInit();
            panelSubmenuVenta.SuspendLayout();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.BackColor = Color.FromArgb(11, 7, 17);
            panelSideMenu.Controls.Add(btnEstadisticas);
            panelSideMenu.Controls.Add(panelSubMenuModif);
            panelSideMenu.Controls.Add(btnModificaciones);
            panelSideMenu.Controls.Add(panelSubmenuVenta);
            panelSideMenu.Controls.Add(btnVenta);
            panelSideMenu.Controls.Add(panelUsuario);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(200, 413);
            panelSideMenu.TabIndex = 0;
            // 
            // btnEstadisticas
            // 
            btnEstadisticas.Dock = DockStyle.Top;
            btnEstadisticas.FlatAppearance.BorderSize = 0;
            btnEstadisticas.FlatAppearance.MouseOverBackColor = Color.FromArgb(18, 18, 18);
            btnEstadisticas.FlatStyle = FlatStyle.Flat;
            btnEstadisticas.ForeColor = Color.Gainsboro;
            btnEstadisticas.Location = new Point(0, 217);
            btnEstadisticas.Name = "btnEstadisticas";
            btnEstadisticas.Padding = new Padding(10, 0, 0, 0);
            btnEstadisticas.Size = new Size(200, 27);
            btnEstadisticas.TabIndex = 4;
            btnEstadisticas.Text = "Estadisticas Historicas";
            btnEstadisticas.TextAlign = ContentAlignment.MiddleLeft;
            btnEstadisticas.UseVisualStyleBackColor = true;
            // 
            // panelSubMenuModif
            // 
            panelSubMenuModif.BackColor = Color.FromArgb(35, 32, 39);
            panelSubMenuModif.Controls.Add(btnModPasa);
            panelSubMenuModif.Dock = DockStyle.Top;
            panelSubMenuModif.Location = new Point(0, 187);
            panelSubMenuModif.Name = "panelSubMenuModif";
            panelSubMenuModif.Size = new Size(200, 30);
            panelSubMenuModif.TabIndex = 3;
            // 
            // btnModPasa
            // 
            btnModPasa.Dock = DockStyle.Top;
            btnModPasa.FlatAppearance.BorderSize = 0;
            btnModPasa.FlatStyle = FlatStyle.Flat;
            btnModPasa.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnModPasa.ForeColor = Color.LightGray;
            btnModPasa.Location = new Point(0, 0);
            btnModPasa.Name = "btnModPasa";
            btnModPasa.Padding = new Padding(30, 0, 0, 0);
            btnModPasa.Size = new Size(200, 27);
            btnModPasa.TabIndex = 2;
            btnModPasa.Text = "Modificar Pasajeros";
            btnModPasa.TextAlign = ContentAlignment.MiddleLeft;
            btnModPasa.UseVisualStyleBackColor = true;
            // 
            // btnModificaciones
            // 
            btnModificaciones.Dock = DockStyle.Top;
            btnModificaciones.FlatAppearance.BorderSize = 0;
            btnModificaciones.FlatAppearance.MouseOverBackColor = Color.FromArgb(18, 18, 18);
            btnModificaciones.FlatStyle = FlatStyle.Flat;
            btnModificaciones.ForeColor = Color.LightGray;
            btnModificaciones.Location = new Point(0, 160);
            btnModificaciones.Name = "btnModificaciones";
            btnModificaciones.Padding = new Padding(10, 0, 0, 0);
            btnModificaciones.Size = new Size(200, 27);
            btnModificaciones.TabIndex = 2;
            btnModificaciones.Text = "Modificaciones";
            btnModificaciones.TextAlign = ContentAlignment.MiddleLeft;
            btnModificaciones.UseVisualStyleBackColor = true;
            btnModificaciones.Click += button1_Click;
            // 
            // panelUsuario
            // 
            panelUsuario.Controls.Add(txtBPerfil);
            panelUsuario.Controls.Add(txtBNomUsuario);
            panelUsuario.Controls.Add(picBoxUser);
            panelUsuario.Dock = DockStyle.Top;
            panelUsuario.Location = new Point(0, 0);
            panelUsuario.Name = "panelUsuario";
            panelUsuario.Size = new Size(200, 76);
            panelUsuario.TabIndex = 1;
            // 
            // txtBPerfil
            // 
            txtBPerfil.BackColor = Color.FromArgb(11, 7, 17);
            txtBPerfil.BorderStyle = BorderStyle.None;
            txtBPerfil.ForeColor = Color.LightGray;
            txtBPerfil.Location = new Point(66, 44);
            txtBPerfil.Name = "txtBPerfil";
            txtBPerfil.Size = new Size(100, 16);
            txtBPerfil.TabIndex = 3;
            txtBPerfil.Text = "Perfil";
            // 
            // txtBNomUsuario
            // 
            txtBNomUsuario.BackColor = Color.FromArgb(11, 7, 17);
            txtBNomUsuario.BorderStyle = BorderStyle.None;
            txtBNomUsuario.ForeColor = Color.LightGray;
            txtBNomUsuario.Location = new Point(66, 22);
            txtBNomUsuario.Name = "txtBNomUsuario";
            txtBNomUsuario.Size = new Size(100, 16);
            txtBNomUsuario.TabIndex = 1;
            txtBNomUsuario.Text = "Nombre Usuario";
            // 
            // picBoxUser
            // 
            picBoxUser.Image = Properties.Resources.contact_500px1;
            picBoxUser.Location = new Point(0, 0);
            picBoxUser.Name = "picBoxUser";
            picBoxUser.Size = new Size(60, 70);
            picBoxUser.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxUser.TabIndex = 1;
            picBoxUser.TabStop = false;
            // 
            // picBEscape
            // 
            picBEscape.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picBEscape.Image = Properties.Resources.close_512px2;
            picBEscape.Location = new Point(681, 7);
            picBEscape.Name = "picBEscape";
            picBEscape.Size = new Size(21, 20);
            picBEscape.SizeMode = PictureBoxSizeMode.Zoom;
            picBEscape.TabIndex = 2;
            picBEscape.TabStop = false;
            picBEscape.Click += picBEscape_Click;
            // 
            // picBoxLogo
            // 
            picBoxLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picBoxLogo.BackgroundImage = Properties.Resources.email_send_96px2;
            picBoxLogo.BackgroundImageLayout = ImageLayout.Center;
            picBoxLogo.Location = new Point(440, 122);
            picBoxLogo.Name = "picBoxLogo";
            picBoxLogo.Size = new Size(209, 177);
            picBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxLogo.TabIndex = 1;
            picBoxLogo.TabStop = false;
            // 
            // picBSettings
            // 
            picBSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picBSettings.Image = Properties.Resources.settings_144px;
            picBSettings.Location = new Point(624, 7);
            picBSettings.Name = "picBSettings";
            picBSettings.Size = new Size(21, 20);
            picBSettings.SizeMode = PictureBoxSizeMode.Zoom;
            picBSettings.TabIndex = 3;
            picBSettings.TabStop = false;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(picbMini);
            panelTop.Controls.Add(picBSettings);
            panelTop.Controls.Add(picBEscape);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(200, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(711, 34);
            panelTop.TabIndex = 4;
            // 
            // picbMini
            // 
            picbMini.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picbMini.Image = Properties.Resources.minus_96px1;
            picbMini.Location = new Point(652, 7);
            picbMini.Name = "picbMini";
            picbMini.Size = new Size(21, 20);
            picbMini.SizeMode = PictureBoxSizeMode.Zoom;
            picbMini.TabIndex = 3;
            picbMini.TabStop = false;
            picbMini.Click += picbMini_Click;
            // 
            // btnVenta
            // 
            btnVenta.Dock = DockStyle.Top;
            btnVenta.FlatAppearance.BorderSize = 0;
            btnVenta.FlatAppearance.MouseOverBackColor = Color.FromArgb(18, 18, 18);
            btnVenta.FlatStyle = FlatStyle.Flat;
            btnVenta.ForeColor = Color.Gainsboro;
            btnVenta.ImageAlign = ContentAlignment.MiddleLeft;
            btnVenta.Location = new Point(0, 76);
            btnVenta.Name = "btnVenta";
            btnVenta.Padding = new Padding(10, 0, 0, 0);
            btnVenta.Size = new Size(200, 27);
            btnVenta.TabIndex = 1;
            btnVenta.Text = "Venta";
            btnVenta.TextAlign = ContentAlignment.MiddleLeft;
            btnVenta.UseVisualStyleBackColor = true;
            btnVenta.Click += btnVenta_Click;
            // 
            // panelSubmenuVenta
            // 
            panelSubmenuVenta.BackColor = Color.FromArgb(35, 32, 39);
            panelSubmenuVenta.Controls.Add(btnVender);
            panelSubmenuVenta.Controls.Add(btnViajesDispon);
            panelSubmenuVenta.Dock = DockStyle.Top;
            panelSubmenuVenta.Location = new Point(0, 103);
            panelSubmenuVenta.Name = "panelSubmenuVenta";
            panelSubmenuVenta.Size = new Size(200, 57);
            panelSubmenuVenta.TabIndex = 1;
            // 
            // btnViajesDispon
            // 
            btnViajesDispon.Dock = DockStyle.Top;
            btnViajesDispon.FlatAppearance.BorderSize = 0;
            btnViajesDispon.FlatStyle = FlatStyle.Flat;
            btnViajesDispon.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnViajesDispon.ForeColor = Color.LightGray;
            btnViajesDispon.Location = new Point(0, 0);
            btnViajesDispon.Name = "btnViajesDispon";
            btnViajesDispon.Padding = new Padding(30, 0, 0, 0);
            btnViajesDispon.Size = new Size(200, 27);
            btnViajesDispon.TabIndex = 2;
            btnViajesDispon.Text = "Viajes Disponibles";
            btnViajesDispon.TextAlign = ContentAlignment.MiddleLeft;
            btnViajesDispon.UseVisualStyleBackColor = true;
            // 
            // btnVender
            // 
            btnVender.Dock = DockStyle.Top;
            btnVender.FlatAppearance.BorderSize = 0;
            btnVender.FlatStyle = FlatStyle.Flat;
            btnVender.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnVender.ForeColor = Color.LightGray;
            btnVender.Location = new Point(0, 27);
            btnVender.Name = "btnVender";
            btnVender.Padding = new Padding(30, 0, 0, 0);
            btnVender.Size = new Size(200, 24);
            btnVender.TabIndex = 3;
            btnVender.Text = "Vender";
            btnVender.TextAlign = ContentAlignment.MiddleLeft;
            btnVender.UseVisualStyleBackColor = true;
            // 
            // FrmVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 32, 39);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(911, 413);
            Controls.Add(panelTop);
            Controls.Add(picBoxLogo);
            Controls.Add(panelSideMenu);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmVendedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bienvenido";
            Load += FrmPrincipal_Load;
            panelSideMenu.ResumeLayout(false);
            panelSubMenuModif.ResumeLayout(false);
            panelUsuario.ResumeLayout(false);
            panelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBEscape).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBSettings).EndInit();
            panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picbMini).EndInit();
            panelSubmenuVenta.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Button btnEstadisticas;
        private Panel panelSubMenuModif;
        private Button btnModPasa;
        private Button btnModificaciones;
        private Panel panelUsuario;
        private TextBox txtBNomUsuario;
        private PictureBox picBEscape;
        private PictureBox picBoxUser;
        private TextBox txtBPerfil;
        private PictureBox picBoxLogo;
        private Panel panelTop;
        private PictureBox picbMini;
        private PictureBox picBSettings;
        private Panel panelSubmenuVenta;
        private Button btnVender;
        private Button btnViajesDispon;
        private Button btnVenta;
    }
}