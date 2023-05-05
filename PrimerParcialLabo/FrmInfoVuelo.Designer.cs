namespace PrimerParcialLabo
{
    partial class FrmInfoVuelo
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
            dataGVInfoVuelos = new DataGridView();
            ColumApellido = new DataGridViewTextBoxColumn();
            ColumNombre = new DataGridViewTextBoxColumn();
            ColumDni = new DataGridViewTextBoxColumn();
            ColumEdad = new DataGridViewTextBoxColumn();
            ColumEquipajeMano = new DataGridViewTextBoxColumn();
            ColumEquipajeBodega = new DataGridViewTextBoxColumn();
            ColumPesoEquip = new DataGridViewTextBoxColumn();
            ColumClase = new DataGridViewTextBoxColumn();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGVInfoVuelos).BeginInit();
            SuspendLayout();
            // 
            // dataGVInfoVuelos
            // 
            dataGVInfoVuelos.AllowUserToAddRows = false;
            dataGVInfoVuelos.AllowUserToDeleteRows = false;
            dataGVInfoVuelos.AllowUserToResizeColumns = false;
            dataGVInfoVuelos.AllowUserToResizeRows = false;
            dataGVInfoVuelos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGVInfoVuelos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGVInfoVuelos.BackgroundColor = Color.FromArgb(35, 32, 39);
            dataGVInfoVuelos.BorderStyle = BorderStyle.None;
            dataGVInfoVuelos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGVInfoVuelos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle1.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGVInfoVuelos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGVInfoVuelos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGVInfoVuelos.Columns.AddRange(new DataGridViewColumn[] { ColumApellido, ColumNombre, ColumDni, ColumEdad, ColumEquipajeMano, ColumEquipajeBodega, ColumPesoEquip, ColumClase });
            dataGVInfoVuelos.EnableHeadersVisualStyles = false;
            dataGVInfoVuelos.GridColor = Color.FromArgb(35, 32, 39);
            dataGVInfoVuelos.Location = new Point(0, 0);
            dataGVInfoVuelos.Name = "dataGVInfoVuelos";
            dataGVInfoVuelos.ReadOnly = true;
            dataGVInfoVuelos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.DarkGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle2.SelectionForeColor = Color.DarkGray;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGVInfoVuelos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGVInfoVuelos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGVInfoVuelos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGVInfoVuelos.RowTemplate.Height = 25;
            dataGVInfoVuelos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGVInfoVuelos.Size = new Size(711, 350);
            dataGVInfoVuelos.TabIndex = 1;
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
            btnVolver.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = Color.LightGray;
            btnVolver.Location = new Point(297, 351);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(116, 25);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmInfoVuelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 32, 39);
            ClientSize = new Size(711, 379);
            Controls.Add(btnVolver);
            Controls.Add(dataGVInfoVuelos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmInfoVuelo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmInfoVuelo";
            Load += FrmInfoVuelo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGVInfoVuelos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGVInfoVuelos;
        private Button btnVolver;
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