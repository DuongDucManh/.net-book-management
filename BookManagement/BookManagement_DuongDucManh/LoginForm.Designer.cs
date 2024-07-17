namespace BookManagement_DuongDucManh
{
    partial class LoginForm
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
            grbAccountInfo = new GroupBox();
            btnQuit = new Button();
            lblPassword = new Label();
            txtEmail = new TextBox();
            btnLogin = new Button();
            lblEmail = new Label();
            txtPassword = new TextBox();
            lblLogin = new Label();
            grbAccountInfo.SuspendLayout();
            SuspendLayout();
            // 
            // grbAccountInfo
            // 
            grbAccountInfo.Controls.Add(btnQuit);
            grbAccountInfo.Controls.Add(lblPassword);
            grbAccountInfo.Controls.Add(txtEmail);
            grbAccountInfo.Controls.Add(btnLogin);
            grbAccountInfo.Controls.Add(lblEmail);
            grbAccountInfo.Controls.Add(txtPassword);
            grbAccountInfo.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbAccountInfo.ForeColor = Color.Gold;
            grbAccountInfo.Location = new Point(12, 64);
            grbAccountInfo.Name = "grbAccountInfo";
            grbAccountInfo.Size = new Size(482, 340);
            grbAccountInfo.TabIndex = 1;
            grbAccountInfo.TabStop = false;
            grbAccountInfo.Text = "Login info";
            // 
            // btnQuit
            // 
            btnQuit.Font = new Font("Segoe UI", 15F);
            btnQuit.ForeColor = Color.DarkMagenta;
            btnQuit.Location = new Point(197, 224);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(143, 41);
            btnQuit.TabIndex = 6;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Sans Serif", 15F);
            lblPassword.ForeColor = Color.Gold;
            lblPassword.Location = new Point(19, 127);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(124, 29);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 15F);
            txtEmail.Location = new Point(167, 62);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(295, 41);
            txtEmail.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 15F);
            btnLogin.ForeColor = Color.DarkMagenta;
            btnLogin.Location = new Point(19, 224);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(143, 41);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 15F);
            lblEmail.ForeColor = Color.Gold;
            lblEmail.Location = new Point(19, 62);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(78, 29);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 15F);
            txtPassword.Location = new Point(167, 127);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(295, 41);
            txtPassword.TabIndex = 3;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.Gold;
            lblLogin.Location = new Point(199, 9);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(106, 39);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "Login";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(506, 416);
            Controls.Add(lblLogin);
            Controls.Add(grbAccountInfo);
            ForeColor = Color.Gold;
            Name = "LoginForm";
            Text = "LoginForm";
            grbAccountInfo.ResumeLayout(false);
            grbAccountInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbAccountInfo;
        private TextBox txtEmail;
        private Button btnLogin;
        private Label lblEmail;
        private TextBox txtPassword;
        private Label lblPassword;
        private Button btnQuit;
        private Label lblLogin;
    }
}