namespace WinFormsApp6
{
    public partial class frmDOR : Form
    {
        public frmDOR()
        {
            InitializeComponent();
        }
        float N1;
        float N2;
        float N3;
        float N4;
        float media;

        private void btoCalcular_Click(object sender, EventArgs e)
        {
            //N1
            if (!float.TryParse(txtN1.Text, out N1))
            {
                MessageBox.Show("Erro, N1 deve ser numérico");
                txtN1.Text = "";
                txtN1.Focus();
                return;

            }

            else if (N1 > 10 || N1 < 0)
            {
                MessageBox.Show("Erro, valor de N1 deve estar entre 0 e 10");
                txtN1.Text = "";
                txtN1.Focus();
                return;
            }

            //N2
            if (!float.TryParse(txtN2.Text, out N2))
            {
                MessageBox.Show("Erro, N2 deve ser numérico");
                txtN2.Text = "";
                txtN2.Focus();
                return;

            }

            else if (N2 > 10 || N2 < 0)
            {
                MessageBox.Show("Erro, valor de N2 deve estar entre 0 e 10");
                txtN2.Text = "";
                txtN2.Focus();
                return;
            }

            //N3
            if (!float.TryParse(txtN3.Text, out N3))
            {
                MessageBox.Show("Erro, N3 deve ser numérico");
                txtN3.Text = "";
                txtN3.Focus();
                return;

            }

           else if (N3 > 10 || N3 < 0)
            {
                MessageBox.Show("Erro, valor de N3 deve estar entre 0 e 10");
                txtN3.Text = "";
                txtN3.Focus();
                return;
            }

            //N4
            if (!float.TryParse(txtN4.Text, out N4))
            {
                MessageBox.Show("Erro, N1 deve ser numérico");
                txtN4.Text = "";
                txtN4.Focus();
                return;
            }

            else if (N4 > 10 || N4 < 0)
            {
                MessageBox.Show("Erro, valor de N3 deve estar entre 0 e 10");
                txtN4.Text = "";
                txtN4.Focus();
                return;
            }

            
            media = (N1 + N2 + N3 + N4) / 4;
            if (media >= 7)
            {
                lblMedia.Text = media.ToString();
                lblMedia.BackColor = Color.Blue;
                lblMedia.ForeColor = Color.White;
                lblStatus.Text = "Aprovado";
            }
            else if (media < 5)
            {
                lblMedia.Text = media.ToString();
                lblMedia.BackColor = Color.Red;
                lblMedia.ForeColor = Color.White;
                lblStatus.Text = "Reprovado";
            }
            else if (media >= 5)
            {
                lblMedia.Text = media.ToString();
                lblMedia.BackColor = Color.Orange;
                lblMedia.ForeColor = Color.White;
                lblStatus.Text = "Exame";
            }

        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Text = "";
            txtN2.Text = "";
            txtN3.Text = "";
            txtN4.Text = "";
        }
    }

    }
