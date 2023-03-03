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
            mtbDataC = new MaskedTextBox();
            label1 = new Label();
            txtCodigo = new TextBox();
            btoPesquisa = new Button();
            groupBox2 = new GroupBox();
            cboQtdeEstoque = new ComboBox();
            label12 = new Label();
            label11 = new Label();
            cboStatus = new ComboBox();
            cboIDUser = new ComboBox();
            cboIDProd = new ComboBox();
            cboNomeUsu = new ComboBox();
            cboNomeProd = new ComboBox();
            btoPesquisarUser = new Button();
            btoPesquisarProd = new Button();
            label10 = new Label();
            txtQtdeMovimentada = new TextBox();
            label3 = new Label();
            label9 = new Label();
            label8 = new Label();
            label5 = new Label();
            cboTipoMov = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            btoLimpar = new Button();
            btoCancel = new Button();
            btoOk = new Button();
            txtObs = new TextBox();
            label7 = new Label();
            label6 = new Label();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            textBox3 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(mtbDataC);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(btoPesquisa);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(690, 76);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // mtbDataC
            // 
            mtbDataC.Enabled = false;
            mtbDataC.Location = new Point(112, 37);
            mtbDataC.Mask = "__/__/____";
            mtbDataC.Name = "mtbDataC";
            mtbDataC.Size = new Size(124, 23);
            mtbDataC.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 19);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 2;
            label1.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(6, 37);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(103, 23);
            txtCodigo.TabIndex = 0;
            // 
            // btoPesquisa
            // 
            btoPesquisa.Location = new Point(242, 37);
            btoPesquisa.Name = "btoPesquisa";
            btoPesquisa.Size = new Size(75, 23);
            btoPesquisa.TabIndex = 1;
            btoPesquisa.Text = "&Pesquisar";
            btoPesquisa.UseVisualStyleBackColor = true;
            btoPesquisa.Click += btoPesquisa_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cboQtdeEstoque);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(cboStatus);
            groupBox2.Controls.Add(cboIDUser);
            groupBox2.Controls.Add(cboIDProd);
            groupBox2.Controls.Add(cboNomeUsu);
            groupBox2.Controls.Add(cboNomeProd);
            groupBox2.Controls.Add(btoPesquisarUser);
            groupBox2.Controls.Add(btoPesquisarProd);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtQtdeMovimentada);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cboTipoMov);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(12, 94);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(690, 134);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // cboQtdeEstoque
            // 
            cboQtdeEstoque.DropDownStyle = ComboBoxStyle.Simple;
            cboQtdeEstoque.DropDownWidth = 89;
            cboQtdeEstoque.FormattingEnabled = true;
            cboQtdeEstoque.IntegralHeight = false;
            cboQtdeEstoque.Location = new Point(140, 86);
            cboQtdeEstoque.Name = "cboQtdeEstoque";
            cboQtdeEstoque.Size = new Size(89, 23);
            cboQtdeEstoque.TabIndex = 29;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(581, 68);
            label12.Name = "label12";
            label12.Size = new Size(39, 15);
            label12.TabIndex = 28;
            label12.Text = "Status";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(580, 68);
            label11.Name = "label11";
            label11.Size = new Size(0, 15);
            label11.TabIndex = 27;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(581, 86);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(102, 23);
            cboStatus.TabIndex = 10;
            // 
            // cboIDUser
            // 
            cboIDUser.FormattingEnabled = true;
            cboIDUser.Location = new Point(580, 40);
            cboIDUser.Name = "cboIDUser";
            cboIDUser.Size = new Size(45, 23);
            cboIDUser.TabIndex = 5;
            // 
            // cboIDProd
            // 
            cboIDProd.FormattingEnabled = true;
            cboIDProd.Location = new Point(233, 39);
            cboIDProd.Name = "cboIDProd";
            cboIDProd.Size = new Size(50, 23);
            cboIDProd.TabIndex = 2;
            // 
            // cboNomeUsu
            // 
            cboNomeUsu.FormattingEnabled = true;
            cboNomeUsu.Location = new Point(385, 41);
            cboNomeUsu.Name = "cboNomeUsu";
            cboNomeUsu.Size = new Size(189, 23);
            cboNomeUsu.TabIndex = 4;
            // 
            // cboNomeProd
            // 
            cboNomeProd.FormattingEnabled = true;
            cboNomeProd.Location = new Point(6, 40);
            cboNomeProd.Name = "cboNomeProd";
            cboNomeProd.Size = new Size(221, 23);
            cboNomeProd.TabIndex = 1;
            // 
            // btoPesquisarUser
            // 
            btoPesquisarUser.Location = new Point(631, 39);
            btoPesquisarUser.Name = "btoPesquisarUser";
            btoPesquisarUser.Size = new Size(52, 24);
            btoPesquisarUser.TabIndex = 6;
            btoPesquisarUser.Text = "...";
            btoPesquisarUser.UseVisualStyleBackColor = true;
            btoPesquisarUser.Click += btoPesquisarUser_Click;
            // 
            // btoPesquisarProd
            // 
            btoPesquisarProd.Location = new Point(291, 38);
            btoPesquisarProd.Name = "btoPesquisarProd";
            btoPesquisarProd.Size = new Size(52, 25);
            btoPesquisarProd.TabIndex = 3;
            btoPesquisarProd.Text = "...";
            btoPesquisarProd.UseVisualStyleBackColor = true;
            btoPesquisarProd.Click += btoPesquisarProd_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(235, 68);
            label10.Name = "label10";
            label10.Size = new Size(110, 15);
            label10.TabIndex = 17;
            label10.Text = "Qtde Movimentada";
            // 
            // txtQtdeMovimentada
            // 
            txtQtdeMovimentada.Location = new Point(233, 86);
            txtQtdeMovimentada.Name = "txtQtdeMovimentada";
            txtQtdeMovimentada.Size = new Size(110, 23);
            txtQtdeMovimentada.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(233, 24);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 15;
            label3.Text = "ID Prod";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 24);
            label9.Name = "label9";
            label9.Size = new Size(103, 15);
            label9.TabIndex = 14;
            label9.Text = "Nome do Produto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(141, 68);
            label8.Name = "label8";
            label8.Size = new Size(78, 15);
            label8.TabIndex = 11;
            label8.Text = "Qtde Estoque";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 68);
            label5.Name = "label5";
            label5.Size = new Size(129, 15);
            label5.TabIndex = 9;
            label5.Text = "Tipo de Movimentação";
            // 
            // cboTipoMov
            // 
            cboTipoMov.FormattingEnabled = true;
            cboTipoMov.Items.AddRange(new object[] { "Venda", "Compra" });
            cboTipoMov.Location = new Point(6, 86);
            cboTipoMov.Name = "cboTipoMov";
            cboTipoMov.Size = new Size(128, 23);
            cboTipoMov.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(572, 22);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 7;
            label4.Text = "ID User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(385, 23);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome do Usuário";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btoLimpar);
            groupBox3.Controls.Add(btoCancel);
            groupBox3.Controls.Add(btoOk);
            groupBox3.Controls.Add(txtObs);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(12, 234);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(690, 148);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            // 
            // btoLimpar
            // 
            btoLimpar.Location = new Point(268, 108);
            btoLimpar.Name = "btoLimpar";
            btoLimpar.Size = new Size(75, 23);
            btoLimpar.TabIndex = 13;
            btoLimpar.Text = "&Limpar";
            btoLimpar.UseVisualStyleBackColor = true;
            btoLimpar.Click += btoLimpar_Click;
            // 
            // btoCancel
            // 
            btoCancel.Location = new Point(349, 108);
            btoCancel.Name = "btoCancel";
            btoCancel.Size = new Size(75, 23);
            btoCancel.TabIndex = 14;
            btoCancel.Text = "&Cancelar";
            btoCancel.UseVisualStyleBackColor = true;
            // 
            // btoOk
            // 
            btoOk.Location = new Point(187, 108);
            btoOk.Name = "btoOk";
            btoOk.Size = new Size(75, 23);
            btoOk.TabIndex = 12;
            btoOk.Text = "&Ok";
            btoOk.UseVisualStyleBackColor = true;
            btoOk.Click += btoOk_Click;
            // 
            // txtObs
            // 
            txtObs.Location = new Point(6, 37);
            txtObs.Multiline = true;
            txtObs.Name = "txtObs";
            txtObs.Size = new Size(677, 65);
            txtObs.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 19);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 10;
            label7.Text = "Observação";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 19);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 10;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Controls.Add(textBox3);
            groupBox4.Location = new Point(12, 388);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(690, 218);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(668, 150);
            dataGridView1.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(9, 22);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(665, 23);
            textBox3.TabIndex = 0;
            // 
            // frmMovProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 618);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Enabled = false;
            Name = "frmMovProduto";
            Text = "frmMovProduto";
            Load += frmMovProduto_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtCodigo;
        private Button btoPesquisa;
        private GroupBox groupBox2;
        private Label label8;
        private Label label5;
        private ComboBox cboTipoMov;
        private Label label4;
        private Label label2;
        private GroupBox groupBox3;
        private Button btoLimpar;
        private Button btoCancel;
        private Button btoOk;
        private TextBox txtObs;
        private Label label7;
        private Label label6;
        private Button btoPesquisarUser;
        private Button btoPesquisarProd;
        private Label label10;
        private TextBox txtQtdeMovimentada;
        private Label label3;
        private Label label9;
        private Label label11;
        private ComboBox cboStatus;
        private ComboBox cboIDUser;
        private ComboBox cboIDProd;
        private ComboBox cboNomeUsu;
        private ComboBox cboNomeProd;
        private Label label12;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private TextBox textBox3;
        private MaskedTextBox mtbDataC;
        private ComboBox cboQtdeEstoque;
    }
}