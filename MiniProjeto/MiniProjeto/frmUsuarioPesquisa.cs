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

        void CarregarDataGrid()
        { 
        string sql =  "select id_Usuario as 'ID'," +
"nome__Usuario as 'Nome'," +
"Status_Usuario as 'Status'," +
"Login_Usuario as 'Login'," +
"from Usuario where nome_Usuario like '%"  + txtNomePesquisa.Text + "'%";  
        }
        private void dataGridUsuarioPesquisa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmUsuarioPesquisa_Load(object sender, EventArgs e)
        {

        }
    }
}
