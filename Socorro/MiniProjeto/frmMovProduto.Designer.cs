namespace MiniProjeto
{
    partial class frmMovProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            btoPesquisa = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtIdProduto = new TextBox();
            mtbDataRealizacao = new MaskedTextBox();
            label4 = new Label();
            cboTipoMov = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            btoCadastro = new Button();
            btoAlterar = new Button();
            btoLimpar = new Button();
            btoExcluir = new Button();
            maskedTextBox1 = new MaskedTextBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(btoPesquisa);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 76);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(maskedTextBox1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cboTipoMov);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(mtbDataRealizacao);
            groupBox2.Controls.Add(txtIdProduto);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtNome);
            groupBox2.Location = new Point(12, 94);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 79);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btoExcluir);
            groupBox3.Controls.Add(btoLimpar);
            groupBox3.Controls.Add(btoAlterar);
            groupBox3.Controls.Add(btoCadastro);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(12, 179);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(776, 197);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            // 
            // btoPesquisa
            // 
            btoPesquisa.Location = new Point(125, 37);
            btoPesquisa.Name = "btoPesquisa";
            btoPesquisa.Size = new Size(75, 23);
            btoPesquisa.TabIndex = 1;
            btoPesquisa.Text = "&Pesquisar";
            btoPesquisa.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 19);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 2;
            label1.Text = "Código";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(19, 37);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(221, 23);
            txtNome.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 19);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome do Produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(353, 19);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 4;
            label3.Text = "Data da Realização";
            // 
            // txtIdProduto
            // 
            txtIdProduto.Location = new Point(246, 37);
            txtIdProduto.Name = "txtIdProduto";
            txtIdProduto.Size = new Size(100, 23);
            txtIdProduto.TabIndex = 1;
            // 
            // mtbDataRealizacao
            // 
            mtbDataRealizacao.Location = new Point(353, 37);
            mtbDataRealizacao.Mask = "__/__/____";
            mtbDataRealizacao.Name = "mtbDataRealizacao";
            mtbDataRealizacao.Size = new Size(109, 23);
            mtbDataRealizacao.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(246, 19);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 7;
            label4.Text = "Código";
            // 
            // cboTipoMov
            // 
            cboTipoMov.FormattingEnabled = true;
            cboTipoMov.Items.AddRange(new object[] { "Venda", "Compra" });
            cboTipoMov.Location = new Point(583, 37);
            cboTipoMov.Name = "cboTipoMov";
            cboTipoMov.Size = new Size(129, 23);
            cboTipoMov.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(583, 19);
            label5.Name = "label5";
            label5.Size = new Size(129, 15);
            label5.TabIndex = 9;
            label5.Text = "Tipo de Movimentação";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 19);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 19);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 10;
            label7.Text = "Observação";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(22, 37);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(547, 65);
            textBox2.TabIndex = 0;
            // 
            // btoCadastro
            // 
            btoCadastro.Location = new Point(97, 125);
            btoCadastro.Name = "btoCadastro";
            btoCadastro.Size = new Size(75, 23);
            btoCadastro.TabIndex = 1;
            btoCadastro.Text = "&Cadastro";
            btoCadastro.UseVisualStyleBackColor = true;
            // 
            // btoAlterar
            // 
            btoAlterar.Location = new Point(200, 125);
            btoAlterar.Name = "btoAlterar";
            btoAlterar.Size = new Size(75, 23);
            btoAlterar.TabIndex = 2;
            btoAlterar.Text = "&Alterar";
            btoAlterar.UseVisualStyleBackColor = true;
            // 
            // btoLimpar
            // 
            btoLimpar.Location = new Point(308, 125);
            btoLimpar.Name = "btoLimpar";
            btoLimpar.Size = new Size(75, 23);
            btoLimpar.TabIndex = 3;
            btoLimpar.Text = "&Limpar";
            btoLimpar.UseVisualStyleBackColor = true;
            // 
            // btoExcluir
            // 
            btoExcluir.Location = new Point(404, 125);
            btoExcluir.Name = "btoExcluir";
            btoExcluir.Size = new Size(75, 23);
            btoExcluir.TabIndex = 4;
            btoExcluir.Text = "&Excluir";
            btoExcluir.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(468, 37);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(109, 23);
            maskedTextBox1.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(468, 19);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 11;
            label8.Text = "Qtde";
            // 
            // frmMovProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmMovProduto";
            Text = "frmMovProduto";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox1;
        private Button btoPesquisa;
        private GroupBox groupBox2;
        private Label label8;
        private MaskedTextBox maskedTextBox1;
        private Label label5;
        private ComboBox cboTipoMov;
        private Label label4;
        private MaskedTextBox mtbDataRealizacao;
        private TextBox txtIdProduto;
        private Label label3;
        private Label label2;
        private TextBox txtNome;
        private GroupBox groupBox3;
        private Button btoExcluir;
        private Button btoLimpar;
        private Button btoAlterar;
        private Button btoCadastro;
        private TextBox textBox2;
        private Label label7;
        private Label label6;
    }
}