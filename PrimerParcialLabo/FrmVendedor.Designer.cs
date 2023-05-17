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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVendedor));
            panelSideMenu = new Panel();
            panelEstadisticas = new Panel();
            btnHorasVuelos = new Button();
            btnDestinoMasElegido = new Button();
            btnPasajerosFrecuentes = new Button();
            btnFacturacionDestinos = new Button();
            lblFecha = new Label();
            btnEstadisticas = new Button();
            panelSubMenuModif = new Panel();
            btnModPasa = new Button();
            btnModificaciones = new Button();
            panelSubmenuVenta = new Panel();
            btnVender = new Button();
            btnViajesDispon = new Button();
            btnVenta = new Button();
            panelUsuario = new Panel();
            lblPerfil = new Label();
            lblNombreUsuario = new Label();
            picBoxUser = new PictureBox();
            picBoxLogo = new PictureBox();
            panelFormularios = new Panel();
            panelSideMenu.SuspendLayout();
            panelEstadisticas.SuspendLayout();
            panelSubMenuModif.SuspendLayout();
            panelSubmenuVenta.SuspendLayout();
            panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).BeginInit();
            panelFormularios.SuspendLayout();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.BackColor = Color.FromArgb(11, 7, 17);
            panelSideMenu.Controls.Add(panelEstadisticas);
            panelSideMenu.Controls.Add(lblFecha);
            panelSideMenu.Controls.Add(btnEstadisticas);
            panelSideMenu.Controls.Add(panelSubMenuModif);
            panelSideMenu.Controls.Add(btnModificaciones);
            panelSideMenu.Controls.Add(panelSubmenuVenta);
            panelSideMenu.Controls.Add(btnVenta);
            panelSideMenu.Controls.Add(panelUsuario);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(200, 409);
            panelSideMenu.TabIndex = 0;
            // 
            // panelEstadisticas
            // 
            panelEstadisticas.BackColor = Color.FromArgb(35, 32, 39);
            panelEstadisticas.Controls.Add(btnHorasVuelos);
            panelEstadisticas.Controls.Add(btnDestinoMasElegido);
            panelEstadisticas.Controls.Add(btnPasajerosFrecuentes);
            panelEstadisticas.Controls.Add(btnFacturacionDestinos);
            panelEstadisticas.Cursor = Cursors.Hand;
            panelEstadisticas.Dock = DockStyle.Top;
            panelEstadisticas.Location = new Point(0, 247);
            panelEstadisticas.Name = "panelEstadisticas";
            panelEstadisticas.Size = new Size(200, 121);
            panelEstadisticas.TabIndex = 14;
            // 
            // btnHorasVuelos
            // 
            btnHorasVuelos.Dock = DockStyle.Top;
            btnHorasVuelos.FlatAppearance.BorderSize = 0;
            btnHorasVuelos.FlatStyle = FlatStyle.Flat;
            btnHorasVuelos.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnHorasVuelos.ForeColor = Color.LightGray;
            btnHorasVuelos.Location = new Point(0, 89);
            btnHorasVuelos.Name = "btnHorasVuelos";
            btnHorasVuelos.Padding = new Padding(30, 0, 0, 0);
            btnHorasVuelos.Size = new Size(200, 29);
            btnHorasVuelos.TabIndex = 5;
            btnHorasVuelos.Text = "Horas De Vuelo";
            btnHorasVuelos.TextAlign = ContentAlignment.MiddleLeft;
            btnHorasVuelos.UseVisualStyleBackColor = true;
            btnHorasVuelos.Click += btnHorasVuelos_Click;
            // 
            // btnDestinoMasElegido
            // 
            btnDestinoMasElegido.Dock = DockStyle.Top;
            btnDestinoMasElegido.FlatAppearance.BorderSize = 0;
            btnDestinoMasElegido.FlatStyle = FlatStyle.Flat;
            btnDestinoMasElegido.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDestinoMasElegido.ForeColor = Color.LightGray;
            btnDestinoMasElegido.Location = new Point(0, 60);
            btnDestinoMasElegido.Name = "btnDestinoMasElegido";
            btnDestinoMasElegido.Padding = new Padding(30, 0, 0, 0);
            btnDestinoMasElegido.Size = new Size(200, 29);
            btnDestinoMasElegido.TabIndex = 4;
            btnDestinoMasElegido.Text = "Destino Mas Elegido";
            btnDestinoMasElegido.TextAlign = ContentAlignment.MiddleLeft;
            btnDestinoMasElegido.UseVisualStyleBackColor = true;
            btnDestinoMasElegido.Click += btnDestinoMasElegido_Click;
            // 
            // btnPasajerosFrecuentes
            // 
            btnPasajerosFrecuentes.Dock = DockStyle.Top;
            btnPasajerosFrecuentes.FlatAppearance.BorderSize = 0;
            btnPasajerosFrecuentes.FlatStyle = FlatStyle.Flat;
            btnPasajerosFrecuentes.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPasajerosFrecuentes.ForeColor = Color.LightGray;
            btnPasajerosFrecuentes.Location = new Point(0, 31);
            btnPasajerosFrecuentes.Name = "btnPasajerosFrecuentes";
            btnPasajerosFrecuentes.Padding = new Padding(30, 0, 0, 0);
            btnPasajerosFrecuentes.Size = new Size(200, 29);
            btnPasajerosFrecuentes.TabIndex = 3;
            btnPasajerosFrecuentes.Text = "Pasajeros Frecuentes";
            btnPasajerosFrecuentes.TextAlign = ContentAlignment.MiddleLeft;
            btnPasajerosFrecuentes.UseVisualStyleBackColor = true;
            btnPasajerosFrecuentes.Click += btnPasajerosFrecuentes_Click;
            // 
            // btnFacturacionDestinos
            // 
            btnFacturacionDestinos.Cursor = Cursors.Hand;
            btnFacturacionDestinos.Dock = DockStyle.Top;
            btnFacturacionDestinos.FlatAppearance.BorderSize = 0;
            btnFacturacionDestinos.FlatStyle = FlatStyle.Flat;
            btnFacturacionDestinos.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnFacturacionDestinos.ForeColor = Color.LightGray;
            btnFacturacionDestinos.Location = new Point(0, 0);
            btnFacturacionDestinos.Name = "btnFacturacionDestinos";
            btnFacturacionDestinos.Padding = new Padding(30, 0, 0, 0);
            btnFacturacionDestinos.Size = new Size(200, 31);
            btnFacturacionDestinos.TabIndex = 2;
            btnFacturacionDestinos.Text = "Facturación Destinos";
            btnFacturacionDestinos.TextAlign = ContentAlignment.MiddleLeft;
            btnFacturacionDestinos.UseVisualStyleBackColor = true;
            btnFacturacionDestinos.Click += btnFacturacionDestinos_Click;
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblFecha.AutoSize = true;
            lblFecha.ForeColor = Color.Gainsboro;
            lblFecha.Location = new Point(4, 389);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(0, 15);
            lblFecha.TabIndex = 13;
            // 
            // btnEstadisticas
            // 
            btnEstadisticas.Cursor = Cursors.Hand;
            btnEstadisticas.Dock = DockStyle.Top;
            btnEstadisticas.FlatAppearance.BorderSize = 0;
            btnEstadisticas.FlatAppearance.MouseOverBackColor = Color.FromArgb(18, 18, 18);
            btnEstadisticas.FlatStyle = FlatStyle.Flat;
            btnEstadisticas.ForeColor = Color.Gainsboro;
            btnEstadisticas.Location = new Point(0, 220);
            btnEstadisticas.Name = "btnEstadisticas";
            btnEstadisticas.Padding = new Padding(10, 0, 0, 0);
            btnEstadisticas.Size = new Size(200, 27);
            btnEstadisticas.TabIndex = 4;
            btnEstadisticas.Text = "Estadisticas Historicas";
            btnEstadisticas.TextAlign = ContentAlignment.MiddleLeft;
            btnEstadisticas.UseVisualStyleBackColor = true;
            btnEstadisticas.Click += btnEstadisticas_Click;
            // 
            // panelSubMenuModif
            // 
            panelSubMenuModif.BackColor = Color.FromArgb(35, 32, 39);
            panelSubMenuModif.Controls.Add(btnModPasa);
            panelSubMenuModif.Cursor = Cursors.Hand;
            panelSubMenuModif.Dock = DockStyle.Top;
            panelSubMenuModif.Location = new Point(0, 190);
            panelSubMenuModif.Name = "panelSubMenuModif";
            panelSubMenuModif.Size = new Size(200, 30);
            panelSubMenuModif.TabIndex = 3;
            // 
            // btnModPasa
            // 
            btnModPasa.Dock = DockStyle.Top;
            btnModPasa.FlatAppearance.BorderSize = 0;
            btnModPasa.FlatStyle = FlatStyle.Flat;
            btnModPasa.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnModPasa.ForeColor = Color.LightGray;
            btnModPasa.Location = new Point(0, 0);
            btnModPasa.Name = "btnModPasa";
            btnModPasa.Padding = new Padding(30, 0, 0, 0);
            btnModPasa.Size = new Size(200, 27);
            btnModPasa.TabIndex = 2;
            btnModPasa.Text = "Modificar Pasajeros";
            btnModPasa.TextAlign = ContentAlignment.MiddleLeft;
            btnModPasa.UseVisualStyleBackColor = true;
            btnModPasa.Click += btnModPasa_Click;
            // 
            // btnModificaciones
            // 
            btnModificaciones.Cursor = Cursors.Hand;
            btnModificaciones.Dock = DockStyle.Top;
            btnModificaciones.FlatAppearance.BorderSize = 0;
            btnModificaciones.FlatAppearance.MouseOverBackColor = Color.FromArgb(18, 18, 18);
            btnModificaciones.FlatStyle = FlatStyle.Flat;
            btnModificaciones.ForeColor = Color.LightGray;
            btnModificaciones.Location = new Point(0, 163);
            btnModificaciones.Name = "btnModificaciones";
            btnModificaciones.Padding = new Padding(10, 0, 0, 0);
            btnModificaciones.Size = new Size(200, 27);
            btnModificaciones.TabIndex = 2;
            btnModificaciones.Text = "Modificaciones";
            btnModificaciones.TextAlign = ContentAlignment.MiddleLeft;
            btnModificaciones.UseVisualStyleBackColor = true;
            btnModificaciones.Click += button1_Click;
            // 
            // panelSubmenuVenta
            // 
            panelSubmenuVenta.BackColor = Color.FromArgb(35, 32, 39);
            panelSubmenuVenta.Controls.Add(btnVender);
            panelSubmenuVenta.Controls.Add(btnViajesDispon);
            panelSubmenuVenta.Cursor = Cursors.Hand;
            panelSubmenuVenta.Dock = DockStyle.Top;
            panelSubmenuVenta.Location = new Point(0, 106);
            panelSubmenuVenta.Name = "panelSubmenuVenta";
            panelSubmenuVenta.Size = new Size(200, 57);
            panelSubmenuVenta.TabIndex = 1;
            // 
            // btnVender
            // 
            btnVender.Dock = DockStyle.Top;
            btnVender.FlatAppearance.BorderSize = 0;
            btnVender.FlatStyle = FlatStyle.Flat;
            btnVender.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnVender.ForeColor = Color.LightGray;
            btnVender.Location = new Point(0, 27);
            btnVender.Name = "btnVender";
            btnVender.Padding = new Padding(30, 0, 0, 0);
            btnVender.Size = new Size(200, 24);
            btnVender.TabIndex = 3;
            btnVender.Text = "Venta Viaje";
            btnVender.TextAlign = ContentAlignment.MiddleLeft;
            btnVender.UseVisualStyleBackColor = true;
            btnVender.Click += btnVender_Click;
            // 
            // btnViajesDispon
            // 
            btnViajesDispon.Cursor = Cursors.Hand;
            btnViajesDispon.Dock = DockStyle.Top;
            btnViajesDispon.FlatAppearance.BorderSize = 0;
            btnViajesDispon.FlatStyle = FlatStyle.Flat;
            btnViajesDispon.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnViajesDispon.ForeColor = Color.LightGray;
            btnViajesDispon.Location = new Point(0, 0);
            btnViajesDispon.Name = "btnViajesDispon";
            btnViajesDispon.Padding = new Padding(30, 0, 0, 0);
            btnViajesDispon.Size = new Size(200, 27);
            btnViajesDispon.TabIndex = 2;
            btnViajesDispon.Text = "Viajes Disponibles";
            btnViajesDispon.TextAlign = ContentAlignment.MiddleLeft;
            btnViajesDispon.UseVisualStyleBackColor = true;
            btnViajesDispon.Click += btnViajesDispon_Click;
            // 
            // btnVenta
            // 
            btnVenta.Cursor = Cursors.Hand;
            btnVenta.Dock = DockStyle.Top;
            btnVenta.FlatAppearance.BorderSize = 0;
            btnVenta.FlatAppearance.MouseOverBackColor = Color.FromArgb(18, 18, 18);
            btnVenta.FlatStyle = FlatStyle.Flat;
            btnVenta.ForeColor = Color.Gainsboro;
            btnVenta.ImageAlign = ContentAlignment.MiddleLeft;
            btnVenta.Location = new Point(0, 79);
            btnVenta.Name = "btnVenta";
            btnVenta.Padding = new Padding(10, 0, 0, 0);
            btnVenta.Size = new Size(200, 27);
            btnVenta.TabIndex = 1;
            btnVenta.Text = "Vuelos";
            btnVenta.TextAlign = ContentAlignment.MiddleLeft;
            btnVenta.UseVisualStyleBackColor = true;
            btnVenta.Click += btnVenta_Click;
            // 
            // panelUsuario
            // 
            panelUsuario.Controls.Add(lblPerfil);
            panelUsuario.Controls.Add(lblNombreUsuario);
            panelUsuario.Controls.Add(picBoxUser);
            panelUsuario.Dock = DockStyle.Top;
            panelUsuario.Location = new Point(0, 0);
            panelUsuario.Name = "panelUsuario";
            panelUsuario.Size = new Size(200, 79);
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
            lblPerfil.TabIndex = 4;
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
            lblNombreUsuario.TabIndex = 2;
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
            // picBoxLogo
            // 
            picBoxLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picBoxLogo.BackgroundImage = Properties.Resources.email_send_96px2;
            picBoxLogo.BackgroundImageLayout = ImageLayout.Center;
            picBoxLogo.Location = new Point(191, 63);
            picBoxLogo.Name = "picBoxLogo";
            picBoxLogo.Size = new Size(344, 276);
            picBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxLogo.TabIndex = 1;
            picBoxLogo.TabStop = false;
            // 
            // panelFormularios
            // 
            panelFormularios.Controls.Add(picBoxLogo);
            panelFormularios.Dock = DockStyle.Fill;
            panelFormularios.Location = new Point(200, 0);
            panelFormularios.Name = "panelFormularios";
            panelFormularios.Size = new Size(754, 409);
            panelFormularios.TabIndex = 5;
            // 
            // FrmVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 32, 39);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(954, 409);
            Controls.Add(panelFormularios);
            Controls.Add(panelSideMenu);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(970, 448);
            Name = "FrmVendedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AvalloneAirLines";
            FormClosing += FrmVendedor_FormClosing;
            Load += FrmPrincipal_Load;
            panelSideMenu.ResumeLayout(false);
            panelSideMenu.PerformLayout();
            panelEstadisticas.ResumeLayout(false);
            panelSubMenuModif.ResumeLayout(false);
            panelSubmenuVenta.ResumeLayout(false);
            panelUsuario.ResumeLayout(false);
            panelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).EndInit();
            panelFormularios.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Button btnEstadisticas;
        private Panel panelSubMenuModif;
        private Button btnModPasa;
        private Button btnModificaciones;
        private Panel panelUsuario;
        private PictureBox picBoxUser;
        private PictureBox picBoxLogo;
        private Panel panelSubmenuVenta;
        private Button btnVender;
        private Button btnViajesDispon;
        private Button btnVenta;
        private Panel panelFormularios;
        private Label lblPerfil;
        private Label lblNombreUsuario;
        private Label lblFecha;
        private Panel panelEstadisticas;
        private Button btnPasajerosFrecuentes;
        private Button btnFacturacionDestinos;
        private Button btnHorasVuelos;
        private Button btnDestinoMasElegido;
    }
}