using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp8
{
    public partial class frmCalculo : Form
    {
        public frmCalculo()
        {
            InitializeComponent();
        }
        float altura;
        float largura;
        float result;
       
        // largura = base
        private void btoCalc_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtAltura.Text, out altura)) ;
            if (float.TryParse(txtBase.Text, out largura)) ;
            lblResult.Text = (largura * altura).ToString();   

        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Text = "";
            txtBase.Text = "";
            txtAltura.Focus();
            return;
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmCalculo_Load(object sender, EventArgs e)
        {

        }
    }
}
