



namespace MiniProjeto

{
    using System.Data;
    using System.Data.SqlClient;
    public partial class frmCategoria : Form
    {
        string stringConexao = frmLogin.stringConexao;
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
            CarregarDataGrid();
            TestarConexao();
        }
        private bool Validar()
        {
            if (txtNome.Text == "")
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











 

 
        void CarregarDataGrid()
        {
            string sql = "select id_Categoria as 'ID'," +
       "nome_Categoria as 'Categoria'," +
       "Status_Categoria as 'Status'" +


       "from Categoria where nome_Categoria like '%" + textBox1.Text + "%'";
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();

            try
            {
                adapter.Fill(ds);
                dataGridCategoria.DataSource = ds.Tables[0];
                dataGridCategoria.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridCategoria.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCellsExceptHeader);

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





        private void frmCategoria_Load(object sender, EventArgs e)
        {
            TestarConexao();
            CarregarDataGrid();
        }

        private void btoSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btoCadastro2_Click_1(object sender, EventArgs e)
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
                    CarregarDataGrid();
                    conn.Close();
                }
            }
        }

        private void btoAlterar_Click_1(object sender, EventArgs e)
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
                CarregarDataGrid();
                conn.Close();
            }
        }

        private void btoCadastro1_Click(object sender, EventArgs e)
        {

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
                CarregarDataGrid();
                conn.Close();
            }
        }

        private void dataGridCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dataGridCategoria.CurrentRow.Cells["id_Categoria"].Value.ToString();
            CarregarDataGrid();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }

        private void btoPesquisar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() == "")
            {
                frmUsuarioPesquisa dor = new frmUsuarioPesquisa();
                dor.ShowDialog();
                txtCodigo.Text = dor._codigo;
            }




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
    }
}
