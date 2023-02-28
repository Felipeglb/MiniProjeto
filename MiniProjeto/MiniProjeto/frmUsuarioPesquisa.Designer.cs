namespace MiniProjeto
{
    partial class frmUsuarioPesquisa
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridUsuarioPesquisa = new System.Windows.Forms.DataGridView();
            this.txtNomePesquisa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarioPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisa da Dor";
            // 
            // dataGridUsuarioPesquisa
            // 
            this.dataGridUsuarioPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsuarioPesquisa.Location = new System.Drawing.Point(25, 57);
            this.dataGridUsuarioPesquisa.Name = "dataGridUsuarioPesquisa";
            this.dataGridUsuarioPesquisa.RowTemplate.Height = 25;
            this.dataGridUsuarioPesquisa.Size = new System.Drawing.Size(1027, 390);
            this.dataGridUsuarioPesquisa.TabIndex = 2;
            this.dataGridUsuarioPesquisa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUsuarioPesquisa_CellContentClick);
            // 
            // txtNomePesquisa
            // 
            this.txtNomePesquisa.Location = new System.Drawing.Point(25, 28);
            this.txtNomePesquisa.Name = "txtNomePesquisa";
            this.txtNomePesquisa.Size = new System.Drawing.Size(295, 23);
            this.txtNomePesquisa.TabIndex = 3;
            // 
            // frmUsuarioPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 503);
            this.Controls.Add(this.txtNomePesquisa);
            this.Controls.Add(this.dataGridUsuarioPesquisa);
            this.Controls.Add(this.label1);
            this.Name = "frmUsuarioPesquisa";
            this.Text = "frmUsuarioPesquisa";
            this.Load += new System.EventHandler(this.frmUsuarioPesquisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarioPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dataGridUsuarioPesquisa;
        private TextBox txtNomePesquisa;
    }
}