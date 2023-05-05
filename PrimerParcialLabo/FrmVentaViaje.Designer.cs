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
            dataGVVuelos = new DataGridView();
            ColumFecha = new DataGridViewTextBoxColumn();
            ColumOrigen = new DataGridViewTextBoxColumn();
            ColumDestino = new DataGridViewTextBoxColumn();
            ColumPrecio = new DataGridViewTextBoxColumn();
            ColumPrecioP = new DataGridViewTextBoxColumn();
            ColumAvion = new DataGridViewTextBoxColumn();
            ColumWifi = new DataGridViewTextBoxColumn();
            ColumComida = new DataGridViewTextBoxColumn();
            checkBInternet = new CheckBox();
            checkBComida = new CheckBox();
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
            dataGVVuelos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGVVuelos.Columns.AddRange(new DataGridViewColumn[] { ColumFecha, ColumOrigen, ColumDestino, ColumPrecio, ColumPrecioP, ColumAvion, ColumWifi, ColumComida });
            dataGVVuelos.EnableHeadersVisualStyles = false;
            dataGVVuelos.GridColor = Color.FromArgb(35, 32, 39);
            dataGVVuelos.Location = new Point(3, 1);
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
            dataGVVuelos.Size = new Size(709, 350);
            dataGVVuelos.TabIndex = 1;
            dataGVVuelos.CellClick += dataGVVuelos_CellClick;
            // 
            // ColumFecha
            // 
            ColumFecha.HeaderText = "FECHA Y HS.";
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
            ColumPrecio.HeaderText = "PRECIO T.";
            ColumPrecio.Name = "ColumPrecio";
            ColumPrecio.ReadOnly = true;
            // 
            // ColumPrecioP
            // 
            ColumPrecioP.HeaderText = "PRECIO P.";
            ColumPrecioP.Name = "ColumPrecioP";
            ColumPrecioP.ReadOnly = true;
            // 
            // ColumAvion
            // 
            ColumAvion.HeaderText = "AVION";
            ColumAvion.Name = "ColumAvion";
            ColumAvion.ReadOnly = true;
            // 
            // ColumWifi
            // 
            ColumWifi.HeaderText = "WIFI";
            ColumWifi.Name = "ColumWifi";
            ColumWifi.ReadOnly = true;
            // 
            // ColumComida
            // 
            ColumComida.HeaderText = "COMIDA";
            ColumComida.Name = "ColumComida";
            ColumComida.ReadOnly = true;
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
            checkBInternet.Location = new Point(281, 352);
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
            checkBComida.Location = new Point(360, 352);
            checkBComida.Name = "checkBComida";
            checkBComida.Size = new Size(67, 18);
            checkBComida.TabIndex = 3;
            checkBComida.Text = "COMIDA";
            checkBComida.UseVisualStyleBackColor = true;
            checkBComida.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // FrmVentaViaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 32, 39);
            ClientSize = new Size(711, 379);
            Controls.Add(checkBComida);
            Controls.Add(checkBInternet);
            Controls.Add(dataGVVuelos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmVentaViaje";
            Text = "FrmVentaViaje";
            Load += FrmVentaViaje_Load;
            ((System.ComponentModel.ISupportInitialize)dataGVVuelos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGVVuelos;
        private CheckBox checkBInternet;
        private CheckBox checkBComida;
        private DataGridViewTextBoxColumn ColumFecha;
        private DataGridViewTextBoxColumn ColumOrigen;
        private DataGridViewTextBoxColumn ColumDestino;
        private DataGridViewTextBoxColumn ColumPrecio;
        private DataGridViewTextBoxColumn ColumPrecioP;
        private DataGridViewTextBoxColumn ColumAvion;
        private DataGridViewTextBoxColumn ColumWifi;
        private DataGridViewTextBoxColumn ColumComida;
    }
}