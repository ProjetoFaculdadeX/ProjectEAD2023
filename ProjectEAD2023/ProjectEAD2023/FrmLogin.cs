using Microsoft.Data.SqlClient;

namespace ProjectEAD2023
{
    public partial class FrmLogin : Form
    {
        Banco.UserDataBase user = new Banco.UserDataBase();
        FrmInitial FrmInitial = new FrmInitial();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btmRegister_Click(object sender, EventArgs e)
        {
            FrmRegistre frmRegistre = new FrmRegistre();
            this.Hide();
            frmRegistre.Show();
        }

        private void btmLogin_Click(object sender, EventArgs e)
        {
            string strUser = txtUser.Text;
            string strPassword = BD.Criptografar(txtPassword.Text);

            SqlDataReader dt = user.AuthLogin(strUser, strPassword);

            if (dt.Read())
            {
                this.Hide();
                FrmInitial.Show();
                MessageBox.Show("Login realizado com sucesso!", "Bem vindo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Login ou senha incorretos!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}