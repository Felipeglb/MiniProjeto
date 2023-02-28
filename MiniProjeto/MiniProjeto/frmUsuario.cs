
namespace MiniProjeto

{
    using System.Data;
    using System.Data.SqlClient;

    public partial class frmUsuario : Form
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
        public frmUsuario()
        {
            InitializeComponent();
        }


        private void frmUsuario_Load(object sender, EventArgs e)
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

            if (txtLogin.Text == "")
            {
                MessageBox.Show("Erro, o campo Login deve ser preenchido");
                txtLogin.Text = "";
                txtLogin.Focus();
                return false;
            }

            if (txtSenha.Text == "")
            {
                MessageBox.Show("Erro, o campo Senha deve ser preenchido");
                txtSenha.Text = "";
                txtSenha.Focus();
                return false;
            }

            if (txtConfirmaS.Text != txtSenha.Text)
            {
                MessageBox.Show("Erro, a Senha deve ser identica nos dois campos deve ser preenchido");
                txtConfirmaS.Text = "";
                txtConfirmaS.Focus();
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


        private void btoCadastro_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                string sql = "insert into Usuario" +
                    "(" +
                    "nome_Usuario," +
                    "Status_Usuario," +
                    "Login_Usuario," +
                    "Senha_Usuario," +
                    "Obs_Usuario" +
                    ")" +
                    "Values" +
                    "(" +
                    "'" + txtNome.Text + "'," +
                    "'" + cboStatus.Text + "'," +
                    "'" + txtLogin.Text + "'," +
                    "'" + txtSenha.Text + "'," +
                    "'" + txtObservacao.Text + "'" +
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
                    CarregarDataGrid();
                    conn.Close();
                }
            }
        }

        private void btoCadastrar2_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                string sql = "insert into Usuario  " +
        "(" +
        "nome_Usuario," +
        "Status_Usuario," +
        "Login_Usuario," +
        "Senha_Usuario," +
        "Obs_Usuario" +
        ")" +
        "Values" +
        "(" +
        "'" + txtNome.Text + "'," +
        "'" + cboStatus.SelectedItem + "'," +
        "'" + txtLogin.Text + "'," +
        "'" + txtSenha.Text + "'," +
        "'" + txtObservacao.Text + "'" +
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
                        txtLogin.Text = leitura[2].ToString();
                        cboStatus.SelectedItem = leitura[3].ToString();
                        txtLogin.Text = leitura[4].ToString();
                        txtSenha.Text = leitura[5].ToString();
                        txtObservacao.Text = leitura[6].ToString();





                        btoPesquisar.PerformClick();
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



        private void btoPesquisar_Click(object sender, EventArgs e)
        {
            string sql = "select * from Usuario where id_Usuario =" + txtCodigo.Text;

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
                    txtLogin.Text = reader[2].ToString();
                    txtSenha.Text = reader[3].ToString();
                    txtConfirmaS.Text = reader[3].ToString();
                    txtObservacao.Text = reader[4].ToString();
                    cboStatus.SelectedItem = reader[5].ToString();
                }
                else
                {
                    MessageBox.Show("Código do Usuário inexistente");
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
            string sql = "update  Usuario set " +
            "nome_Usuario= '" + txtNome.Text + "'," +
            "status_Usuario= '" + cboStatus.Text + "'," +
            "login_Usuario= '" + txtLogin.Text + "'," +
            "senha_Usuario= '" + txtSenha.Text + "'," +
            "obs_Usuario= '" + txtObservacao.Text + "'" +
            "Where id_Usuario = " + txtCodigo.Text;

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
                CarregarDataGrid();
                conn.Close();
            }
        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {

            txtCodigo.Text = "";
            txtNome.Text = "";
            cboStatus.SelectedIndex = -1;
            txtLogin.Text = "";
            txtSenha.Text = "";
            txtConfirmaS.Text = "";
            txtObservacao.Text = "";
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btoExcluir_Click(object sender, EventArgs e)
        {
            string sql = "delete from  Usuario Where id_Usuario = " + txtCodigo.Text;

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
                CarregarDataGrid();
                conn.Close();
            }
        }

        void CarregarDataGrid()
        {
            string sql = "select id_Usuario as 'ID'," +
       "nome__Usuario as 'Nome'," +
        "Status_Usuario as 'Status'," +
       "Login_Usuario as 'Login'," +
       "from Usuario where nome_Usuario like '%" + txtNome.Text + "%'";
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();

            try
            {
                adapter.Fill(ds);
                dataGridUsuario.DataSource = ds.Tables[0];
                dataGridUsuario.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridUsuario.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCellsExceptHeader);

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }
    }
}