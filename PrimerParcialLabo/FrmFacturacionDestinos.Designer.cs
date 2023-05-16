namespace PrimerParcialLabo
{
    partial class FrmFacturacionDestinos
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
            dataGVFacturacionDestinos = new DataGridView();
            ColumDestino = new DataGridViewTextBoxColumn();
            ColumRecaudacion = new DataGridViewTextBoxColumn();
            lblGananciaNacional = new Label();
            lblGananciaInter = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGVFacturacionDestinos).BeginInit();
            SuspendLayout();
            // 
            // dataGVFacturacionDestinos
            // 
            dataGVFacturacionDestinos.AllowUserToAddRows = false;
            dataGVFacturacionDestinos.AllowUserToDeleteRows = false;
            dataGVFacturacionDestinos.AllowUserToResizeColumns = false;
            dataGVFacturacionDestinos.AllowUserToResizeRows = false;
            dataGVFacturacionDestinos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGVFacturacionDestinos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGVFacturacionDestinos.BackgroundColor = Color.FromArgb(35, 32, 39);
            dataGVFacturacionDestinos.BorderStyle = BorderStyle.None;
            dataGVFacturacionDestinos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGVFacturacionDestinos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle1.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGVFacturacionDestinos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGVFacturacionDestinos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGVFacturacionDestinos.Columns.AddRange(new DataGridViewColumn[] { ColumDestino, ColumRecaudacion });
            dataGVFacturacionDestinos.Cursor = Cursors.Hand;
            dataGVFacturacionDestinos.EnableHeadersVisualStyles = false;
            dataGVFacturacionDestinos.GridColor = Color.FromArgb(35, 32, 39);
            dataGVFacturacionDestinos.Location = new Point(1, -2);
            dataGVFacturacionDestinos.Name = "dataGVFacturacionDestinos";
            dataGVFacturacionDestinos.ReadOnly = true;
            dataGVFacturacionDestinos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.DarkGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle2.SelectionForeColor = Color.DarkGray;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGVFacturacionDestinos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGVFacturacionDestinos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(35, 32, 39);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGVFacturacionDestinos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGVFacturacionDestinos.RowTemplate.Height = 25;
            dataGVFacturacionDestinos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGVFacturacionDestinos.Size = new Size(708, 338);
            dataGVFacturacionDestinos.TabIndex = 5;
            dataGVFacturacionDestinos.CellContentClick += dataGVFacturacionDestinos_CellContentClick;
            // 
            // ColumDestino
            // 
            ColumDestino.HeaderText = "DESTINO";
            ColumDestino.Name = "ColumDestino";
            ColumDestino.ReadOnly = true;
            // 
            // ColumRecaudacion
            // 
            ColumRecaudacion.HeaderText = "RECAUDACIÓN";
            ColumRecaudacion.Name = "ColumRecaudacion";
            ColumRecaudacion.ReadOnly = true;
            // 
            // lblGananciaNacional
            // 
            lblGananciaNacional.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblGananciaNacional.AutoSize = true;
            lblGananciaNacional.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGananciaNacional.ForeColor = Color.WhiteSmoke;
            lblGananciaNacional.Location = new Point(423, 357);
            lblGananciaNacional.Name = "lblGananciaNacional";
            lblGananciaNacional.Size = new Size(0, 13);
            lblGananciaNacional.TabIndex = 9;
            // 
            // lblGananciaInter
            // 
            lblGananciaInter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblGananciaInter.AutoSize = true;
            lblGananciaInter.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGananciaInter.ForeColor = Color.WhiteSmoke;
            lblGananciaInter.Location = new Point(12, 357);
            lblGananciaInter.Name = "lblGananciaInter";
            lblGananciaInter.Size = new Size(0, 13);
            lblGananciaInter.TabIndex = 8;
            // 
            // FrmFacturacionDestinos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 32, 39);
            ClientSize = new Size(711, 379);
            Controls.Add(lblGananciaNacional);
            Controls.Add(lblGananciaInter);
            Controls.Add(dataGVFacturacionDestinos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmFacturacionDestinos";
            Text = "FrmFacturacionDestinos";
            Load += FrmFacturacionDestinos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGVFacturacionDestinos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGVFacturacionDestinos;
        private Label lblGananciaNacional;
        private Label lblGananciaInter;
        private DataGridViewTextBoxColumn ColumDestino;
        private DataGridViewTextBoxColumn ColumRecaudacion;
    }
}