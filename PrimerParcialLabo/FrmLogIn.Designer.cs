namespace PrimerParcialLabo
{
    partial class FrmLogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBLogo = new PictureBox();
            pictureBEmail = new PictureBox();
            pictureBContra = new PictureBox();
            txtBMail = new TextBox();
            panelEmail = new Panel();
            panelContrseña = new Panel();
            txtBContraseña = new TextBox();
            btnIngresar = new Button();
            pictureBEscape = new PictureBox();
            pictureBMinimize = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBContra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBEscape).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBMinimize).BeginInit();
            SuspendLayout();
            // 
            // pictureBLogo
            // 
            pictureBLogo.Image = Properties.Resources.email_send_96px;
            pictureBLogo.Location = new Point(102, 34);
            pictureBLogo.Name = "pictureBLogo";
            pictureBLogo.Size = new Size(81, 74);
            pictureBLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBLogo.TabIndex = 0;
            pictureBLogo.TabStop = false;
            // 
            // pictureBEmail
            // 
            pictureBEmail.Image = Properties.Resources.mail_96px;
            pictureBEmail.Location = new Point(33, 147);
            pictureBEmail.Name = "pictureBEmail";
            pictureBEmail.Size = new Size(33, 31);
            pictureBEmail.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBEmail.TabIndex = 1;
            pictureBEmail.TabStop = false;
            // 
            // pictureBContra
            // 
            pictureBContra.Image = Properties.Resources.lock_500px;
            pictureBContra.Location = new Point(33, 209);
            pictureBContra.Name = "pictureBContra";
            pictureBContra.Size = new Size(33, 31);
            pictureBContra.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBContra.TabIndex = 2;
            pictureBContra.TabStop = false;
            // 
            // txtBMail
            // 
            txtBMail.BackColor = Color.FromArgb(34, 36, 49);
            txtBMail.BorderStyle = BorderStyle.None;
            txtBMail.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBMail.ForeColor = SystemColors.Window;
            txtBMail.Location = new Point(72, 155);
            txtBMail.Name = "txtBMail";
            txtBMail.Size = new Size(181, 15);
            txtBMail.TabIndex = 3;
            txtBMail.Text = "Email";
            // 
            // panelEmail
            // 
            panelEmail.BackColor = Color.White;
            panelEmail.Location = new Point(33, 177);
            panelEmail.Name = "panelEmail";
            panelEmail.Size = new Size(220, 1);
            panelEmail.TabIndex = 4;
            // 
            // panelContrseña
            // 
            panelContrseña.BackColor = Color.White;
            panelContrseña.Location = new Point(33, 244);
            panelContrseña.Name = "panelContrseña";
            panelContrseña.Size = new Size(220, 1);
            panelContrseña.TabIndex = 6;
            // 
            // txtBContraseña
            // 
            txtBContraseña.BackColor = Color.FromArgb(34, 36, 49);
            txtBContraseña.BorderStyle = BorderStyle.None;
            txtBContraseña.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBContraseña.ForeColor = SystemColors.Window;
            txtBContraseña.Location = new Point(72, 222);
            txtBContraseña.Name = "txtBContraseña";
            txtBContraseña.Size = new Size(181, 15);
            txtBContraseña.TabIndex = 5;
            txtBContraseña.Text = "Contraseña";
            txtBContraseña.TextChanged += txtBContraseña_TextChanged;
            // 
            // btnIngresar
            // 
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.ForeColor = Color.Gray;
            btnIngresar.Location = new Point(70, 290);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(147, 31);
            btnIngresar.TabIndex = 7;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // pictureBEscape
            // 
            pictureBEscape.Image = Properties.Resources.close_512px1;
            pictureBEscape.Location = new Point(261, 6);
            pictureBEscape.Name = "pictureBEscape";
            pictureBEscape.Size = new Size(17, 17);
            pictureBEscape.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBEscape.TabIndex = 8;
            pictureBEscape.TabStop = false;
            pictureBEscape.Click += pictureBEscape_Click;
            // 
            // pictureBMinimize
            // 
            pictureBMinimize.Image = Properties.Resources.minus_96px;
            pictureBMinimize.Location = new Point(238, 6);
            pictureBMinimize.Name = "pictureBMinimize";
            pictureBMinimize.Size = new Size(17, 17);
            pictureBMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBMinimize.TabIndex = 9;
            pictureBMinimize.TabStop = false;
            pictureBMinimize.Click += pictureBMinimize_Click;
            // 
            // FrmLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(286, 345);
            Controls.Add(pictureBMinimize);
            Controls.Add(pictureBEscape);
            Controls.Add(btnIngresar);
            Controls.Add(panelContrseña);
            Controls.Add(txtBContraseña);
            Controls.Add(panelEmail);
            Controls.Add(txtBMail);
            Controls.Add(pictureBContra);
            Controls.Add(pictureBEmail);
            Controls.Add(pictureBLogo);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FrmLogIn_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBContra).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBEscape).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBMinimize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBLogo;
        private PictureBox pictureBEmail;
        private PictureBox pictureBContra;
        private TextBox txtBMail;
        private Panel panelEmail;
        private Panel panelContrseña;
        private TextBox txtBContraseña;
        private Button btnIngresar;
        private PictureBox pictureBEscape;
        private PictureBox pictureBMinimize;
    }
}