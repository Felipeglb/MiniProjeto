



namespace MiniProjeto

{
    using System.Data;
    using System.Data.SqlClient;
    public partial class frmCategoria : Form
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
        public frmCategoria()
        {
            InitializeComponent();
        }



        private void frmCategoria_Load_1(object sender, EventArgs e)
        {
            TestarConexao();
        }
        private bool Validar()
        {
            if (txtNome.Text =="" ) 
            {
                MessageBox.Show("Erro, o nome da Categoria deve ser inserido");
                txtNome.Text = "";
                txtNome.Focus();
                return false;
            }

            if (cboStatus.Text == "") 
            {
                MessageBox.Show("Erro, o campo Status deve ser preenchido");
                cboStatus.SelectedIndex = -1;
                cboStatus.Focus();
                return false;
            }
            return true;
        }

        private void btoPesquisar_Click(object sender, EventArgs e)
        {
            string sql = "select * from Categoria where id_Categoria =" + txtCodigo.Text;

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
                    txtDesc.Text = reader[2].ToString();
                    cboStatus.SelectedItem = reader[3].ToString();
                    txtObs.Text = reader[4].ToString();
                }
                
                    
                else
                {
                    MessageBox.Show("Categoria inexistente");
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

        private void btoCadastro1_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                string sql = "insert into Categoria" +
                    "(" +
                    "nome_Categoria," +
                    "descricao_Categoria," +
                    "status_Categoria," +
                    "obs_Categoria" +
                    ")" +
                    "Values" +
                    "(" +
                    "'" + txtNome.Text + "'," +
                    "'" + txtDesc.Text + "'," +
                    "'" + cboStatus.Text + "'," +
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
                string sql = "insert into Categoria" +
                    "(" +
                    "Nome_Categoria," +
                    "Descricao_Categoria," +
                    "Status_Categoria," +
                    "Obs_Categoria" +
                    ")" +
                    "Values" +
                    "(" +
                    "'" + txtNome.Text + "'," +
                    "'" + txtDesc.Text + "'," +
                    "'" + cboStatus.Text + "'," +
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
                        txtDesc.Text = leitura[2].ToString();
                        cboStatus.SelectedItem = leitura[3].ToString();
                        txtObs.Text = leitura[4].ToString();





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

        private void btoAlterar_Click(object sender, EventArgs e)
        {
            string sql = "update  Categoria set " +
"nome_Categoria= '" + txtNome.Text + "'," +
"Descricao_Categoria= '" + txtDesc.Text + "'," +
"status_Usuario= '" + cboStatus.Text + "'," +
"obs_Categoria= '" + txtObs.Text + "'" +
"Where id_Categoria = " + txtCodigo.Text;

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
            txtCodigo.Text = "";
            txtNome.Text = "";
            cboStatus.SelectedIndex = -1;
            txtDesc.Text = "";
            txtObs.Text = "";
        }

        private void btoExcluir_Click(object sender, EventArgs e)
        {
            string sql = "delete from  Categoria Where id_Categoria = " + txtCodigo.Text;

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
    }
    }
