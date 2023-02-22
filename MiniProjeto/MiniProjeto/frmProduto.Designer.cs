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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btoPesquisar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtValorC = new System.Windows.Forms.TextBox();
            this.txtValorV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mtbDataC = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btoCadastro1 = new System.Windows.Forms.Button();
            this.btoCadastro2 = new System.Windows.Forms.Button();
            this.btoAlterar = new System.Windows.Forms.Button();
            this.btoLimpar = new System.Windows.Forms.Button();
            this.btoExcluir = new System.Windows.Forms.Button();
            this.btoSair = new System.Windows.Forms.Button();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btoPesquisar);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            // 
            // btoPesquisar
            // 
            this.btoPesquisar.Location = new System.Drawing.Point(123, 26);
            this.btoPesquisar.Name = "btoPesquisar";
            this.btoPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btoPesquisar.TabIndex = 1;
            this.btoPesquisar.Text = "Pesquisar";
            this.btoPesquisar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtQtde);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtObs);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtDesc);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.mtbDataC);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtValorV);
            this.groupBox2.Controls.Add(this.txtValorC);
            this.groupBox2.Controls.Add(this.txtCategoria);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cboStatus);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(7, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(781, 277);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(17, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(274, 23);
            this.txtNome.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome do Produto";
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Disponível",
            "Indisponível"});
            this.cboStatus.Location = new System.Drawing.Point(589, 32);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(138, 23);
            this.cboStatus.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(589, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor de Venda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valor de Custo";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(17, 76);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(274, 23);
            this.txtCategoria.TabIndex = 4;
            // 
            // txtValorC
            // 
            this.txtValorC.Location = new System.Drawing.Point(297, 32);
            this.txtValorC.Name = "txtValorC";
            this.txtValorC.Size = new System.Drawing.Size(142, 23);
            this.txtValorC.TabIndex = 1;
            // 
            // txtValorV
            // 
            this.txtValorV.Location = new System.Drawing.Point(445, 32);
            this.txtValorV.Name = "txtValorV";
            this.txtValorV.Size = new System.Drawing.Size(138, 23);
            this.txtValorV.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Categoria";
            // 
            // mtbDataC
            // 
            this.mtbDataC.Location = new System.Drawing.Point(297, 76);
            this.mtbDataC.Mask = "__/__/____";
            this.mtbDataC.Name = "mtbDataC";
            this.mtbDataC.Size = new System.Drawing.Size(142, 23);
            this.mtbDataC.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Data de Cadastro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(445, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Qtde";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(17, 123);
            this.txtDesc.MaxLength = 255;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(710, 54);
            this.txtDesc.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Descrição";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(17, 198);
            this.txtObs.MaxLength = 255;
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(710, 53);
            this.txtObs.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Observação";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btoSair);
            this.groupBox3.Controls.Add(this.btoExcluir);
            this.groupBox3.Controls.Add(this.btoLimpar);
            this.groupBox3.Controls.Add(this.btoAlterar);
            this.groupBox3.Controls.Add(this.btoCadastro2);
            this.groupBox3.Controls.Add(this.btoCadastro1);
            this.groupBox3.Location = new System.Drawing.Point(7, 367);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(781, 52);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btoCadastro1
            // 
            this.btoCadastro1.Location = new System.Drawing.Point(150, 13);
            this.btoCadastro1.Name = "btoCadastro1";
            this.btoCadastro1.Size = new System.Drawing.Size(75, 23);
            this.btoCadastro1.TabIndex = 0;
            this.btoCadastro1.Text = "&Cadastro";
            this.btoCadastro1.UseVisualStyleBackColor = true;
            this.btoCadastro1.Click += new System.EventHandler(this.btoCadastro1_Click);
            // 
            // btoCadastro2
            // 
            this.btoCadastro2.Location = new System.Drawing.Point(231, 13);
            this.btoCadastro2.Name = "btoCadastro2";
            this.btoCadastro2.Size = new System.Drawing.Size(75, 23);
            this.btoCadastro2.TabIndex = 1;
            this.btoCadastro2.Text = "&Cadastro2";
            this.btoCadastro2.UseVisualStyleBackColor = true;
            // 
            // btoAlterar
            // 
            this.btoAlterar.Location = new System.Drawing.Point(312, 13);
            this.btoAlterar.Name = "btoAlterar";
            this.btoAlterar.Size = new System.Drawing.Size(75, 23);
            this.btoAlterar.TabIndex = 2;
            this.btoAlterar.Text = "&Alterar";
            this.btoAlterar.UseVisualStyleBackColor = true;
            // 
            // btoLimpar
            // 
            this.btoLimpar.Location = new System.Drawing.Point(393, 13);
            this.btoLimpar.Name = "btoLimpar";
            this.btoLimpar.Size = new System.Drawing.Size(75, 23);
            this.btoLimpar.TabIndex = 3;
            this.btoLimpar.Text = "&Limpar";
            this.btoLimpar.UseVisualStyleBackColor = true;
            // 
            // btoExcluir
            // 
            this.btoExcluir.Location = new System.Drawing.Point(474, 13);
            this.btoExcluir.Name = "btoExcluir";
            this.btoExcluir.Size = new System.Drawing.Size(75, 23);
            this.btoExcluir.TabIndex = 4;
            this.btoExcluir.Text = "&Excluir";
            this.btoExcluir.UseVisualStyleBackColor = true;
            // 
            // btoSair
            // 
            this.btoSair.Location = new System.Drawing.Point(555, 13);
            this.btoSair.Name = "btoSair";
            this.btoSair.Size = new System.Drawing.Size(75, 23);
            this.btoSair.TabIndex = 5;
            this.btoSair.Text = "&Sair";
            this.btoSair.UseVisualStyleBackColor = true;
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(445, 76);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(138, 23);
            this.txtQtde.TabIndex = 22;
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmProduto";
            this.Text = "frmProduto";
            this.Load += new System.EventHandler(this.frmProduto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btoPesquisar;
        private TextBox textBox1;
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
        private TextBox txtCategoria;
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
    }
}