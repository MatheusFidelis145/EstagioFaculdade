namespace Telas_MCSystem
{
    partial class TelaBemVindo
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
            this.BtnCaCli = new System.Windows.Forms.Button();
            this.BtnVenda = new System.Windows.Forms.Button();
            this.BtnConCli = new System.Windows.Forms.Button();
            this.BtnRelatorio = new System.Windows.Forms.Button();
            this.BtnConFun = new System.Windows.Forms.Button();
            this.ConsultarProduto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem vindo";
            // 
            // BtnCaCli
            // 
            this.BtnCaCli.Location = new System.Drawing.Point(12, 67);
            this.BtnCaCli.Name = "BtnCaCli";
            this.BtnCaCli.Size = new System.Drawing.Size(141, 23);
            this.BtnCaCli.TabIndex = 1;
            this.BtnCaCli.Text = "Cadastro ";
            this.BtnCaCli.UseVisualStyleBackColor = true;
            this.BtnCaCli.Click += new System.EventHandler(this.BtnCaCli_Click);
            // 
            // BtnVenda
            // 
            this.BtnVenda.Location = new System.Drawing.Point(13, 213);
            this.BtnVenda.Name = "BtnVenda";
            this.BtnVenda.Size = new System.Drawing.Size(75, 23);
            this.BtnVenda.TabIndex = 2;
            this.BtnVenda.Text = "Venda";
            this.BtnVenda.UseVisualStyleBackColor = true;
            // 
            // BtnConCli
            // 
            this.BtnConCli.Location = new System.Drawing.Point(12, 96);
            this.BtnConCli.Name = "BtnConCli";
            this.BtnConCli.Size = new System.Drawing.Size(141, 23);
            this.BtnConCli.TabIndex = 3;
            this.BtnConCli.Text = "Consultar Cliente";
            this.BtnConCli.UseVisualStyleBackColor = true;
            this.BtnConCli.Click += new System.EventHandler(this.BtnConCli_Click);
            // 
            // BtnRelatorio
            // 
            this.BtnRelatorio.Location = new System.Drawing.Point(13, 184);
            this.BtnRelatorio.Name = "BtnRelatorio";
            this.BtnRelatorio.Size = new System.Drawing.Size(75, 23);
            this.BtnRelatorio.TabIndex = 4;
            this.BtnRelatorio.Text = "Relatorios";
            this.BtnRelatorio.UseVisualStyleBackColor = true;
            // 
            // BtnConFun
            // 
            this.BtnConFun.Location = new System.Drawing.Point(13, 126);
            this.BtnConFun.Name = "BtnConFun";
            this.BtnConFun.Size = new System.Drawing.Size(140, 23);
            this.BtnConFun.TabIndex = 5;
            this.BtnConFun.Text = "Consultar Funcionario";
            this.BtnConFun.UseVisualStyleBackColor = true;
            this.BtnConFun.Click += new System.EventHandler(this.BtnConFun_Click);
            // 
            // ConsultarProduto
            // 
            this.ConsultarProduto.Location = new System.Drawing.Point(13, 155);
            this.ConsultarProduto.Name = "ConsultarProduto";
            this.ConsultarProduto.Size = new System.Drawing.Size(135, 23);
            this.ConsultarProduto.TabIndex = 6;
            this.ConsultarProduto.Text = "Consultar Produtos";
            this.ConsultarProduto.UseVisualStyleBackColor = true;
            this.ConsultarProduto.Click += new System.EventHandler(this.ConsultarProduto_Click);
            // 
            // TelaBemVindo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 274);
            this.Controls.Add(this.ConsultarProduto);
            this.Controls.Add(this.BtnConFun);
            this.Controls.Add(this.BtnRelatorio);
            this.Controls.Add(this.BtnConCli);
            this.Controls.Add(this.BtnVenda);
            this.Controls.Add(this.BtnCaCli);
            this.Controls.Add(this.label1);
            this.Name = "TelaBemVindo";
            this.Text = "TelaBemVindo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCaCli;
        private System.Windows.Forms.Button BtnVenda;
        private System.Windows.Forms.Button BtnConCli;
        private System.Windows.Forms.Button BtnRelatorio;
        private System.Windows.Forms.Button BtnConFun;
        private System.Windows.Forms.Button ConsultarProduto;
    }
}