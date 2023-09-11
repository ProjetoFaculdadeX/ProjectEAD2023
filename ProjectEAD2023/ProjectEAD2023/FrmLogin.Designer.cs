using System.Data.SqlClient;

namespace ProjectEAD2023
{
    partial class FrmLogin
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
            btmLogin = new Button();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            lblUser = new Label();
            lblPassword = new Label();
            btmRegister = new Button();
            SuspendLayout();
            // 
            // btmLogin
            // 
            btmLogin.Location = new Point(320, 272);
            btmLogin.Name = "btmLogin";
            btmLogin.Size = new Size(75, 23);
            btmLogin.TabIndex = 0;
            btmLogin.Text = "Entrar";
            btmLogin.UseVisualStyleBackColor = true;
            btmLogin.UseWaitCursor = true;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(295, 146);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(100, 23);
            txtUser.TabIndex = 1;
            txtUser.UseWaitCursor = true;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(295, 195);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 2;
            txtPassword.UseWaitCursor = true;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(230, 146);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(50, 15);
            lblUser.TabIndex = 3;
            lblUser.Text = "Usuario:";
            lblUser.UseWaitCursor = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(230, 203);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(42, 15);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Senha:";
            lblPassword.UseWaitCursor = true;
            // 
            // btmRegister
            // 
            btmRegister.Location = new Point(230, 272);
            btmRegister.Name = "btmRegister";
            btmRegister.Size = new Size(75, 23);
            btmRegister.TabIndex = 5;
            btmRegister.Text = "Cadatro";
            btmRegister.UseVisualStyleBackColor = true;
            btmRegister.UseWaitCursor = true;
            btmRegister.Click += btmRegister_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 526);
            Controls.Add(btmRegister);
            Controls.Add(lblPassword);
            Controls.Add(lblUser);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(btmLogin);
            Name = "FrmLogin";
            Text = "ProjectEAD2023";
            UseWaitCursor = true;
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btmLogin;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Label lblUser;
        private Label lblPassword;
        private Button btmRegister;
    }
}