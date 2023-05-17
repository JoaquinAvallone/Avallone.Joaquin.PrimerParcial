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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dataGVVuelos = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ColumPartida = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            ColumPrecioTuris = new DataGridViewTextBoxColumn();
            ColumPrecioPrem = new DataGridViewTextBoxColumn();
            ColumMatricula = new DataGridViewTextBoxColumn();
            ColumDuracion = new DataGridViewTextBoxColumn();
            dataGVInfoPasajeros = new DataGridView();
            btnVolver = new Button();
            ColumFecha = new DataGridViewTextBoxColumn();
            ColumOrigen = new DataGridViewTextBoxColumn();
            ColumDestino = new DataGridViewTextBoxColumn();
            ColumPrecio = new DataGridViewTextBoxColumn();
            ColumPrecioP = new DataGridViewTextBoxColumn();
            ColumAvion = new DataGridViewTextBoxColumn();
            ColumApellido = new DataGridViewTextBoxColumn();
            ColumNombre = new DataGridViewTextBoxColumn();
            ColumDni = new DataGridViewTextBoxColumn();
            ColumEdad = new DataGridViewTextBoxColumn();
            ColumEquipajeMano = new DataGridViewTextBoxColumn();
            ColumEquipajeBodega = new DataGridViewTextBoxColumn();
            ColumPesoEquip = new DataGridViewTextBoxColumn();
            ColumClase = new DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle1.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGVVuelos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGVVuelos.ColumnHeadersHeight = 36;
            dataGVVuelos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGVVuelos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, ColumPartida, dataGridViewTextBoxColumn2, ColumPrecioTuris, ColumPrecioPrem, ColumMatricula, ColumDuracion });
            dataGVVuelos.Cursor = Cursors.Hand;
            dataGVVuelos.Dock = DockStyle.Fill;
            dataGVVuelos.EnableHeadersVisualStyles = false;
            dataGVVuelos.GridColor = Color.FromArgb(35, 32, 39);
            dataGVVuelos.Location = new Point(0, 0);
            dataGVVuelos.Name = "dataGVVuelos";
            dataGVVuelos.ReadOnly = true;
            dataGVVuelos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.DarkGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle2.SelectionForeColor = Color.DarkGray;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGVVuelos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGVVuelos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGVVuelos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGVVuelos.RowTemplate.Height = 25;
            dataGVVuelos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGVVuelos.Size = new Size(711, 379);
            dataGVVuelos.TabIndex = 0;
            dataGVVuelos.CellClick += dataGVVuelos_CellClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "FECHA Y HORA";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumPartida
            // 
            ColumPartida.HeaderText = "CIUDAD PARTIDA";
            ColumPartida.Name = "ColumPartida";
            ColumPartida.ReadOnly = true;
            ColumPartida.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "DESTINO";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumPrecioTuris
            // 
            ColumPrecioTuris.HeaderText = "PRECIO TURISTA +IVA";
            ColumPrecioTuris.Name = "ColumPrecioTuris";
            ColumPrecioTuris.ReadOnly = true;
            ColumPrecioTuris.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumPrecioPrem
            // 
            ColumPrecioPrem.HeaderText = "PRECIO PREMIUM +IVA";
            ColumPrecioPrem.Name = "ColumPrecioPrem";
            ColumPrecioPrem.ReadOnly = true;
            ColumPrecioPrem.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumMatricula
            // 
            ColumMatricula.HeaderText = "MATRICULA";
            ColumMatricula.Name = "ColumMatricula";
            ColumMatricula.ReadOnly = true;
            ColumMatricula.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumDuracion
            // 
            ColumDuracion.HeaderText = "DURACION";
            ColumDuracion.Name = "ColumDuracion";
            ColumDuracion.ReadOnly = true;
            ColumDuracion.SortMode = DataGridViewColumnSortMode.NotSortable;
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle4.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGVInfoPasajeros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.DarkGray;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle5.SelectionForeColor = Color.DarkGray;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGVInfoPasajeros.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGVInfoPasajeros.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.LightGray;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGVInfoPasajeros.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGVInfoPasajeros.RowTemplate.Height = 25;
            dataGVInfoPasajeros.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGVInfoPasajeros.Size = new Size(711, 379);
            dataGVInfoPasajeros.TabIndex = 2;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Bottom;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = Color.WhiteSmoke;
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
            // ColumFecha
            // 
            ColumFecha.HeaderText = "FECHA Y HORA";
            ColumFecha.Name = "ColumFecha";
            ColumFecha.Width = 115;
            // 
            // ColumOrigen
            // 
            ColumOrigen.HeaderText = "ORIGEN";
            ColumOrigen.Name = "ColumOrigen";
            ColumOrigen.Width = 116;
            // 
            // ColumDestino
            // 
            ColumDestino.HeaderText = "DESTINO";
            ColumDestino.Name = "ColumDestino";
            ColumDestino.Width = 115;
            // 
            // ColumPrecio
            // 
            ColumPrecio.HeaderText = "PRECIO TURIS.";
            ColumPrecio.Name = "ColumPrecio";
            ColumPrecio.Width = 116;
            // 
            // ColumPrecioP
            // 
            ColumPrecioP.HeaderText = "PRECIO PREM.";
            ColumPrecioP.Name = "ColumPrecioP";
            ColumPrecioP.Width = 115;
            // 
            // ColumAvion
            // 
            ColumAvion.HeaderText = "AVION";
            ColumAvion.Name = "ColumAvion";
            ColumAvion.Width = 116;
            // 
            // ColumApellido
            // 
            ColumApellido.HeaderText = "APELLIDO";
            ColumApellido.Name = "ColumApellido";
            ColumApellido.ReadOnly = true;
            ColumApellido.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumNombre
            // 
            ColumNombre.HeaderText = "NOMBRE";
            ColumNombre.Name = "ColumNombre";
            ColumNombre.ReadOnly = true;
            ColumNombre.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumDni
            // 
            ColumDni.HeaderText = "DNI";
            ColumDni.Name = "ColumDni";
            ColumDni.ReadOnly = true;
            ColumDni.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumEdad
            // 
            ColumEdad.HeaderText = "EDAD";
            ColumEdad.Name = "ColumEdad";
            ColumEdad.ReadOnly = true;
            ColumEdad.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumEquipajeMano
            // 
            ColumEquipajeMano.HeaderText = "EQUIPAJE MANO";
            ColumEquipajeMano.Name = "ColumEquipajeMano";
            ColumEquipajeMano.ReadOnly = true;
            ColumEquipajeMano.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumEquipajeBodega
            // 
            ColumEquipajeBodega.HeaderText = "EQUIPAJE BODEGA";
            ColumEquipajeBodega.Name = "ColumEquipajeBodega";
            ColumEquipajeBodega.ReadOnly = true;
            ColumEquipajeBodega.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumPesoEquip
            // 
            ColumPesoEquip.HeaderText = "PESO EQUIPAJE";
            ColumPesoEquip.Name = "ColumPesoEquip";
            ColumPesoEquip.ReadOnly = true;
            ColumPesoEquip.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumClase
            // 
            ColumClase.HeaderText = "CLASE";
            ColumClase.Name = "ColumClase";
            ColumClase.ReadOnly = true;
            ColumClase.SortMode = DataGridViewColumnSortMode.NotSortable;
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
        private Button btnVolver;
        private DataGridViewTextBoxColumn ColumDuracionVuelo;
        private DataGridViewTextBoxColumn ColumFecha;
        private DataGridViewTextBoxColumn ColumOrigen;
        private DataGridViewTextBoxColumn ColumDestino;
        private DataGridViewTextBoxColumn ColumPrecio;
        private DataGridViewTextBoxColumn ColumPrecioP;
        private DataGridViewTextBoxColumn ColumAvion;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ColumPartida;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn ColumPrecioTuris;
        private DataGridViewTextBoxColumn ColumPrecioPrem;
        private DataGridViewTextBoxColumn ColumMatricula;
        private DataGridViewTextBoxColumn ColumDuracion;
        private DataGridViewTextBoxColumn ColumApellido;
        private DataGridViewTextBoxColumn ColumNombre;
        private DataGridViewTextBoxColumn ColumDni;
        private DataGridViewTextBoxColumn ColumEdad;
        private DataGridViewTextBoxColumn ColumEquipajeMano;
        private DataGridViewTextBoxColumn ColumEquipajeBodega;
        private DataGridViewTextBoxColumn ColumPesoEquip;
        private DataGridViewTextBoxColumn ColumClase;
    }
}