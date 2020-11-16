namespace Telas_MCSystem.view
{
    partial class ConsultaFuncionario
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
            this.TbConFun = new System.Windows.Forms.TextBox();
            this.BPesquisarFun = new System.Windows.Forms.Button();
            this.btnVolConFun = new System.Windows.Forms.Button();
            this.BExcluirConFun = new System.Windows.Forms.Button();
            this.BAlterarConFun = new System.Windows.Forms.Button();
            this.dataGridFuncionario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // TbConFun
            // 
            this.TbConFun.Location = new System.Drawing.Point(13, 13);
            this.TbConFun.Name = "TbConFun";
            this.TbConFun.Size = new System.Drawing.Size(203, 20);
            this.TbConFun.TabIndex = 0;
            // 
            // BPesquisarFun
            // 
            this.BPesquisarFun.Location = new System.Drawing.Point(233, 11);
            this.BPesquisarFun.Name = "BPesquisarFun";
            this.BPesquisarFun.Size = new System.Drawing.Size(75, 23);
            this.BPesquisarFun.TabIndex = 1;
            this.BPesquisarFun.Text = "Pesquisar";
            this.BPesquisarFun.UseVisualStyleBackColor = true;
            this.BPesquisarFun.Click += new System.EventHandler(this.BPesquisarFun_Click);
            // 
            // btnVolConFun
            // 
            this.btnVolConFun.Location = new System.Drawing.Point(174, 214);
            this.btnVolConFun.Name = "btnVolConFun";
            this.btnVolConFun.Size = new System.Drawing.Size(75, 23);
            this.btnVolConFun.TabIndex = 14;
            this.btnVolConFun.Text = "Voltar";
            this.btnVolConFun.UseVisualStyleBackColor = true;
            this.btnVolConFun.Click += new System.EventHandler(this.btnVolConFun_Click);
            // 
            // BExcluirConFun
            // 
            this.BExcluirConFun.Location = new System.Drawing.Point(93, 214);
            this.BExcluirConFun.Name = "BExcluirConFun";
            this.BExcluirConFun.Size = new System.Drawing.Size(75, 23);
            this.BExcluirConFun.TabIndex = 13;
            this.BExcluirConFun.Text = "Excluir";
            this.BExcluirConFun.UseVisualStyleBackColor = true;
            this.BExcluirConFun.Click += new System.EventHandler(this.BExcluirConFun_Click_1);
            // 
            // BAlterarConFun
            // 
            this.BAlterarConFun.Location = new System.Drawing.Point(12, 214);
            this.BAlterarConFun.Name = "BAlterarConFun";
            this.BAlterarConFun.Size = new System.Drawing.Size(75, 23);
            this.BAlterarConFun.TabIndex = 12;
            this.BAlterarConFun.Text = "Alterar";
            this.BAlterarConFun.UseVisualStyleBackColor = true;
            this.BAlterarConFun.Click += new System.EventHandler(this.BAlterarConFun_Click);
            // 
            // dataGridFuncionario
            // 
            this.dataGridFuncionario.AllowUserToAddRows = false;
            this.dataGridFuncionario.AllowUserToDeleteRows = false;
            this.dataGridFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFuncionario.Location = new System.Drawing.Point(12, 49);
            this.dataGridFuncionario.Name = "dataGridFuncionario";
            this.dataGridFuncionario.ReadOnly = true;
            this.dataGridFuncionario.Size = new System.Drawing.Size(906, 150);
            this.dataGridFuncionario.TabIndex = 9;
            // 
            // ConsultaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 260);
            this.Controls.Add(this.btnVolConFun);
            this.Controls.Add(this.BExcluirConFun);
            this.Controls.Add(this.BAlterarConFun);
            this.Controls.Add(this.dataGridFuncionario);
            this.Controls.Add(this.BPesquisarFun);
            this.Controls.Add(this.TbConFun);
            this.Name = "ConsultaFuncionario";
            this.Text = "ConsultaFuncionario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbConFun;
        private System.Windows.Forms.Button BPesquisarFun;
        private System.Windows.Forms.Button btnVolConFun;
        private System.Windows.Forms.Button BExcluirConFun;
        private System.Windows.Forms.Button BAlterarConFun;
        private System.Windows.Forms.DataGridView dataGridFuncionario;
    }
}