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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btoPesquisa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.cboIDUser = new System.Windows.Forms.ComboBox();
            this.cboIDProd = new System.Windows.Forms.ComboBox();
            this.cboNomeUsu = new System.Windows.Forms.ComboBox();
            this.cboNomeProd = new System.Windows.Forms.ComboBox();
            this.btoPesquisarUser = new System.Windows.Forms.Button();
            this.btoPesquisarProd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQtdeMovimentada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTipoMov = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btoLimpar = new System.Windows.Forms.Button();
            this.btoCancel = new System.Windows.Forms.Button();
            this.btoOk = new System.Windows.Forms.Button();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.mtbDataC = new System.Windows.Forms.MaskedTextBox();
            this.cboQtdeEstoque = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtbDataC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.btoPesquisa);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(6, 37);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(103, 23);
            this.txtCodigo.TabIndex = 0;
            // 
            // btoPesquisa
            // 
            this.btoPesquisa.Location = new System.Drawing.Point(242, 37);
            this.btoPesquisa.Name = "btoPesquisa";
            this.btoPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btoPesquisa.TabIndex = 1;
            this.btoPesquisa.Text = "&Pesquisar";
            this.btoPesquisa.UseVisualStyleBackColor = true;
            this.btoPesquisa.Click += new System.EventHandler(this.btoPesquisa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboQtdeEstoque);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cboStatus);
            this.groupBox2.Controls.Add(this.cboIDUser);
            this.groupBox2.Controls.Add(this.cboIDProd);
            this.groupBox2.Controls.Add(this.cboNomeUsu);
            this.groupBox2.Controls.Add(this.cboNomeProd);
            this.groupBox2.Controls.Add(this.btoPesquisarUser);
            this.groupBox2.Controls.Add(this.btoPesquisarProd);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtQtdeMovimentada);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cboTipoMov);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(690, 134);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(581, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 15);
            this.label12.TabIndex = 28;
            this.label12.Text = "Status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(580, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 15);
            this.label11.TabIndex = 27;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(581, 86);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(102, 23);
            this.cboStatus.TabIndex = 10;
            // 
            // cboIDUser
            // 
            this.cboIDUser.FormattingEnabled = true;
            this.cboIDUser.Location = new System.Drawing.Point(580, 40);
            this.cboIDUser.Name = "cboIDUser";
            this.cboIDUser.Size = new System.Drawing.Size(45, 23);
            this.cboIDUser.TabIndex = 5;
            // 
            // cboIDProd
            // 
            this.cboIDProd.FormattingEnabled = true;
            this.cboIDProd.Location = new System.Drawing.Point(233, 39);
            this.cboIDProd.Name = "cboIDProd";
            this.cboIDProd.Size = new System.Drawing.Size(50, 23);
            this.cboIDProd.TabIndex = 2;
            // 
            // cboNomeUsu
            // 
            this.cboNomeUsu.FormattingEnabled = true;
            this.cboNomeUsu.Location = new System.Drawing.Point(385, 41);
            this.cboNomeUsu.Name = "cboNomeUsu";
            this.cboNomeUsu.Size = new System.Drawing.Size(189, 23);
            this.cboNomeUsu.TabIndex = 4;
            // 
            // cboNomeProd
            // 
            this.cboNomeProd.FormattingEnabled = true;
            this.cboNomeProd.Location = new System.Drawing.Point(6, 40);
            this.cboNomeProd.Name = "cboNomeProd";
            this.cboNomeProd.Size = new System.Drawing.Size(221, 23);
            this.cboNomeProd.TabIndex = 1;
            // 
            // btoPesquisarUser
            // 
            this.btoPesquisarUser.Location = new System.Drawing.Point(631, 39);
            this.btoPesquisarUser.Name = "btoPesquisarUser";
            this.btoPesquisarUser.Size = new System.Drawing.Size(52, 24);
            this.btoPesquisarUser.TabIndex = 6;
            this.btoPesquisarUser.Text = "...";
            this.btoPesquisarUser.UseVisualStyleBackColor = true;
            this.btoPesquisarUser.Click += new System.EventHandler(this.btoPesquisarUser_Click);
            // 
            // btoPesquisarProd
            // 
            this.btoPesquisarProd.Location = new System.Drawing.Point(291, 38);
            this.btoPesquisarProd.Name = "btoPesquisarProd";
            this.btoPesquisarProd.Size = new System.Drawing.Size(52, 25);
            this.btoPesquisarProd.TabIndex = 3;
            this.btoPesquisarProd.Text = "...";
            this.btoPesquisarProd.UseVisualStyleBackColor = true;
            this.btoPesquisarProd.Click += new System.EventHandler(this.btoPesquisarProd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(235, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Qtde Movimentada";
            // 
            // txtQtdeMovimentada
            // 
            this.txtQtdeMovimentada.Location = new System.Drawing.Point(233, 86);
            this.txtQtdeMovimentada.Name = "txtQtdeMovimentada";
            this.txtQtdeMovimentada.Size = new System.Drawing.Size(110, 23);
            this.txtQtdeMovimentada.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "ID Prod";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Nome do Produto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(141, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Qtde Estoque";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipo de Movimentação";
            // 
            // cboTipoMov
            // 
            this.cboTipoMov.FormattingEnabled = true;
            this.cboTipoMov.Items.AddRange(new object[] {
            "Venda",
            "Compra"});
            this.cboTipoMov.Location = new System.Drawing.Point(6, 86);
            this.cboTipoMov.Name = "cboTipoMov";
            this.cboTipoMov.Size = new System.Drawing.Size(128, 23);
            this.cboTipoMov.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(572, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome do Usuário";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btoLimpar);
            this.groupBox3.Controls.Add(this.btoCancel);
            this.groupBox3.Controls.Add(this.btoOk);
            this.groupBox3.Controls.Add(this.txtObs);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 234);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(690, 148);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // btoLimpar
            // 
            this.btoLimpar.Location = new System.Drawing.Point(268, 108);
            this.btoLimpar.Name = "btoLimpar";
            this.btoLimpar.Size = new System.Drawing.Size(75, 23);
            this.btoLimpar.TabIndex = 13;
            this.btoLimpar.Text = "&Limpar";
            this.btoLimpar.UseVisualStyleBackColor = true;
            this.btoLimpar.Click += new System.EventHandler(this.btoLimpar_Click);
            // 
            // btoCancel
            // 
            this.btoCancel.Location = new System.Drawing.Point(349, 108);
            this.btoCancel.Name = "btoCancel";
            this.btoCancel.Size = new System.Drawing.Size(75, 23);
            this.btoCancel.TabIndex = 14;
            this.btoCancel.Text = "&Cancelar";
            this.btoCancel.UseVisualStyleBackColor = true;
            // 
            // btoOk
            // 
            this.btoOk.Location = new System.Drawing.Point(187, 108);
            this.btoOk.Name = "btoOk";
            this.btoOk.Size = new System.Drawing.Size(75, 23);
            this.btoOk.TabIndex = 12;
            this.btoOk.Text = "&Ok";
            this.btoOk.UseVisualStyleBackColor = true;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(6, 37);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(677, 65);
            this.txtObs.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Observação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Location = new System.Drawing.Point(12, 388);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(690, 218);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(668, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 22);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(665, 23);
            this.textBox3.TabIndex = 0;
            // 
            // mtbDataC
            // 
            this.mtbDataC.Enabled = false;
            this.mtbDataC.Location = new System.Drawing.Point(112, 37);
            this.mtbDataC.Mask = "__/__/____";
            this.mtbDataC.Name = "mtbDataC";
            this.mtbDataC.Size = new System.Drawing.Size(124, 23);
            this.mtbDataC.TabIndex = 15;
            // 
            // cboQtdeEstoque
            // 
            this.cboQtdeEstoque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboQtdeEstoque.DropDownWidth = 89;
            this.cboQtdeEstoque.FormattingEnabled = true;
            this.cboQtdeEstoque.IntegralHeight = false;
            this.cboQtdeEstoque.Location = new System.Drawing.Point(140, 86);
            this.cboQtdeEstoque.Name = "cboQtdeEstoque";
            this.cboQtdeEstoque.Size = new System.Drawing.Size(89, 23);
            this.cboQtdeEstoque.TabIndex = 29;
            // 
            // frmMovProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 618);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Enabled = false;
            this.Name = "frmMovProduto";
            this.Text = "frmMovProduto";
            this.Load += new System.EventHandler(this.frmMovProduto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

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