namespace PrimerParcialLabo
{
    partial class FrmPasajerosFrecuentes
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
            ColumCantVuelos = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGVPasajeros).BeginInit();
            SuspendLayout();
            // 
            // dataGVPasajeros
            // 
            dataGVPasajeros.AllowUserToAddRows = false;
            dataGVPasajeros.AllowUserToDeleteRows = false;
            dataGVPasajeros.AllowUserToResizeColumns = false;
            dataGVPasajeros.AllowUserToResizeRows = false;
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
            dataGVPasajeros.Columns.AddRange(new DataGridViewColumn[] { ColumApellido, ColumNombre, ColumDni, ColumEdad, ColumCantVuelos });
            dataGVPasajeros.Cursor = Cursors.Hand;
            dataGVPasajeros.Dock = DockStyle.Fill;
            dataGVPasajeros.EnableHeadersVisualStyles = false;
            dataGVPasajeros.GridColor = Color.FromArgb(35, 32, 39);
            dataGVPasajeros.Location = new Point(0, 0);
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
            dataGVPasajeros.Size = new Size(711, 379);
            dataGVPasajeros.TabIndex = 6;
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
            // ColumCantVuelos
            // 
            ColumCantVuelos.HeaderText = "VUELOS";
            ColumCantVuelos.Name = "ColumCantVuelos";
            ColumCantVuelos.ReadOnly = true;
            // 
            // FrmPasajerosFrecuentes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 32, 39);
            ClientSize = new Size(711, 379);
            Controls.Add(dataGVPasajeros);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPasajerosFrecuentes";
            Text = "FrmPasajerosFrecuentes";
            Load += FrmPasajerosFrecuentes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGVPasajeros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGVPasajeros;
        private DataGridViewTextBoxColumn ColumApellido;
        private DataGridViewTextBoxColumn ColumNombre;
        private DataGridViewTextBoxColumn ColumDni;
        private DataGridViewTextBoxColumn ColumEdad;
        private DataGridViewTextBoxColumn ColumCantVuelos;
    }
}