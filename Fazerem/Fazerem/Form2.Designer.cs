namespace Fazerem
{
    partial class Form2
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
            this.listNomes = new System.Windows.Forms.ListBox();
            this.btoOK = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btoLimpar = new System.Windows.Forms.Button();
            this.btoRemove = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btoDelicia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listNomes
            // 
            this.listNomes.FormattingEnabled = true;
            this.listNomes.ItemHeight = 30;
            this.listNomes.Location = new System.Drawing.Point(184, 15);
            this.listNomes.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.listNomes.Name = "listNomes";
            this.listNomes.Size = new System.Drawing.Size(680, 244);
            this.listNomes.TabIndex = 0;
            this.listNomes.Click += new System.EventHandler(this.listNomes_Click);
            // 
            // btoOK
            // 
            this.btoOK.Location = new System.Drawing.Point(5, 63);
            this.btoOK.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btoOK.Name = "btoOK";
            this.btoOK.Size = new System.Drawing.Size(169, 46);
            this.btoOK.TabIndex = 1;
            this.btoOK.Text = "OK";
            this.btoOK.UseVisualStyleBackColor = true;
            this.btoOK.Click += new System.EventHandler(this.btoOK_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(5, 15);
            this.txtNome.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(169, 36);
            this.txtNome.TabIndex = 2;
            // 
            // btoLimpar
            // 
            this.btoLimpar.Location = new System.Drawing.Point(5, 118);
            this.btoLimpar.Name = "btoLimpar";
            this.btoLimpar.Size = new System.Drawing.Size(171, 46);
            this.btoLimpar.TabIndex = 3;
            this.btoLimpar.Text = "Limpar Lista";
            this.btoLimpar.UseVisualStyleBackColor = true;
            this.btoLimpar.Click += new System.EventHandler(this.btoLimpar_Click);
            // 
            // btoRemove
            // 
            this.btoRemove.Location = new System.Drawing.Point(5, 170);
            this.btoRemove.Name = "btoRemove";
            this.btoRemove.Size = new System.Drawing.Size(171, 46);
            this.btoRemove.TabIndex = 4;
            this.btoRemove.Text = "Remover item";
            this.btoRemove.UseVisualStyleBackColor = true;
            this.btoRemove.Click += new System.EventHandler(this.btoRemove_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btoDelicia
            // 
            this.btoDelicia.Location = new System.Drawing.Point(5, 265);
            this.btoDelicia.Name = "btoDelicia";
            this.btoDelicia.Size = new System.Drawing.Size(171, 45);
            this.btoDelicia.TabIndex = 6;
            this.btoDelicia.Text = "&Delicia";
            this.btoDelicia.UseVisualStyleBackColor = true;
            this.btoDelicia.Click += new System.EventHandler(this.btoDelicia_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 427);
            this.Controls.Add(this.btoDelicia);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btoRemove);
            this.Controls.Add(this.btoLimpar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btoOK);
            this.Controls.Add(this.listNomes);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listNomes;
        private Button btoOK;
        private TextBox txtNome;
        private Button btoLimpar;
        private Button btoRemove;
        private Button button1;
        private Button btoDelicia;
    }
}