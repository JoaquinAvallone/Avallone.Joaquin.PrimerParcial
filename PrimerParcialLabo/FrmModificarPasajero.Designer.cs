namespace PrimerParcialLabo
{
    partial class FrmModificarPasajero
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
            radioBPremium = new RadioButton();
            radioBTurista = new RadioButton();
            btnCancelar = new Button();
            btnAceptar = new Button();
            txtBPesoEquipaje = new TextBox();
            txtBEdad = new TextBox();
            txtBDni = new TextBox();
            txtBNombre = new TextBox();
            txtBApellido = new TextBox();
            checkBEquipajeBodega = new CheckBox();
            checkBEquipajeMano = new CheckBox();
            lblClase = new Label();
            panel7 = new Panel();
            lblPesoEquipaje = new Label();
            panel6 = new Panel();
            lblEquipajeBodega = new Label();
            panel5 = new Panel();
            llblEquipajeMano = new Label();
            panel4 = new Panel();
            lblEdad = new Label();
            panel3 = new Panel();
            lblDni = new Label();
            lblNombre = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            lblApellido = new Label();
            panelContrseña = new Panel();
            panel11 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            SuspendLayout();
            // 
            // radioBPremium
            // 
            radioBPremium.AutoSize = true;
            radioBPremium.Cursor = Cursors.Hand;
            radioBPremium.ForeColor = Color.WhiteSmoke;
            radioBPremium.Location = new Point(199, 342);
            radioBPremium.Name = "radioBPremium";
            radioBPremium.Size = new Size(74, 19);
            radioBPremium.TabIndex = 74;
            radioBPremium.TabStop = true;
            radioBPremium.Text = "Premium";
            radioBPremium.UseVisualStyleBackColor = true;
            // 
            // radioBTurista
            // 
            radioBTurista.AutoSize = true;
            radioBTurista.Cursor = Cursors.Hand;
            radioBTurista.ForeColor = Color.WhiteSmoke;
            radioBTurista.Location = new Point(121, 342);
            radioBTurista.Name = "radioBTurista";
            radioBTurista.Size = new Size(60, 19);
            radioBTurista.TabIndex = 73;
            radioBTurista.TabStop = true;
            radioBTurista.Text = "Turista";
            radioBTurista.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.WhiteSmoke;
            btnCancelar.Location = new Point(165, 407);
            btnCancelar.MaximumSize = new Size(116, 25);
            btnCancelar.MinimumSize = new Size(116, 25);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(116, 25);
            btnCancelar.TabIndex = 72;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.Bottom;
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.WhiteSmoke;
            btnAceptar.Location = new Point(46, 407);
            btnAceptar.MaximumSize = new Size(116, 25);
            btnAceptar.MinimumSize = new Size(116, 25);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(116, 25);
            btnAceptar.TabIndex = 71;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtBPesoEquipaje
            // 
            txtBPesoEquipaje.BackColor = Color.FromArgb(35, 32, 39);
            txtBPesoEquipaje.BorderStyle = BorderStyle.None;
            txtBPesoEquipaje.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBPesoEquipaje.ForeColor = Color.WhiteSmoke;
            txtBPesoEquipaje.Location = new Point(148, 304);
            txtBPesoEquipaje.MaxLength = 6;
            txtBPesoEquipaje.Name = "txtBPesoEquipaje";
            txtBPesoEquipaje.Size = new Size(133, 16);
            txtBPesoEquipaje.TabIndex = 70;
            // 
            // txtBEdad
            // 
            txtBEdad.BackColor = Color.FromArgb(35, 32, 39);
            txtBEdad.BorderStyle = BorderStyle.None;
            txtBEdad.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBEdad.ForeColor = Color.WhiteSmoke;
            txtBEdad.Location = new Point(94, 172);
            txtBEdad.MaxLength = 3;
            txtBEdad.Name = "txtBEdad";
            txtBEdad.Size = new Size(184, 16);
            txtBEdad.TabIndex = 69;
            // 
            // txtBDni
            // 
            txtBDni.BackColor = Color.FromArgb(35, 32, 39);
            txtBDni.BorderStyle = BorderStyle.None;
            txtBDni.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBDni.ForeColor = Color.WhiteSmoke;
            txtBDni.Location = new Point(87, 128);
            txtBDni.MaxLength = 8;
            txtBDni.Name = "txtBDni";
            txtBDni.Size = new Size(191, 16);
            txtBDni.TabIndex = 68;
            // 
            // txtBNombre
            // 
            txtBNombre.BackColor = Color.FromArgb(35, 32, 39);
            txtBNombre.BorderStyle = BorderStyle.None;
            txtBNombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBNombre.ForeColor = Color.WhiteSmoke;
            txtBNombre.Location = new Point(111, 83);
            txtBNombre.Name = "txtBNombre";
            txtBNombre.Size = new Size(167, 16);
            txtBNombre.TabIndex = 67;
            txtBNombre.KeyPress += txtBNombre_KeyPress;
            // 
            // txtBApellido
            // 
            txtBApellido.BackColor = Color.FromArgb(35, 32, 39);
            txtBApellido.BorderStyle = BorderStyle.None;
            txtBApellido.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBApellido.ForeColor = Color.WhiteSmoke;
            txtBApellido.Location = new Point(111, 40);
            txtBApellido.Name = "txtBApellido";
            txtBApellido.Size = new Size(167, 16);
            txtBApellido.TabIndex = 66;
            txtBApellido.KeyPress += txtBApellido_KeyPress;
            // 
            // checkBEquipajeBodega
            // 
            checkBEquipajeBodega.AutoSize = true;
            checkBEquipajeBodega.Cursor = Cursors.Hand;
            checkBEquipajeBodega.ForeColor = Color.WhiteSmoke;
            checkBEquipajeBodega.Location = new Point(188, 258);
            checkBEquipajeBodega.Name = "checkBEquipajeBodega";
            checkBEquipajeBodega.Size = new Size(53, 19);
            checkBEquipajeBodega.TabIndex = 65;
            checkBEquipajeBodega.Text = "Lleva";
            checkBEquipajeBodega.UseVisualStyleBackColor = true;
            // 
            // checkBEquipajeMano
            // 
            checkBEquipajeMano.AutoSize = true;
            checkBEquipajeMano.Cursor = Cursors.Hand;
            checkBEquipajeMano.ForeColor = Color.WhiteSmoke;
            checkBEquipajeMano.Location = new Point(188, 214);
            checkBEquipajeMano.Name = "checkBEquipajeMano";
            checkBEquipajeMano.Size = new Size(53, 19);
            checkBEquipajeMano.TabIndex = 64;
            checkBEquipajeMano.Text = "Lleva";
            checkBEquipajeMano.UseVisualStyleBackColor = true;
            // 
            // lblClase
            // 
            lblClase.AutoSize = true;
            lblClase.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblClase.ForeColor = Color.WhiteSmoke;
            lblClase.Location = new Point(59, 347);
            lblClase.Name = "lblClase";
            lblClase.Size = new Size(42, 15);
            lblClase.TabIndex = 63;
            lblClase.Text = "Clase:";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Location = new Point(59, 365);
            panel7.Name = "panel7";
            panel7.Size = new Size(220, 1);
            panel7.TabIndex = 62;
            // 
            // lblPesoEquipaje
            // 
            lblPesoEquipaje.AutoSize = true;
            lblPesoEquipaje.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPesoEquipaje.ForeColor = Color.WhiteSmoke;
            lblPesoEquipaje.Location = new Point(58, 304);
            lblPesoEquipaje.Name = "lblPesoEquipaje";
            lblPesoEquipaje.Size = new Size(90, 15);
            lblPesoEquipaje.TabIndex = 61;
            lblPesoEquipaje.Text = "Peso Equipaje:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(59, 322);
            panel6.Name = "panel6";
            panel6.Size = new Size(220, 1);
            panel6.TabIndex = 60;
            // 
            // lblEquipajeBodega
            // 
            lblEquipajeBodega.AutoSize = true;
            lblEquipajeBodega.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEquipajeBodega.ForeColor = Color.WhiteSmoke;
            lblEquipajeBodega.Location = new Point(58, 262);
            lblEquipajeBodega.Name = "lblEquipajeBodega";
            lblEquipajeBodega.Size = new Size(104, 15);
            lblEquipajeBodega.TabIndex = 59;
            lblEquipajeBodega.Text = "Equipaje Bodega:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(59, 280);
            panel5.Name = "panel5";
            panel5.Size = new Size(220, 1);
            panel5.TabIndex = 58;
            // 
            // llblEquipajeMano
            // 
            llblEquipajeMano.AutoSize = true;
            llblEquipajeMano.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            llblEquipajeMano.ForeColor = Color.WhiteSmoke;
            llblEquipajeMano.Location = new Point(57, 218);
            llblEquipajeMano.Name = "llblEquipajeMano";
            llblEquipajeMano.Size = new Size(92, 15);
            llblEquipajeMano.TabIndex = 57;
            llblEquipajeMano.Text = "Equipaje Mano:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(58, 236);
            panel4.Name = "panel4";
            panel4.Size = new Size(220, 1);
            panel4.TabIndex = 56;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEdad.ForeColor = Color.WhiteSmoke;
            lblEdad.Location = new Point(59, 173);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(38, 15);
            lblEdad.TabIndex = 55;
            lblEdad.Text = "Edad:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(60, 191);
            panel3.Name = "panel3";
            panel3.Size = new Size(220, 1);
            panel3.TabIndex = 54;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDni.ForeColor = Color.WhiteSmoke;
            lblDni.Location = new Point(59, 129);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(29, 15);
            lblDni.TabIndex = 53;
            lblDni.Text = "DNI:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.WhiteSmoke;
            lblNombre.Location = new Point(58, 84);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(55, 15);
            lblNombre.TabIndex = 52;
            lblNombre.Text = "Nombre:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(59, 147);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 1);
            panel2.TabIndex = 51;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(59, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 1);
            panel1.TabIndex = 50;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.ForeColor = Color.WhiteSmoke;
            lblApellido.Location = new Point(58, 40);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(55, 15);
            lblApellido.TabIndex = 49;
            lblApellido.Text = "Apellido:";
            // 
            // panelContrseña
            // 
            panelContrseña.BackColor = Color.White;
            panelContrseña.Location = new Point(59, 58);
            panelContrseña.Name = "panelContrseña";
            panelContrseña.Size = new Size(220, 1);
            panelContrseña.TabIndex = 48;
            // 
            // panel11
            // 
            panel11.BackColor = Color.WhiteSmoke;
            panel11.Location = new Point(0, 471);
            panel11.Name = "panel11";
            panel11.Size = new Size(339, 1);
            panel11.TabIndex = 75;
            // 
            // panel8
            // 
            panel8.BackColor = Color.WhiteSmoke;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(339, 1);
            panel8.TabIndex = 76;
            // 
            // panel9
            // 
            panel9.BackColor = Color.WhiteSmoke;
            panel9.Location = new Point(338, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(1, 472);
            panel9.TabIndex = 77;
            // 
            // panel10
            // 
            panel10.BackColor = Color.WhiteSmoke;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(1, 472);
            panel10.TabIndex = 78;
            // 
            // FrmModificarPasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 32, 39);
            ClientSize = new Size(339, 472);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel11);
            Controls.Add(radioBPremium);
            Controls.Add(radioBTurista);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtBPesoEquipaje);
            Controls.Add(txtBEdad);
            Controls.Add(txtBDni);
            Controls.Add(txtBNombre);
            Controls.Add(txtBApellido);
            Controls.Add(checkBEquipajeBodega);
            Controls.Add(checkBEquipajeMano);
            Controls.Add(lblClase);
            Controls.Add(panel7);
            Controls.Add(lblPesoEquipaje);
            Controls.Add(panel6);
            Controls.Add(lblEquipajeBodega);
            Controls.Add(panel5);
            Controls.Add(llblEquipajeMano);
            Controls.Add(panel4);
            Controls.Add(lblEdad);
            Controls.Add(panel3);
            Controls.Add(lblDni);
            Controls.Add(lblNombre);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblApellido);
            Controls.Add(panelContrseña);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmModificarPasajero";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmModificarPasajero";
            Load += FrmModificarPasajero_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioBPremium;
        private RadioButton radioBTurista;
        private Button btnCancelar;
        private Button btnAceptar;
        private TextBox txtBPesoEquipaje;
        private TextBox txtBEdad;
        private TextBox txtBDni;
        private TextBox txtBNombre;
        private TextBox txtBApellido;
        private CheckBox checkBEquipajeBodega;
        private CheckBox checkBEquipajeMano;
        private Label lblClase;
        private Panel panel7;
        private Label lblPesoEquipaje;
        private Panel panel6;
        private Label lblEquipajeBodega;
        private Panel panel5;
        private Label llblEquipajeMano;
        private Panel panel4;
        private Label lblEdad;
        private Panel panel3;
        private Label lblDni;
        private Label lblNombre;
        private Panel panel2;
        private Panel panel1;
        private Label lblApellido;
        private Panel panelContrseña;
        private Panel panel11;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
    }
}