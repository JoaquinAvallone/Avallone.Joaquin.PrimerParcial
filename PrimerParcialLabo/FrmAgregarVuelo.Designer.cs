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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            dateTimePicker1 = new DateTimePicker();
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle4.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGVAviones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGVAviones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGVAviones.Columns.AddRange(new DataGridViewColumn[] { ColumMatricula, ColumAsientos, ColumBaños, ColumInternet, ColumComida, ColumBodega });
            dataGVAviones.Cursor = Cursors.Hand;
            dataGVAviones.EnableHeadersVisualStyles = false;
            dataGVAviones.GridColor = Color.FromArgb(35, 32, 39);
            dataGVAviones.Location = new Point(2, 1);
            dataGVAviones.Name = "dataGVAviones";
            dataGVAviones.ReadOnly = true;
            dataGVAviones.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.DarkGray;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle5.SelectionForeColor = Color.DarkGray;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGVAviones.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGVAviones.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.LightGray;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGVAviones.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGVAviones.RowTemplate.Height = 25;
            dataGVAviones.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGVAviones.Size = new Size(706, 210);
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
            txtBMatricula.Location = new Point(549, 275);
            txtBMatricula.MaxLength = 8;
            txtBMatricula.Name = "txtBMatricula";
            txtBMatricula.PlaceholderText = "Buscar...";
            txtBMatricula.Size = new Size(143, 16);
            txtBMatricula.TabIndex = 45;
            txtBMatricula.TextChanged += txtBMatricula_TextChanged_1;
            // 
            // lblPartida
            // 
            lblPartida.AutoSize = true;
            lblPartida.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPartida.ForeColor = Color.WhiteSmoke;
            lblPartida.Location = new Point(6, 329);
            lblPartida.Name = "lblPartida";
            lblPartida.Size = new Size(105, 15);
            lblPartida.TabIndex = 56;
            lblPartida.Text = "Ciudad De Partida:";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDestino.ForeColor = Color.WhiteSmoke;
            lblDestino.Location = new Point(2, 276);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(109, 15);
            lblDestino.TabIndex = 57;
            lblDestino.Text = "Ciudad De Destino:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFecha.ForeColor = Color.WhiteSmoke;
            lblFecha.Location = new Point(277, 230);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(41, 15);
            lblFecha.TabIndex = 58;
            lblFecha.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.WhiteSmoke;
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(35, 32, 39);
            dateTimePicker1.CalendarTitleBackColor = Color.FromArgb(35, 32, 39);
            dateTimePicker1.CalendarTitleForeColor = Color.WhiteSmoke;
            dateTimePicker1.CalendarTrailingForeColor = Color.WhiteSmoke;
            dateTimePicker1.Cursor = Cursors.Hand;
            dateTimePicker1.Location = new Point(324, 227);
            dateTimePicker1.MinDate = new DateTime(2023, 5, 11, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 65;
            // 
            // comboBPartida
            // 
            comboBPartida.BackColor = Color.FromArgb(35, 32, 39);
            comboBPartida.Cursor = Cursors.Hand;
            comboBPartida.FlatStyle = FlatStyle.Flat;
            comboBPartida.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBPartida.ForeColor = Color.WhiteSmoke;
            comboBPartida.FormattingEnabled = true;
            comboBPartida.Location = new Point(117, 326);
            comboBPartida.Name = "comboBPartida";
            comboBPartida.Size = new Size(121, 23);
            comboBPartida.TabIndex = 66;
            // 
            // comboBDestino
            // 
            comboBDestino.BackColor = Color.FromArgb(35, 32, 39);
            comboBDestino.Cursor = Cursors.Hand;
            comboBDestino.FlatStyle = FlatStyle.Flat;
            comboBDestino.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBDestino.ForeColor = Color.WhiteSmoke;
            comboBDestino.FormattingEnabled = true;
            comboBDestino.Location = new Point(117, 273);
            comboBDestino.Name = "comboBDestino";
            comboBDestino.Size = new Size(121, 23);
            comboBDestino.TabIndex = 67;
            comboBDestino.TextChanged += comboBDestino_TextChanged;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblHora.ForeColor = Color.WhiteSmoke;
            lblHora.Location = new Point(277, 276);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(36, 15);
            lblHora.TabIndex = 68;
            lblHora.Text = "Hora:";
            // 
            // numericUDHora
            // 
            numericUDHora.BackColor = Color.FromArgb(35, 32, 39);
            numericUDHora.BorderStyle = BorderStyle.None;
            numericUDHora.Cursor = Cursors.Hand;
            numericUDHora.ForeColor = Color.WhiteSmoke;
            numericUDHora.Location = new Point(335, 276);
            numericUDHora.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            numericUDHora.Name = "numericUDHora";
            numericUDHora.Size = new Size(99, 19);
            numericUDHora.TabIndex = 77;
            numericUDHora.TextAlign = HorizontalAlignment.Center;
            // 
            // numericUDMinutos
            // 
            numericUDMinutos.BackColor = Color.FromArgb(35, 32, 39);
            numericUDMinutos.BorderStyle = BorderStyle.None;
            numericUDMinutos.Cursor = Cursors.Hand;
            numericUDMinutos.ForeColor = Color.WhiteSmoke;
            numericUDMinutos.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numericUDMinutos.Location = new Point(339, 327);
            numericUDMinutos.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUDMinutos.Name = "numericUDMinutos";
            numericUDMinutos.Size = new Size(95, 19);
            numericUDMinutos.TabIndex = 78;
            numericUDMinutos.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(277, 329);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 79;
            label1.Text = "Minutos:";
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.Bottom;
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.WhiteSmoke;
            btnAceptar.Location = new Point(461, 321);
            btnAceptar.MaximumSize = new Size(116, 25);
            btnAceptar.MinimumSize = new Size(116, 25);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(116, 25);
            btnAceptar.TabIndex = 80;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.WhiteSmoke;
            btnCancelar.Location = new Point(583, 321);
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
            checkBInternacional.AutoSize = true;
            checkBInternacional.CheckAlign = ContentAlignment.MiddleRight;
            checkBInternacional.Cursor = Cursors.Hand;
            checkBInternacional.FlatAppearance.BorderSize = 0;
            checkBInternacional.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBInternacional.ForeColor = Color.WhiteSmoke;
            checkBInternacional.Location = new Point(2, 232);
            checkBInternacional.Name = "checkBInternacional";
            checkBInternacional.Size = new Size(130, 19);
            checkBInternacional.TabIndex = 82;
            checkBInternacional.Text = "Vuelo Internacional";
            checkBInternacional.UseVisualStyleBackColor = true;
            checkBInternacional.CheckedChanged += checkBInternacional_CheckedChanged;
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMatricula.ForeColor = Color.WhiteSmoke;
            lblMatricula.Location = new Point(488, 275);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(60, 15);
            lblMatricula.TabIndex = 83;
            lblMatricula.Text = "Matricula:";
            // 
            // FrmAgregarVuelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 32, 39);
            ClientSize = new Size(711, 379);
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
            Controls.Add(dateTimePicker1);
            Controls.Add(lblFecha);
            Controls.Add(lblDestino);
            Controls.Add(lblPartida);
            Controls.Add(txtBMatricula);
            Controls.Add(dataGVAviones);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAgregarVuelo";
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
        private DateTimePicker dateTimePicker1;
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
    }
}