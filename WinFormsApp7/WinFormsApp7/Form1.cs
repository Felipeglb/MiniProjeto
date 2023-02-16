namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float Codigo;
        float Nome;
        float Sexo;
        float Nasc;
        float logra;
        float numero;
        float Complemento;
        float CEP;
        float cidade;
        float UF;
        float salario;
        float telefone;
        float email;
        string nome;


        private void btoEnviar_Click(object sender, EventArgs e)
        {
         
                //Telefone
                if (!float.TryParse(txtTEL.Text, out telefone))
                {
                    MessageBox.Show("Erro, N1 deve ser numérico");
                    txtTEL.Text = "";
                    txtTEL.Focus();
                    return;

                }

            //CEP
            if (!float.TryParse(txtCep.Text, out telefone))
            {
                MessageBox.Show("Erro, N1 deve ser numérico");
                txtTEL.Text = "";
                txtTEL.Focus();
                return;

            }



        }


    }
}