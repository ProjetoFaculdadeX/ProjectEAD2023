using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEAD2023.Banco
{
    class ProductDataBase : DataBaseConnection
    {
        public int ProductRegistre(string strDescription, string strLote, string strValidade, string strQuantity, DateTime dtCreate, DateTime dtModified)
        {
            string SqlQuery = string.Empty;
            SqlCommand c = null;
            SqlConnection conn = null;

            try
            {
                SqlQuery = "INSERT INTO PRODUCT_ESTOQUE(DESCRIPTION_PRODUCT, LOTE, VALIDADE, QUANTIDADE, DATE_CREATED, DATE_MODIFIED) " +
                        "VALUES (@DESCRIPTION_PRODUCT, @LOTE, @VALIDADE, @QUANTIDADE, @DATE_CREATED, @DATE_MODIFIED)";

                conn = new SqlConnection(strConnection);
                c = new SqlCommand(SqlQuery.ToString(), conn);

                c.Parameters.Add("@DESCRIPTION_PRODUCT", SqlDbType.VarChar).Value = strDescription;
                c.Parameters.Add("@LOTE", SqlDbType.VarChar).Value = strLote;
                c.Parameters.Add("@VALIDADE", SqlDbType.VarChar).Value = strValidade;
                c.Parameters.Add("@QUANTIDADE", SqlDbType.VarChar).Value = strQuantity;
                c.Parameters.Add(new SqlParameter("@DATE_CREATED", dtCreate));
                c.Parameters.Add(new SqlParameter("@DATE_MODIFIED", dtModified));

                return ExecuteSqlCommand(c);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
