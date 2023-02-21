



namespace MiniProjeto

{
    using System.Data;
    using System.Data.SqlClient;
    public partial class Form1 : Form
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
        public Form1()
        {
            InitializeComponent();
        }


        private void frmUsuario_Load(object sender, EventArgs e)
        {
            TestarConexao();
        }

        private void btoCadastrar1_Click(object sender, EventArgs e)
        {

        }



        }
}
