using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjeto
{
    public partial class frmMovProduto : Form
    {
        public frmMovProduto()
        {
            InitializeComponent();
        }

        private void TestarConexao()
        {
            SqlConnection conn = new SqlConnection(stringConexao);

            try
            {
                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
                Application.Exit();
            }
        }
        ComboBox()
        { 

        string sql = "select id_Categoria, nome_Categoria from Categoria";
        SqlConnection con = new SqlConnection(stringConexao);
        SqlCommand cmd = new SqlCommand(sql, con);
        cmd.CommandType = CommandType.Text;
            SqlDataReader reader;

        DataTable tabela = new DataTable();
        con.Open();

            try
            {
                reader = cmd.ExecuteReader();
                tabela.Load(reader);

                cboCategoria.DisplayMember = "nome_Categoria";
                cboCategoria.DataSource = tabela;


                cboIDCate.DisplayMember = "id_Categoria";
                cboIDCate.DataSource = tabela;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro - " + ex.ToString());
                Application.Exit();
            }
            finally
            }
{
    con.Close();
}

private void frmMovProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
