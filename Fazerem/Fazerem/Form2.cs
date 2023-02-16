using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fazerem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btoOK_Click(object sender, EventArgs e)
        {
            listNomes.Items.Add(txtNome.Text);
            txtNome.Text = "";
            txtNome.Focus();
        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            listNomes.Items.Clear();

        }

        private void btoRemove_Click(object sender, EventArgs e)
        {
            listNomes.Items.RemoveAt(int.Parse(txtNome.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listNomes.SelectedIndex.ToString());
        }

        private void listNomes_Click(object sender, EventArgs e)
        {
            txtNome.Text = listNomes.SelectedIndex.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btoDelicia_Click(object sender, EventArgs e)
        {

            int cont = 1;

            do
            {
                MessageBox.Show(cont.ToString());
                cont++;
            }
            while(cont <=5);
        }
    }
}
