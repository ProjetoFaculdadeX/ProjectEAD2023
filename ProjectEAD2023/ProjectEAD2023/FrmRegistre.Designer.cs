namespace ProjectEAD2023
{
    partial class FrmRegistre : Form
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
            btmRegistre = new Button();
            txtName = new TextBox();
            lblName = new Label();
            lblDepartment = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            btnReturn = new Button();
            cmbDepartment = new ComboBox();
            SuspendLayout();
            // 
            // btmRegistre
            // 
            btmRegistre.Location = new Point(113, 273);
            btmRegistre.Name = "btmRegistre";
            btmRegistre.Size = new Size(75, 23);
            btmRegistre.TabIndex = 0;
            btmRegistre.Text = "Cadastrar";
            btmRegistre.UseVisualStyleBackColor = true;
            btmRegistre.Click += btmRegistre_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(113, 73);
            txtName.Name = "txtName";
            txtName.Size = new Size(303, 23);
            txtName.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 76);
            lblName.Name = "lblName";
            lblName.Size = new Size(99, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Nome Completo:";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(21, 121);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(86, 15);
            lblDepartment.TabIndex = 3;
            lblDepartment.Text = "Departamento:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(113, 195);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(128, 23);
            txtPassword.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(21, 203);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(42, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Senha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 203);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(113, 156);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(303, 23);
            txtEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(21, 164);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "E-mail:";
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(239, 273);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(75, 23);
            btnReturn.TabIndex = 7;
            btnReturn.Text = "Voltar";
            btnReturn.TextImageRelation = TextImageRelation.TextAboveImage;
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(113, 118);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(121, 23);
            cmbDepartment.TabIndex = 8;
            // 
            // FrmRegistre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 555);
            Controls.Add(cmbDepartment);
            Controls.Add(btnReturn);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(lblDepartment);
            Controls.Add(lblPassword);
            Controls.Add(lblName);
            Controls.Add(txtPassword);
            Controls.Add(txtName);
            Controls.Add(btmRegistre);
            MaximizeBox = false;
            Name = "FrmRegistre";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Usuário";
            Load += FrmRegistre_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btmRegistre;
        private TextBox txtName;
        private Label lblName;
        private Label lblDepartment;
        private TextBox txtPassword;
        private Label lblPassword;
        private Label label4;
        private TextBox txtEmail;
        private Label lblEmail;
        private Button btnReturn;
        private ComboBox cmbDepartment;
    }
}