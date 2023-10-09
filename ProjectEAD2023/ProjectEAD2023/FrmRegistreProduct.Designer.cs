namespace ProjectEAD2023
{
    partial class FrmRegistreProduct
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
            btnReturn = new Button();
            lblEmail = new Label();
            txtLote = new TextBox();
            lblPassword = new Label();
            lblDescription = new Label();
            txtQuantity = new TextBox();
            txtDescription = new TextBox();
            btmRegistre = new Button();
            SuspendLayout();
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(60, 193);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(75, 23);
            btnReturn.TabIndex = 17;
            btnReturn.Text = "Voltar";
            btnReturn.TextImageRelation = TextImageRelation.TextAboveImage;
            btnReturn.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(60, 73);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(33, 15);
            lblEmail.TabIndex = 16;
            lblEmail.Text = "Lote:";
            // 
            // txtLote
            // 
            txtLote.Location = new Point(113, 73);
            txtLote.Name = "txtLote";
            txtLote.Size = new Size(303, 23);
            txtLote.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(21, 119);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(72, 15);
            lblPassword.TabIndex = 12;
            lblPassword.Text = "Quantidade:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(32, 39);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(61, 15);
            lblDescription.TabIndex = 13;
            lblDescription.Text = "Descrição:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(113, 119);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PasswordChar = '*';
            txtQuantity.Size = new Size(128, 23);
            txtQuantity.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(113, 36);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(303, 23);
            txtDescription.TabIndex = 1;
            // 
            // btmRegistre
            // 
            btmRegistre.Location = new Point(226, 193);
            btmRegistre.Name = "btmRegistre";
            btmRegistre.Size = new Size(75, 23);
            btmRegistre.TabIndex = 9;
            btmRegistre.Text = "Cadastrar";
            btmRegistre.UseVisualStyleBackColor = true;
            // 
            // FrmRegistreProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReturn);
            Controls.Add(lblEmail);
            Controls.Add(txtLote);
            Controls.Add(lblPassword);
            Controls.Add(lblDescription);
            Controls.Add(txtQuantity);
            Controls.Add(txtDescription);
            Controls.Add(btmRegistre);
            Name = "FrmRegistreProduct";
            Text = "FrmRegistreProduct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnReturn;
        private Label lblEmail;
        private TextBox txtLote;
        private Label lblPassword;
        private Label lblDescription;
        private TextBox txtQuantity;
        private TextBox txtDescription;
        private Button btmRegistre;
    }
}