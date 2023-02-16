using System.Drawing.Text;

namespace WinFormsApp7
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
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



        private void btoEnviar_Click(object sender, EventArgs e)
        {
            bool Validar()
            {
                //Código
                if (!float.TryParse(txtCodigo.Text, out Codigo))
                {
                    MessageBox.Show("Erro, Código deve ser numérico");
                    txtTel.Text = "";
                    txtTel.Focus();
                    return false;

                }
                return true;

                //NOME 
                if (txtNome.Text.Trim() == "")
                {
                    MessageBox.Show("Erro, Nome deve ser preenchido corretamente");
                    txtTel.Text = "";
                    txtTel.Focus();
                    return false;

                }
                return true;

                //Sexo
                if (!float.TryParse(txtCEP.Text, out CEP))
                {
                    MessageBox.Show("Erro, CEP deve conter valores ");
                    txtCEP.Text = "";
                    txtCEP.Focus();
                    return false;

                }
                return true;

                //Data Nascimento
                if (!float.TryParse(txtNasc.Text, out Nasc))
                {
                    MessageBox.Show("Erro, CEP deve conter valores ");
                    txtNasc.Text = "";
                    txtNasc.Focus();
                    return false;

                }
                return true;

                //Telefone
                if (!float.TryParse(txtTel.Text, out telefone))
                {
                    MessageBox.Show("Erro, Telefone deve conter valores numéricos");
                    txtTel.Text = "";
                    txtTel.Focus();
                    return false;

                }

                return true;
                //Logradouro
                if (txtLogradouro.Text.Trim() == "")
                {
                    MessageBox.Show("Erro, Telefone deve conter valores numéricos");
                    txtTel.Text = "";
                    txtTel.Focus();
                    return false;

                }
                return true;

                //Número
                if (!float.TryParse(txtNumero.Text, out numero))
                {
                    MessageBox.Show("Erro, insira um valor numérico ");
                    txtNumero.Text = "";
                    txtNumero.Focus();
                    return false;

                }
                return true;

                //Complemento
                if (txtComple.Text.Trim() == "")
                {
                    MessageBox.Show("Erro, o campo deve ser preenchido");
                    txtComple.Text = "";
                    txtComple.Focus();
                    return false;

                }
                return true;

                //CEP
                if (!float.TryParse(txtCEP.Text, out CEP))
                {
                    MessageBox.Show("Erro, CEP deve conter valores ");
                    txtCEP.Text = "";
                    txtCEP.Focus();
                    return false;

                }
                return true;

                //Cidade
                if (txtCidade.Text.Trim() == "")
                {
                    MessageBox.Show("Erro, o campo deve ser preenchido");
                    txtCidade.Text = "";
                    txtCidade.Focus();
                    return false;


                }
                return true;

                //UF
                if (cboUF.Text.Trim() == "")
                {
                    MessageBox.Show("Erro, o campo deve ser preenchido");
                    cboUF.Text = "";
                    cboUF.Focus();
                    return false;
                }
                return true;


                //salario
                if (!float.TryParse(txtSalario.Text, out salario))
                {
                    MessageBox.Show("Erro, insira valor numérico");
                    txtSalario.Text = "";
                    txtSalario.Focus();
                    return false;

                }
                return true;


                //Telefone
                if (!float.TryParse(txtTel.Text, out telefone))
                {
                    MessageBox.Show("Erro, insira valo rnumérico");
                    txtTel.Text = "";
                    txtTel.Focus();
                    return false;
                }
                return true;

                //email
                if (txtEmail.Text.Trim() == "")
                {
                    MessageBox.Show("Erro, o campo deve ser preenchido");
                    txtEmail.Text = "";
                    txtEmail.Focus();
                    return false;
                }
                return true;

                //Observação
                if (txtObs.Text.Trim() == "")
                {
                    MessageBox.Show("O Campo deve ser preenchido");
                    txtObs.Text = "";
                    txtObs.Focus();
                    return false;
                }
                return true;

            }
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }


        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            cboSexo.Text = "";
            txtNasc.Text = "";
            txtLogradouro.Text = "";
            txtNumero.Text = "";
            txtComple.Text = "";
            txtCEP.Text = "";
            txtCidade.Text = "";
            cboUF.Text = "";
            txtSalario.Text = "";
            txtTel.Text = "";
            txtEmail.Text = "";
            txtObs.Text = "";
        }


    }
}

