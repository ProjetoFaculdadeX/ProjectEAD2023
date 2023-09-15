using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.Data.SqlClient;

namespace ProjectEAD2023
{
    public partial class FrmRegistre : Form
    {
        FrmLogin frmLogin = new FrmLogin();
        Banco.UserDataBase user = new Banco.UserDataBase();

        public FrmRegistre()
        {
            InitializeComponent();
        }

        private void btmRegistre_Click(object sender, EventArgs e)
        {
            //Conexão com banco

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AUL6F82\MSSQL;Initial Catalog=ProjectEAD;Integrated Security=SSPI;TrustServerCertificate=True");
            try
            {
                string strNome = txtName.Text;
                int intDepartment = Int32.Parse(cmbDepartment.SelectedValue.ToString());
                string strEmail = txtEmail.Text;
                string strPassword = "";


                if (strNome != "" || intDepartment == 0 || strEmail != "" || strPassword != "")
                {
                    strPassword = BD.Criptografar(txtPassword.Text);

                    user.UserRegister(strNome, intDepartment, strEmail, strPassword, DateTime.Now, DateTime.Now);
                    MessageBox.Show("CADASTRO REALIZADO COM SUCESSO!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                    frmLogin.Show();
                }
                else
                    MessageBox.Show("Preencha todos os campos obrigatórios!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro" + ex);
                con.Close();
            }
            finally
            {
                con.Close();
            }


        }

        private void FrmRegistre_Load(object sender, EventArgs e)
        {
            DataTable DepartmentList = user.DepartamentList();

            cmbDepartment.ValueMember = "DEPARTMENT_ID";
            cmbDepartment.DisplayMember = "DEPARTMENT";
            cmbDepartment.DataSource = DepartmentList;
        }
    }
}
