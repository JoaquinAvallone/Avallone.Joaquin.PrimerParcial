namespace PrimerParcialLabo
{
    partial class FrmCrudPasajero
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
            dataGVPasajeros = new DataGridView();
            ColumApellido = new DataGridViewTextBoxColumn();
            ColumNombre = new DataGridViewTextBoxColumn();
            ColumDni = new DataGridViewTextBoxColumn();
            ColumEdad = new DataGridViewTextBoxColumn();
            ColumEquipajeMano = new DataGridViewTextBoxColumn();
            ColumEquipajeBodega = new DataGridViewTextBoxColumn();
            ColumPesoEquip = new DataGridViewTextBoxColumn();
            ColumClase = new DataGridViewTextBoxColumn();
            btnEliminar = new Button();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGVPasajeros).BeginInit();
            SuspendLayout();
            // 
            // dataGVPasajeros
            // 
            dataGVPasajeros.AllowUserToAddRows = false;
            dataGVPasajeros.AllowUserToDeleteRows = false;
            dataGVPasajeros.AllowUserToResizeColumns = false;
            dataGVPasajeros.AllowUserToResizeRows = false;
            dataGVPasajeros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGVPasajeros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGVPasajeros.BackgroundColor = Color.FromArgb(35, 32, 39);
            dataGVPasajeros.BorderStyle = BorderStyle.None;
            dataGVPasajeros.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGVPasajeros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle1.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGVPasajeros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGVPasajeros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGVPasajeros.Columns.AddRange(new DataGridViewColumn[] { ColumApellido, ColumNombre, ColumDni, ColumEdad, ColumEquipajeMano, ColumEquipajeBodega, ColumPesoEquip, ColumClase });
            dataGVPasajeros.Cursor = Cursors.Hand;
            dataGVPasajeros.EnableHeadersVisualStyles = false;
            dataGVPasajeros.GridColor = Color.FromArgb(35, 32, 39);
            dataGVPasajeros.Location = new Point(4, 6);
            dataGVPasajeros.Name = "dataGVPasajeros";
            dataGVPasajeros.ReadOnly = true;
            dataGVPasajeros.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.DarkGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle2.SelectionForeColor = Color.DarkGray;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGVPasajeros.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGVPasajeros.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGVPasajeros.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGVPasajeros.RowTemplate.Height = 25;
            dataGVPasajeros.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGVPasajeros.Size = new Size(727, 345);
            dataGVPasajeros.TabIndex = 3;
            dataGVPasajeros.CellClick += dataGVPasajeros_CellClick;
            // 
            // ColumApellido
            // 
            ColumApellido.HeaderText = "APELLIDO";
            ColumApellido.Name = "ColumApellido";
            ColumApellido.ReadOnly = true;
            // 
            // ColumNombre
            // 
            ColumNombre.HeaderText = "NOMBRE";
            ColumNombre.Name = "ColumNombre";
            ColumNombre.ReadOnly = true;
            // 
            // ColumDni
            // 
            ColumDni.HeaderText = "DNI";
            ColumDni.Name = "ColumDni";
            ColumDni.ReadOnly = true;
            // 
            // ColumEdad
            // 
            ColumEdad.HeaderText = "EDAD";
            ColumEdad.Name = "ColumEdad";
            ColumEdad.ReadOnly = true;
            // 
            // ColumEquipajeMano
            // 
            ColumEquipajeMano.HeaderText = "EQUIPAJE MANO";
            ColumEquipajeMano.Name = "ColumEquipajeMano";
            ColumEquipajeMano.ReadOnly = true;
            // 
            // ColumEquipajeBodega
            // 
            ColumEquipajeBodega.HeaderText = "EQUIPAJE BODEGA";
            ColumEquipajeBodega.Name = "ColumEquipajeBodega";
            ColumEquipajeBodega.ReadOnly = true;
            // 
            // ColumPesoEquip
            // 
            ColumPesoEquip.HeaderText = "PESO EQUIPAJE";
            ColumPesoEquip.Name = "ColumPesoEquip";
            ColumPesoEquip.ReadOnly = true;
            // 
            // ColumClase
            // 
            ColumClase.HeaderText = "CLASE";
            ColumClase.Name = "ColumClase";
            ColumClase.ReadOnly = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.WhiteSmoke;
            btnEliminar.Location = new Point(432, 358);
            btnEliminar.MaximumSize = new Size(116, 25);
            btnEliminar.MinimumSize = new Size(116, 25);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(116, 25);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.WhiteSmoke;
            btnAgregar.Location = new Point(304, 357);
            btnAgregar.MaximumSize = new Size(116, 25);
            btnAgregar.MinimumSize = new Size(116, 25);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(116, 25);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Bottom;
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.WhiteSmoke;
            btnModificar.Location = new Point(189, 358);
            btnModificar.MaximumSize = new Size(116, 25);
            btnModificar.MinimumSize = new Size(116, 25);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(116, 25);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Bottom;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = Color.WhiteSmoke;
            btnVolver.Location = new Point(615, 358);
            btnVolver.MaximumSize = new Size(116, 25);
            btnVolver.MinimumSize = new Size(116, 25);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(116, 25);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmCrudPasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 32, 39);
            ClientSize = new Size(735, 393);
            Controls.Add(btnVolver);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(dataGVPasajeros);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCrudPasajero";
            Text = "FrmCrudPasajero";
            Load += FrmCrudPasajero_Load;
            ((System.ComponentModel.ISupportInitialize)dataGVPasajeros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGVPasajeros;
        private DataGridViewTextBoxColumn ColumApellido;
        private DataGridViewTextBoxColumn ColumNombre;
        private DataGridViewTextBoxColumn ColumDni;
        private DataGridViewTextBoxColumn ColumEdad;
        private DataGridViewTextBoxColumn ColumEquipajeMano;
        private DataGridViewTextBoxColumn ColumEquipajeBodega;
        private DataGridViewTextBoxColumn ColumPesoEquip;
        private DataGridViewTextBoxColumn ColumClase;
        private Button btnEliminar;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnVolver;
    }
}