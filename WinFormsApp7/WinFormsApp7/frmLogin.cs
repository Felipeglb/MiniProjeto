using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btoOK_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "" || txtSenha.Text.Trim() == "")
            { MessageBox.Show("Erro, usuário ou senha inválidos");
                return;

            }

            if (txtUsuario.Text == "Jélbis" || txtSenha.Text == "5645")

                {
                    MessageBox.Show("Erro, usuário ou senha inválidos");
                    mdiPrincipal frm = new mdiPrincipal();
                    frm.Show();
                    this.Close();
                }

            else
                {
                MessageBox.Show("Erro, usuário ou senha inválidos");
                }



            
        }


    }

}

