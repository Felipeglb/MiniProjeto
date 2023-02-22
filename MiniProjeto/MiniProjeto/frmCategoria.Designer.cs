namespace MiniProjeto
{
    partial class frmCategoria
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
            this.btoPesquisar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btoExcluir = new System.Windows.Forms.Button();
            this.btoLimpar = new System.Windows.Forms.Button();
            this.btoAlterar = new System.Windows.Forms.Button();
            this.btoCadastro2 = new System.Windows.Forms.Button();
            this.btoCadastro1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btoPesquisar);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btoPesquisar
            // 
            this.btoPesquisar.Location = new System.Drawing.Point(132, 36);
            this.btoPesquisar.Name = "btoPesquisar";
            this.btoPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btoPesquisar.TabIndex = 1;
            this.btoPesquisar.Text = "&Pesquisar";
            this.btoPesquisar.UseVisualStyleBackColor = true;
            this.btoPesquisar.Click += new System.EventHandler(this.btoPesquisar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(20, 37);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 23);
            this.txtCodigo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtDesc);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cboStatus);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Location = new System.Drawing.Point(12, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 159);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descrição";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(20, 90);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(729, 60);
            this.txtDesc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status";
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cboStatus.Location = new System.Drawing.Point(213, 37);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(121, 23);
            this.cboStatus.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoria";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(20, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(187, 23);
            this.txtNome.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btoExcluir);
            this.groupBox3.Controls.Add(this.btoLimpar);
            this.groupBox3.Controls.Add(this.btoAlterar);
            this.groupBox3.Controls.Add(this.btoCadastro2);
            this.groupBox3.Controls.Add(this.btoCadastro1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtObs);
            this.groupBox3.Location = new System.Drawing.Point(12, 256);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 142);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // btoExcluir
            // 
            this.btoExcluir.Location = new System.Drawing.Point(508, 100);
            this.btoExcluir.Name = "btoExcluir";
            this.btoExcluir.Size = new System.Drawing.Size(75, 26);
            this.btoExcluir.TabIndex = 12;
            this.btoExcluir.Text = "&Excluir";
            this.btoExcluir.UseVisualStyleBackColor = true;
            this.btoExcluir.Click += new System.EventHandler(this.btoExcluir_Click);
            // 
            // btoLimpar
            // 
            this.btoLimpar.Location = new System.Drawing.Point(427, 100);
            this.btoLimpar.Name = "btoLimpar";
            this.btoLimpar.Size = new System.Drawing.Size(75, 26);
            this.btoLimpar.TabIndex = 11;
            this.btoLimpar.Text = "&Limpar";
            this.btoLimpar.UseVisualStyleBackColor = true;
            this.btoLimpar.Click += new System.EventHandler(this.btoLimpar_Click);
            // 
            // btoAlterar
            // 
            this.btoAlterar.Location = new System.Drawing.Point(346, 100);
            this.btoAlterar.Name = "btoAlterar";
            this.btoAlterar.Size = new System.Drawing.Size(75, 26);
            this.btoAlterar.TabIndex = 10;
            this.btoAlterar.Text = "&Alterar";
            this.btoAlterar.UseVisualStyleBackColor = true;
            this.btoAlterar.Click += new System.EventHandler(this.btoAlterar_Click);
            // 
            // btoCadastro2
            // 
            this.btoCadastro2.Location = new System.Drawing.Point(265, 100);
            this.btoCadastro2.Name = "btoCadastro2";
            this.btoCadastro2.Size = new System.Drawing.Size(75, 26);
            this.btoCadastro2.TabIndex = 9;
            this.btoCadastro2.Text = "&Cadastrar2";
            this.btoCadastro2.UseVisualStyleBackColor = true;
            this.btoCadastro2.Click += new System.EventHandler(this.btoCadastro2_Click);
            // 
            // btoCadastro1
            // 
            this.btoCadastro1.Location = new System.Drawing.Point(184, 100);
            this.btoCadastro1.Name = "btoCadastro1";
            this.btoCadastro1.Size = new System.Drawing.Size(75, 26);
            this.btoCadastro1.TabIndex = 8;
            this.btoCadastro1.Text = "&Cadastrar1";
            this.btoCadastro1.UseVisualStyleBackColor = true;
            this.btoCadastro1.Click += new System.EventHandler(this.btoCadastro1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Observação";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(20, 34);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(729, 60);
            this.txtObs.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(589, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 13;
            this.button1.Text = "&Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCategoria";
            this.Text = "Categoria";
            this.Load += new System.EventHandler(this.frmCategoria_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btoPesquisar;
        private TextBox txtCodigo;
        private Label label4;
        private TextBox txtDesc;
        private Label label3;
        private ComboBox cboStatus;
        private Label label2;
        private TextBox txtNome;
        private Button btoExcluir;
        private Button btoLimpar;
        private Button btoAlterar;
        private Button btoCadastro2;
        private Button btoCadastro1;
        private Label label5;
        private TextBox txtObs;
        private Button button1;
    }
}