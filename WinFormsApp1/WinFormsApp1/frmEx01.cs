namespace WinFormsApp1
{
    public partial class frmEx01 : Form
    {
        public frmEx01()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Sair da aplicação
        }


        

        private void btoOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O nome da pessoa é:" + txtNome.Text); //Apresentar caixa de Texto
            btoLimpar.PerformClick(); //Simular Click de ativação de outro objeto
        }

        private void btoLimpar_Click_1(object sender, EventArgs e)
        {
            txtNome.Text = ""; //Limpar Caixa de Texto
            txtNome.Focus(); //Após limpar, selecionar Caixa de texto
        }
    }
}