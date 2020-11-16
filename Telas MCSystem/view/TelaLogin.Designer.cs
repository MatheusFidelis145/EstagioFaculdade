namespace Telas_MCSystem
{
    partial class TelaLogin
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
            this.Login = new System.Windows.Forms.Label();
            this.TXTLogin = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.Label();
            this.TXTSenha = new System.Windows.Forms.TextBox();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(12, 85);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(33, 13);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            // 
            // TXTLogin
            // 
            this.TXTLogin.Location = new System.Drawing.Point(69, 82);
            this.TXTLogin.Name = "TXTLogin";
            this.TXTLogin.Size = new System.Drawing.Size(100, 20);
            this.TXTLogin.TabIndex = 1;
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Location = new System.Drawing.Point(12, 113);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(38, 13);
            this.Senha.TabIndex = 2;
            this.Senha.Text = "Senha";
            // 
            // TXTSenha
            // 
            this.TXTSenha.Location = new System.Drawing.Point(69, 113);
            this.TXTSenha.Name = "TXTSenha";
            this.TXTSenha.Size = new System.Drawing.Size(100, 20);
            this.TXTSenha.TabIndex = 3;
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.Location = new System.Drawing.Point(69, 150);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(75, 23);
            this.BtnEntrar.TabIndex = 4;
            this.BtnEntrar.Text = "Entrar";
            this.BtnEntrar.UseVisualStyleBackColor = true;
            this.BtnEntrar.Click += new System.EventHandler(this.Entrar_Click);
            this.BtnEntrar.Enter += new System.EventHandler(this.Entrar_Click);
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 221);
            this.Controls.Add(this.BtnEntrar);
            this.Controls.Add(this.TXTSenha);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.TXTLogin);
            this.Controls.Add(this.Login);
            this.Name = "TelaLogin";
            this.Text = "TelaLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.TextBox TXTLogin;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.TextBox TXTSenha;
        private System.Windows.Forms.Button BtnEntrar;
    }
}