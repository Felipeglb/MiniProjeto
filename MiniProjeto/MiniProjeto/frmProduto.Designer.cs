namespace MiniProjeto
{
    partial class frmProduto
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
            btoPesquisar = new Button();
            txtCodigo = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btoSair = new Button();
            cboCategoria = new ComboBox();
            btoExcluir = new Button();
            lbl11 = new Label();
            btoLimpar = new Button();
            cboIDCate = new ComboBox();
            btoAlterar = new Button();
            txtQtde = new TextBox();
            btoCadastro2 = new Button();
            label10 = new Label();
            btoCadastro1 = new Button();
            txtObs = new TextBox();
            label9 = new Label();
            txtDesc = new TextBox();
            label8 = new Label();
            label7 = new Label();
            mtbDataC = new MaskedTextBox();
            label6 = new Label();
            txtValorV = new TextBox();
            txtValorC = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            cboStatus = new ComboBox();
            txtNome = new TextBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            txtNomePesquisa = new TextBox();
            dataGridProduto = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProduto).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btoPesquisar);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(7, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(974, 53);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btoPesquisar
            // 
            btoPesquisar.Location = new Point(123, 26);
            btoPesquisar.Name = "btoPesquisar";
            btoPesquisar.Size = new Size(75, 23);
            btoPesquisar.TabIndex = 1;
            btoPesquisar.Text = "Pesquisar";
            btoPesquisar.UseVisualStyleBackColor = true;
            btoPesquisar.Click += btoPesquisar_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(17, 27);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 9);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btoSair);
            groupBox2.Controls.Add(cboCategoria);
            groupBox2.Controls.Add(btoExcluir);
            groupBox2.Controls.Add(lbl11);
            groupBox2.Controls.Add(btoLimpar);
            groupBox2.Controls.Add(cboIDCate);
            groupBox2.Controls.Add(btoAlterar);
            groupBox2.Controls.Add(txtQtde);
            groupBox2.Controls.Add(btoCadastro2);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(btoCadastro1);
            groupBox2.Controls.Add(txtObs);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtDesc);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(mtbDataC);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtValorV);
            groupBox2.Controls.Add(txtValorC);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cboStatus);
            groupBox2.Controls.Add(txtNome);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(7, 67);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(974, 286);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // btoSair
            // 
            btoSair.Location = new Point(619, 257);
            btoSair.Name = "btoSair";
            btoSair.Size = new Size(75, 23);
            btoSair.TabIndex = 14;
            btoSair.Text = "&Sair";
            btoSair.UseVisualStyleBackColor = true;
            btoSair.Click += btoSair_Click;
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(17, 76);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(274, 23);
            cboCategoria.TabIndex = 25;
            // 
            // btoExcluir
            // 
            btoExcluir.Location = new Point(538, 257);
            btoExcluir.Name = "btoExcluir";
            btoExcluir.Size = new Size(75, 23);
            btoExcluir.TabIndex = 13;
            btoExcluir.Text = "&Excluir";
            btoExcluir.UseVisualStyleBackColor = true;
            btoExcluir.Click += btoExcluir_Click;
            // 
            // lbl11
            // 
            lbl11.AutoSize = true;
            lbl11.Location = new Point(297, 58);
            lbl11.Name = "lbl11";
            lbl11.Size = new Size(72, 15);
            lbl11.TabIndex = 24;
            lbl11.Text = "ID Categoria";
            // 
            // btoLimpar
            // 
            btoLimpar.Location = new Point(457, 257);
            btoLimpar.Name = "btoLimpar";
            btoLimpar.Size = new Size(75, 23);
            btoLimpar.TabIndex = 12;
            btoLimpar.Text = "&Limpar";
            btoLimpar.UseVisualStyleBackColor = true;
            btoLimpar.Click += btoLimpar_Click;
            // 
            // cboIDCate
            // 
            cboIDCate.DropDownStyle = ComboBoxStyle.DropDownList;
            cboIDCate.FormattingEnabled = true;
            cboIDCate.Items.AddRange(new object[] { "Disponível", "Indisponível" });
            cboIDCate.Location = new Point(297, 76);
            cboIDCate.Name = "cboIDCate";
            cboIDCate.Size = new Size(142, 23);
            cboIDCate.TabIndex = 23;
            // 
            // btoAlterar
            // 
            btoAlterar.Location = new Point(376, 257);
            btoAlterar.Name = "btoAlterar";
            btoAlterar.Size = new Size(75, 23);
            btoAlterar.TabIndex = 11;
            btoAlterar.Text = "&Alterar";
            btoAlterar.UseVisualStyleBackColor = true;
            btoAlterar.Click += btoAlterar_Click;
            // 
            // txtQtde
            // 
            txtQtde.Location = new Point(445, 76);
            txtQtde.Name = "txtQtde";
            txtQtde.Size = new Size(138, 23);
            txtQtde.TabIndex = 22;
            // 
            // btoCadastro2
            // 
            btoCadastro2.Location = new Point(295, 257);
            btoCadastro2.Name = "btoCadastro2";
            btoCadastro2.Size = new Size(75, 23);
            btoCadastro2.TabIndex = 10;
            btoCadastro2.Text = "&Cadastro2";
            btoCadastro2.UseVisualStyleBackColor = true;
            btoCadastro2.Click += btoCadastro2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 180);
            label10.Name = "label10";
            label10.Size = new Size(69, 15);
            label10.TabIndex = 21;
            label10.Text = "Observação";
            // 
            // btoCadastro1
            // 
            btoCadastro1.Location = new Point(214, 257);
            btoCadastro1.Name = "btoCadastro1";
            btoCadastro1.Size = new Size(75, 23);
            btoCadastro1.TabIndex = 9;
            btoCadastro1.Text = "&Cadastro";
            btoCadastro1.UseVisualStyleBackColor = true;
            btoCadastro1.Click += btoCadastro1_Click;
            // 
            // txtObs
            // 
            txtObs.Location = new Point(17, 198);
            txtObs.MaxLength = 255;
            txtObs.Multiline = true;
            txtObs.Name = "txtObs";
            txtObs.Size = new Size(854, 53);
            txtObs.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 105);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 19;
            label9.Text = "Descrição";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(17, 123);
            txtDesc.MaxLength = 255;
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(854, 54);
            txtDesc.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(445, 58);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 17;
            label8.Text = "Qtde";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(589, 14);
            label7.Name = "label7";
            label7.Size = new Size(97, 15);
            label7.TabIndex = 15;
            label7.Text = "Data de Cadastro";
            // 
            // mtbDataC
            // 
            mtbDataC.Location = new Point(589, 32);
            mtbDataC.Mask = "  /  /    ";
            mtbDataC.Name = "mtbDataC";
            mtbDataC.ReadOnly = true;
            mtbDataC.Size = new Size(138, 23);
            mtbDataC.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 58);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 13;
            label6.Text = "Categoria";
            // 
            // txtValorV
            // 
            txtValorV.Location = new Point(445, 32);
            txtValorV.Name = "txtValorV";
            txtValorV.Size = new Size(138, 23);
            txtValorV.TabIndex = 2;
            // 
            // txtValorC
            // 
            txtValorC.Location = new Point(297, 32);
            txtValorC.Name = "txtValorC";
            txtValorC.Size = new Size(142, 23);
            txtValorC.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(297, 14);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 9;
            label5.Text = "Valor de Custo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(445, 14);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 8;
            label4.Text = "Valor de Venda";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(733, 14);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Status";
            // 
            // cboStatus
            // 
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Disponível", "Indisponível" });
            cboStatus.Location = new Point(733, 32);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(138, 23);
            cboStatus.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(17, 32);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(274, 23);
            txtNome.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 14);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome do Produto";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtNomePesquisa);
            groupBox3.Controls.Add(dataGridProduto);
            groupBox3.Location = new Point(7, 359);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(974, 168);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // txtNomePesquisa
            // 
            txtNomePesquisa.Location = new Point(12, 13);
            txtNomePesquisa.Name = "txtNomePesquisa";
            txtNomePesquisa.Size = new Size(414, 23);
            txtNomePesquisa.TabIndex = 0;
            txtNomePesquisa.TextChanged += txtNomePesquisa_TextChanged;
            // 
            // dataGridProduto
            // 
            dataGridProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProduto.Location = new Point(12, 42);
            dataGridProduto.Name = "dataGridProduto";
            dataGridProduto.RowTemplate.Height = 25;
            dataGridProduto.Size = new Size(859, 105);
            dataGridProduto.TabIndex = 0;
            dataGridProduto.CellClick += dataGridProduto_CellClick;
            // 
            // frmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 532);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmProduto";
            Text = "frmProduto";
            Load += frmProduto_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProduto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btoPesquisar;
        private TextBox txtCodigo;
        private Label label1;
        private GroupBox groupBox2;
        private Label label9;
        private TextBox txtDesc;
        private Label label8;
        private Label label7;
        private MaskedTextBox mtbDataC;
        private Label label6;
        private TextBox txtValorV;
        private TextBox txtValorC;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cboStatus;
        private TextBox txtNome;
        private Label label2;
        private Label label10;
        private TextBox txtObs;
        private GroupBox groupBox3;
        private Button btoSair;
        private Button btoExcluir;
        private Button btoLimpar;
        private Button btoAlterar;
        private Button btoCadastro2;
        private Button btoCadastro1;
        private TextBox txtQtde;
        private ComboBox cboCategoria;
        private Label lbl11;
        private ComboBox cboIDCate;
        private TextBox txtNomePesquisa;
        private DataGridView dataGridProduto;
    }
}