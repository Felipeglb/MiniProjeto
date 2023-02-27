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
    public partial class frmLogin : Form
    {
        public static string stringConexao = " data source = Localhost; initial Catalog=T13_MiniProjeto;User ID=sa; password=123456";
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

            public frmLogin()
        {
            InitializeComponent();
            
        }
        public static string IDUsuario = "";
        public static string NomeUsuario = "";
        public static string LoginUsuario = "";

        private void frmLogin_Load(object sender, EventArgs e)
        {
            TestarConexao();
        }

        private void btoOK_Click(object sender, EventArgs e)
        { Boolean Valida = false;
            string sql = "select * from usuario where " +
                "login_Usuario = '" + txtLogin.Text + "' and " +
                "senha_Usuario = '" + txtSenha.Text + "'";

            

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
                    Valida = true;
                    IDUsuario = reader[0].ToString();
                    NomeUsuario = reader[1].ToString();
                    LoginUsuario = reader[2].ToString();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos");
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

            if (Valida)
            {
                MDIParent1 frm = new MDIParent1();
                frm.Show();
                this.Hide();
            }
        }
    }
}
