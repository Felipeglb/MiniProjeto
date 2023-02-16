namespace mostrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdvinhar_Click(object sender, EventArgs e)
        {
            int n1;
            int n2;
            string imput1 = txtJ1.Text;
            string imput2 = txtJ2.Text;

            n1 = Convert.ToInt32(imput1);
            n2 = Convert.ToInt32(imput2);

            while (n1 != n2)
            {
                MessageBox.Show("Erro numero incorreto.");
                txtJ2.Text = "";
                txtJ2.Focus();
                return;
            }
            MessageBox.Show("Parabens");
        }
    }
}