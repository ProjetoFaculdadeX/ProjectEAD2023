namespace ProjectEAD2023
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btmRegister_Click(object sender, EventArgs e)
        {
            FrmRegistre frmRegistre = new FrmRegistre();
            this.Hide();    
            frmRegistre.Show();
        }
    }
}