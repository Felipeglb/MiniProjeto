namespace Fazerem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Text = "";
            txtN2.Text = "";
            lstResult.Items.Clear();
        }

        private void btoContar_Click(object sender, EventArgs e)
        {
            float n1;
            float n2;
            string imput1 = txtN1.Text;
            string imput2 = txtN2.Text;

            n1 = float.Parse(imput1);
            n2 = float.Parse(imput2);

            lstResult.Items.Clear();

            do
            {
                lstResult.Items.Add(n1);
                n1++;
            }
            while (n1 <= n2);
        }
    }
}