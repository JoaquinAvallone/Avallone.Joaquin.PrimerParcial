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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogIn));
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
            picBEye = new PictureBox();
            picBEyeBlind = new PictureBox();
            checkBCompletado = new CheckBox();
            comboBUsuarios = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBContra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBEscape).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBEye).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBEyeBlind).BeginInit();
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
            pictureBEmail.Location = new Point(33, 140);
            pictureBEmail.Name = "pictureBEmail";
            pictureBEmail.Size = new Size(33, 31);
            pictureBEmail.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBEmail.TabIndex = 1;
            pictureBEmail.TabStop = false;
            // 
            // pictureBContra
            // 
            pictureBContra.Image = Properties.Resources.lock_500px;
            pictureBContra.Location = new Point(33, 202);
            pictureBContra.Name = "pictureBContra";
            pictureBContra.Size = new Size(33, 31);
            pictureBContra.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBContra.TabIndex = 2;
            pictureBContra.TabStop = false;
            // 
            // txtBMail
            // 
            txtBMail.BackColor = Color.FromArgb(35, 32, 39);
            txtBMail.BorderStyle = BorderStyle.None;
            txtBMail.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBMail.ForeColor = SystemColors.Window;
            txtBMail.Location = new Point(72, 148);
            txtBMail.Name = "txtBMail";
            txtBMail.PlaceholderText = "Email";
            txtBMail.Size = new Size(181, 15);
            txtBMail.TabIndex = 3;
            // 
            // panelEmail
            // 
            panelEmail.BackColor = Color.White;
            panelEmail.Location = new Point(33, 170);
            panelEmail.Name = "panelEmail";
            panelEmail.Size = new Size(220, 1);
            panelEmail.TabIndex = 4;
            // 
            // panelContrseña
            // 
            panelContrseña.BackColor = Color.White;
            panelContrseña.Location = new Point(33, 237);
            panelContrseña.Name = "panelContrseña";
            panelContrseña.Size = new Size(220, 1);
            panelContrseña.TabIndex = 6;
            // 
            // txtBContraseña
            // 
            txtBContraseña.BackColor = Color.FromArgb(35, 32, 39);
            txtBContraseña.BorderStyle = BorderStyle.None;
            txtBContraseña.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBContraseña.ForeColor = SystemColors.Window;
            txtBContraseña.Location = new Point(72, 215);
            txtBContraseña.Name = "txtBContraseña";
            txtBContraseña.PlaceholderText = "Contraseña";
            txtBContraseña.Size = new Size(181, 15);
            txtBContraseña.TabIndex = 5;
            txtBContraseña.UseSystemPasswordChar = true;
            txtBContraseña.TextChanged += txtBContraseña_TextChanged;
            // 
            // btnIngresar
            // 
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.ForeColor = Color.Gray;
            btnIngresar.Location = new Point(69, 284);
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
            // picBEye
            // 
            picBEye.Cursor = Cursors.Hand;
            picBEye.Image = (Image)resources.GetObject("picBEye.Image");
            picBEye.Location = new Point(234, 213);
            picBEye.Name = "picBEye";
            picBEye.Size = new Size(15, 20);
            picBEye.SizeMode = PictureBoxSizeMode.Zoom;
            picBEye.TabIndex = 10;
            picBEye.TabStop = false;
            picBEye.Visible = false;
            picBEye.Click += picBEye_Click;
            // 
            // picBEyeBlind
            // 
            picBEyeBlind.Cursor = Cursors.Hand;
            picBEyeBlind.Image = (Image)resources.GetObject("picBEyeBlind.Image");
            picBEyeBlind.Location = new Point(234, 211);
            picBEyeBlind.Name = "picBEyeBlind";
            picBEyeBlind.Size = new Size(15, 20);
            picBEyeBlind.SizeMode = PictureBoxSizeMode.Zoom;
            picBEyeBlind.TabIndex = 11;
            picBEyeBlind.TabStop = false;
            picBEyeBlind.Visible = false;
            picBEyeBlind.Click += picBEyeBlind_Click;
            // 
            // checkBCompletado
            // 
            checkBCompletado.AutoSize = true;
            checkBCompletado.FlatAppearance.BorderSize = 0;
            checkBCompletado.FlatStyle = FlatStyle.Flat;
            checkBCompletado.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBCompletado.ForeColor = Color.Gray;
            checkBCompletado.Location = new Point(34, 253);
            checkBCompletado.Name = "checkBCompletado";
            checkBCompletado.Size = new Size(103, 19);
            checkBCompletado.TabIndex = 12;
            checkBCompletado.Text = "Autocompletar";
            checkBCompletado.UseVisualStyleBackColor = true;
            checkBCompletado.CheckedChanged += checkBCompletado_CheckedChanged;
            // 
            // comboBUsuarios
            // 
            comboBUsuarios.BackColor = Color.FromArgb(35, 32, 39);
            comboBUsuarios.FlatStyle = FlatStyle.Flat;
            comboBUsuarios.ForeColor = Color.WhiteSmoke;
            comboBUsuarios.FormattingEnabled = true;
            comboBUsuarios.Location = new Point(57, 249);
            comboBUsuarios.Name = "comboBUsuarios";
            comboBUsuarios.Size = new Size(172, 23);
            comboBUsuarios.TabIndex = 13;
            comboBUsuarios.TextChanged += comboBUsuarios_TextChanged;
            // 
            // FrmLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 32, 39);
            ClientSize = new Size(286, 345);
            Controls.Add(comboBUsuarios);
            Controls.Add(checkBCompletado);
            Controls.Add(picBEyeBlind);
            Controls.Add(picBEye);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FrmLogIn_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBContra).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBEscape).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBEye).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBEyeBlind).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBLogo;
        private PictureBox pictureBEmail;
        private PictureBox pictureBContra;
        private Panel panelEmail;
        private Panel panelContrseña;
        private TextBox txtBContraseña;
        private Button btnIngresar;
        private PictureBox pictureBEscape;
        private PictureBox pictureBMinimize;
        public TextBox txtBMail;
        private PictureBox picBEye;
        private PictureBox picBEyeBlind;
        private CheckBox checkBCompletado;
        private ComboBox comboBUsuarios;
    }
}