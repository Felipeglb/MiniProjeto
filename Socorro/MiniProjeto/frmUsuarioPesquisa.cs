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
    public partial class frmUsuarioPesquisa : Form
    {
        public frmUsuarioPesquisa()
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
        string sql =  "select id_Usuario as 'ID'," +
"nome_Usuario as 'Nome'," +
"Status_Usuario as 'Status'," +
"Login_Usuario as 'Login'" +
"from Usuario where nome_Usuario like '%"  + txtNomePesquisa.Text + "%'";
            SqlConnection connection = new SqlConnection(Conexao);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();

            try
            {
                adapter.Fill(ds);
                dataGridUsuarioPesquisa.DataSource = ds.Tables[0];
                dataGridUsuarioPesquisa.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridUsuarioPesquisa.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCellsExceptHeader);

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


        private void frmUsuarioPesquisa_Load(object sender, EventArgs e)
        {
            TestarConexao();
            CarregarDataGrid(); 
        }

        
        private void txtNomePesquisa_TextChanged(object sender, EventArgs e)
        {   
            CarregarDataGrid();
        }

        private void dataGridUsuarioPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _codigo = dataGridUsuarioPesquisa.CurrentRow.Cells["ID"].Value.ToString();
            this.Close();
        }
    }
}
