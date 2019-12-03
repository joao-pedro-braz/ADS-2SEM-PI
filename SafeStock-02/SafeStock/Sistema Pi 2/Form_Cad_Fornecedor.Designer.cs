namespace Sistema_Pi_2
{
    partial class Form_Cad_Fornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cad_Fornecedor));
            this.button3 = new System.Windows.Forms.Button();
            this.btn_SalvarProd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txb_Cnpj = new System.Windows.Forms.TextBox();
            this.txb_Telefone = new System.Windows.Forms.TextBox();
            this.txb_Nome = new System.Windows.Forms.TextBox();
            this.txb_cidade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.Location = new System.Drawing.Point(553, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 45);
            this.button3.TabIndex = 28;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_SalvarProd
            // 
            this.btn_SalvarProd.Location = new System.Drawing.Point(53, 255);
            this.btn_SalvarProd.Name = "btn_SalvarProd";
            this.btn_SalvarProd.Size = new System.Drawing.Size(155, 40);
            this.btn_SalvarProd.TabIndex = 27;
            this.btn_SalvarProd.Text = "Salvar";
            this.btn_SalvarProd.UseVisualStyleBackColor = true;
            this.btn_SalvarProd.Click += new System.EventHandler(this.btn_SalvarProd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Cidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "CNPJ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(310, 62);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 20;
            this.lbl_nome.Text = "Nome";
            // 
            // txb_Cnpj
            // 
            this.txb_Cnpj.Location = new System.Drawing.Point(372, 118);
            this.txb_Cnpj.Multiline = true;
            this.txb_Cnpj.Name = "txb_Cnpj";
            this.txb_Cnpj.Size = new System.Drawing.Size(157, 26);
            this.txb_Cnpj.TabIndex = 19;
            // 
            // txb_Telefone
            // 
            this.txb_Telefone.Location = new System.Drawing.Point(372, 220);
            this.txb_Telefone.Multiline = true;
            this.txb_Telefone.Name = "txb_Telefone";
            this.txb_Telefone.Size = new System.Drawing.Size(157, 26);
            this.txb_Telefone.TabIndex = 18;
            // 
            // txb_Nome
            // 
            this.txb_Nome.Location = new System.Drawing.Point(372, 62);
            this.txb_Nome.Multiline = true;
            this.txb_Nome.Name = "txb_Nome";
            this.txb_Nome.Size = new System.Drawing.Size(157, 26);
            this.txb_Nome.TabIndex = 15;
            // 
            // txb_cidade
            // 
            this.txb_cidade.Location = new System.Drawing.Point(372, 166);
            this.txb_cidade.Multiline = true;
            this.txb_cidade.Name = "txb_cidade";
            this.txb_cidade.Size = new System.Drawing.Size(157, 26);
            this.txb_cidade.TabIndex = 29;
            // 
            // Form_Cad_Fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_Pi_2.Properties.Resources.LogPequeno;
            this.ClientSize = new System.Drawing.Size(613, 320);
            this.Controls.Add(this.txb_cidade);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_SalvarProd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.txb_Cnpj);
            this.Controls.Add(this.txb_Telefone);
            this.Controls.Add(this.txb_Nome);
            this.Name = "Form_Cad_Fornecedor";
            this.Text = "Cadastro de Fornecedor";
            this.Load += new System.EventHandler(this.Form_Cad_Fornecedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_SalvarProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txb_Cnpj;
        private System.Windows.Forms.TextBox txb_Telefone;
        private System.Windows.Forms.TextBox txb_Nome;
        private System.Windows.Forms.TextBox txb_cidade;
    }
}