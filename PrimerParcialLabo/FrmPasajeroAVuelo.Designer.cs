namespace PrimerParcialLabo
{
    partial class FrmPasajeroAVuelo
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
            btnAceptar2 = new Button();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.Visible = false;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderSize = 0;
            // 
            // btnAceptar2
            // 
            btnAceptar2.Anchor = AnchorStyles.Bottom;
            btnAceptar2.Cursor = Cursors.Hand;
            btnAceptar2.FlatAppearance.BorderSize = 0;
            btnAceptar2.FlatStyle = FlatStyle.Flat;
            btnAceptar2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar2.ForeColor = Color.WhiteSmoke;
            btnAceptar2.Location = new Point(44, 408);
            btnAceptar2.MaximumSize = new Size(116, 25);
            btnAceptar2.MinimumSize = new Size(116, 25);
            btnAceptar2.Name = "btnAceptar2";
            btnAceptar2.Size = new Size(116, 25);
            btnAceptar2.TabIndex = 52;
            btnAceptar2.Text = "Aceptar";
            btnAceptar2.UseVisualStyleBackColor = true;
            btnAceptar2.Click += btnAceptar2_Click;
            // 
            // FrmPasajeroAVuelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 32, 39);
            ClientSize = new Size(339, 472);
            Controls.Add(btnAceptar2);
            Name = "FrmPasajeroAVuelo";
            Text = "FrmPasajeroAVuelo";
            Load += FrmPasajeroAVuelo_Load;
            Controls.SetChildIndex(panelContrseña, 0);
            Controls.SetChildIndex(lblApellido, 0);
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(lblNombre, 0);
            Controls.SetChildIndex(lblDni, 0);
            Controls.SetChildIndex(panel3, 0);
            Controls.SetChildIndex(lblEdad, 0);
            Controls.SetChildIndex(panel4, 0);
            Controls.SetChildIndex(llblEquipajeMano, 0);
            Controls.SetChildIndex(panel5, 0);
            Controls.SetChildIndex(lblEquipajeBodega, 0);
            Controls.SetChildIndex(panel6, 0);
            Controls.SetChildIndex(lblPesoEquipaje, 0);
            Controls.SetChildIndex(panel7, 0);
            Controls.SetChildIndex(lblClase, 0);
            Controls.SetChildIndex(checkBEquipajeMano, 0);
            Controls.SetChildIndex(checkBEquipajeBodega, 0);
            Controls.SetChildIndex(txtBApellido, 0);
            Controls.SetChildIndex(txtBNombre, 0);
            Controls.SetChildIndex(txtBDni, 0);
            Controls.SetChildIndex(txtBEdad, 0);
            Controls.SetChildIndex(txtBPesoEquipaje, 0);
            Controls.SetChildIndex(btnAceptar, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(radioBTurista, 0);
            Controls.SetChildIndex(radioBPremium, 0);
            Controls.SetChildIndex(btnAceptar2, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected Button btnAceptar2;
    }
}