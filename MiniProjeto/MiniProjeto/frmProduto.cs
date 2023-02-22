

namespace MiniProjeto
{
    using System.Data;
    using System.Data.SqlClient;
    public partial class frmProduto : Form
    {
        string stringConexao = " data source = Localhost; initial Catalog=T13_MiniProjeto;User ID=sa; password=123456";
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
        public frmProduto()
        {
            InitializeComponent();
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            TestarConexao();
        }
        private bool Validar()
        {

            if (txtNome.Text == "")
            {
                MessageBox.Show("Erro, o campo Nome deve ser preenchido");
                txtNome.Text = "";
                txtNome.Focus();
                return false;
            }

            if (txtValorC.Text == "")
            {
                MessageBox.Show("Erro, o Valor de custo deve ser informado");
                txtValorC.Text = "";
                txtValorC.Focus();
                return false;
            }

            if (txtValorV.Text == "")
            {
                MessageBox.Show("Erro, o Valor de Venda deve ser informado");
                txtValorV.Text = "";
                txtValorV.Focus();
                return false;
            }

            if (cboStatus.Text == "")
            {
                MessageBox.Show("Erro, o campo Status deve ser preenchido");
                cboStatus.SelectedIndex = -1;
                cboStatus.Focus();
                return false;
            }

            if (txtCategoria.Text == "")
            {
                MessageBox.Show("Erro, informe a Categoria do produto");
                txtCategoria.Text = "";
                txtCategoria.Focus();
                return false;
            }


            if (mtbDataC.Text == "")
            {
                MessageBox.Show("Erro, Data de Cadastro não informada");
                mtbDataC.Text = "";
                mtbDataC.Focus();
                return false;
            }
            
            if (txtQtde.Text == "")
            {
                MessageBox.Show("Erro, informe a Quantidade do Produto disponível");
                txtQtde.Text = "";
                txtQtde.Focus();
                return false;
            }
            return true;
        }
        


private void btoCadastro1_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                string sql = "insert into Produto" +
                    "(" +
                    "Nome_Produto," +
                    "ValorCusto_Produto," +
                    "ValorVenda_Produto," +
                    "Status_Produto," +
                    "Nome_Categoria_Produto," +
                    "dataCadastro_Produto," +
                    "qtde_Produto," +
                    "descricao_Produto," +
                    "Obs_Produto" +
                    ")" +
                    "Values" +
                    "(" +
                    "'" + txtNome.Text + "'," +
                    "'" + txtValorC.Text + "'," +
                    "'" + txtValorV.Text + "'," +
                    "'" + cboStatus.Text + "'" +
                    "'" + txtCategoria.Text + "'" +
                    "'" + mtbDataC.Text + "'" +
                    "'" + txtQtde.Text + "'" +
                    "'" + txtDesc.Text + "'" +
                    "'" + txtObs.Text + "'" +
                    ")";

                SqlConnection conn = new SqlConnection(stringConexao);
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Cadastro realizado com sucesso");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
