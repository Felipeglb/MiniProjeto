namespace MiniProjeto
{
    partial class frmUsuario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btoPesquisar = new Button();
            txtCodigo = new TextBox();
            label1 = new Label();
            btoCadastrar2 = new Button();
            groupBox2 = new GroupBox();
            label7 = new Label();
            txtObservacao = new TextBox();
            txtConfirmaS = new TextBox();
            label6 = new Label();
            txtSenha = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtLogin = new TextBox();
            label3 = new Label();
            cboStatus = new ComboBox();
            txtNome = new TextBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            btoSair = new Button();
            btoExcluir = new Button();
            btoAlterar = new Button();
            btoLimpar = new Button();
            btoCadastro = new Button();
            dataGridUsuario = new DataGridView();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuario).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btoPesquisar);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(10, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(665, 68);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btoPesquisar
            // 
            btoPesquisar.Location = new Point(304, 37);
            btoPesquisar.Name = "btoPesquisar";
            btoPesquisar.Size = new Size(76, 20);
            btoPesquisar.TabIndex = 1;
            btoPesquisar.Text = "&Pesquisar";
            btoPesquisar.UseVisualStyleBackColor = true;
            btoPesquisar.Click += btoPesquisar_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(5, 37);
            txtCodigo.Margin = new Padding(2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(295, 22);
            txtCodigo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(5, 16);
            label1.Name = "label1";
            label1.Size = new Size(45, 13);
            label1.TabIndex = 2;
            label1.Text = "Código";
            // 
            // btoCadastrar2
            // 
            btoCadastrar2.Location = new Point(37, 189);
            btoCadastrar2.Name = "btoCadastrar2";
            btoCadastrar2.Size = new Size(81, 26);
            btoCadastrar2.TabIndex = 13;
            btoCadastrar2.Text = "&Cadastrar2";
            btoCadastrar2.UseVisualStyleBackColor = true;
            btoCadastrar2.Click += btoCadastrar2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btoCadastrar2);
            groupBox2.Controls.Add(btoSair);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(btoExcluir);
            groupBox2.Controls.Add(txtObservacao);
            groupBox2.Controls.Add(btoAlterar);
            groupBox2.Controls.Add(txtConfirmaS);
            groupBox2.Controls.Add(btoLimpar);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(btoCadastro);
            groupBox2.Controls.Add(txtSenha);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtLogin);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cboStatus);
            groupBox2.Controls.Add(txtNome);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(10, 84);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(665, 248);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(5, 100);
            label7.Name = "label7";
            label7.Size = new Size(67, 13);
            label7.TabIndex = 13;
            label7.Text = "Observação";
            // 
            // txtObservacao
            // 
            txtObservacao.Location = new Point(5, 115);
            txtObservacao.Margin = new Padding(2);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(596, 69);
            txtObservacao.TabIndex = 12;
            // 
            // txtConfirmaS
            // 
            txtConfirmaS.Location = new Point(262, 76);
            txtConfirmaS.Margin = new Padding(2);
            txtConfirmaS.Name = "txtConfirmaS";
            txtConfirmaS.Size = new Size(125, 22);
            txtConfirmaS.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(262, 61);
            label6.Name = "label6";
            label6.Size = new Size(90, 13);
            label6.TabIndex = 10;
            label6.Text = "ConfirmarSenha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(133, 76);
            txtSenha.Margin = new Padding(2);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(125, 22);
            txtSenha.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(133, 61);
            label5.Name = "label5";
            label5.Size = new Size(39, 13);
            label5.TabIndex = 7;
            label5.Text = "Senha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(497, 16);
            label4.Name = "label4";
            label4.Size = new Size(39, 13);
            label4.TabIndex = 8;
            label4.Text = "Status";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(5, 76);
            txtLogin.Margin = new Padding(2);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(125, 22);
            txtLogin.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 61);
            label3.Name = "label3";
            label3.Size = new Size(36, 13);
            label3.TabIndex = 6;
            label3.Text = "Login";
            // 
            // cboStatus
            // 
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Ativo", "Inativo" });
            cboStatus.Location = new Point(497, 37);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(104, 21);
            cboStatus.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(5, 37);
            txtNome.Margin = new Padding(2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(488, 22);
            txtNome.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(5, 16);
            label2.Name = "label2";
            label2.Size = new Size(37, 13);
            label2.TabIndex = 4;
            label2.Text = "Nome";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(dataGridUsuario);
            groupBox3.Location = new Point(10, 338);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(665, 144);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // btoSair
            // 
            btoSair.Location = new Point(466, 189);
            btoSair.Name = "btoSair";
            btoSair.Size = new Size(81, 26);
            btoSair.TabIndex = 18;
            btoSair.Text = "&Sair";
            btoSair.UseVisualStyleBackColor = true;
            btoSair.Click += btoSair_Click;
            // 
            // btoExcluir
            // 
            btoExcluir.Location = new Point(380, 189);
            btoExcluir.Name = "btoExcluir";
            btoExcluir.Size = new Size(81, 26);
            btoExcluir.TabIndex = 17;
            btoExcluir.Text = "&Excluir";
            btoExcluir.UseVisualStyleBackColor = true;
            btoExcluir.Click += btoExcluir_Click;
            // 
            // btoAlterar
            // 
            btoAlterar.Location = new Point(294, 189);
            btoAlterar.Name = "btoAlterar";
            btoAlterar.Size = new Size(81, 26);
            btoAlterar.TabIndex = 16;
            btoAlterar.Text = "&Alterar";
            btoAlterar.UseVisualStyleBackColor = true;
            btoAlterar.Click += btoAlterar_Click;
            // 
            // btoLimpar
            // 
            btoLimpar.Location = new Point(209, 189);
            btoLimpar.Name = "btoLimpar";
            btoLimpar.Size = new Size(81, 26);
            btoLimpar.TabIndex = 15;
            btoLimpar.Text = "&Limpar";
            btoLimpar.UseVisualStyleBackColor = true;
            btoLimpar.Click += btoLimpar_Click;
            // 
            // btoCadastro
            // 
            btoCadastro.Location = new Point(123, 189);
            btoCadastro.Name = "btoCadastro";
            btoCadastro.Size = new Size(81, 26);
            btoCadastro.TabIndex = 14;
            btoCadastro.Text = "&Cadastrar";
            btoCadastro.UseVisualStyleBackColor = true;
            btoCadastro.Click += btoCadastro_Click;
            // 
            // dataGridUsuario
            // 
            dataGridUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUsuario.Location = new Point(5, 43);
            dataGridUsuario.Name = "dataGridUsuario";
            dataGridUsuario.RowTemplate.Height = 25;
            dataGridUsuario.Size = new Size(654, 95);
            dataGridUsuario.TabIndex = 0;

            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(423, 22);
            textBox1.TabIndex = 1;
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 494);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmUsuario";
            Text = "Usuario";
            Load += frmUsuario_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btoPesquisar;
        private TextBox txtCodigo;
        private Label label1;
        private GroupBox groupBox2;
        private Label label7;
        private TextBox txtObservacao;
        private TextBox txtConfirmaS;
        private Label label6;
        private TextBox txtSenha;
        private Label label5;
        private Label label4;
        private TextBox txtLogin;
        private Label label3;
        private ComboBox cboStatus;
        private TextBox txtNome;
        private Label label2;
        private GroupBox groupBox3;
        private Button btoSair;
        private Button btoExcluir;
        private Button btoAlterar;
        private Button btoLimpar;
        private Button btoCadastro;
        private Button btoCadastrar2;
        private TextBox textBox1;
        private DataGridView dataGridUsuario;
    }
}