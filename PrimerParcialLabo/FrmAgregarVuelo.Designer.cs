namespace PrimerParcialLabo
{
    partial class FrmAgregarVuelo
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGVAviones = new DataGridView();
            ColumMatricula = new DataGridViewTextBoxColumn();
            ColumAsientos = new DataGridViewTextBoxColumn();
            ColumBaños = new DataGridViewTextBoxColumn();
            ColumInternet = new DataGridViewTextBoxColumn();
            ColumComida = new DataGridViewTextBoxColumn();
            ColumBodega = new DataGridViewTextBoxColumn();
            txtBMatricula = new TextBox();
            lblPartida = new Label();
            lblDestino = new Label();
            lblFecha = new Label();
            dateTPFechaVuelo = new DateTimePicker();
            comboBPartida = new ComboBox();
            comboBDestino = new ComboBox();
            lblHora = new Label();
            numericUDHora = new NumericUpDown();
            numericUDMinutos = new NumericUpDown();
            label1 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            checkBInternacional = new CheckBox();
            lblMatricula = new Label();
            panel8 = new Panel();
            panel1 = new Panel();
            panel11 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGVAviones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUDHora).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUDMinutos).BeginInit();
            SuspendLayout();
            // 
            // dataGVAviones
            // 
            dataGVAviones.AllowUserToAddRows = false;
            dataGVAviones.AllowUserToDeleteRows = false;
            dataGVAviones.AllowUserToResizeColumns = false;
            dataGVAviones.AllowUserToResizeRows = false;
            dataGVAviones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGVAviones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGVAviones.BackgroundColor = Color.FromArgb(35, 32, 39);
            dataGVAviones.BorderStyle = BorderStyle.None;
            dataGVAviones.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGVAviones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle1.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGVAviones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGVAviones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGVAviones.Columns.AddRange(new DataGridViewColumn[] { ColumMatricula, ColumAsientos, ColumBaños, ColumInternet, ColumComida, ColumBodega });
            dataGVAviones.Cursor = Cursors.Hand;
            dataGVAviones.EnableHeadersVisualStyles = false;
            dataGVAviones.GridColor = Color.FromArgb(35, 32, 39);
            dataGVAviones.Location = new Point(2, 3);
            dataGVAviones.Name = "dataGVAviones";
            dataGVAviones.ReadOnly = true;
            dataGVAviones.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.DarkGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle2.SelectionForeColor = Color.DarkGray;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGVAviones.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGVAviones.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGVAviones.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGVAviones.RowTemplate.Height = 25;
            dataGVAviones.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGVAviones.Size = new Size(825, 261);
            dataGVAviones.TabIndex = 5;
            dataGVAviones.CellClick += dataGVAviones_CellClick;
            // 
            // ColumMatricula
            // 
            ColumMatricula.HeaderText = "MATRICULA";
            ColumMatricula.Name = "ColumMatricula";
            ColumMatricula.ReadOnly = true;
            // 
            // ColumAsientos
            // 
            ColumAsientos.HeaderText = "CANT. ASIENTOS";
            ColumAsientos.Name = "ColumAsientos";
            ColumAsientos.ReadOnly = true;
            // 
            // ColumBaños
            // 
            ColumBaños.HeaderText = "CANT. BAÑOS";
            ColumBaños.Name = "ColumBaños";
            ColumBaños.ReadOnly = true;
            // 
            // ColumInternet
            // 
            ColumInternet.HeaderText = "INTERNET";
            ColumInternet.Name = "ColumInternet";
            ColumInternet.ReadOnly = true;
            // 
            // ColumComida
            // 
            ColumComida.HeaderText = "COMIDA";
            ColumComida.Name = "ColumComida";
            ColumComida.ReadOnly = true;
            // 
            // ColumBodega
            // 
            ColumBodega.HeaderText = "CAPACIDAD BODEGA";
            ColumBodega.Name = "ColumBodega";
            ColumBodega.ReadOnly = true;
            // 
            // txtBMatricula
            // 
            txtBMatricula.Anchor = AnchorStyles.Bottom;
            txtBMatricula.BackColor = Color.FromArgb(35, 32, 39);
            txtBMatricula.BorderStyle = BorderStyle.None;
            txtBMatricula.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtBMatricula.ForeColor = Color.WhiteSmoke;
            txtBMatricula.Location = new Point(677, 271);
            txtBMatricula.MaxLength = 8;
            txtBMatricula.Name = "txtBMatricula";
            txtBMatricula.PlaceholderText = "Avion a asignar";
            txtBMatricula.Size = new Size(143, 16);
            txtBMatricula.TabIndex = 45;
            txtBMatricula.TextChanged += txtBMatricula_TextChanged_1;
            // 
            // lblPartida
            // 
            lblPartida.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPartida.AutoSize = true;
            lblPartida.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPartida.ForeColor = Color.WhiteSmoke;
            lblPartida.Location = new Point(524, 341);
            lblPartida.Name = "lblPartida";
            lblPartida.Size = new Size(111, 15);
            lblPartida.TabIndex = 56;
            lblPartida.Text = "Ciudad De Partida:";
            // 
            // lblDestino
            // 
            lblDestino.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDestino.AutoSize = true;
            lblDestino.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDestino.ForeColor = Color.WhiteSmoke;
            lblDestino.Location = new Point(226, 341);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(113, 15);
            lblDestino.TabIndex = 57;
            lblDestino.Text = "Ciudad De Destino:";
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.Bottom;
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFecha.ForeColor = Color.WhiteSmoke;
            lblFecha.Location = new Point(21, 270);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(44, 15);
            lblFecha.TabIndex = 58;
            lblFecha.Text = "Fecha:";
            // 
            // dateTPFechaVuelo
            // 
            dateTPFechaVuelo.Anchor = AnchorStyles.Bottom;
            dateTPFechaVuelo.CalendarForeColor = Color.WhiteSmoke;
            dateTPFechaVuelo.CalendarMonthBackground = Color.FromArgb(35, 32, 39);
            dateTPFechaVuelo.CalendarTitleBackColor = Color.FromArgb(35, 32, 39);
            dateTPFechaVuelo.CalendarTitleForeColor = Color.WhiteSmoke;
            dateTPFechaVuelo.CalendarTrailingForeColor = Color.WhiteSmoke;
            dateTPFechaVuelo.Cursor = Cursors.Hand;
            dateTPFechaVuelo.Location = new Point(70, 267);
            dateTPFechaVuelo.MinDate = new DateTime(2023, 5, 12, 0, 0, 0, 0);
            dateTPFechaVuelo.Name = "dateTPFechaVuelo";
            dateTPFechaVuelo.Size = new Size(200, 23);
            dateTPFechaVuelo.TabIndex = 65;
            // 
            // comboBPartida
            // 
            comboBPartida.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBPartida.BackColor = Color.FromArgb(35, 32, 39);
            comboBPartida.Cursor = Cursors.Hand;
            comboBPartida.FlatStyle = FlatStyle.Flat;
            comboBPartida.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBPartida.ForeColor = Color.WhiteSmoke;
            comboBPartida.FormattingEnabled = true;
            comboBPartida.Location = new Point(641, 338);
            comboBPartida.Name = "comboBPartida";
            comboBPartida.Size = new Size(121, 23);
            comboBPartida.TabIndex = 66;
            // 
            // comboBDestino
            // 
            comboBDestino.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBDestino.BackColor = Color.FromArgb(35, 32, 39);
            comboBDestino.Cursor = Cursors.Hand;
            comboBDestino.FlatStyle = FlatStyle.Flat;
            comboBDestino.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBDestino.ForeColor = Color.WhiteSmoke;
            comboBDestino.FormattingEnabled = true;
            comboBDestino.Location = new Point(344, 338);
            comboBDestino.Name = "comboBDestino";
            comboBDestino.Size = new Size(121, 23);
            comboBDestino.TabIndex = 67;
            comboBDestino.TextChanged += comboBDestino_TextChanged;
            // 
            // lblHora
            // 
            lblHora.Anchor = AnchorStyles.Bottom;
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblHora.ForeColor = Color.WhiteSmoke;
            lblHora.Location = new Point(283, 270);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(37, 15);
            lblHora.TabIndex = 68;
            lblHora.Text = "Hora:";
            // 
            // numericUDHora
            // 
            numericUDHora.Anchor = AnchorStyles.Bottom;
            numericUDHora.BackColor = Color.FromArgb(35, 32, 39);
            numericUDHora.BorderStyle = BorderStyle.None;
            numericUDHora.Cursor = Cursors.Hand;
            numericUDHora.ForeColor = Color.WhiteSmoke;
            numericUDHora.Location = new Point(326, 271);
            numericUDHora.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            numericUDHora.Name = "numericUDHora";
            numericUDHora.Size = new Size(101, 19);
            numericUDHora.TabIndex = 77;
            numericUDHora.TextAlign = HorizontalAlignment.Center;
            // 
            // numericUDMinutos
            // 
            numericUDMinutos.Anchor = AnchorStyles.Bottom;
            numericUDMinutos.BackColor = Color.FromArgb(35, 32, 39);
            numericUDMinutos.BorderStyle = BorderStyle.None;
            numericUDMinutos.Cursor = Cursors.Hand;
            numericUDMinutos.ForeColor = Color.WhiteSmoke;
            numericUDMinutos.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numericUDMinutos.Location = new Point(498, 271);
            numericUDMinutos.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUDMinutos.Name = "numericUDMinutos";
            numericUDMinutos.Size = new Size(99, 19);
            numericUDMinutos.TabIndex = 78;
            numericUDMinutos.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(440, 271);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 79;
            label1.Text = "Minutos:";
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.Bottom;
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.WhiteSmoke;
            btnAceptar.Location = new Point(283, 409);
            btnAceptar.MaximumSize = new Size(116, 25);
            btnAceptar.MinimumSize = new Size(116, 25);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(116, 25);
            btnAceptar.TabIndex = 80;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.WhiteSmoke;
            btnCancelar.Location = new Point(431, 409);
            btnCancelar.MaximumSize = new Size(116, 25);
            btnCancelar.MinimumSize = new Size(116, 25);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(116, 25);
            btnCancelar.TabIndex = 81;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // checkBInternacional
            // 
            checkBInternacional.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            checkBInternacional.AutoSize = true;
            checkBInternacional.CheckAlign = ContentAlignment.MiddleRight;
            checkBInternacional.Cursor = Cursors.Hand;
            checkBInternacional.FlatAppearance.BorderSize = 0;
            checkBInternacional.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBInternacional.ForeColor = Color.WhiteSmoke;
            checkBInternacional.Location = new Point(21, 340);
            checkBInternacional.Name = "checkBInternacional";
            checkBInternacional.Size = new Size(135, 19);
            checkBInternacional.TabIndex = 82;
            checkBInternacional.Text = "Vuelo Internacional";
            checkBInternacional.UseVisualStyleBackColor = true;
            checkBInternacional.CheckedChanged += checkBInternacional_CheckedChanged;
            // 
            // lblMatricula
            // 
            lblMatricula.Anchor = AnchorStyles.Bottom;
            lblMatricula.AutoSize = true;
            lblMatricula.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMatricula.ForeColor = Color.WhiteSmoke;
            lblMatricula.Location = new Point(614, 271);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(63, 15);
            lblMatricula.TabIndex = 83;
            lblMatricula.Text = "Matricula:";
            // 
            // panel8
            // 
            panel8.BackColor = Color.WhiteSmoke;
            panel8.Location = new Point(829, -9);
            panel8.Name = "panel8";
            panel8.Size = new Size(1, 472);
            panel8.TabIndex = 84;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Location = new Point(0, -9);
            panel1.Name = "panel1";
            panel1.Size = new Size(1, 472);
            panel1.TabIndex = 85;
            // 
            // panel11
            // 
            panel11.BackColor = Color.WhiteSmoke;
            panel11.Location = new Point(2, 454);
            panel11.Name = "panel11";
            panel11.Size = new Size(830, 1);
            panel11.TabIndex = 86;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(830, 1);
            panel2.TabIndex = 87;
            // 
            // FrmAgregarVuelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 32, 39);
            ClientSize = new Size(830, 455);
            Controls.Add(panel2);
            Controls.Add(panel11);
            Controls.Add(panel1);
            Controls.Add(panel8);
            Controls.Add(lblMatricula);
            Controls.Add(checkBInternacional);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label1);
            Controls.Add(numericUDMinutos);
            Controls.Add(numericUDHora);
            Controls.Add(lblHora);
            Controls.Add(comboBDestino);
            Controls.Add(comboBPartida);
            Controls.Add(dateTPFechaVuelo);
            Controls.Add(lblFecha);
            Controls.Add(lblDestino);
            Controls.Add(lblPartida);
            Controls.Add(txtBMatricula);
            Controls.Add(dataGVAviones);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAgregarVuelo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAgregarVuelo";
            Load += FrmAgregarVuelo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGVAviones).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUDHora).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUDMinutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGVAviones;
        private DataGridViewTextBoxColumn ColumMatricula;
        private DataGridViewTextBoxColumn ColumAsientos;
        private DataGridViewTextBoxColumn ColumBaños;
        private DataGridViewTextBoxColumn ColumInternet;
        private DataGridViewTextBoxColumn ColumComida;
        private DataGridViewTextBoxColumn ColumBodega;
        protected TextBox txtBMatricula;
        protected Label lblPartida;
        protected Label lblDestino;
        protected Label lblFecha;
        private DateTimePicker dateTPFechaVuelo;
        private ComboBox comboBPartida;
        private ComboBox comboBDestino;
        protected Label lblHora;
        protected NumericUpDown numericUDHora;
        protected NumericUpDown numericUDMinutos;
        protected Label label1;
        protected Button btnAceptar;
        protected Button btnCancelar;
        private CheckBox checkBInternacional;
        protected Label lblMatricula;
        private Panel panel8;
        private Panel panel1;
        private Panel panel11;
        private Panel panel2;
    }
}