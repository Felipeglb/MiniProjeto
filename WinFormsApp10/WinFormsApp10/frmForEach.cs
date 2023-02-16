namespace WinFormsApp10
{
    public partial class frmForEach : Form
    {
        public frmForEach()
        {
            InitializeComponent();
        }

        private void btoAzul_Click(object sender, EventArgs e)
        {
            foreach (Control Doidera in Controls)
         { 
           if (Doidera is TextBox)
            {
                    Doidera.BackColor = Color.Blue;
                    Doidera.ForeColor = Color.White;
                    btoAzul.Focus();
            }





            }

            
        }

        private void btoVermelho_Click(object sender, EventArgs e)
        {
            foreach (Control Doidera in Controls)
                if (Doidera is TextBox)
                { Doidera.BackColor=Color.Red;
                    Doidera.Focus();

                        }


        }

        private void btoVerde_Click(object sender, EventArgs e)
        {
            foreach (Control Doidera in Controls)
            if(Doidera is TextBox)
        {  Doidera.BackColor = 
                }
        }
    }



}


