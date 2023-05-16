namespace PrimerParcialLabo
{
    partial class FrmCrudAeronaves
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
            btnVolver = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            btnEliminar = new Button();
            txtBMatricula = new TextBox();
            ColumMatricula = new DataGridViewTextBoxColumn();
            ColumAsientos = new DataGridViewTextBoxColumn();
            ColumBaños = new DataGridViewTextBoxColumn();
            ColumInternet = new DataGridViewTextBoxColumn();
            ColumComida = new DataGridViewTextBoxColumn();
            ColumBodega = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGVAviones).BeginInit();
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
            dataGVAviones.Location = new Point(4, 0);
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
            dataGVAviones.Size = new Size(706, 327);
            dataGVAviones.TabIndex = 4;
            dataGVAviones.CellClick += dataGVAviones_CellClick;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Bottom;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = Color.WhiteSmoke;
            btnVolver.Location = new Point(292, 344);
            btnVolver.MaximumSize = new Size(116, 25);
            btnVolver.MinimumSize = new Size(116, 25);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(116, 25);
            btnVolver.TabIndex = 13;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Bottom;
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.WhiteSmoke;
            btnModificar.Location = new Point(171, 344);
            btnModificar.MaximumSize = new Size(116, 25);
            btnModificar.MinimumSize = new Size(116, 25);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(116, 25);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.WhiteSmoke;
            btnAgregar.Location = new Point(292, 344);
            btnAgregar.MaximumSize = new Size(116, 25);
            btnAgregar.MinimumSize = new Size(116, 25);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(116, 25);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.WhiteSmoke;
            btnEliminar.Location = new Point(418, 344);
            btnEliminar.MaximumSize = new Size(116, 25);
            btnEliminar.MinimumSize = new Size(116, 25);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(116, 25);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtBMatricula
            // 
            txtBMatricula.Anchor = AnchorStyles.Bottom;
            txtBMatricula.BackColor = Color.FromArgb(35, 32, 39);
            txtBMatricula.BorderStyle = BorderStyle.None;
            txtBMatricula.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBMatricula.ForeColor = Color.WhiteSmoke;
            txtBMatricula.Location = new Point(553, 347);
            txtBMatricula.MaxLength = 8;
            txtBMatricula.Name = "txtBMatricula";
            txtBMatricula.PlaceholderText = "Filtrar por matricula";
            txtBMatricula.Size = new Size(143, 15);
            txtBMatricula.TabIndex = 44;
            txtBMatricula.TextChanged += txtBMatricula_TextChanged;
            // 
            // ColumMatricula
            // 
            ColumMatricula.HeaderText = "MATRICULA";
            ColumMatricula.Name = "ColumMatricula";
            ColumMatricula.ReadOnly = true;
            ColumMatricula.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumAsientos
            // 
            ColumAsientos.HeaderText = "CANT. ASIENTOS";
            ColumAsientos.Name = "ColumAsientos";
            ColumAsientos.ReadOnly = true;
            ColumAsientos.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumBaños
            // 
            ColumBaños.HeaderText = "CANT. BAÑOS";
            ColumBaños.Name = "ColumBaños";
            ColumBaños.ReadOnly = true;
            ColumBaños.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumInternet
            // 
            ColumInternet.HeaderText = "INTERNET";
            ColumInternet.Name = "ColumInternet";
            ColumInternet.ReadOnly = true;
            ColumInternet.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumComida
            // 
            ColumComida.HeaderText = "COMIDA";
            ColumComida.Name = "ColumComida";
            ColumComida.ReadOnly = true;
            ColumComida.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumBodega
            // 
            ColumBodega.HeaderText = "CAPACIDAD BODEGA";
            ColumBodega.Name = "ColumBodega";
            ColumBodega.ReadOnly = true;
            ColumBodega.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmCrudAeronaves
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 32, 39);
            ClientSize = new Size(711, 379);
            Controls.Add(txtBMatricula);
            Controls.Add(btnVolver);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(dataGVAviones);
            ForeColor = Color.FromArgb(35, 32, 39);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCrudAeronaves";
            Text = "FrmCrudAeronaves";
            Load += FrmCrudAeronaves_Load;
            ((System.ComponentModel.ISupportInitialize)dataGVAviones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGVAviones;
        private Button btnVolver;
        private Button btnModificar;
        private Button btnAgregar;
        private Button btnEliminar;
        protected TextBox txtBMatricula;
        private DataGridViewTextBoxColumn ColumMatricula;
        private DataGridViewTextBoxColumn ColumAsientos;
        private DataGridViewTextBoxColumn ColumBaños;
        private DataGridViewTextBoxColumn ColumInternet;
        private DataGridViewTextBoxColumn ColumComida;
        private DataGridViewTextBoxColumn ColumBodega;
    }
}