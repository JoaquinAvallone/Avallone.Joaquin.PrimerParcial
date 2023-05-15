﻿namespace PrimerParcialLabo
{
    partial class FrmCrudVuelos
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
            dataGVVuelos = new DataGridView();
            txtBMatricula = new TextBox();
            btnVolver = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            btnEliminar = new Button();
            panelFormularios = new Panel();
            ColumFecha = new DataGridViewTextBoxColumn();
            ColumOrigen = new DataGridViewTextBoxColumn();
            ColumDestino = new DataGridViewTextBoxColumn();
            ColumPrecio = new DataGridViewTextBoxColumn();
            ColumPrecioP = new DataGridViewTextBoxColumn();
            ColumPrecioTSinIva = new DataGridViewTextBoxColumn();
            ColumPrecioPremSinIva = new DataGridViewTextBoxColumn();
            ColumTurista = new DataGridViewTextBoxColumn();
            ColumPremium = new DataGridViewTextBoxColumn();
            ColumDuracion = new DataGridViewTextBoxColumn();
            ColumAvion = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGVVuelos).BeginInit();
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
            dataGridViewCellStyle1.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle1.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGVVuelos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGVVuelos.ColumnHeadersHeight = 46;
            dataGVVuelos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGVVuelos.Columns.AddRange(new DataGridViewColumn[] { ColumFecha, ColumOrigen, ColumDestino, ColumPrecio, ColumPrecioP, ColumPrecioTSinIva, ColumPrecioPremSinIva, ColumTurista, ColumPremium, ColumDuracion, ColumAvion });
            dataGVVuelos.Cursor = Cursors.Hand;
            dataGVVuelos.EnableHeadersVisualStyles = false;
            dataGVVuelos.GridColor = Color.FromArgb(35, 32, 39);
            dataGVVuelos.Location = new Point(6, 3);
            dataGVVuelos.MultiSelect = false;
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
            dataGVVuelos.Size = new Size(703, 331);
            dataGVVuelos.TabIndex = 1;
            dataGVVuelos.CellClick += dataGVVuelos_CellClick;
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
            txtBMatricula.TabIndex = 49;
            txtBMatricula.TextChanged += txtBMatricula_TextChanged;
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
            btnVolver.TabIndex = 48;
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
            btnModificar.TabIndex = 47;
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
            btnAgregar.TabIndex = 46;
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
            btnEliminar.TabIndex = 45;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // panelFormularios
            // 
            panelFormularios.Dock = DockStyle.Fill;
            panelFormularios.Location = new Point(0, 0);
            panelFormularios.Name = "panelFormularios";
            panelFormularios.Size = new Size(711, 379);
            panelFormularios.TabIndex = 50;
            // 
            // ColumFecha
            // 
            ColumFecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ColumFecha.HeaderText = "FECHA Y HORA";
            ColumFecha.Name = "ColumFecha";
            ColumFecha.ReadOnly = true;
            ColumFecha.Width = 65;
            // 
            // ColumOrigen
            // 
            ColumOrigen.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ColumOrigen.HeaderText = "ORIGEN";
            ColumOrigen.Name = "ColumOrigen";
            ColumOrigen.ReadOnly = true;
            ColumOrigen.Width = 69;
            // 
            // ColumDestino
            // 
            ColumDestino.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ColumDestino.HeaderText = "DESTINO";
            ColumDestino.Name = "ColumDestino";
            ColumDestino.ReadOnly = true;
            ColumDestino.Width = 75;
            // 
            // ColumPrecio
            // 
            ColumPrecio.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ColumPrecio.HeaderText = "PRECIO TURIS. C/IVA";
            ColumPrecio.Name = "ColumPrecio";
            ColumPrecio.ReadOnly = true;
            ColumPrecio.Width = 88;
            // 
            // ColumPrecioP
            // 
            ColumPrecioP.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ColumPrecioP.HeaderText = "PRECIO PREM. C/IVA";
            ColumPrecioP.Name = "ColumPrecioP";
            ColumPrecioP.ReadOnly = true;
            ColumPrecioP.Width = 87;
            // 
            // ColumPrecioTSinIva
            // 
            ColumPrecioTSinIva.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ColumPrecioTSinIva.HeaderText = "PRECIO TURIS. S/IVA";
            ColumPrecioTSinIva.Name = "ColumPrecioTSinIva";
            ColumPrecioTSinIva.ReadOnly = true;
            ColumPrecioTSinIva.Width = 87;
            // 
            // ColumPrecioPremSinIva
            // 
            ColumPrecioPremSinIva.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ColumPrecioPremSinIva.HeaderText = "PRECIO PREM. S/IVA";
            ColumPrecioPremSinIva.Name = "ColumPrecioPremSinIva";
            ColumPrecioPremSinIva.ReadOnly = true;
            ColumPrecioPremSinIva.Width = 86;
            // 
            // ColumTurista
            // 
            ColumTurista.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ColumTurista.HeaderText = "ASIENTOS TURIS.";
            ColumTurista.Name = "ColumTurista";
            ColumTurista.ReadOnly = true;
            ColumTurista.Width = 110;
            // 
            // ColumPremium
            // 
            ColumPremium.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ColumPremium.HeaderText = "ASIENTOS PREM.";
            ColumPremium.Name = "ColumPremium";
            ColumPremium.ReadOnly = true;
            ColumPremium.Width = 109;
            // 
            // ColumDuracion
            // 
            ColumDuracion.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ColumDuracion.HeaderText = "DURACION";
            ColumDuracion.Name = "ColumDuracion";
            ColumDuracion.ReadOnly = true;
            ColumDuracion.Width = 85;
            // 
            // ColumAvion
            // 
            ColumAvion.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ColumAvion.HeaderText = "AVION";
            ColumAvion.Name = "ColumAvion";
            ColumAvion.ReadOnly = true;
            ColumAvion.Width = 63;
            // 
            // FrmCrudVuelos
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
            Controls.Add(dataGVVuelos);
            Controls.Add(panelFormularios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCrudVuelos";
            Text = "FrmCrudVuelos";
            Load += FrmCrudVuelos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGVVuelos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGVVuelos;
        protected TextBox txtBMatricula;
        private Button btnVolver;
        private Button btnModificar;
        private Button btnAgregar;
        private Button btnEliminar;
        private Panel panelFormularios;
        private DataGridViewTextBoxColumn ColumFecha;
        private DataGridViewTextBoxColumn ColumOrigen;
        private DataGridViewTextBoxColumn ColumDestino;
        private DataGridViewTextBoxColumn ColumPrecio;
        private DataGridViewTextBoxColumn ColumPrecioP;
        private DataGridViewTextBoxColumn ColumPrecioTSinIva;
        private DataGridViewTextBoxColumn ColumPrecioPremSinIva;
        private DataGridViewTextBoxColumn ColumTurista;
        private DataGridViewTextBoxColumn ColumPremium;
        private DataGridViewTextBoxColumn ColumDuracion;
        private DataGridViewTextBoxColumn ColumAvion;
    }
}