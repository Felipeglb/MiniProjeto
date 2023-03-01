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
    public partial class frmCategoriaPesquisa : Form
    {
        public frmCategoriaPesquisa()
        {
            InitializeComponent();
        }



        string Conexao = frmLogin.stringConexao;
        public string _codigo;

        private void TestarConexao()
        {
            SqlConnection conn = new SqlConnection(Conexao);

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
            string sql = "select id_Categoria as 'ID'," +
    "nome_Categoria as 'Nome'," +
    "Status_Categoria as 'Status'," +
    "descricao_Categoria as 'Descrição'" +
    "from Categoria where nome_Categoria like '%" + txtNomePesquisa.Text + "%'";
            SqlConnection connection = new SqlConnection(Conexao);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();

            try
            {
                adapter.Fill(ds);
                dataGridCategoriaPesquisa.DataSource = ds.Tables[0];
                dataGridCategoriaPesquisa.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridCategoriaPesquisa.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCellsExceptHeader);

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

        private void txtNomePesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregarDataGrid();
            
        }

        private void frmCategoriaPesquisa_Load_1(object sender, EventArgs e)
        {
            CarregarDataGrid();
            TestarConexao();
        }

        private void dataGridCategoriaPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _codigo = dataGridCategoriaPesquisa.CurrentRow.Cells["ID"].Value.ToString();
            this.Close();
        }
    }


}

