namespace PrimerParcialLabo
{
    partial class FrmSupervisor
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
            panelTop = new Panel();
            picBMinimize = new PictureBox();
            pictureBSettings = new PictureBox();
            pictureBEscape = new PictureBox();
            picbMini = new PictureBox();
            picBSettings = new PictureBox();
            picBEscape = new PictureBox();
            picBoxLogo = new PictureBox();
            panelSideMenu.SuspendLayout();
            panelSubMenuModif.SuspendLayout();
            panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxUser).BeginInit();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBSettings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBEscape).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picbMini).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBSettings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBEscape).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.BackColor = Color.FromArgb(11, 7, 17);
            panelSideMenu.Controls.Add(btnEstadisticas);
            panelSideMenu.Controls.Add(panelSubMenuModif);
            panelSideMenu.Controls.Add(btnModificaciones);
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
            btnEstadisticas.Location = new Point(0, 133);
            btnEstadisticas.Name = "btnEstadisticas";
            btnEstadisticas.Padding = new Padding(10, 0, 0, 0);
            btnEstadisticas.Size = new Size(200, 27);
            btnEstadisticas.TabIndex = 10;
            btnEstadisticas.Text = "Estadisticas Historicas";
            btnEstadisticas.TextAlign = ContentAlignment.MiddleLeft;
            btnEstadisticas.UseVisualStyleBackColor = true;
            // 
            // panelSubMenuModif
            // 
            panelSubMenuModif.BackColor = Color.FromArgb(35, 32, 39);
            panelSubMenuModif.Controls.Add(btnModPasa);
            panelSubMenuModif.Dock = DockStyle.Top;
            panelSubMenuModif.Location = new Point(0, 103);
            panelSubMenuModif.Name = "panelSubMenuModif";
            panelSubMenuModif.Size = new Size(200, 30);
            panelSubMenuModif.TabIndex = 9;
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
            btnModificaciones.Location = new Point(0, 76);
            btnModificaciones.Name = "btnModificaciones";
            btnModificaciones.Padding = new Padding(10, 0, 0, 0);
            btnModificaciones.Size = new Size(200, 27);
            btnModificaciones.TabIndex = 8;
            btnModificaciones.Text = "Modificaciones";
            btnModificaciones.TextAlign = ContentAlignment.MiddleLeft;
            btnModificaciones.UseVisualStyleBackColor = true;
            btnModificaciones.Click += btnModificaciones_Click;
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
            panelUsuario.TabIndex = 7;
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
            // panelTop
            // 
            panelTop.Controls.Add(picBMinimize);
            panelTop.Controls.Add(pictureBSettings);
            panelTop.Controls.Add(pictureBEscape);
            panelTop.Controls.Add(picbMini);
            panelTop.Controls.Add(picBSettings);
            panelTop.Controls.Add(picBEscape);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(200, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(711, 34);
            panelTop.TabIndex = 5;
            // 
            // picBMinimize
            // 
            picBMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picBMinimize.Image = Properties.Resources.minus_96px1;
            picBMinimize.Location = new Point(652, 7);
            picBMinimize.Name = "picBMinimize";
            picBMinimize.Size = new Size(21, 20);
            picBMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            picBMinimize.TabIndex = 6;
            picBMinimize.TabStop = false;
            picBMinimize.Click += picBMinimize_Click;
            // 
            // pictureBSettings
            // 
            pictureBSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBSettings.Image = Properties.Resources.settings_144px;
            pictureBSettings.Location = new Point(624, 7);
            pictureBSettings.Name = "pictureBSettings";
            pictureBSettings.Size = new Size(21, 20);
            pictureBSettings.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBSettings.TabIndex = 5;
            pictureBSettings.TabStop = false;
            // 
            // pictureBEscape
            // 
            pictureBEscape.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBEscape.Image = Properties.Resources.close_512px2;
            pictureBEscape.Location = new Point(681, 7);
            pictureBEscape.Name = "pictureBEscape";
            pictureBEscape.Size = new Size(21, 20);
            pictureBEscape.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBEscape.TabIndex = 4;
            pictureBEscape.TabStop = false;
            pictureBEscape.Click += pictureBEscape_Click;
            // 
            // picbMini
            // 
            picbMini.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picbMini.Image = Properties.Resources.minus_96px1;
            picbMini.Location = new Point(1163, 7);
            picbMini.Name = "picbMini";
            picbMini.Size = new Size(21, 20);
            picbMini.SizeMode = PictureBoxSizeMode.Zoom;
            picbMini.TabIndex = 3;
            picbMini.TabStop = false;
            // 
            // picBSettings
            // 
            picBSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picBSettings.Image = Properties.Resources.settings_144px;
            picBSettings.Location = new Point(1135, 7);
            picBSettings.Name = "picBSettings";
            picBSettings.Size = new Size(21, 20);
            picBSettings.SizeMode = PictureBoxSizeMode.Zoom;
            picBSettings.TabIndex = 3;
            picBSettings.TabStop = false;
            // 
            // picBEscape
            // 
            picBEscape.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picBEscape.Image = Properties.Resources.close_512px2;
            picBEscape.Location = new Point(1192, 7);
            picBEscape.Name = "picBEscape";
            picBEscape.Size = new Size(21, 20);
            picBEscape.SizeMode = PictureBoxSizeMode.Zoom;
            picBEscape.TabIndex = 2;
            picBEscape.TabStop = false;
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
            picBoxLogo.TabIndex = 6;
            picBoxLogo.TabStop = false;
            // 
            // FrmSupervisor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 32, 39);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(911, 413);
            Controls.Add(picBoxLogo);
            Controls.Add(panelTop);
            Controls.Add(panelSideMenu);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSupervisor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bienvenido";
            Load += FrmSupervisor_Load;
            panelSideMenu.ResumeLayout(false);
            panelSubMenuModif.ResumeLayout(false);
            panelUsuario.ResumeLayout(false);
            panelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxUser).EndInit();
            panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBSettings).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBEscape).EndInit();
            ((System.ComponentModel.ISupportInitialize)picbMini).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBSettings).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBEscape).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Button btnEstadisticas;
        private Panel panelSubMenuModif;
        private Button btnModPasa;
        private Button btnModificaciones;
        private Panel panelUsuario;
        private TextBox txtBPerfil;
        private TextBox txtBNomUsuario;
        private PictureBox picBoxUser;
        private Panel panelTop;
        private PictureBox picbMini;
        private PictureBox picBSettings;
        private PictureBox picBEscape;
        private PictureBox picBMinimize;
        private PictureBox pictureBSettings;
        private PictureBox pictureBEscape;
        private PictureBox picBoxLogo;
    }
}