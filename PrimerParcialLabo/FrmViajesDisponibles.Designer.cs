namespace PrimerParcialLabo
{
    partial class FrmViajesDisponibles
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            dataGVVuelos = new DataGridView();
            ColumFecha = new DataGridViewTextBoxColumn();
            ColumOrigen = new DataGridViewTextBoxColumn();
            ColumDestino = new DataGridViewTextBoxColumn();
            ColumPrecio = new DataGridViewTextBoxColumn();
            ColumPrecioP = new DataGridViewTextBoxColumn();
            ColumAvion = new DataGridViewTextBoxColumn();
            dataGVInfoPasajeros = new DataGridView();
            ColumApellido = new DataGridViewTextBoxColumn();
            ColumNombre = new DataGridViewTextBoxColumn();
            ColumDni = new DataGridViewTextBoxColumn();
            ColumEdad = new DataGridViewTextBoxColumn();
            ColumEquipajeMano = new DataGridViewTextBoxColumn();
            ColumEquipajeBodega = new DataGridViewTextBoxColumn();
            ColumPesoEquip = new DataGridViewTextBoxColumn();
            ColumClase = new DataGridViewTextBoxColumn();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGVVuelos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGVInfoPasajeros).BeginInit();
            SuspendLayout();
            // 
            // dataGVVuelos
            // 
            dataGVVuelos.AllowUserToAddRows = false;
            dataGVVuelos.AllowUserToDeleteRows = false;
            dataGVVuelos.AllowUserToResizeColumns = false;
            dataGVVuelos.AllowUserToResizeRows = false;
            dataGVVuelos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGVVuelos.BackgroundColor = Color.FromArgb(35, 32, 39);
            dataGVVuelos.BorderStyle = BorderStyle.None;
            dataGVVuelos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGVVuelos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle7.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGVVuelos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGVVuelos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGVVuelos.Columns.AddRange(new DataGridViewColumn[] { ColumFecha, ColumOrigen, ColumDestino, ColumPrecio, ColumPrecioP, ColumAvion });
            dataGVVuelos.Dock = DockStyle.Fill;
            dataGVVuelos.EnableHeadersVisualStyles = false;
            dataGVVuelos.GridColor = Color.FromArgb(35, 32, 39);
            dataGVVuelos.Location = new Point(0, 0);
            dataGVVuelos.Name = "dataGVVuelos";
            dataGVVuelos.ReadOnly = true;
            dataGVVuelos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.DarkGray;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle8.SelectionForeColor = Color.DarkGray;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGVVuelos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGVVuelos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.LightGray;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGVVuelos.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGVVuelos.RowTemplate.Height = 25;
            dataGVVuelos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGVVuelos.Size = new Size(711, 379);
            dataGVVuelos.TabIndex = 0;
            dataGVVuelos.CellClick += dataGVVuelos_CellClick;
            // 
            // ColumFecha
            // 
            ColumFecha.HeaderText = "FECHA Y HORA";
            ColumFecha.Name = "ColumFecha";
            ColumFecha.ReadOnly = true;
            // 
            // ColumOrigen
            // 
            ColumOrigen.HeaderText = "ORIGEN";
            ColumOrigen.Name = "ColumOrigen";
            ColumOrigen.ReadOnly = true;
            // 
            // ColumDestino
            // 
            ColumDestino.HeaderText = "DESTINO";
            ColumDestino.Name = "ColumDestino";
            ColumDestino.ReadOnly = true;
            // 
            // ColumPrecio
            // 
            ColumPrecio.HeaderText = "PRECIO TURIS.";
            ColumPrecio.Name = "ColumPrecio";
            ColumPrecio.ReadOnly = true;
            // 
            // ColumPrecioP
            // 
            ColumPrecioP.HeaderText = "PRECIO PREM.";
            ColumPrecioP.Name = "ColumPrecioP";
            ColumPrecioP.ReadOnly = true;
            // 
            // ColumAvion
            // 
            ColumAvion.HeaderText = "AVION";
            ColumAvion.Name = "ColumAvion";
            ColumAvion.ReadOnly = true;
            // 
            // dataGVInfoPasajeros
            // 
            dataGVInfoPasajeros.AllowUserToAddRows = false;
            dataGVInfoPasajeros.AllowUserToDeleteRows = false;
            dataGVInfoPasajeros.AllowUserToResizeColumns = false;
            dataGVInfoPasajeros.AllowUserToResizeRows = false;
            dataGVInfoPasajeros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGVInfoPasajeros.BackgroundColor = Color.FromArgb(35, 32, 39);
            dataGVInfoPasajeros.BorderStyle = BorderStyle.None;
            dataGVInfoPasajeros.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGVInfoPasajeros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle10.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGVInfoPasajeros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGVInfoPasajeros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGVInfoPasajeros.Columns.AddRange(new DataGridViewColumn[] { ColumApellido, ColumNombre, ColumDni, ColumEdad, ColumEquipajeMano, ColumEquipajeBodega, ColumPesoEquip, ColumClase });
            dataGVInfoPasajeros.Cursor = Cursors.Hand;
            dataGVInfoPasajeros.Dock = DockStyle.Fill;
            dataGVInfoPasajeros.EnableHeadersVisualStyles = false;
            dataGVInfoPasajeros.GridColor = Color.FromArgb(35, 32, 39);
            dataGVInfoPasajeros.Location = new Point(0, 0);
            dataGVInfoPasajeros.Name = "dataGVInfoPasajeros";
            dataGVInfoPasajeros.ReadOnly = true;
            dataGVInfoPasajeros.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.DarkGray;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle11.SelectionForeColor = Color.DarkGray;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGVInfoPasajeros.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGVInfoPasajeros.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.LightGray;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle12.SelectionForeColor = Color.White;
            dataGVInfoPasajeros.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dataGVInfoPasajeros.RowTemplate.Height = 25;
            dataGVInfoPasajeros.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGVInfoPasajeros.Size = new Size(711, 379);
            dataGVInfoPasajeros.TabIndex = 2;
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
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Bottom;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = Color.LightGray;
            btnVolver.Location = new Point(282, 342);
            btnVolver.MaximumSize = new Size(116, 25);
            btnVolver.MinimumSize = new Size(116, 25);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(116, 25);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmViajesDisponibles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 32, 39);
            ClientSize = new Size(711, 379);
            Controls.Add(btnVolver);
            Controls.Add(dataGVInfoPasajeros);
            Controls.Add(dataGVVuelos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmViajesDisponibles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmViajesDisponibles";
            Load += FrmViajesDisponibles_Load;
            ((System.ComponentModel.ISupportInitialize)dataGVVuelos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGVInfoPasajeros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGVVuelos;
        private DataGridView dataGVInfoPasajeros;
        private DataGridViewTextBoxColumn ColumApellido;
        private DataGridViewTextBoxColumn ColumNombre;
        private DataGridViewTextBoxColumn ColumDni;
        private DataGridViewTextBoxColumn ColumEdad;
        private DataGridViewTextBoxColumn ColumEquipajeMano;
        private DataGridViewTextBoxColumn ColumEquipajeBodega;
        private DataGridViewTextBoxColumn ColumPesoEquip;
        private DataGridViewTextBoxColumn ColumClase;
        private Button btnVolver;
        private DataGridViewTextBoxColumn ColumFecha;
        private DataGridViewTextBoxColumn ColumOrigen;
        private DataGridViewTextBoxColumn ColumDestino;
        private DataGridViewTextBoxColumn ColumPrecio;
        private DataGridViewTextBoxColumn ColumPrecioP;
        private DataGridViewTextBoxColumn ColumAvion;
    }
}