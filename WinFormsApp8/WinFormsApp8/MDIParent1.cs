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
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }
        private void MDIParent1_Load(object sender, EventArgs e)
        {}

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MDIParent1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void calculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculo frmCalculo = new frmCalculo();
            frmCalculo.Show();
            this.Hide();
            
        }

        private void calculoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto frmProduto = new frmProduto();
            frmProduto.Show();
            this.Hide();

        }
    }
}
