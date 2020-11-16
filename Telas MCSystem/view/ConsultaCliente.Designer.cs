namespace Telas_MCSystem.view
{
    partial class ConsultaCliente
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
            this.dataGridCliente = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.BTNPesquisar = new System.Windows.Forms.Button();
            this.BAlterar = new System.Windows.Forms.Button();
            this.BExcluir = new System.Windows.Forms.Button();
            this.btnVolCon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCliente
            // 
            this.dataGridCliente.AllowUserToAddRows = false;
            this.dataGridCliente.AllowUserToDeleteRows = false;
            this.dataGridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCliente.Location = new System.Drawing.Point(12, 52);
            this.dataGridCliente.Name = "dataGridCliente";
            this.dataGridCliente.ReadOnly = true;
            this.dataGridCliente.Size = new System.Drawing.Size(905, 150);
            this.dataGridCliente.TabIndex = 1;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(12, 12);
            this.txtBuscar.MaxLength = 100;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(228, 20);
            this.txtBuscar.TabIndex = 4;
            // 
            // BTNPesquisar
            // 
            this.BTNPesquisar.Location = new System.Drawing.Point(246, 12);
            this.BTNPesquisar.Name = "BTNPesquisar";
            this.BTNPesquisar.Size = new System.Drawing.Size(75, 23);
            this.BTNPesquisar.TabIndex = 5;
            this.BTNPesquisar.Text = "Pesquisar";
            this.BTNPesquisar.UseVisualStyleBackColor = true;
            this.BTNPesquisar.Click += new System.EventHandler(this.BTNPesquisar_Click);
            // 
            // BAlterar
            // 
            this.BAlterar.Location = new System.Drawing.Point(12, 217);
            this.BAlterar.Name = "BAlterar";
            this.BAlterar.Size = new System.Drawing.Size(75, 23);
            this.BAlterar.TabIndex = 6;
            this.BAlterar.Text = "Alterar";
            this.BAlterar.UseVisualStyleBackColor = true;
            this.BAlterar.Click += new System.EventHandler(this.BAlterar_Click);
            // 
            // BExcluir
            // 
            this.BExcluir.Location = new System.Drawing.Point(93, 217);
            this.BExcluir.Name = "BExcluir";
            this.BExcluir.Size = new System.Drawing.Size(75, 23);
            this.BExcluir.TabIndex = 7;
            this.BExcluir.Text = "Excluir";
            this.BExcluir.UseVisualStyleBackColor = true;
            this.BExcluir.Click += new System.EventHandler(this.BExcluir_Click);
            // 
            // btnVolCon
            // 
            this.btnVolCon.Location = new System.Drawing.Point(175, 216);
            this.btnVolCon.Name = "btnVolCon";
            this.btnVolCon.Size = new System.Drawing.Size(75, 23);
            this.btnVolCon.TabIndex = 8;
            this.btnVolCon.Text = "Voltar";
            this.btnVolCon.UseVisualStyleBackColor = true;
            this.btnVolCon.Click += new System.EventHandler(this.btnVolCon_Click);
            // 
            // ConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 260);
            this.Controls.Add(this.btnVolCon);
            this.Controls.Add(this.BExcluir);
            this.Controls.Add(this.BAlterar);
            this.Controls.Add(this.BTNPesquisar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dataGridCliente);
            this.Name = "ConsultaCliente";
            this.Text = "ConsultaCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridCliente;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button BTNPesquisar;
        private System.Windows.Forms.Button BAlterar;
        private System.Windows.Forms.Button BExcluir;
        private System.Windows.Forms.Button btnVolCon;
    }
}