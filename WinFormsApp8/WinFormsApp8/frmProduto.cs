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
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {

        }

        private void cboProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboPreco.SelectedIndex = cboProduto.SelectedIndex;

        }

        private void btoOK_Click(object sender, EventArgs e)
        {
            float preco;
            int qtde;
            float total;
           
            if (!float.TryParse(cboPreco.Text, out preco))
            {
                MessageBox.Show("Erro, produto deve ser preenchido");
                return;
            }

            if (!int.TryParse(txtQtde.Text, out qtde))
            {
                MessageBox.Show("Erro, produto deve ser preenchido");
                return;

            }
            total = preco * qtde;
            txtTotal.Text = string.Format("{0:C}", total);
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

