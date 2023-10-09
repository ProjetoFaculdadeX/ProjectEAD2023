using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using ProjectEAD2023.Banco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace ProjectEAD2023
{
    public partial class FrmRegistreProduct : Form
    {
        FrmInitial frminitial = new FrmInitial();
        Banco.ProductDataBase produto = new Banco.ProductDataBase();
        public FrmRegistreProduct()
        {
            InitializeComponent();
        }

        private void btmRegistreProduct_Click(object sender, EventArgs e)
        {
            //Conexão com banco

            SqlConnection con = new SqlConnection(@"Data Source=JULIO_FREITAS;Initial Catalog=ProjetoEAD;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AUL6F82\MSSQL;Initial Catalog=ProjectEAD;Integrated Security=SSPI;TrustServerCertificate=True");
            try
            {
                string strDescription = txtDescription.Text;
                string strLote = txtLote.Text;
                string strValidade = txtValidade.Text;
                string strQuantity = txtQuantity.Text;               

                // Valide a entrada para garantir que seja uma data válida no formato desejado
                if (DateTime.TryParseExact(strValidade, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime date))
                {
                    // Caminho do arquivo de texto
                    string filePath = "data.txt";

                    try
                    {
                        // Escreva a data no arquivo de texto
                        using (StreamWriter writer = new StreamWriter(filePath, true))
                        {
                            writer.WriteLine(date.ToString("dd/MM/yyyy"));
                        }                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao salvar a data: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Data inserida é inválida. Use o formato DD/MM/AAAA.");
                }            


                if (strDescription != "" || strLote != "" || strValidade != "" || strQuantity != "")
                {

                    produto.ProductRegistre(strDescription, strLote, strValidade, strQuantity, DateTime.Now, DateTime.Now);
                    MessageBox.Show("CADASTRO REALIZADO COM SUCESSO!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            FrmInitial frminitial = new FrmInitial();
            this.Hide();
            frminitial.Show();
        }
    }
}
