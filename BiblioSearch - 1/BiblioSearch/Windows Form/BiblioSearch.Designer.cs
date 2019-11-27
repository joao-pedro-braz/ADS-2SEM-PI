namespace ConsoleApplication.Windows_Form
{
    partial class BiblioSearch
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BiblioSearch));
            this.tbPesquisa = new System.Windows.Forms.TextBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lbResultados = new System.Windows.Forms.ListBox();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAutores = new System.Windows.Forms.TextBox();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbEstante = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbColuna = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbBandeja = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbLado = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCutter = new System.Windows.Forms.TextBox();
            this.lbOutrasPos = new System.Windows.Forms.ListBox();
            this.btPesquisar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btLimpar = new MaterialSkin.Controls.MaterialFlatButton();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.pnLivro = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnOutrasLoc = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbLivro = new System.Windows.Forms.PictureBox();
            this.ctPesquisa = new System.Windows.Forms.Panel();
            this.pbPesquisa = new System.Windows.Forms.PictureBox();
            this.pbFundo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnOutrasLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLivro)).BeginInit();
            this.ctPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFundo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPesquisa
            // 
            this.tbPesquisa.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPesquisa.Location = new System.Drawing.Point(211, 18);
            this.tbPesquisa.Name = "tbPesquisa";
            this.tbPesquisa.Size = new System.Drawing.Size(649, 25);
            this.tbPesquisa.TabIndex = 0;
            this.tbPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPesquisa_KeyDown);
            // 
            // cbCategoria
            // 
            this.cbCategoria.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Geral",
            "Por Autor",
            "Título"});
            this.cbCategoria.Location = new System.Drawing.Point(328, 97);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(393, 23);
            this.cbCategoria.TabIndex = 4;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // lbResultados
            // 
            this.lbResultados.BackColor = System.Drawing.Color.White;
            this.lbResultados.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultados.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbResultados.FormattingEnabled = true;
            this.lbResultados.ItemHeight = 15;
            this.lbResultados.Location = new System.Drawing.Point(11, 131);
            this.lbResultados.Name = "lbResultados";
            this.lbResultados.Size = new System.Drawing.Size(986, 94);
            this.lbResultados.TabIndex = 8;
            this.lbResultados.SelectedIndexChanged += new System.EventHandler(this.lbResultados_SelectedIndexChanged);
            // 
            // tbTitulo
            // 
            this.tbTitulo.BackColor = System.Drawing.SystemColors.Window;
            this.tbTitulo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitulo.Location = new System.Drawing.Point(364, 15);
            this.tbTitulo.Multiline = true;
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.ReadOnly = true;
            this.tbTitulo.Size = new System.Drawing.Size(282, 46);
            this.tbTitulo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(276, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Título";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(276, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Autores";
            // 
            // tbAutores
            // 
            this.tbAutores.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbAutores.BackColor = System.Drawing.SystemColors.Window;
            this.tbAutores.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAutores.Location = new System.Drawing.Point(364, 108);
            this.tbAutores.Multiline = true;
            this.tbAutores.Name = "tbAutores";
            this.tbAutores.ReadOnly = true;
            this.tbAutores.Size = new System.Drawing.Size(282, 57);
            this.tbAutores.TabIndex = 13;
            // 
            // tbDescricao
            // 
            this.tbDescricao.BackColor = System.Drawing.SystemColors.Window;
            this.tbDescricao.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescricao.Location = new System.Drawing.Point(280, 176);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.ReadOnly = true;
            this.tbDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescricao.Size = new System.Drawing.Size(366, 201);
            this.tbDescricao.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(670, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Estante";
            // 
            // lbEstante
            // 
            this.lbEstante.AutoSize = true;
            this.lbEstante.BackColor = System.Drawing.SystemColors.Window;
            this.lbEstante.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstante.Location = new System.Drawing.Point(768, 45);
            this.lbEstante.Name = "lbEstante";
            this.lbEstante.Size = new System.Drawing.Size(20, 22);
            this.lbEstante.TabIndex = 17;
            this.lbEstante.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Window;
            this.label9.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(670, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 22);
            this.label9.TabIndex = 18;
            this.label9.Text = "Coluna";
            // 
            // lbColuna
            // 
            this.lbColuna.AutoSize = true;
            this.lbColuna.BackColor = System.Drawing.SystemColors.Window;
            this.lbColuna.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColuna.Location = new System.Drawing.Point(768, 74);
            this.lbColuna.Name = "lbColuna";
            this.lbColuna.Size = new System.Drawing.Size(20, 22);
            this.lbColuna.TabIndex = 19;
            this.lbColuna.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Window;
            this.label10.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(670, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 22);
            this.label10.TabIndex = 20;
            this.label10.Text = "Bandeja";
            // 
            // lbBandeja
            // 
            this.lbBandeja.AutoSize = true;
            this.lbBandeja.BackColor = System.Drawing.SystemColors.Window;
            this.lbBandeja.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBandeja.Location = new System.Drawing.Point(768, 100);
            this.lbBandeja.Name = "lbBandeja";
            this.lbBandeja.Size = new System.Drawing.Size(20, 22);
            this.lbBandeja.TabIndex = 21;
            this.lbBandeja.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Window;
            this.label11.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(671, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 22);
            this.label11.TabIndex = 22;
            this.label11.Text = "Lado";
            // 
            // lbLado
            // 
            this.lbLado.AutoSize = true;
            this.lbLado.BackColor = System.Drawing.SystemColors.Window;
            this.lbLado.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLado.Location = new System.Drawing.Point(768, 127);
            this.lbLado.Name = "lbLado";
            this.lbLado.Size = new System.Drawing.Size(20, 22);
            this.lbLado.TabIndex = 23;
            this.lbLado.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(276, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 22);
            this.label8.TabIndex = 24;
            this.label8.Text = "Cutter";
            // 
            // tbCutter
            // 
            this.tbCutter.BackColor = System.Drawing.SystemColors.Window;
            this.tbCutter.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCutter.Location = new System.Drawing.Point(364, 63);
            this.tbCutter.Multiline = true;
            this.tbCutter.Name = "tbCutter";
            this.tbCutter.ReadOnly = true;
            this.tbCutter.Size = new System.Drawing.Size(282, 20);
            this.tbCutter.TabIndex = 25;
            // 
            // lbOutrasPos
            // 
            this.lbOutrasPos.BackColor = System.Drawing.SystemColors.Window;
            this.lbOutrasPos.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOutrasPos.FormattingEnabled = true;
            this.lbOutrasPos.ItemHeight = 22;
            this.lbOutrasPos.Location = new System.Drawing.Point(22, 59);
            this.lbOutrasPos.Name = "lbOutrasPos";
            this.lbOutrasPos.Size = new System.Drawing.Size(323, 158);
            this.lbOutrasPos.TabIndex = 26;
            // 
            // btPesquisar
            // 
            this.btPesquisar.AutoSize = true;
            this.btPesquisar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btPesquisar.BackColor = System.Drawing.SystemColors.Control;
            this.btPesquisar.Depth = 0;
            this.btPesquisar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btPesquisar.Icon = null;
            this.btPesquisar.Location = new System.Drawing.Point(445, 56);
            this.btPesquisar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btPesquisar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Primary = false;
            this.btPesquisar.Size = new System.Drawing.Size(94, 36);
            this.btPesquisar.TabIndex = 27;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = false;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.AutoSize = true;
            this.btLimpar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btLimpar.Depth = 0;
            this.btLimpar.Icon = null;
            this.btLimpar.Location = new System.Drawing.Point(546, 56);
            this.btLimpar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btLimpar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Primary = false;
            this.btLimpar.Size = new System.Drawing.Size(71, 36);
            this.btLimpar.TabIndex = 28;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.BackColor = System.Drawing.SystemColors.Window;
            this.lbCategoria.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbCategoria.Location = new System.Drawing.Point(334, 100);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(147, 15);
            this.lbCategoria.TabIndex = 31;
            this.lbCategoria.Text = "Pesquisa avançada...";
            // 
            // pnLivro
            // 
            this.pnLivro.AutoScroll = true;
            this.pnLivro.BackColor = System.Drawing.SystemColors.Window;
            this.pnLivro.Controls.Add(this.label3);
            this.pnLivro.Controls.Add(this.pictureBox1);
            this.pnLivro.Controls.Add(this.pnOutrasLoc);
            this.pnLivro.Controls.Add(this.label4);
            this.pnLivro.Controls.Add(this.tbTitulo);
            this.pnLivro.Controls.Add(this.label5);
            this.pnLivro.Controls.Add(this.tbAutores);
            this.pnLivro.Controls.Add(this.tbCutter);
            this.pnLivro.Controls.Add(this.pbLivro);
            this.pnLivro.Controls.Add(this.tbDescricao);
            this.pnLivro.Controls.Add(this.label8);
            this.pnLivro.Controls.Add(this.label7);
            this.pnLivro.Controls.Add(this.lbLado);
            this.pnLivro.Controls.Add(this.lbEstante);
            this.pnLivro.Controls.Add(this.label11);
            this.pnLivro.Controls.Add(this.label9);
            this.pnLivro.Controls.Add(this.lbBandeja);
            this.pnLivro.Controls.Add(this.lbColuna);
            this.pnLivro.Controls.Add(this.label10);
            this.pnLivro.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnLivro.Location = new System.Drawing.Point(12, 332);
            this.pnLivro.Name = "pnLivro";
            this.pnLivro.Size = new System.Drawing.Size(1012, 399);
            this.pnLivro.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Consolas", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(697, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 28);
            this.label3.TabIndex = 29;
            this.label3.Text = "Seu livro está na:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BiblioSearch.Properties.Resources.ícone_localização;
            this.pictureBox1.Location = new System.Drawing.Point(667, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // pnOutrasLoc
            // 
            this.pnOutrasLoc.Controls.Add(this.label2);
            this.pnOutrasLoc.Controls.Add(this.label1);
            this.pnOutrasLoc.Controls.Add(this.lbOutrasPos);
            this.pnOutrasLoc.Location = new System.Drawing.Point(652, 160);
            this.pnOutrasLoc.Name = "pnOutrasLoc";
            this.pnOutrasLoc.Size = new System.Drawing.Size(357, 236);
            this.pnOutrasLoc.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 29;
            this.label2.Text = "do Livro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 22);
            this.label1.TabIndex = 28;
            this.label1.Text = "Outras possíveis localizações";
            // 
            // pbLivro
            // 
            this.pbLivro.Image = global::BiblioSearch.Properties.Resources.ImagemFundo;
            this.pbLivro.Location = new System.Drawing.Point(11, 14);
            this.pbLivro.Name = "pbLivro";
            this.pbLivro.Size = new System.Drawing.Size(259, 363);
            this.pbLivro.TabIndex = 1;
            this.pbLivro.TabStop = false;
            // 
            // ctPesquisa
            // 
            this.ctPesquisa.BackColor = System.Drawing.SystemColors.Window;
            this.ctPesquisa.Controls.Add(this.lbCategoria);
            this.ctPesquisa.Controls.Add(this.btLimpar);
            this.ctPesquisa.Controls.Add(this.btPesquisar);
            this.ctPesquisa.Controls.Add(this.lbResultados);
            this.ctPesquisa.Controls.Add(this.cbCategoria);
            this.ctPesquisa.Controls.Add(this.tbPesquisa);
            this.ctPesquisa.Controls.Add(this.pbPesquisa);
            this.ctPesquisa.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctPesquisa.Location = new System.Drawing.Point(12, 72);
            this.ctPesquisa.Name = "ctPesquisa";
            this.ctPesquisa.Size = new System.Drawing.Size(1012, 254);
            this.ctPesquisa.TabIndex = 33;
            // 
            // pbPesquisa
            // 
            this.pbPesquisa.ErrorImage = null;
            this.pbPesquisa.Image = global::BiblioSearch.Properties.Resources.pesquisar;
            this.pbPesquisa.Location = new System.Drawing.Point(172, 9);
            this.pbPesquisa.Name = "pbPesquisa";
            this.pbPesquisa.Size = new System.Drawing.Size(745, 43);
            this.pbPesquisa.TabIndex = 29;
            this.pbPesquisa.TabStop = false;
            // 
            // pbFundo
            // 
            this.pbFundo.BackColor = System.Drawing.SystemColors.Window;
            this.pbFundo.Image = global::BiblioSearch.Properties.Resources.ImagemFundo;
            this.pbFundo.Location = new System.Drawing.Point(23, 737);
            this.pbFundo.Name = "pbFundo";
            this.pbFundo.Size = new System.Drawing.Size(341, 478);
            this.pbFundo.TabIndex = 27;
            this.pbFundo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BiblioSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1036, 788);
            this.Controls.Add(this.ctPesquisa);
            this.Controls.Add(this.pbFundo);
            this.Controls.Add(this.pnLivro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BiblioSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblio Search";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BiblioSearch_FormClosing);
            this.Load += new System.EventHandler(this.BiblioSearch_Load);
            this.ResizeBegin += new System.EventHandler(this.BiblioSearch_ResizeBegin);
            this.pnLivro.ResumeLayout(false);
            this.pnLivro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnOutrasLoc.ResumeLayout(false);
            this.pnOutrasLoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLivro)).EndInit();
            this.ctPesquisa.ResumeLayout(false);
            this.ctPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFundo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbPesquisa;
        private System.Windows.Forms.PictureBox pbLivro;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ListBox lbResultados;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAutores;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbEstante;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbColuna;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbBandeja;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbLado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCutter;
        private System.Windows.Forms.ListBox lbOutrasPos;
        private MaterialSkin.Controls.MaterialFlatButton btPesquisar;
        private MaterialSkin.Controls.MaterialFlatButton btLimpar;
        private System.Windows.Forms.PictureBox pbPesquisa;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Panel pnLivro;
        private System.Windows.Forms.Panel ctPesquisa;
        private System.Windows.Forms.PictureBox pbFundo;
        private System.Windows.Forms.Panel pnOutrasLoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}