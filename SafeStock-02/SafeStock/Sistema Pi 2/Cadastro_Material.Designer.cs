namespace Sistema_Pi_2
{
    partial class Cadastro_Material
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_Material));
            this.txb_Produto = new System.Windows.Forms.TextBox();
            this.txb_Local = new System.Windows.Forms.TextBox();
            this.txb_Fornec = new System.Windows.Forms.TextBox();
            this.txb_Qtd = new System.Windows.Forms.TextBox();
            this.txb_Lote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_SalvarProd = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btRFID = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_Produto
            // 
            this.txb_Produto.Location = new System.Drawing.Point(378, 22);
            this.txb_Produto.Multiline = true;
            this.txb_Produto.Name = "txb_Produto";
            this.txb_Produto.Size = new System.Drawing.Size(157, 26);
            this.txb_Produto.TabIndex = 0;
            // 
            // txb_Local
            // 
            this.txb_Local.Location = new System.Drawing.Point(378, 278);
            this.txb_Local.Multiline = true;
            this.txb_Local.Name = "txb_Local";
            this.txb_Local.Size = new System.Drawing.Size(157, 26);
            this.txb_Local.TabIndex = 1;
            // 
            // txb_Fornec
            // 
            this.txb_Fornec.Location = new System.Drawing.Point(378, 230);
            this.txb_Fornec.Multiline = true;
            this.txb_Fornec.Name = "txb_Fornec";
            this.txb_Fornec.Size = new System.Drawing.Size(157, 26);
            this.txb_Fornec.TabIndex = 2;
            // 
            // txb_Qtd
            // 
            this.txb_Qtd.Location = new System.Drawing.Point(378, 180);
            this.txb_Qtd.Multiline = true;
            this.txb_Qtd.Name = "txb_Qtd";
            this.txb_Qtd.Size = new System.Drawing.Size(157, 26);
            this.txb_Qtd.TabIndex = 3;
            // 
            // txb_Lote
            // 
            this.txb_Lote.Location = new System.Drawing.Point(378, 78);
            this.txb_Lote.Multiline = true;
            this.txb_Lote.Name = "txb_Lote";
            this.txb_Lote.Size = new System.Drawing.Size(157, 26);
            this.txb_Lote.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Produto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lote";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Qtd.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fornec.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Local.";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(378, 129);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 20);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.Value = new System.DateTime(2019, 12, 1, 0, 0, 0, 0);
            // 
            // btn_SalvarProd
            // 
            this.btn_SalvarProd.Location = new System.Drawing.Point(53, 255);
            this.btn_SalvarProd.Name = "btn_SalvarProd";
            this.btn_SalvarProd.Size = new System.Drawing.Size(155, 40);
            this.btn_SalvarProd.TabIndex = 13;
            this.btn_SalvarProd.Text = "Salvar";
            this.btn_SalvarProd.UseVisualStyleBackColor = true;
            this.btn_SalvarProd.Click += new System.EventHandler(this.btn_SalvarProd_Click);
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
            this.button3.TabIndex = 14;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btRFID
            // 
            this.btRFID.Location = new System.Drawing.Point(53, 185);
            this.btRFID.Name = "btRFID";
            this.btRFID.Size = new System.Drawing.Size(155, 44);
            this.btRFID.TabIndex = 15;
            this.btRFID.Text = "Cadastro com RFID";
            this.btRFID.UseVisualStyleBackColor = true;
            this.btRFID.Click += new System.EventHandler(this.btRFID_Click);
            // 
            // Cadastro_Material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_Pi_2.Properties.Resources.LogPequeno;
            this.ClientSize = new System.Drawing.Size(613, 320);
            this.Controls.Add(this.btRFID);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_SalvarProd);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_Lote);
            this.Controls.Add(this.txb_Qtd);
            this.Controls.Add(this.txb_Fornec);
            this.Controls.Add(this.txb_Local);
            this.Controls.Add(this.txb_Produto);
            this.Name = "Cadastro_Material";
            this.Text = "Cadastro Material";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cadastro_Material_FormClosing);
            this.Load += new System.EventHandler(this.Cadastro_Material_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_Produto;
        private System.Windows.Forms.TextBox txb_Local;
        private System.Windows.Forms.TextBox txb_Fornec;
        private System.Windows.Forms.TextBox txb_Qtd;
        private System.Windows.Forms.TextBox txb_Lote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_SalvarProd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btRFID;
    }
}