namespace mostrar
{
    partial class Form1
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
            this.btnAdvinhar = new System.Windows.Forms.Button();
            this.txtJ2 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJ1 = new System.Windows.Forms.MaskedTextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdvinhar
            // 
            this.btnAdvinhar.Location = new System.Drawing.Point(28, 187);
            this.btnAdvinhar.Name = "btnAdvinhar";
            this.btnAdvinhar.Size = new System.Drawing.Size(100, 45);
            this.btnAdvinhar.TabIndex = 2;
            this.btnAdvinhar.Text = "Advinhar";
            this.btnAdvinhar.UseVisualStyleBackColor = true;
            this.btnAdvinhar.Click += new System.EventHandler(this.btnAdvinhar_Click);
            // 
            // txtJ2
            // 
            this.txtJ2.Location = new System.Drawing.Point(244, 98);
            this.txtJ2.Mask = "0";
            this.txtJ2.Name = "txtJ2";
            this.txtJ2.Size = new System.Drawing.Size(100, 35);
            this.txtJ2.TabIndex = 1;
            this.txtJ2.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Jogador 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jogador 2";
            // 
            // txtJ1
            // 
            this.txtJ1.Location = new System.Drawing.Point(28, 98);
            this.txtJ1.Mask = "0";
            this.txtJ1.Name = "txtJ1";
            this.txtJ1.PasswordChar = '*';
            this.txtJ1.Size = new System.Drawing.Size(100, 35);
            this.txtJ1.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(244, 187);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 45);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 284);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtJ1);
            this.Controls.Add(this.txtJ2);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAdvinhar);
            this.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAdvinhar;
        private MaskedTextBox txtJ2;
        private Label label1;
        private Label label2;
        private MaskedTextBox txtJ1;
        private Button btnSair;
    }
}