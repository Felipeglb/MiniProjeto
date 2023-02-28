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
            groupBox1 = new GroupBox();
            btoPesquisar = new Button();
            txtCodigo = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label4 = new Label();
            txtDesc = new TextBox();
            label3 = new Label();
            cboStatus = new ComboBox();
            label2 = new Label();
            txtNome = new TextBox();
            groupBox3 = new GroupBox();
            btoSair = new Button();
            btoExcluir = new Button();
            btoLimpar = new Button();
            btoAlterar = new Button();
            btoCadastro2 = new Button();
            btoCadastro1 = new Button();
            label5 = new Label();
            txtObs = new TextBox();
            dataGridCategoria = new DataGridView();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCategoria).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btoPesquisar);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(10, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(665, 56);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btoPesquisar
            // 
            btoPesquisar.Location = new Point(113, 31);
            btoPesquisar.Name = "btoPesquisar";
            btoPesquisar.Size = new Size(64, 20);
            btoPesquisar.TabIndex = 1;
            btoPesquisar.Text = "&Pesquisar";
            btoPesquisar.UseVisualStyleBackColor = true;
            btoPesquisar.Click += btoPesquisar_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(22, 32);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(86, 22);
            txtCodigo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 16);
            label1.Name = "label1";
            label1.Size = new Size(45, 13);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtDesc);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cboStatus);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtNome);
            groupBox2.Location = new Point(10, 66);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(665, 122);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 55);
            label4.Name = "label4";
            label4.Size = new Size(56, 13);
            label4.TabIndex = 6;
            label4.Text = "Descrição";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(17, 70);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(625, 42);
            txtDesc.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 16);
            label3.Name = "label3";
            label3.Size = new Size(39, 13);
            label3.TabIndex = 4;
            label3.Text = "Status";
            // 
            // cboStatus
            // 
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Ativo", "Inativo" });
            cboStatus.Location = new Point(183, 32);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(104, 21);
            cboStatus.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 16);
            label2.Name = "label2";
            label2.Size = new Size(57, 13);
            label2.TabIndex = 2;
            label2.Text = "Categoria";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(17, 32);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(161, 22);
            txtNome.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btoSair);
            groupBox3.Controls.Add(btoExcluir);
            groupBox3.Controls.Add(btoLimpar);
            groupBox3.Controls.Add(btoAlterar);
            groupBox3.Controls.Add(btoCadastro2);
            groupBox3.Controls.Add(btoCadastro1);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txtObs);
            groupBox3.Location = new Point(10, 193);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(665, 115);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            // 
            // btoSair
            // 
            btoSair.Location = new Point(478, 77);
            btoSair.Name = "btoSair";
            btoSair.Size = new Size(64, 23);
            btoSair.TabIndex = 13;
            btoSair.Text = "&Sair";
            btoSair.UseVisualStyleBackColor = true;
            btoSair.Click += btoSair_Click;
            // 
            // btoExcluir
            // 
            btoExcluir.Location = new Point(409, 77);
            btoExcluir.Name = "btoExcluir";
            btoExcluir.Size = new Size(64, 23);
            btoExcluir.TabIndex = 12;
            btoExcluir.Text = "&Excluir";
            btoExcluir.UseVisualStyleBackColor = true;
            btoExcluir.Click += btoExcluir_Click;
            // 
            // btoLimpar
            // 
            btoLimpar.Location = new Point(339, 77);
            btoLimpar.Name = "btoLimpar";
            btoLimpar.Size = new Size(64, 23);
            btoLimpar.TabIndex = 11;
            btoLimpar.Text = "&Limpar";
            btoLimpar.UseVisualStyleBackColor = true;
            btoLimpar.Click += btoLimpar_Click;
            // 
            // btoAlterar
            // 
            btoAlterar.Location = new Point(270, 77);
            btoAlterar.Name = "btoAlterar";
            btoAlterar.Size = new Size(64, 23);
            btoAlterar.TabIndex = 10;
            btoAlterar.Text = "&Alterar";
            btoAlterar.UseVisualStyleBackColor = true;
            btoAlterar.Click += btoAlterar_Click;
            // 
            // btoCadastro2
            // 
            btoCadastro2.Location = new Point(195, 77);
            btoCadastro2.Name = "btoCadastro2";
            btoCadastro2.Size = new Size(64, 23);
            btoCadastro2.TabIndex = 9;
            btoCadastro2.Text = "&Cadastrar2";
            btoCadastro2.UseVisualStyleBackColor = true;
            btoCadastro2.Click += btoCadastro2_Click;
            // 
            // btoCadastro1
            // 
            btoCadastro1.Location = new Point(125, 77);
            btoCadastro1.Name = "btoCadastro1";
            btoCadastro1.Size = new Size(64, 23);
            btoCadastro1.TabIndex = 8;
            btoCadastro1.Text = "&Cadastrar1";
            btoCadastro1.UseVisualStyleBackColor = true;
            btoCadastro1.Click += btoCadastro1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 14);
            label5.Name = "label5";
            label5.Size = new Size(67, 13);
            label5.TabIndex = 7;
            label5.Text = "Observação";
            // 
            // txtObs
            // 
            txtObs.Location = new Point(17, 29);
            txtObs.Multiline = true;
            txtObs.Name = "txtObs";
            txtObs.Size = new Size(625, 43);
            txtObs.TabIndex = 7;
            // 
            // dataGridCategoria
            // 
            dataGridCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCategoria.Location = new Point(10, 338);
            dataGridCategoria.Name = "dataGridCategoria";
            dataGridCategoria.RowTemplate.Height = 25;
            dataGridCategoria.Size = new Size(665, 87);
            dataGridCategoria.TabIndex = 2;
            dataGridCategoria.CellClick += dataGridCategoria_CellClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 313);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(343, 22);
            textBox1.TabIndex = 3;
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 437);
            Controls.Add(textBox1);
            Controls.Add(dataGridCategoria);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmCategoria";
            Text = "Categoria";
            Load += frmCategoria_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCategoria).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Button btoSair;
        private DataGridView dataGridCategoria;
        private TextBox textBox1;
    }
}