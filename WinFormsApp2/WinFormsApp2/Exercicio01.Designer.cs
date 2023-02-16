namespace WinFormsApp2
{
    partial class Exercicio01
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
            this.textNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNome2 = new System.Windows.Forms.TextBox();
            this.btoOK = new System.Windows.Forms.Button();
            this.btoLimpar = new System.Windows.Forms.Button();
            this.btoSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(69, 95);
            this.textNome.Margin = new System.Windows.Forms.Padding(5);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(408, 33);
            this.textNome.TabIndex = 0;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insira seu Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "O nome que voce digitou é:";
            // 
            // textNome2
            // 
            this.textNome2.Location = new System.Drawing.Point(69, 178);
            this.textNome2.Name = "textNome2";
            this.textNome2.Size = new System.Drawing.Size(406, 33);
            this.textNome2.TabIndex = 3;
            // 
            // btoOK
            // 
            this.btoOK.Location = new System.Drawing.Point(599, 89);
            this.btoOK.Name = "btoOK";
            this.btoOK.Size = new System.Drawing.Size(86, 38);
            this.btoOK.TabIndex = 4;
            this.btoOK.Text = "OK";
            this.btoOK.UseVisualStyleBackColor = true;
            this.btoOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // btoLimpar
            // 
            this.btoLimpar.Location = new System.Drawing.Point(599, 133);
            this.btoLimpar.Name = "btoLimpar";
            this.btoLimpar.Size = new System.Drawing.Size(86, 32);
            this.btoLimpar.TabIndex = 5;
            this.btoLimpar.Text = "Limpar";
            this.btoLimpar.UseVisualStyleBackColor = true;
            this.btoLimpar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btoSair
            // 
            this.btoSair.Location = new System.Drawing.Point(599, 171);
            this.btoSair.Name = "btoSair";
            this.btoSair.Size = new System.Drawing.Size(86, 40);
            this.btoSair.TabIndex = 6;
            this.btoSair.Text = "Sair";
            this.btoSair.UseVisualStyleBackColor = true;
            this.btoSair.Click += new System.EventHandler(this.btoSair_Click);
            // 
            // Exercicio01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 750);
            this.Controls.Add(this.btoSair);
            this.Controls.Add(this.btoLimpar);
            this.Controls.Add(this.btoOK);
            this.Controls.Add(this.textNome2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNome);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Exercicio01";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textNome;
        private Label label1;
        private Label label2;
        private TextBox textNome2;
        private Button btoOK;
        private Button btoLimpar;
        private Button btoSair;
    }
}