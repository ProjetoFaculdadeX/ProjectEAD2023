using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjectEAD2023.Banco
{
    class UserDataBase : DataBaseConnection
    {
        public int UserRegister(string strNome, int intDepart, string strEmail, string strPassword, DateTime dtCreate, DateTime dtModified)
        {
            string SqlQuery = string.Empty;
            SqlCommand c = null;
            SqlConnection conn = null;

            try
            {
                SqlQuery = "INSERT INTO USER_LOGIN(NOME_USER, DEPARTMENT_ID, EMAIL, USER_PASSWORD, DATE_CREATE, DATE_MODIFIED) " +
                        "VALUES (@NOME_USER, @DEPARTMENT_ID, @EMAIL, @USER_PASSWORD, @DATE_CREATE, @DATE_MODIFIED)";

                conn = new SqlConnection(strConnection);
                c = new SqlCommand(SqlQuery.ToString(), conn);

                c.Parameters.Add("@NOME_USER", SqlDbType.VarChar).Value = strNome;
                c.Parameters.Add("@DEPARTMENT_ID", SqlDbType.VarChar).Value = intDepart;
                c.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = strEmail;
                c.Parameters.Add("@USER_PASSWORD", SqlDbType.VarChar).Value = strPassword;
                c.Parameters.Add(new SqlParameter("@DATE_CREATE", dtCreate));
                c.Parameters.Add(new SqlParameter("@DATE_MODIFIED", dtModified));

                return ExecuteSqlCommand(c);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable DepartamentList()
        {
            string SqlQuery = string.Empty;
            SqlCommand c = new SqlCommand();
            SqlConnection conn = new SqlConnection(strConnection);
            DataTable dt = new DataTable();

            try
            {
                SqlQuery = "SELECT DEPARTMENT_ID, DEPARTMENT FROM DEPARTMENT UNION ALL SELECT 0, '' ORDER BY DEPARTMENT";

                conn.Open();
                c.Connection = conn;
                c.CommandText = SqlQuery;

                SqlDataReader dr = c.ExecuteReader();

                dt.Load(dr);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public SqlDataReader AuthLogin(string strLogin, string strPassword)
        {
            string SqlQuery = string.Empty;
            SqlCommand c = new SqlCommand();
            SqlConnection conn = new SqlConnection(strConnection);

            try
            {
                SqlQuery = "SELECT 1 FROM USER_LOGIN WHERE NOME_USER = @NOME_USER AND USER_PASSWORD = @USER_PASSWORD";

                conn = new SqlConnection(strConnection);
                c = new SqlCommand(SqlQuery.ToString(), conn);

                c.Parameters.Add("@NOME_USER", SqlDbType.VarChar).Value = strLogin;
                c.Parameters.Add("@USER_PASSWORD", SqlDbType.VarChar).Value = strPassword;

                conn.Open();
                c.Connection = conn;
                c.CommandText = SqlQuery;

                return c.ExecuteReader();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
