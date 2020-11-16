namespace Telas_MCSystem.view
{
    partial class ConsultaFornecedor
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
            this.btnVolConFor = new System.Windows.Forms.Button();
            this.BExcluirConFor = new System.Windows.Forms.Button();
            this.BAlterarConFor = new System.Windows.Forms.Button();
            this.dataGridFornecedor = new System.Windows.Forms.DataGridView();
            this.BPesquisarFor = new System.Windows.Forms.Button();
            this.TbConFor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolConFor
            // 
            this.btnVolConFor.Location = new System.Drawing.Point(174, 225);
            this.btnVolConFor.Name = "btnVolConFor";
            this.btnVolConFor.Size = new System.Drawing.Size(75, 23);
            this.btnVolConFor.TabIndex = 20;
            this.btnVolConFor.Text = "Voltar";
            this.btnVolConFor.UseVisualStyleBackColor = true;
            // 
            // BExcluirConFor
            // 
            this.BExcluirConFor.Location = new System.Drawing.Point(93, 225);
            this.BExcluirConFor.Name = "BExcluirConFor";
            this.BExcluirConFor.Size = new System.Drawing.Size(75, 23);
            this.BExcluirConFor.TabIndex = 19;
            this.BExcluirConFor.Text = "Excluir";
            this.BExcluirConFor.UseVisualStyleBackColor = true;
            // 
            // BAlterarConFor
            // 
            this.BAlterarConFor.Location = new System.Drawing.Point(12, 225);
            this.BAlterarConFor.Name = "BAlterarConFor";
            this.BAlterarConFor.Size = new System.Drawing.Size(75, 23);
            this.BAlterarConFor.TabIndex = 18;
            this.BAlterarConFor.Text = "Alterar";
            this.BAlterarConFor.UseVisualStyleBackColor = true;
            this.BAlterarConFor.Click += new System.EventHandler(this.BAlterarConFor_Click);
            // 
            // dataGridFornecedor
            // 
            this.dataGridFornecedor.AllowUserToAddRows = false;
            this.dataGridFornecedor.AllowUserToDeleteRows = false;
            this.dataGridFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFornecedor.Location = new System.Drawing.Point(12, 56);
            this.dataGridFornecedor.Name = "dataGridFornecedor";
            this.dataGridFornecedor.ReadOnly = true;
            this.dataGridFornecedor.Size = new System.Drawing.Size(906, 150);
            this.dataGridFornecedor.TabIndex = 17;
            // 
            // BPesquisarFor
            // 
            this.BPesquisarFor.Location = new System.Drawing.Point(221, 12);
            this.BPesquisarFor.Name = "BPesquisarFor";
            this.BPesquisarFor.Size = new System.Drawing.Size(75, 23);
            this.BPesquisarFor.TabIndex = 16;
            this.BPesquisarFor.Text = "Pesquisar";
            this.BPesquisarFor.UseVisualStyleBackColor = true;
            this.BPesquisarFor.Click += new System.EventHandler(this.BPesquisarFor_Click);
            // 
            // TbConFor
            // 
            this.TbConFor.Location = new System.Drawing.Point(12, 12);
            this.TbConFor.Name = "TbConFor";
            this.TbConFor.Size = new System.Drawing.Size(203, 20);
            this.TbConFor.TabIndex = 15;
            // 
            // ConsultaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 260);
            this.Controls.Add(this.btnVolConFor);
            this.Controls.Add(this.BExcluirConFor);
            this.Controls.Add(this.BAlterarConFor);
            this.Controls.Add(this.dataGridFornecedor);
            this.Controls.Add(this.BPesquisarFor);
            this.Controls.Add(this.TbConFor);
            this.Name = "ConsultaFornecedor";
            this.Text = "ConsultaFornecedor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolConFor;
        private System.Windows.Forms.Button BExcluirConFor;
        private System.Windows.Forms.Button BAlterarConFor;
        private System.Windows.Forms.DataGridView dataGridFornecedor;
        private System.Windows.Forms.Button BPesquisarFor;
        private System.Windows.Forms.TextBox TbConFor;
    }
}