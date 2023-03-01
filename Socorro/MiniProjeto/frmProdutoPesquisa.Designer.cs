namespace MiniProjeto
{
    partial class frmProdutoPesquisa
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
            this.txtNomePesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridProdutoPesquisa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdutoPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomePesquisa
            // 
            this.txtNomePesquisa.Location = new System.Drawing.Point(12, 49);
            this.txtNomePesquisa.Name = "txtNomePesquisa";
            this.txtNomePesquisa.Size = new System.Drawing.Size(210, 23);
            this.txtNomePesquisa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisa Dolorosa";
            // 
            // dataGridProdutoPesquisa
            // 
            this.dataGridProdutoPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProdutoPesquisa.Location = new System.Drawing.Point(12, 78);
            this.dataGridProdutoPesquisa.Name = "dataGridProdutoPesquisa";
            this.dataGridProdutoPesquisa.RowTemplate.Height = 25;
            this.dataGridProdutoPesquisa.Size = new System.Drawing.Size(937, 303);
            this.dataGridProdutoPesquisa.TabIndex = 2;
            this.dataGridProdutoPesquisa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProdutoPesquisa_CellDoubleClick);
            // 
            // frmProdutoPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 542);
            this.Controls.Add(this.dataGridProdutoPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomePesquisa);
            this.Name = "frmProdutoPesquisa";
            this.Text = "frmProdutoPesquisa";
            this.Load += new System.EventHandler(this.frmProdutoPesquisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdutoPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNomePesquisa;
        private Label label1;
        private DataGridView dataGridProdutoPesquisa;
    }
}