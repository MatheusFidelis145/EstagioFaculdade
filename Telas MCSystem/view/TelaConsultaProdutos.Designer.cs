namespace Telas_MCSystem.view
{
    partial class TelaConsultaProdutos
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
            this.btnVolConProd = new System.Windows.Forms.Button();
            this.BExcluirConProd = new System.Windows.Forms.Button();
            this.BAlterarConProd = new System.Windows.Forms.Button();
            this.dataGridProdutos = new System.Windows.Forms.DataGridView();
            this.BPesquisarProd = new System.Windows.Forms.Button();
            this.TbConProd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolConProd
            // 
            this.btnVolConProd.Location = new System.Drawing.Point(174, 225);
            this.btnVolConProd.Name = "btnVolConProd";
            this.btnVolConProd.Size = new System.Drawing.Size(75, 23);
            this.btnVolConProd.TabIndex = 20;
            this.btnVolConProd.Text = "Voltar";
            this.btnVolConProd.UseVisualStyleBackColor = true;
            this.btnVolConProd.Click += new System.EventHandler(this.btnVolConProd_Click);
            // 
            // BExcluirConProd
            // 
            this.BExcluirConProd.Location = new System.Drawing.Point(93, 225);
            this.BExcluirConProd.Name = "BExcluirConProd";
            this.BExcluirConProd.Size = new System.Drawing.Size(75, 23);
            this.BExcluirConProd.TabIndex = 19;
            this.BExcluirConProd.Text = "Excluir";
            this.BExcluirConProd.UseVisualStyleBackColor = true;
            this.BExcluirConProd.Click += new System.EventHandler(this.BExcluirConProd_Click);
            // 
            // BAlterarConProd
            // 
            this.BAlterarConProd.Location = new System.Drawing.Point(12, 225);
            this.BAlterarConProd.Name = "BAlterarConProd";
            this.BAlterarConProd.Size = new System.Drawing.Size(75, 23);
            this.BAlterarConProd.TabIndex = 18;
            this.BAlterarConProd.Text = "Alterar";
            this.BAlterarConProd.UseVisualStyleBackColor = true;
            this.BAlterarConProd.Click += new System.EventHandler(this.BAlterarConProd_Click);
            // 
            // dataGridProdutos
            // 
            this.dataGridProdutos.AllowUserToAddRows = false;
            this.dataGridProdutos.AllowUserToDeleteRows = false;
            this.dataGridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProdutos.Location = new System.Drawing.Point(12, 48);
            this.dataGridProdutos.Name = "dataGridProdutos";
            this.dataGridProdutos.ReadOnly = true;
            this.dataGridProdutos.Size = new System.Drawing.Size(906, 150);
            this.dataGridProdutos.TabIndex = 17;
           
            // 
            // BPesquisarProd
            // 
            this.BPesquisarProd.Location = new System.Drawing.Point(222, 12);
            this.BPesquisarProd.Name = "BPesquisarProd";
            this.BPesquisarProd.Size = new System.Drawing.Size(75, 23);
            this.BPesquisarProd.TabIndex = 16;
            this.BPesquisarProd.Text = "Pesquisar";
            this.BPesquisarProd.UseVisualStyleBackColor = true;
            this.BPesquisarProd.Click += new System.EventHandler(this.BPesquisarProd_Click);
            // 
            // TbConProd
            // 
            this.TbConProd.Location = new System.Drawing.Point(12, 12);
            this.TbConProd.Name = "TbConProd";
            this.TbConProd.Size = new System.Drawing.Size(203, 20);
            this.TbConProd.TabIndex = 15;
            // 
            // TelaConsultaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 260);
            this.Controls.Add(this.btnVolConProd);
            this.Controls.Add(this.BExcluirConProd);
            this.Controls.Add(this.BAlterarConProd);
            this.Controls.Add(this.dataGridProdutos);
            this.Controls.Add(this.BPesquisarProd);
            this.Controls.Add(this.TbConProd);
            this.Name = "TelaConsultaProdutos";
            this.Text = "TelaConsultaProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolConProd;
        private System.Windows.Forms.Button BExcluirConProd;
        private System.Windows.Forms.Button BAlterarConProd;
        private System.Windows.Forms.DataGridView dataGridProdutos;
        private System.Windows.Forms.Button BPesquisarProd;
        private System.Windows.Forms.TextBox TbConProd;
    }
}