using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ProjectEAD2023.Banco
{
    class DataBaseConnection
    {
        //Conexão com banco
        public static string strConnection = @"Data Source=JULIO_FREITAS;Initial Catalog=ProjetoEAD;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public static int ExecuteSqlCommand(SqlCommand strSql)
        {
            int RetVal = 0;
            using (SqlConnection con = new SqlConnection(strConnection))
            {
                con.Open();
                strSql.Connection = con;
                RetVal = strSql.ExecuteNonQuery();
                con.Close();
                con.Dispose();
            }
            return RetVal;
        }

    }
}
