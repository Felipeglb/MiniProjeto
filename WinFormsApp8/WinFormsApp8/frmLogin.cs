namespace WinFormsApp8
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        float senha;
        float usuario;
        int claudio = 0;
        


        private void btoOK_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Jélbis" && txtSenha.Text == "1234" || txtUsuario.Text == "Glauber" && txtSenha.Text == "5678" || txtUsuario.Text == "Welton" && txtSenha.Text == "9101")
            {
                MessageBox.Show("Seja Bem vindo");
                MDIParent1 frm = new MDIParent1();
                frm.Show();
                this.Hide();

            } else
            {
                MessageBox.Show("Erro, usuário ou senha inválidos");
                claudio++;

            }
            if (claudio == 3)
            {
                MessageBox.Show("Número de tentativas excedida");
                Application.Exit();
            }

         
        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtSenha.Text = "";
            txtUsuario.Text = "";
            txtUsuario.Focus();
            return;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}

