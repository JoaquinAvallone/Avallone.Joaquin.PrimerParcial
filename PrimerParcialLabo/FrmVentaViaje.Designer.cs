namespace PrimerParcialLabo
{
    partial class FrmVentaViaje
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
            ColumFecha = new DataGridViewTextBoxColumn();
            ColumOrigen = new DataGridViewTextBoxColumn();
            ColumDestino = new DataGridViewTextBoxColumn();
            ColumPrecio = new DataGridViewTextBoxColumn();
            ColumPrecioP = new DataGridViewTextBoxColumn();
            ColumPrecioTSinIva = new DataGridViewTextBoxColumn();
            ColumPrecioPSinIva = new DataGridViewTextBoxColumn();
            ColumAsientosTuris = new DataGridViewTextBoxColumn();
            ColumAsientosPrem = new DataGridViewTextBoxColumn();
            ColumWifi = new DataGridViewTextBoxColumn();
            ColumComida = new DataGridViewTextBoxColumn();
            ColumAvion = new DataGridViewTextBoxColumn();
            checkBInternet = new CheckBox();
            checkBComida = new CheckBox();
            btnVolver = new Button();
            btnCrear = new Button();
            btnAsignar = new Button();
            dataGVPasajeros = new DataGridView();
            ColumApellido = new DataGridViewTextBoxColumn();
            ColumNombre = new DataGridViewTextBoxColumn();
            ColumDni = new DataGridViewTextBoxColumn();
            ColumEdad = new DataGridViewTextBoxColumn();
            ColumEquipajeMano = new DataGridViewTextBoxColumn();
            ColumEquipajeBodega = new DataGridViewTextBoxColumn();
            ColumPesoEquip = new DataGridViewTextBoxColumn();
            ColumClase = new DataGridViewTextBoxColumn();
            txtBDni = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            btnVolverPasajeros = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGVVuelos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGVPasajeros).BeginInit();
            SuspendLayout();
            // 
            // dataGVVuelos
            // 
            dataGVVuelos.AllowUserToAddRows = false;
            dataGVVuelos.AllowUserToDeleteRows = false;
            dataGVVuelos.AllowUserToResizeColumns = false;
            dataGVVuelos.AllowUserToResizeRows = false;
            dataGVVuelos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGVVuelos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGVVuelos.BackgroundColor = Color.FromArgb(35, 32, 39);
            dataGVVuelos.BorderStyle = BorderStyle.None;
            dataGVVuelos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGVVuelos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle1.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGVVuelos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGVVuelos.ColumnHeadersHeight = 42;
            dataGVVuelos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGVVuelos.Columns.AddRange(new DataGridViewColumn[] { ColumFecha, ColumOrigen, ColumDestino, ColumPrecio, ColumPrecioP, ColumPrecioTSinIva, ColumPrecioPSinIva, ColumAsientosTuris, ColumAsientosPrem, ColumWifi, ColumComida, ColumAvion });
            dataGVVuelos.Cursor = Cursors.Hand;
            dataGVVuelos.EnableHeadersVisualStyles = false;
            dataGVVuelos.GridColor = Color.FromArgb(35, 32, 39);
            dataGVVuelos.Location = new Point(3, 1);
            dataGVVuelos.MultiSelect = false;
            dataGVVuelos.Name = "dataGVVuelos";
            dataGVVuelos.ReadOnly = true;
            dataGVVuelos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.DarkGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle2.SelectionForeColor = Color.DarkGray;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGVVuelos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGVVuelos.RowHeadersVisible = false;
            dataGVVuelos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGVVuelos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGVVuelos.RowTemplate.Height = 25;
            dataGVVuelos.ScrollBars = ScrollBars.Horizontal;
            dataGVVuelos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGVVuelos.Size = new Size(709, 342);
            dataGVVuelos.TabIndex = 1;
            dataGVVuelos.CellClick += dataGVVuelos_CellClick;
            // 
            // ColumFecha
            // 
            ColumFecha.HeaderText = "FECHA/HS.";
            ColumFecha.Name = "ColumFecha";
            ColumFecha.ReadOnly = true;
            ColumFecha.Resizable = DataGridViewTriState.False;
            ColumFecha.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumOrigen
            // 
            ColumOrigen.HeaderText = "ORIGEN";
            ColumOrigen.Name = "ColumOrigen";
            ColumOrigen.ReadOnly = true;
            ColumOrigen.Resizable = DataGridViewTriState.False;
            ColumOrigen.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumDestino
            // 
            ColumDestino.HeaderText = "DESTINO";
            ColumDestino.Name = "ColumDestino";
            ColumDestino.ReadOnly = true;
            ColumDestino.Resizable = DataGridViewTriState.False;
            ColumDestino.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumPrecio
            // 
            ColumPrecio.HeaderText = "PRECIO TURIS. C/IVA";
            ColumPrecio.Name = "ColumPrecio";
            ColumPrecio.ReadOnly = true;
            ColumPrecio.Resizable = DataGridViewTriState.False;
            ColumPrecio.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumPrecioP
            // 
            ColumPrecioP.HeaderText = "PRECIO PREM. C/IVA";
            ColumPrecioP.Name = "ColumPrecioP";
            ColumPrecioP.ReadOnly = true;
            ColumPrecioP.Resizable = DataGridViewTriState.False;
            ColumPrecioP.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumPrecioTSinIva
            // 
            ColumPrecioTSinIva.HeaderText = "PRECION TURIS. S/IVA";
            ColumPrecioTSinIva.Name = "ColumPrecioTSinIva";
            ColumPrecioTSinIva.ReadOnly = true;
            ColumPrecioTSinIva.Resizable = DataGridViewTriState.False;
            ColumPrecioTSinIva.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumPrecioPSinIva
            // 
            ColumPrecioPSinIva.HeaderText = "PRECIO PREM. S/IVA";
            ColumPrecioPSinIva.Name = "ColumPrecioPSinIva";
            ColumPrecioPSinIva.ReadOnly = true;
            ColumPrecioPSinIva.Resizable = DataGridViewTriState.False;
            ColumPrecioPSinIva.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumAsientosTuris
            // 
            ColumAsientosTuris.HeaderText = "ASIENTOS TURIS.";
            ColumAsientosTuris.Name = "ColumAsientosTuris";
            ColumAsientosTuris.ReadOnly = true;
            ColumAsientosTuris.Resizable = DataGridViewTriState.False;
            ColumAsientosTuris.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumAsientosPrem
            // 
            ColumAsientosPrem.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ColumAsientosPrem.HeaderText = "ASIENTOS PREM.";
            ColumAsientosPrem.Name = "ColumAsientosPrem";
            ColumAsientosPrem.ReadOnly = true;
            ColumAsientosPrem.Resizable = DataGridViewTriState.False;
            ColumAsientosPrem.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColumAsientosPrem.Width = 90;
            // 
            // ColumWifi
            // 
            ColumWifi.HeaderText = "WIFI";
            ColumWifi.Name = "ColumWifi";
            ColumWifi.ReadOnly = true;
            ColumWifi.Resizable = DataGridViewTriState.False;
            ColumWifi.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumComida
            // 
            ColumComida.HeaderText = "COMIDA";
            ColumComida.Name = "ColumComida";
            ColumComida.ReadOnly = true;
            ColumComida.Resizable = DataGridViewTriState.False;
            ColumComida.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumAvion
            // 
            ColumAvion.HeaderText = "AVION";
            ColumAvion.Name = "ColumAvion";
            ColumAvion.ReadOnly = true;
            ColumAvion.Resizable = DataGridViewTriState.False;
            ColumAvion.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // checkBInternet
            // 
            checkBInternet.Anchor = AnchorStyles.Bottom;
            checkBInternet.AutoSize = true;
            checkBInternet.Cursor = Cursors.Hand;
            checkBInternet.FlatAppearance.BorderSize = 0;
            checkBInternet.FlatStyle = FlatStyle.Flat;
            checkBInternet.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            checkBInternet.ForeColor = Color.LightGray;
            checkBInternet.Location = new Point(281, 348);
            checkBInternet.Name = "checkBInternet";
            checkBInternet.Size = new Size(73, 18);
            checkBInternet.TabIndex = 2;
            checkBInternet.Text = "INTERNET";
            checkBInternet.UseVisualStyleBackColor = true;
            checkBInternet.CheckedChanged += checkBInternet_CheckedChanged;
            // 
            // checkBComida
            // 
            checkBComida.Anchor = AnchorStyles.Bottom;
            checkBComida.AutoSize = true;
            checkBComida.Cursor = Cursors.Hand;
            checkBComida.FlatAppearance.BorderSize = 0;
            checkBComida.FlatStyle = FlatStyle.Flat;
            checkBComida.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            checkBComida.ForeColor = Color.LightGray;
            checkBComida.Location = new Point(378, 348);
            checkBComida.Name = "checkBComida";
            checkBComida.Size = new Size(67, 18);
            checkBComida.TabIndex = 3;
            checkBComida.Text = "COMIDA";
            checkBComida.UseVisualStyleBackColor = true;
            checkBComida.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Bottom;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = Color.WhiteSmoke;
            btnVolver.Location = new Point(300, 345);
            btnVolver.MaximumSize = new Size(116, 25);
            btnVolver.MinimumSize = new Size(116, 25);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(116, 25);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnCrear
            // 
            btnCrear.Anchor = AnchorStyles.Bottom;
            btnCrear.Cursor = Cursors.Hand;
            btnCrear.FlatAppearance.BorderSize = 0;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCrear.ForeColor = Color.WhiteSmoke;
            btnCrear.Location = new Point(416, 345);
            btnCrear.MaximumSize = new Size(116, 25);
            btnCrear.MinimumSize = new Size(116, 25);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(116, 25);
            btnCrear.TabIndex = 5;
            btnCrear.Text = "Crear pasajero";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnAsignar
            // 
            btnAsignar.Anchor = AnchorStyles.Bottom;
            btnAsignar.Cursor = Cursors.Hand;
            btnAsignar.FlatAppearance.BorderSize = 0;
            btnAsignar.FlatStyle = FlatStyle.Flat;
            btnAsignar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAsignar.ForeColor = Color.WhiteSmoke;
            btnAsignar.Location = new Point(161, 345);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(135, 25);
            btnAsignar.TabIndex = 6;
            btnAsignar.Text = "Pasajero existente";
            btnAsignar.UseVisualStyleBackColor = true;
            btnAsignar.Click += btnAsignar_Click_1;
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle4.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGVPasajeros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGVPasajeros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGVPasajeros.Columns.AddRange(new DataGridViewColumn[] { ColumApellido, ColumNombre, ColumDni, ColumEdad, ColumEquipajeMano, ColumEquipajeBodega, ColumPesoEquip, ColumClase });
            dataGVPasajeros.Cursor = Cursors.Hand;
            dataGVPasajeros.EnableHeadersVisualStyles = false;
            dataGVPasajeros.GridColor = Color.FromArgb(35, 32, 39);
            dataGVPasajeros.Location = new Point(3, 1);
            dataGVPasajeros.MultiSelect = false;
            dataGVPasajeros.Name = "dataGVPasajeros";
            dataGVPasajeros.ReadOnly = true;
            dataGVPasajeros.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.DarkGray;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle5.SelectionForeColor = Color.DarkGray;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGVPasajeros.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGVPasajeros.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.LightGray;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGVPasajeros.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGVPasajeros.RowTemplate.Height = 25;
            dataGVPasajeros.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGVPasajeros.Size = new Size(709, 338);
            dataGVPasajeros.TabIndex = 7;
            dataGVPasajeros.CellClick += dataGVPasajeros_CellClick;
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
            // 
            // txtBDni
            // 
            txtBDni.Anchor = AnchorStyles.Bottom;
            txtBDni.BackColor = Color.FromArgb(35, 32, 39);
            txtBDni.BorderStyle = BorderStyle.None;
            txtBDni.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBDni.ForeColor = Color.WhiteSmoke;
            txtBDni.Location = new Point(556, 349);
            txtBDni.MaxLength = 8;
            txtBDni.Name = "txtBDni";
            txtBDni.PlaceholderText = "Filtrar por DNI";
            txtBDni.Size = new Size(143, 15);
            txtBDni.TabIndex = 44;
            txtBDni.TextChanged += txtBDni_TextChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.Bottom;
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.WhiteSmoke;
            btnAceptar.Location = new Point(235, 345);
            btnAceptar.MaximumSize = new Size(116, 25);
            btnAceptar.MinimumSize = new Size(116, 25);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(116, 25);
            btnAceptar.TabIndex = 45;
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
            btnCancelar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.WhiteSmoke;
            btnCancelar.Location = new Point(358, 345);
            btnCancelar.MaximumSize = new Size(116, 25);
            btnCancelar.MinimumSize = new Size(116, 25);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(116, 25);
            btnCancelar.TabIndex = 46;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnVolverPasajeros
            // 
            btnVolverPasajeros.Anchor = AnchorStyles.Bottom;
            btnVolverPasajeros.Cursor = Cursors.Hand;
            btnVolverPasajeros.FlatAppearance.BorderSize = 0;
            btnVolverPasajeros.FlatStyle = FlatStyle.Flat;
            btnVolverPasajeros.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolverPasajeros.ForeColor = Color.WhiteSmoke;
            btnVolverPasajeros.Location = new Point(358, 345);
            btnVolverPasajeros.MaximumSize = new Size(116, 25);
            btnVolverPasajeros.MinimumSize = new Size(116, 25);
            btnVolverPasajeros.Name = "btnVolverPasajeros";
            btnVolverPasajeros.Size = new Size(116, 25);
            btnVolverPasajeros.TabIndex = 47;
            btnVolverPasajeros.Text = "Volver";
            btnVolverPasajeros.UseVisualStyleBackColor = true;
            btnVolverPasajeros.Click += btnVolverPasajeros_Click;
            // 
            // FrmVentaViaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 32, 39);
            ClientSize = new Size(711, 379);
            Controls.Add(btnVolverPasajeros);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtBDni);
            Controls.Add(dataGVPasajeros);
            Controls.Add(btnAsignar);
            Controls.Add(btnCrear);
            Controls.Add(btnVolver);
            Controls.Add(checkBComida);
            Controls.Add(checkBInternet);
            Controls.Add(dataGVVuelos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmVentaViaje";
            Text = "FrmVentaViaje";
            Load += FrmVentaViaje_Load;
            ((System.ComponentModel.ISupportInitialize)dataGVVuelos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGVPasajeros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGVVuelos;
        private CheckBox checkBInternet;
        private CheckBox checkBComida;
        private Button btnVolver;
        private Button btnCrear;
        private Button btnAsignar;
        private DataGridView dataGVPasajeros;
        protected TextBox txtBDni;
        private Button btnAceptar;
        private Button btnCancelar;
        private Button btnVolverPasajeros;
        private DataGridViewTextBoxColumn ColumApellido;
        private DataGridViewTextBoxColumn ColumNombre;
        private DataGridViewTextBoxColumn ColumDni;
        private DataGridViewTextBoxColumn ColumEdad;
        private DataGridViewTextBoxColumn ColumEquipajeMano;
        private DataGridViewTextBoxColumn ColumEquipajeBodega;
        private DataGridViewTextBoxColumn ColumPesoEquip;
        private DataGridViewTextBoxColumn ColumClase;
        private DataGridViewTextBoxColumn ColumFecha;
        private DataGridViewTextBoxColumn ColumOrigen;
        private DataGridViewTextBoxColumn ColumDestino;
        private DataGridViewTextBoxColumn ColumPrecio;
        private DataGridViewTextBoxColumn ColumPrecioP;
        private DataGridViewTextBoxColumn ColumPrecioTSinIva;
        private DataGridViewTextBoxColumn ColumPrecioPSinIva;
        private DataGridViewTextBoxColumn ColumAsientosTuris;
        private DataGridViewTextBoxColumn ColumAsientosPrem;
        private DataGridViewTextBoxColumn ColumWifi;
        private DataGridViewTextBoxColumn ColumComida;
        private DataGridViewTextBoxColumn ColumAvion;
    }
}