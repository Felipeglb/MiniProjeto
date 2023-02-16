namespace WinFormsApp2
{
    public partial class Exercicio01 : Form
    {
        public Exercicio01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textNome2.Text = textNome.Text;
            textNome.Text = "";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textNome.Text = "";
            textNome2.Text = "";
            textNome.Focus();

        }



        private void btoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}