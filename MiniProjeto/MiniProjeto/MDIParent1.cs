using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjeto
{
    public partial class MDIParent1 : Form
    {
       

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {

        }

        private void categoriaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCategoria categoria = new frmCategoria();
            categoria.MdiParent = this;
            categoria.Show();
            this.Hide();


        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto produto = new frmProduto();
            produto.MdiParent = this;           
            produto.Show();
            this.Hide();

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoria cliente = new frmCategoria();
            cliente.MdiParent = this;      
            cliente.Show();
            this.Hide();

        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
        frmUsuario usuario = new frmUsuario();
        usuario.MdiParent = this;
        usuario.Show();
        this.Hide();

        }


    }
}
