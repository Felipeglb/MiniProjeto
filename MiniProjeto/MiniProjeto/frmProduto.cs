﻿

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
            ComboBox();
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

            if (cboCategoria.Text == "")
            {
                MessageBox.Show("Erro, informe a Categoria do produto");
                cboCategoria.Text = "";
                cboCategoria.Focus();
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
                    "'" + cboCategoria.Text + "'" +
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

        private void btoCadastro2_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                string sql = "insert into Usuario  " +
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
                    "'" + cboCategoria + "'" +
                    "'" + mtbDataC.Text + "'" +
                    "'" + txtQtde.Text + "'" +
                    "'" + txtDesc.Text + "'" +
                    "'" + txtObs.Text + "'" +
        ") Select SCOPE_Identity()";
                SqlConnection conn = new SqlConnection(stringConexao);
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader leitura;
                conn.Open();

                try
                {
                    leitura = cmd.ExecuteReader();
                    if (leitura.Read())
                    {
                        MessageBox.Show("Cadastro realizado com sucesso", "Código Gerado:" + leitura[0].ToString());
                        txtCodigo.Text = leitura[0].ToString();

                        txtNome.Text = leitura[1].ToString();
                        txtValorC.Text = leitura[2].ToString();
                        txtValorV.Text = leitura[3].ToString();
                        cboStatus.SelectedItem = leitura[4].ToString();
                        cboCategoria.Text = leitura[5].ToString();
                        mtbDataC.Text = leitura[6].ToString();
                        txtQtde.Text = leitura[7].ToString();
                        txtDesc.Text = leitura[8].ToString();
                        txtObs.Text = leitura[9].ToString();





                        btoPesquisar.PerformClick();
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

        private void btoPesquisar_Click(object sender, EventArgs e)
        {
            string sql = "select * from Usuario where id_Produto =" + txtCodigo.Text;

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
                    txtNome.Text = reader[1].ToString();
                    txtValorC.Text = reader[2].ToString();
                    txtValorV.Text = reader[3].ToString();
                    cboStatus.SelectedItem = reader[4].ToString();
                    cboCategoria.Text = reader[5].ToString();
                    mtbDataC.Text = reader[6].ToString();
                    txtQtde.Text = reader[7].ToString();
                    txtDesc.Text = reader[8].ToString();
                    txtObs.Text = reader[9].ToString();
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

        private void btoAlterar_Click(object sender, EventArgs e)
        {
            string sql = "update  Produto set " +
"nome_Usuario= '" + txtNome.Text + "'," +
"ValorCusto_Produto= '" + txtValorC.Text + "'," +
"ValorVenda_Produto= '" + txtValorV.Text + "'," +
"status_Produto= '" + cboStatus.Text + "'," +
"Nome_Categoria_Produto= '" + cboCategoria.Text + "'," +
"descricao_Produto= '" + mtbDataC.Text + "'," +
"qtde_Produto= '" + txtQtde.Text + "'," +
"dataCadastro_Produto= '" + txtDesc.Text + "'," +
"obs_Usuario= '" + txtObs.Text + "'" +
"Where id_Produto = " + txtCodigo.Text;

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;


            try
            {
                conn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Dados Alterados com sucesso");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtValorC.Text = "";
            txtValorV.Text = "";
            cboStatus.Text = "";
            cboCategoria.Text = "";
            mtbDataC.Text = "";
            txtQtde.Text = "";
            txtDesc.Text = "";
            txtObs.Text = "";
        }

        private void btoExcluir_Click(object sender, EventArgs e)
        {
            string sql = "delete from  Usuario Where id_Produto = " + txtCodigo.Text;

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;

            try
            {
                conn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Dados excluídos");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        void ComboBox()
        {
            string sql = "select id_Categoria, nome_Categoria from Categoria";
            SqlConnection con = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql,con);
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

                tabela.Load(reader);
                cboIDCate.DisplayMember = "id_Categoria";
                cboIDCate.DataSource = tabela;

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
       

 




    }
}