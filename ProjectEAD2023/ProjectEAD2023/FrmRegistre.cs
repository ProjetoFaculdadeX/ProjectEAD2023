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
        public FrmRegistre()
        {
            InitializeComponent();
        }



        private void btmRegistre_Click(object sender, EventArgs e)
        {
            //Conexão com banco

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AUL6F82\MSSQL;Initial Catalog=ProjectEAD;Integrated Security=SSPI;TrustServerCertificate=True");

            string sql = "INSERT INTO NEWUSER_LOGIN(NOME_USER, DEPARTMENT, EMAIL, USER_PASSWORD, DATE_CREATE, DATE_MODIFIED) VALUES (@NOME_USER, @DEPARTMENT, @EMAIL, @USER_PASSWORD, @DATE_CREATE, @DATE_MODIFIED)";
            //int userID = 1;
           

            DateTime dateTime = DateTime.Now;


            try
            {
                string nome = txtName.Text;
                string department = txtDepartment.Text;
                string email = txtEmail.Text;
                string password = BD.Criptografar(txtPassword.Text);
                SqlCommand c = new(sql, con);

                //c.Parameters.Add("@USER_ID", SqlDbType.VarChar).
                c.Parameters.Add("@NOME_USER", SqlDbType.VarChar).Value = nome;
                c.Parameters.Add("@DEPARTMENT", SqlDbType.VarChar).Value = department;
                c.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = email;
                c.Parameters.Add("@USER_PASSWORD", SqlDbType.VarChar).Value = password;
                c.Parameters.Add(new SqlParameter("@DATE_CREATE", dateTime));
                c.Parameters.Add(new SqlParameter("@DATE_MODIFIED", dateTime));

                con.Open();

                c.ExecuteNonQuery();

                MessageBox.Show("CADASTRO REALIZADO COM SUCESSO!");

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
    }
}
