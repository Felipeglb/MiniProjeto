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
    public partial class frmProdutoPesquisa : Form
    {
        string stringConexao = frmLogin.stringConexao;
        public string _codigo;
        public frmProdutoPesquisa()
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

        private void CarregarDataGrid()
        {
            string sql = "select id_Produto as 'ID'," +
    "Nome_Produto as 'Nome'," +
    "ValorCusto_Produto as 'vCusto'," +
    "ValorVenda_Produto as 'vVenda'," +
    "qtde_Produto as 'Qtde'," +
    "Status_Produto as 'Status'" +
    "from Produto  where Nome_Produto like '%" + txtNomePesquisa.Text + "%'";
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();

            try
            {
                adapter.Fill(ds);
                dataGridProdutoPesquisa.DataSource = ds.Tables[0];
                dataGridProdutoPesquisa.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridProdutoPesquisa.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCellsExceptHeader);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                connection.Close();
            }
        }


        private void frmProdutoPesquisa_Load(object sender, EventArgs e)
        {
            TestarConexao();
            CarregarDataGrid();
        }

        private void dataGridProdutoPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _codigo = dataGridProdutoPesquisa.CurrentRow.Cells["ID"].Value.ToString();
            this.Close();
        }
    }
}
