namespace WinFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btoListar_Click(object sender, EventArgs e)
        {
            int n1;
            int n2;
            string exe1 = txtN1.Text;
            string exe2 = txtN2.Text;

            n1 = int.Parse(exe1);
            n2 = int.Parse(exe2);
           
            while (n1 < n2)
            {


                listBox1.Items.Add(n1);
                n1++;


            }
            MessageBox.Show("Listagem Concluida");
            


        }
   }
}