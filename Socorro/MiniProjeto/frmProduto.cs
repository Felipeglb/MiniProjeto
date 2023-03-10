

namespace MiniProjeto
{
    using System.Data;
    using System.Data.SqlClient;
    public partial class frmProduto : Form
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
        public frmProduto()
        {
            InitializeComponent();
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

        void Limpar()
        {
            txtCodigo.Text = "";
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

        void CarregarDataGrid()
        {
            string sql = "select id_Produto as 'ID'," +
       "nome_Produto as 'Nome'," +
       "ValorVenda_Produto as 'Valor Venda'," +
       "qtde_Produto as 'Qtde'," +
       "Status_Produto as 'Status'" +
       "from Produto where nome_Produto like '%" + txtNome.Text + "%'";
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();

            try
            {
                adapter.Fill(ds);
                dataGridProduto.DataSource = ds.Tables[0];
                dataGridProduto.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridProduto.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCellsExceptHeader);

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



  




       private void ComboBox()
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
            {
                con.Close();
            }
        }





        private void frmProduto_Load_1(object sender, EventArgs e)
        {
            TestarConexao();
            CarregarDataGrid();
            ComboBox();
        }

        private void btoCadastro2_Click_1(object sender, EventArgs e)
        {
            string vCusto = txtValorC.Text;
            //R$ 1.000,00
            vCusto = vCusto.Replace("R$ ", ""); //1.000,00
            vCusto = vCusto.Replace(".", ""); //1000,00
            vCusto = vCusto.Replace(',', '.');//1000.00

            string vVenda = txtValorV.Text;
            //R$ 1.000,00
            vVenda = vVenda.Replace("R$ ", ""); //1.000,00
            vVenda = vVenda.Replace(".", "");   //1000,00
            vVenda = vVenda.Replace(",", "."); //1000.00

           


            string Createdate = Convert.ToDateTime(DateTime.Parse(mtbDataC.Text)).ToString("dd/MM/yyyy h:mm tt");



            if (Validar())
            {
                string sql = "insert into Produto  " +
        "(" +
                   "Nome_Produto," + // 1
                    "ValorCusto_Produto," + // 2
                    "ValorVenda_Produto," + //3 
                    "dataCadastro_Produto"+// 4
                    "Status_Produto," + //5 
                    "id_Categoria_Produto," + // 7
                    "qtde_Produto," +//8
                    "descricao_Produto," + //9
                    "Obs_Produto" + 
                    ")" +
                    "Values" +
                    "(" +
                    "'" + txtNome.Text + "'," + //1
                    "" + vCusto + "," + //2
                    "" + vVenda + "," + //3
                    "" + mtbDataC + ","+//4
                    "'" + cboStatus.Text + "'," + // 5
                   "" + cboIDCate.Text + "," + //7 
                    "" + txtQtde.Text + "," + // 8
                    "'" + txtDesc.Text + "'," + //9
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

        private void txtNomePesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }



        private void btoAlterar_Click_1(object sender, EventArgs e)
        {
            string vCusto = txtValorC.Text;
            //R$ 1.000,00
            vCusto = vCusto.Replace("R$ ", ""); //1.000,00
            vCusto = vCusto.Replace(".", ""); //1000,00
            vCusto = vCusto.Replace(',', '.');//1000.00

            string vVenda = txtValorV.Text;
            //R$ 1.000,00
            vVenda = vVenda.Replace("R$ ", ""); //1.000,00
            vVenda = vVenda.Replace(".", "");   //1000,00
            vVenda = vVenda.Replace(",", "."); //1000.00

            string Createdate = Convert.ToDateTime(DateTime.Parse(mtbDataC.Text)).ToString("dd/MM/yyyy h:mm tt");

            string sql = "update  Produto set " +
"nome_Produto= '" + txtNome.Text + "'," +
"ValorCusto_Produto= '" + vCusto + "'," +
"ValorVenda_Produto= '" + vVenda + "'," +
"status_Produto= '" + cboStatus.Text + "'," +
"dataCadastro_Produto= '" + txtDesc.Text + "'," +
"id_Categoria_Produto= '" + cboIDCate.Text + "'," +
"descricao_Produto= '" + mtbDataC.Text + "'," +
"qtde_Produto= '" + txtQtde.Text + "'," +
"obs_Produto= '" + txtObs.Text + "'" +
"Where id_Produto = " + txtCodigo.Text;

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
            Limpar();

        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btoExcluir_Click_1(object sender, EventArgs e)
        {
            string sql = "delete from  Produto Where id_Produto = " + txtCodigo.Text;

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
                CarregarDataGrid();
                conn.Close();
            }
        }



        private void btoPesquisar_Click(object sender, EventArgs e)
        {

            if (txtCodigo.Text.Trim() == "")
            {
                frmProdutoPesquisa dor = new frmProdutoPesquisa();
                dor.ShowDialog();
                txtCodigo.Text = dor._codigo;
            }
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
                    txtNome.Text = reader[1].ToString();

                    txtValorC.Text = reader[2].ToString();
                    string test = txtValorC.Text;
                    txtValorC.Text = String.Format("{0:C}", float.Parse(txtValorC.Text));

                    txtValorV.Text = reader[3].ToString();
                    txtValorV.Text = String.Format("{0:C}", float.Parse(txtValorV.Text));

                    mtbDataC.Text = reader[4].ToString();
                    cboStatus.SelectedItem = reader[5].ToString();                    
                    cboIDCate.Text = reader[6].ToString();
                    txtDesc.Text = reader[7].ToString();
                    txtQtde.Text = reader[8].ToString();                 
                    txtObs.Text = reader[9].ToString();
                   
                    CarregarDataGrid();
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

        private void dataGridProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dataGridProduto.CurrentRow.Cells["id_Produto"].Value.ToString();
            CarregarDataGrid();
        }

        private void txtValorC_Enter(object sender, EventArgs e)
        {
            txtValorC.Text = txtValorC.Text.Replace("R$ ", "");
        }



        private void txtValorC_Leave(object sender, EventArgs e)
        {
            float vCusto;
            if (!float.TryParse(txtValorC.Text, out vCusto) && txtValorC.Text.Trim() != "")
            {
                MessageBox.Show("Erro. Valor de custo deve ser numérico e sem formato.");
                txtValorC.Text = "";
                txtValorC.Focus();
                return;
            }
            else if (txtValorC.Text.Trim() == "")
            {
                txtValorC.Text = "";
                return;
            }

            txtValorC.Text = String.Format("{0:C}", vCusto);
        }

        
        private void txtValorV_Leave(object sender, EventArgs e)
        {
            float vVenda;
            if (!float.TryParse(txtValorV.Text, out vVenda) && txtValorV.Text.Trim() != "")
            {
                MessageBox.Show("Erro. Valor de custo deve ser numérico e sem formato.");
                txtValorV.Text = "";
                txtValorV.Focus();
                return;
            }
            else if (txtValorV.Text.Trim() == "")
            {
                txtValorV.Text = "";
                return;
            }

            txtValorV.Text = String.Format("{0:C}", vVenda);
        }

        private void txtValorV_Enter(object sender, EventArgs e)
        {
            txtValorV.Text = txtValorV.Text.Replace("R$ ", "");
        }

    }
}





