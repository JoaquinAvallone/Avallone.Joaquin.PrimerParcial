namespace PrimerParcialLabo
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            panelSideMenu = new Panel();
            lblFecha = new Label();
            panelSubMenuModif = new Panel();
            btnModifAeronaves = new Button();
            btnModifViajes = new Button();
            btnModificaciones = new Button();
            panelUsuario = new Panel();
            lblPerfil = new Label();
            lblNombreUsuario = new Label();
            picBoxUser = new PictureBox();
            panelFormularios = new Panel();
            picBoxLogo = new PictureBox();
            panelSideMenu.SuspendLayout();
            panelSubMenuModif.SuspendLayout();
            panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxUser).BeginInit();
            panelFormularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.BackColor = Color.FromArgb(11, 7, 17);
            panelSideMenu.Controls.Add(lblFecha);
            panelSideMenu.Controls.Add(panelSubMenuModif);
            panelSideMenu.Controls.Add(btnModificaciones);
            panelSideMenu.Controls.Add(panelUsuario);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(200, 409);
            panelSideMenu.TabIndex = 1;
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblFecha.AutoSize = true;
            lblFecha.ForeColor = Color.Gainsboro;
            lblFecha.Location = new Point(5, 389);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(0, 15);
            lblFecha.TabIndex = 13;
            // 
            // panelSubMenuModif
            // 
            panelSubMenuModif.BackColor = Color.FromArgb(35, 32, 39);
            panelSubMenuModif.Controls.Add(btnModifAeronaves);
            panelSubMenuModif.Controls.Add(btnModifViajes);
            panelSubMenuModif.Cursor = Cursors.Hand;
            panelSubMenuModif.Dock = DockStyle.Top;
            panelSubMenuModif.Location = new Point(0, 103);
            panelSubMenuModif.Name = "panelSubMenuModif";
            panelSubMenuModif.Size = new Size(200, 66);
            panelSubMenuModif.TabIndex = 3;
            // 
            // btnModifAeronaves
            // 
            btnModifAeronaves.Dock = DockStyle.Top;
            btnModifAeronaves.FlatAppearance.BorderSize = 0;
            btnModifAeronaves.FlatStyle = FlatStyle.Flat;
            btnModifAeronaves.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnModifAeronaves.ForeColor = Color.LightGray;
            btnModifAeronaves.Location = new Point(0, 31);
            btnModifAeronaves.Name = "btnModifAeronaves";
            btnModifAeronaves.Padding = new Padding(30, 0, 0, 0);
            btnModifAeronaves.Size = new Size(200, 31);
            btnModifAeronaves.TabIndex = 3;
            btnModifAeronaves.Text = "Modificar Aeronaves";
            btnModifAeronaves.TextAlign = ContentAlignment.MiddleLeft;
            btnModifAeronaves.UseVisualStyleBackColor = true;
            btnModifAeronaves.Click += btnModifAeronaves_Click;
            // 
            // btnModifViajes
            // 
            btnModifViajes.Dock = DockStyle.Top;
            btnModifViajes.FlatAppearance.BorderSize = 0;
            btnModifViajes.FlatStyle = FlatStyle.Flat;
            btnModifViajes.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnModifViajes.ForeColor = Color.LightGray;
            btnModifViajes.Location = new Point(0, 0);
            btnModifViajes.Name = "btnModifViajes";
            btnModifViajes.Padding = new Padding(30, 0, 0, 0);
            btnModifViajes.Size = new Size(200, 31);
            btnModifViajes.TabIndex = 2;
            btnModifViajes.Text = "Modificar Viajes";
            btnModifViajes.TextAlign = ContentAlignment.MiddleLeft;
            btnModifViajes.UseVisualStyleBackColor = true;
            btnModifViajes.Click += btnModifViajes_Click;
            // 
            // btnModificaciones
            // 
            btnModificaciones.Cursor = Cursors.Hand;
            btnModificaciones.Dock = DockStyle.Top;
            btnModificaciones.FlatAppearance.BorderSize = 0;
            btnModificaciones.FlatAppearance.MouseOverBackColor = Color.FromArgb(18, 18, 18);
            btnModificaciones.FlatStyle = FlatStyle.Flat;
            btnModificaciones.ForeColor = Color.LightGray;
            btnModificaciones.Location = new Point(0, 76);
            btnModificaciones.Name = "btnModificaciones";
            btnModificaciones.Padding = new Padding(10, 0, 0, 0);
            btnModificaciones.Size = new Size(200, 27);
            btnModificaciones.TabIndex = 2;
            btnModificaciones.Text = "Modificaciones";
            btnModificaciones.TextAlign = ContentAlignment.MiddleLeft;
            btnModificaciones.UseVisualStyleBackColor = true;
            btnModificaciones.Click += btnModificaciones_Click;
            // 
            // panelUsuario
            // 
            panelUsuario.Controls.Add(lblPerfil);
            panelUsuario.Controls.Add(lblNombreUsuario);
            panelUsuario.Controls.Add(picBoxUser);
            panelUsuario.Dock = DockStyle.Top;
            panelUsuario.Location = new Point(0, 0);
            panelUsuario.Name = "panelUsuario";
            panelUsuario.Size = new Size(200, 76);
            panelUsuario.TabIndex = 1;
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPerfil.ForeColor = Color.LightGray;
            lblPerfil.Location = new Point(66, 41);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(36, 16);
            lblPerfil.TabIndex = 5;
            lblPerfil.Text = "Perfil";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreUsuario.ForeColor = Color.LightGray;
            lblNombreUsuario.Location = new Point(66, 18);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(100, 16);
            lblNombreUsuario.TabIndex = 4;
            lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // picBoxUser
            // 
            picBoxUser.Cursor = Cursors.Hand;
            picBoxUser.Image = Properties.Resources.contact_500px1;
            picBoxUser.Location = new Point(0, 0);
            picBoxUser.Name = "picBoxUser";
            picBoxUser.Size = new Size(60, 70);
            picBoxUser.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxUser.TabIndex = 1;
            picBoxUser.TabStop = false;
            picBoxUser.Click += picBoxUser_Click;
            // 
            // panelFormularios
            // 
            panelFormularios.Controls.Add(picBoxLogo);
            panelFormularios.Dock = DockStyle.Fill;
            panelFormularios.Location = new Point(200, 0);
            panelFormularios.Name = "panelFormularios";
            panelFormularios.Size = new Size(754, 409);
            panelFormularios.TabIndex = 7;
            // 
            // picBoxLogo
            // 
            picBoxLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picBoxLogo.BackgroundImage = Properties.Resources.email_send_96px2;
            picBoxLogo.BackgroundImageLayout = ImageLayout.Center;
            picBoxLogo.Location = new Point(205, 66);
            picBoxLogo.Name = "picBoxLogo";
            picBoxLogo.Size = new Size(344, 242);
            picBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxLogo.TabIndex = 3;
            picBoxLogo.TabStop = false;
            // 
            // FrmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 32, 39);
            ClientSize = new Size(954, 409);
            Controls.Add(panelFormularios);
            Controls.Add(panelSideMenu);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(970, 448);
            Name = "FrmAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AvalloneAirLines";
            FormClosing += FrmAdmin_FormClosing;
            Load += FrmAdmin_Load;
            panelSideMenu.ResumeLayout(false);
            panelSideMenu.PerformLayout();
            panelSubMenuModif.ResumeLayout(false);
            panelUsuario.ResumeLayout(false);
            panelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxUser).EndInit();
            panelFormularios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Panel panelSubMenuModif;
        private Button btnModifViajes;
        private Button btnModificaciones;
        private Panel panelUsuario;
        private PictureBox picBoxUser;
        private Button btnModifAeronaves;
        private Label lblPerfil;
        private Label lblNombreUsuario;
        private Panel panelFormularios;
        private PictureBox picBoxLogo;
        private Label lblFecha;
    }
}