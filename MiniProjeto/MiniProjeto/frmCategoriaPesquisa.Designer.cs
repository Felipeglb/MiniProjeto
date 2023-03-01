namespace MiniProjeto
{
    partial class frmCategoriaPesquisa
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
            txtNomePesquisa = new TextBox();
            label1 = new Label();
            dataGridCategoriaPesquisa = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridCategoriaPesquisa).BeginInit();
            SuspendLayout();
            // 
            // txtNomePesquisa
            // 
            txtNomePesquisa.Location = new Point(12, 35);
            txtNomePesquisa.Name = "txtNomePesquisa";
            txtNomePesquisa.Size = new Size(195, 23);
            txtNomePesquisa.TabIndex = 0;
            txtNomePesquisa.TextChanged += txtNome_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 1;
            label1.Text = "Pesquisa";
            // 
            // dataGridCategoriaPesquisa
            // 
            dataGridCategoriaPesquisa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCategoriaPesquisa.Location = new Point(12, 83);
            dataGridCategoriaPesquisa.Name = "dataGridCategoriaPesquisa";
            dataGridCategoriaPesquisa.RowTemplate.Height = 25;
            dataGridCategoriaPesquisa.Size = new Size(776, 166);
            dataGridCategoriaPesquisa.TabIndex = 2;
            dataGridCategoriaPesquisa.CellDoubleClick += dataGridCategoriaPesquisa_CellDoubleClick;
            // 
            // frmCategoriaPesquisa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridCategoriaPesquisa);
            Controls.Add(label1);
            Controls.Add(txtNomePesquisa);
            Name = "frmCategoriaPesquisa";
            Text = "frmCategoriaPesquisa";
            Load += frmCategoriaPesquisa_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridCategoriaPesquisa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomePesquisa;
        private Label label1;
        private DataGridView dataGridCategoriaPesquisa;
    }
}