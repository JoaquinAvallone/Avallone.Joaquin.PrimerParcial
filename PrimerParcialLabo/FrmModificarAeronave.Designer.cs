namespace PrimerParcialLabo
{
    partial class FrmModificarAeronave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarAeronave));
            panel8 = new Panel();
            panel1 = new Panel();
            panel10 = new Panel();
            panel2 = new Panel();
            numericUDBodega = new NumericUpDown();
            numericUDAsientos = new NumericUpDown();
            numericUDBaños = new NumericUpDown();
            picBGenerar = new PictureBox();
            txtBMatricula = new TextBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            panel7 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panelContrseña = new Panel();
            lblBodega = new Label();
            lblComida = new Label();
            lblInternet = new Label();
            lblBaños = new Label();
            lblAsientos = new Label();
            lblMatricula = new Label();
            checkBInternet = new CheckBox();
            checkBComida = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numericUDBodega).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUDAsientos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUDBaños).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBGenerar).BeginInit();
            SuspendLayout();
            // 
            // panel8
            // 
            panel8.BackColor = Color.WhiteSmoke;
            panel8.Location = new Point(322, -26);
            panel8.Name = "panel8";
            panel8.Size = new Size(1, 472);
            panel8.TabIndex = 54;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Location = new Point(0, -26);
            panel1.Name = "panel1";
            panel1.Size = new Size(1, 472);
            panel1.TabIndex = 55;
            // 
            // panel10
            // 
            panel10.BackColor = Color.WhiteSmoke;
            panel10.Location = new Point(-8, 419);
            panel10.Name = "panel10";
            panel10.Size = new Size(339, 1);
            panel10.TabIndex = 56;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Location = new Point(-8, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(339, 1);
            panel2.TabIndex = 57;
            // 
            // numericUDBodega
            // 
            numericUDBodega.BackColor = Color.FromArgb(35, 32, 39);
            numericUDBodega.BorderStyle = BorderStyle.None;
            numericUDBodega.Cursor = Cursors.Hand;
            numericUDBodega.ForeColor = Color.WhiteSmoke;
            numericUDBodega.Location = new Point(168, 291);
            numericUDBodega.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUDBodega.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUDBodega.Name = "numericUDBodega";
            numericUDBodega.Size = new Size(105, 19);
            numericUDBodega.TabIndex = 104;
            numericUDBodega.TextAlign = HorizontalAlignment.Center;
            numericUDBodega.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // numericUDAsientos
            // 
            numericUDAsientos.BackColor = Color.FromArgb(35, 32, 39);
            numericUDAsientos.BorderStyle = BorderStyle.None;
            numericUDAsientos.Cursor = Cursors.Hand;
            numericUDAsientos.ForeColor = Color.WhiteSmoke;
            numericUDAsientos.Location = new Point(165, 101);
            numericUDAsientos.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUDAsientos.Minimum = new decimal(new int[] { 150, 0, 0, 0 });
            numericUDAsientos.Name = "numericUDAsientos";
            numericUDAsientos.Size = new Size(107, 19);
            numericUDAsientos.TabIndex = 102;
            numericUDAsientos.TextAlign = HorizontalAlignment.Center;
            numericUDAsientos.Value = new decimal(new int[] { 150, 0, 0, 0 });
            // 
            // numericUDBaños
            // 
            numericUDBaños.BackColor = Color.FromArgb(35, 32, 39);
            numericUDBaños.BorderStyle = BorderStyle.None;
            numericUDBaños.Cursor = Cursors.Hand;
            numericUDBaños.ForeColor = Color.WhiteSmoke;
            numericUDBaños.Location = new Point(152, 148);
            numericUDBaños.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            numericUDBaños.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUDBaños.Name = "numericUDBaños";
            numericUDBaños.Size = new Size(120, 19);
            numericUDBaños.TabIndex = 100;
            numericUDBaños.TextAlign = HorizontalAlignment.Center;
            numericUDBaños.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // picBGenerar
            // 
            picBGenerar.Cursor = Cursors.Hand;
            picBGenerar.Image = (Image)resources.GetObject("picBGenerar.Image");
            picBGenerar.Location = new Point(247, 48);
            picBGenerar.Name = "picBGenerar";
            picBGenerar.Size = new Size(25, 23);
            picBGenerar.SizeMode = PictureBoxSizeMode.Zoom;
            picBGenerar.TabIndex = 99;
            picBGenerar.TabStop = false;
            picBGenerar.Click += picBGenerar_Click;
            // 
            // txtBMatricula
            // 
            txtBMatricula.BackColor = Color.FromArgb(35, 32, 39);
            txtBMatricula.BorderStyle = BorderStyle.None;
            txtBMatricula.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBMatricula.ForeColor = Color.WhiteSmoke;
            txtBMatricula.Location = new Point(115, 55);
            txtBMatricula.Name = "txtBMatricula";
            txtBMatricula.ReadOnly = true;
            txtBMatricula.Size = new Size(131, 16);
            txtBMatricula.TabIndex = 98;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.WhiteSmoke;
            btnCancelar.Location = new Point(163, 347);
            btnCancelar.MaximumSize = new Size(116, 25);
            btnCancelar.MinimumSize = new Size(116, 25);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(116, 25);
            btnCancelar.TabIndex = 97;
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
            btnAceptar.Location = new Point(43, 347);
            btnAceptar.MaximumSize = new Size(116, 25);
            btnAceptar.MinimumSize = new Size(116, 25);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(116, 25);
            btnAceptar.TabIndex = 96;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Location = new Point(54, 312);
            panel7.Name = "panel7";
            panel7.Size = new Size(220, 1);
            panel7.TabIndex = 95;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(53, 264);
            panel6.Name = "panel6";
            panel6.Size = new Size(220, 1);
            panel6.TabIndex = 94;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(53, 216);
            panel5.Name = "panel5";
            panel5.Size = new Size(220, 1);
            panel5.TabIndex = 93;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(53, 169);
            panel4.Name = "panel4";
            panel4.Size = new Size(220, 1);
            panel4.TabIndex = 92;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(53, 122);
            panel3.Name = "panel3";
            panel3.Size = new Size(220, 1);
            panel3.TabIndex = 91;
            // 
            // panelContrseña
            // 
            panelContrseña.BackColor = Color.White;
            panelContrseña.Location = new Point(53, 73);
            panelContrseña.Name = "panelContrseña";
            panelContrseña.Size = new Size(220, 1);
            panelContrseña.TabIndex = 90;
            // 
            // lblBodega
            // 
            lblBodega.AutoSize = true;
            lblBodega.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblBodega.ForeColor = Color.WhiteSmoke;
            lblBodega.Location = new Point(53, 295);
            lblBodega.Name = "lblBodega";
            lblBodega.Size = new Size(116, 15);
            lblBodega.TabIndex = 89;
            lblBodega.Text = "Capacidad Bodega:";
            // 
            // lblComida
            // 
            lblComida.AutoSize = true;
            lblComida.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblComida.ForeColor = Color.WhiteSmoke;
            lblComida.Location = new Point(53, 247);
            lblComida.Name = "lblComida";
            lblComida.Size = new Size(53, 15);
            lblComida.TabIndex = 88;
            lblComida.Text = "Comida:";
            // 
            // lblInternet
            // 
            lblInternet.AutoSize = true;
            lblInternet.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblInternet.ForeColor = Color.WhiteSmoke;
            lblInternet.Location = new Point(54, 198);
            lblInternet.Name = "lblInternet";
            lblInternet.Size = new Size(54, 15);
            lblInternet.TabIndex = 87;
            lblInternet.Text = "Internet:";
            // 
            // lblBaños
            // 
            lblBaños.AutoSize = true;
            lblBaños.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblBaños.ForeColor = Color.WhiteSmoke;
            lblBaños.Location = new Point(51, 152);
            lblBaños.Name = "lblBaños";
            lblBaños.Size = new Size(99, 15);
            lblBaños.TabIndex = 86;
            lblBaños.Text = "Cantidad Baños:";
            // 
            // lblAsientos
            // 
            lblAsientos.AutoSize = true;
            lblAsientos.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAsientos.ForeColor = Color.WhiteSmoke;
            lblAsientos.Location = new Point(52, 105);
            lblAsientos.Name = "lblAsientos";
            lblAsientos.Size = new Size(113, 15);
            lblAsientos.TabIndex = 85;
            lblAsientos.Text = "Cantidad Asientos:";
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMatricula.ForeColor = Color.WhiteSmoke;
            lblMatricula.Location = new Point(52, 56);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(63, 15);
            lblMatricula.TabIndex = 84;
            lblMatricula.Text = "Matricula:";
            // 
            // checkBInternet
            // 
            checkBInternet.AutoSize = true;
            checkBInternet.ForeColor = Color.WhiteSmoke;
            checkBInternet.Location = new Point(152, 195);
            checkBInternet.Name = "checkBInternet";
            checkBInternet.Size = new Size(54, 19);
            checkBInternet.TabIndex = 105;
            checkBInternet.Text = "Tiene";
            checkBInternet.UseVisualStyleBackColor = true;
            // 
            // checkBComida
            // 
            checkBComida.AutoSize = true;
            checkBComida.ForeColor = Color.WhiteSmoke;
            checkBComida.Location = new Point(152, 243);
            checkBComida.Name = "checkBComida";
            checkBComida.Size = new Size(54, 19);
            checkBComida.TabIndex = 106;
            checkBComida.Text = "Tiene";
            checkBComida.UseVisualStyleBackColor = true;
            // 
            // FrmModificarAeronave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 32, 39);
            ClientSize = new Size(323, 420);
            Controls.Add(checkBComida);
            Controls.Add(checkBInternet);
            Controls.Add(numericUDBodega);
            Controls.Add(numericUDAsientos);
            Controls.Add(numericUDBaños);
            Controls.Add(picBGenerar);
            Controls.Add(txtBMatricula);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panelContrseña);
            Controls.Add(lblBodega);
            Controls.Add(lblComida);
            Controls.Add(lblInternet);
            Controls.Add(lblBaños);
            Controls.Add(lblAsientos);
            Controls.Add(lblMatricula);
            Controls.Add(panel2);
            Controls.Add(panel10);
            Controls.Add(panel1);
            Controls.Add(panel8);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmModificarAeronave";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmModificarAeronave";
            Load += FrmModificarAeronave_Load;
            ((System.ComponentModel.ISupportInitialize)numericUDBodega).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUDAsientos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUDBaños).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBGenerar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel8;
        private Panel panel1;
        private Panel panel10;
        private Panel panel2;
        protected NumericUpDown numericUDBodega;
        protected NumericUpDown numericUDAsientos;
        protected NumericUpDown numericUDBaños;
        protected PictureBox picBGenerar;
        protected TextBox txtBMatricula;
        protected Button btnCancelar;
        protected Button btnAceptar;
        protected Panel panel7;
        protected Panel panel6;
        protected Panel panel5;
        protected Panel panel4;
        protected Panel panel3;
        protected Panel panelContrseña;
        protected Label lblBodega;
        protected Label lblComida;
        protected Label lblInternet;
        protected Label lblBaños;
        protected Label lblAsientos;
        protected Label lblMatricula;
        private CheckBox checkBInternet;
        private CheckBox checkBComida;
    }
}