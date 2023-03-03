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
        private void frmMovProduto_Load(object sender, EventArgs e)
        {
            TestarConexao();
            ComboBoxUser();
            ComboBoxProduto();

        }
        string stringConexao = frmLogin.stringConexao;

        private void Limpar()
        {
            mtbDataC.Text = "";
            cboNomeProd.SelectedItem = "";
            cboIDProd.SelectedItem = "";
            cboNomeUsu.SelectedItem = "";
            cboIDUser.SelectedItem = "";
            cboQtdeEstoque.SelectedItem = "";
            cboTipoMov.SelectedItem = "";
            txtQtdeMovimentada.Text = "";
            cboStatus.Text = "";
            txtObs.Text = "";
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
        private void ComboBoxProduto()
        {
            string sql = "select nome_Produto, id_Produto, qtde_Produto from Produto";
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

                cboNomeProd.DisplayMember = "nome_Produto";
                cboNomeProd.DataSource = tabela;

                cboIDProd.DisplayMember = "id_Produto";
                cboIDProd.DataSource = tabela;

                cboQtdeEstoque.DisplayMember = "qtde_Produto";
                cboQtdeEstoque.DataSource = tabela;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro - " + ex.ToString());
                Application.Exit();
            }
            finally
            {


                con.Close();
            }
        }
        private void ComboBoxUser()
        {
            string sql = "select nome_Usuario, id_Usuario  from Produto";
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

                cboNomeProd.DisplayMember = "nome_Usuario";
                cboNomeProd.DataSource = tabela;

                cboIDProd.DisplayMember = "id_Usuario";
                cboIDProd.DataSource = tabela;




            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro - " + ex.ToString());
                Application.Exit();
            }
            finally
            {


                con.Close();
            }
        }


        private void PesquisaGeral()
        {
            string sql = "select * from Produto where id_Produto =" + txtCodigo.Text;

            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            conexao.Open();

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    mtbDataC.Text = reader[1].ToString();
                    cboNomeProd.SelectedItem = reader[2].ToString();
                    cboIDProd.SelectedItem = reader[3].ToString();
                    cboNomeUsu.SelectedItem = reader[4].ToString();
                    cboIDUser.SelectedItem = reader[5].ToString();
                    cboQtdeEstoque.SelectedItem = reader[6].ToString();
                    cboTipoMov.SelectedItem = reader[7].ToString();
                    txtQtdeMovimentada.Text = reader[8].ToString();
                    cboStatus.Text = reader[9].ToString();
                    txtObs.Text = reader[10].ToString();
                }

                else
                {
                    MessageBox.Show("Código de Produto inexistente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

                conexao.Close();
            }
        }






        private void btoPesquisarProd_Click(object sender, EventArgs e)
        {
            ComboBoxProduto();
        }

        private void btoPesquisa_Click(object sender, EventArgs e)
        {
            PesquisaGeral();
        }

        private void btoPesquisarUser_Click(object sender, EventArgs e)
        {
            ComboBoxUser();
        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btoOk_Click(object sender, EventArgs e)
        {
            string Createdate = Convert.ToDateTime(DateTime.Parse(mtbDataC.Text)).ToString("dd/MM/yyyy h:mm tt");



            if (Validar())
            {
                string sql = "insert into MovProduto  " +
        "(" +
                   "Nome_MovProduto," + // 1
                    "ValorCusto_MovProduto," + // 2
                    "ValorVenda_MovProduto," + //3 
                    "dataCadastro_MovProduto" +// 4
                    "Status_MovProduto," + //5 
                    "id_Categoria_MovProduto," + // 7
                    "qtde_MovProduto," +//8
                    "descricao_MovProduto," + //9
                    "Obs_MovProduto" +
                    ")" +
                    "Values" +
                    "(" +
                    "'" + mtbDataC.Text + "'," + //1
                    "" + cboNomeProd.Text + "," + //2
                    "" + cboIDProd.Text + "," + //3
                    "" + cboNomeUsu.Text + "," +//4
                    "'" + cboIDUser.Text + "'," + // 5
                   "" + cboQtdeEstoque.Text + "," + //7 
                    "" + cboTipoMov.Text + "," + // 8
                    "'" + txtQtdeMovimentada + "'," + //9
                    "'" + cboStatus.Text + "'," +
                    "'" + txtObs.Text + "'" +

                    ")" + "Select SCOPE_Identity()";
                SqlConnection conn = new SqlConnection(stringConexao);
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader;
                conn.Open();

                try
                {
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Limpar();
                        txtCodigo.Text = reader[0].ToString();
                        btoPesquisar.PerformClick();
                        MessageBox.Show("Cadastro realizado com sucesso", "Código Gerado:" + reader[0].ToString());
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    CarregarDataGrid();
                    conn.Close();
                }
            }
        }
    }
    }
}


