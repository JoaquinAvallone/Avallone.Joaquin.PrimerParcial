namespace PrimerParcialLabo
{
    partial class FrmHorasDeVuelo
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
            ColumHorasVuelo = new DataGridViewTextBoxColumn();
            lblAdvertencia = new Label();
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle4.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGVAviones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGVAviones.ColumnHeadersHeight = 36;
            dataGVAviones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGVAviones.Columns.AddRange(new DataGridViewColumn[] { ColumMatricula, ColumAsientos, ColumBaños, ColumInternet, ColumComida, ColumBodega, ColumHorasVuelo });
            dataGVAviones.Cursor = Cursors.Hand;
            dataGVAviones.EnableHeadersVisualStyles = false;
            dataGVAviones.GridColor = Color.FromArgb(35, 32, 39);
            dataGVAviones.Location = new Point(0, 0);
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
            dataGVAviones.Size = new Size(713, 352);
            dataGVAviones.TabIndex = 5;
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
            // ColumHorasVuelo
            // 
            ColumHorasVuelo.HeaderText = "HORAS DE VUELO";
            ColumHorasVuelo.Name = "ColumHorasVuelo";
            ColumHorasVuelo.ReadOnly = true;
            // 
            // lblAdvertencia
            // 
            lblAdvertencia.Anchor = AnchorStyles.Bottom;
            lblAdvertencia.AutoSize = true;
            lblAdvertencia.ForeColor = Color.WhiteSmoke;
            lblAdvertencia.Location = new Point(182, 355);
            lblAdvertencia.Name = "lblAdvertencia";
            lblAdvertencia.Size = new Size(356, 15);
            lblAdvertencia.TabIndex = 6;
            lblAdvertencia.Text = "No se mostraran los aviones que no hayan sumado horas de vuelo";
            // 
            // FrmHorasDeVuelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 32, 39);
            ClientSize = new Size(711, 379);
            Controls.Add(lblAdvertencia);
            Controls.Add(dataGVAviones);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHorasDeVuelo";
            Text = "FrmHorasDeVuelo";
            Load += FrmHorasDeVuelo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGVAviones).EndInit();
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
        private DataGridViewTextBoxColumn ColumHorasVuelo;
        private Label lblAdvertencia;
    }
}