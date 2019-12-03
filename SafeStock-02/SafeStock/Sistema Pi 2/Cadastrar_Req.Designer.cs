namespace Sistema_Pi_2
{
    partial class Cadastrar_Req
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastrar_Req));
            this.button3 = new System.Windows.Forms.Button();
            this.btn_SalvarProd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txb_Lote = new System.Windows.Forms.TextBox();
            this.txb_Qtd = new System.Windows.Forms.TextBox();
            this.txb_Produto = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.button3.TabIndex = 38;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_SalvarProd
            // 
            this.btn_SalvarProd.Location = new System.Drawing.Point(53, 255);
            this.btn_SalvarProd.Name = "btn_SalvarProd";
            this.btn_SalvarProd.Size = new System.Drawing.Size(155, 40);
            this.btn_SalvarProd.TabIndex = 37;
            this.btn_SalvarProd.Text = "Salvar";
            this.btn_SalvarProd.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Nº Requisição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Autorizado por";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Qtd.";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(310, 62);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(44, 13);
            this.lbl_nome.TabIndex = 32;
            this.lbl_nome.Text = "Material";
            // 
            // txb_Lote
            // 
            this.txb_Lote.Location = new System.Drawing.Point(372, 118);
            this.txb_Lote.Multiline = true;
            this.txb_Lote.Name = "txb_Lote";
            this.txb_Lote.Size = new System.Drawing.Size(157, 26);
            this.txb_Lote.TabIndex = 31;
            // 
            // txb_Qtd
            // 
            this.txb_Qtd.Location = new System.Drawing.Point(372, 220);
            this.txb_Qtd.Multiline = true;
            this.txb_Qtd.Name = "txb_Qtd";
            this.txb_Qtd.Size = new System.Drawing.Size(157, 26);
            this.txb_Qtd.TabIndex = 30;
            // 
            // txb_Produto
            // 
            this.txb_Produto.Location = new System.Drawing.Point(372, 62);
            this.txb_Produto.Multiline = true;
            this.txb_Produto.Name = "txb_Produto";
            this.txb_Produto.Size = new System.Drawing.Size(157, 26);
            this.txb_Produto.TabIndex = 29;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(373, 166);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 26);
            this.textBox1.TabIndex = 39;
            // 
            // Cadastrar_Req
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_Pi_2.Properties.Resources.LogPequeno;
            this.ClientSize = new System.Drawing.Size(613, 320);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_SalvarProd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.txb_Lote);
            this.Controls.Add(this.txb_Qtd);
            this.Controls.Add(this.txb_Produto);
            this.Name = "Cadastrar_Req";
            this.Text = "Cadastrar Requisição";
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
        private System.Windows.Forms.TextBox txb_Lote;
        private System.Windows.Forms.TextBox txb_Qtd;
        private System.Windows.Forms.TextBox txb_Produto;
        private System.Windows.Forms.TextBox textBox1;
    }
}