namespace Sistema_Pi_2
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Botao_Login = new System.Windows.Forms.Button();
            this.labelerro = new System.Windows.Forms.Label();
            this.txb_usuario = new System.Windows.Forms.MaskedTextBox();
            this.txb_senha = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // Botao_Login
            // 
            this.Botao_Login.Location = new System.Drawing.Point(452, 235);
            this.Botao_Login.Name = "Botao_Login";
            this.Botao_Login.Size = new System.Drawing.Size(117, 37);
            this.Botao_Login.TabIndex = 4;
            this.Botao_Login.Text = "Login";
            this.Botao_Login.UseVisualStyleBackColor = true;
            this.Botao_Login.Click += new System.EventHandler(this.Botao_Login_Click);
            // 
            // labelerro
            // 
            this.labelerro.AutoSize = true;
            this.labelerro.Location = new System.Drawing.Point(109, 119);
            this.labelerro.Name = "labelerro";
            this.labelerro.Size = new System.Drawing.Size(0, 13);
            this.labelerro.TabIndex = 5;
            // 
            // txb_usuario
            // 
            this.txb_usuario.Location = new System.Drawing.Point(394, 119);
            this.txb_usuario.Name = "txb_usuario";
            this.txb_usuario.Size = new System.Drawing.Size(175, 20);
            this.txb_usuario.TabIndex = 6;
            // 
            // txb_senha
            // 
            this.txb_senha.Location = new System.Drawing.Point(394, 176);
            this.txb_senha.Name = "txb_senha";
            this.txb_senha.PasswordChar = '*';
            this.txb_senha.Size = new System.Drawing.Size(175, 20);
            this.txb_senha.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(613, 320);
            this.Controls.Add(this.txb_senha);
            this.Controls.Add(this.txb_usuario);
            this.Controls.Add(this.labelerro);
            this.Controls.Add(this.Botao_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Login";
            this.Text = "Tela de Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Botao_Login;
        private System.Windows.Forms.Label labelerro;
        private System.Windows.Forms.MaskedTextBox txb_usuario;
        private System.Windows.Forms.MaskedTextBox txb_senha;
    }
}

