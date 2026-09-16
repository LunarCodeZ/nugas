namespace ContohSoal
{
    partial class Form1Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1Login));
            this.teksUsername = new System.Windows.Forms.Label();
            this.tombolLogin = new System.Windows.Forms.Button();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.teksPassword = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.teksBelumPunyaAkun = new System.Windows.Forms.Label();
            this.teksDaftarSekarang = new System.Windows.Forms.Label();
            this.logoLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // teksUsername
            // 
            this.teksUsername.AutoSize = true;
            this.teksUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksUsername.Location = new System.Drawing.Point(190, 294);
            this.teksUsername.Name = "teksUsername";
            this.teksUsername.Size = new System.Drawing.Size(99, 28);
            this.teksUsername.TabIndex = 0;
            this.teksUsername.Text = "Username";
            // 
            // tombolLogin
            // 
            this.tombolLogin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tombolLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolLogin.Location = new System.Drawing.Point(592, 399);
            this.tombolLogin.Name = "tombolLogin";
            this.tombolLogin.Size = new System.Drawing.Size(119, 41);
            this.tombolLogin.TabIndex = 1;
            this.tombolLogin.Text = "Login";
            this.tombolLogin.UseVisualStyleBackColor = false;
            this.tombolLogin.Click += new System.EventHandler(this.tombolLogin_Click);
            // 
            // usernameTxt
            // 
            this.usernameTxt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.Location = new System.Drawing.Point(320, 294);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(391, 34);
            this.usernameTxt.TabIndex = 2;
            // 
            // teksPassword
            // 
            this.teksPassword.AutoSize = true;
            this.teksPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksPassword.Location = new System.Drawing.Point(190, 347);
            this.teksPassword.Name = "teksPassword";
            this.teksPassword.Size = new System.Drawing.Size(93, 28);
            this.teksPassword.TabIndex = 0;
            this.teksPassword.Text = "Password";
            this.teksPassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(320, 347);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(391, 34);
            this.passwordTxt.TabIndex = 2;
            // 
            // teksBelumPunyaAkun
            // 
            this.teksBelumPunyaAkun.AutoSize = true;
            this.teksBelumPunyaAkun.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksBelumPunyaAkun.Location = new System.Drawing.Point(298, 480);
            this.teksBelumPunyaAkun.Name = "teksBelumPunyaAkun";
            this.teksBelumPunyaAkun.Size = new System.Drawing.Size(166, 25);
            this.teksBelumPunyaAkun.TabIndex = 0;
            this.teksBelumPunyaAkun.Text = "Belum punya akun?";
            // 
            // teksDaftarSekarang
            // 
            this.teksDaftarSekarang.AutoSize = true;
            this.teksDaftarSekarang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksDaftarSekarang.ForeColor = System.Drawing.SystemColors.Highlight;
            this.teksDaftarSekarang.Location = new System.Drawing.Point(470, 480);
            this.teksDaftarSekarang.Name = "teksDaftarSekarang";
            this.teksDaftarSekarang.Size = new System.Drawing.Size(144, 25);
            this.teksDaftarSekarang.TabIndex = 0;
            this.teksDaftarSekarang.Text = "Daftar Sekarang!";
            this.teksDaftarSekarang.Click += new System.EventHandler(this.teksDaftarSekarang_Click);
            // 
            // logoLogin
            // 
            this.logoLogin.Image = global::ContohSoal.Properties.Resources.bromo_landscape;
            this.logoLogin.Location = new System.Drawing.Point(195, 45);
            this.logoLogin.Name = "logoLogin";
            this.logoLogin.Size = new System.Drawing.Size(516, 216);
            this.logoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoLogin.TabIndex = 3;
            this.logoLogin.TabStop = false;
            // 
            // Form1Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 531);
            this.Controls.Add(this.logoLogin);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.teksPassword);
            this.Controls.Add(this.tombolLogin);
            this.Controls.Add(this.teksDaftarSekarang);
            this.Controls.Add(this.teksBelumPunyaAkun);
            this.Controls.Add(this.teksUsername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bromo Airlines - Login";
            ((System.ComponentModel.ISupportInitialize)(this.logoLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label teksUsername;
        private System.Windows.Forms.Button tombolLogin;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label teksPassword;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label teksBelumPunyaAkun;
        private System.Windows.Forms.Label teksDaftarSekarang;
        private System.Windows.Forms.PictureBox logoLogin;
    }
}

