namespace tokenkong
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.leftbar = new System.Windows.Forms.TableLayoutPanel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_activity = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.icon_menu = new System.Windows.Forms.PictureBox();
            this.btn_products = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_clients = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.middle = new System.Windows.Forms.Panel();
            this.btn_maximize = new System.Windows.Forms.PictureBox();
            this.btn_minimize = new System.Windows.Forms.PictureBox();
            this.btn_restore = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.PictureBox();
            this.content = new System.Windows.Forms.Panel();
            this.leftbar.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_menu)).BeginInit();
            this.middle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // leftbar
            // 
            this.leftbar.ColumnCount = 1;
            this.leftbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.leftbar.Controls.Add(this.btn_logout, 0, 6);
            this.leftbar.Controls.Add(this.btn_activity, 0, 2);
            this.leftbar.Controls.Add(this.panel3, 0, 0);
            this.leftbar.Controls.Add(this.btn_products, 0, 4);
            this.leftbar.Controls.Add(this.btn_home, 0, 1);
            this.leftbar.Controls.Add(this.btn_clients, 0, 3);
            this.leftbar.Controls.Add(this.btn_report, 0, 5);
            this.leftbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftbar.Location = new System.Drawing.Point(0, 0);
            this.leftbar.Margin = new System.Windows.Forms.Padding(0);
            this.leftbar.Name = "leftbar";
            this.leftbar.Padding = new System.Windows.Forms.Padding(0, 0, 0, 32);
            this.leftbar.RowCount = 7;
            this.leftbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.leftbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.leftbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.leftbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.leftbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.leftbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.leftbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.leftbar.Size = new System.Drawing.Size(200, 450);
            this.leftbar.TabIndex = 2;
            // 
            // btn_logout
            // 
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_logout.Image")));
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(0, 192);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(0);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(200, 32);
            this.btn_logout.TabIndex = 14;
            this.btn_logout.Text = "         Sair";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.Btn_logout_Click);
            // 
            // btn_activity
            // 
            this.btn_activity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_activity.FlatAppearance.BorderSize = 0;
            this.btn_activity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_activity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_activity.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_activity.ForeColor = System.Drawing.Color.White;
            this.btn_activity.Image = ((System.Drawing.Image)(resources.GetObject("btn_activity.Image")));
            this.btn_activity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_activity.Location = new System.Drawing.Point(0, 64);
            this.btn_activity.Margin = new System.Windows.Forms.Padding(0);
            this.btn_activity.Name = "btn_activity";
            this.btn_activity.Size = new System.Drawing.Size(200, 32);
            this.btn_activity.TabIndex = 10;
            this.btn_activity.Text = "         Vendas";
            this.btn_activity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_activity.UseVisualStyleBackColor = true;
            this.btn_activity.Click += new System.EventHandler(this.Btn_activity_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.icon_menu);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 32);
            this.panel3.TabIndex = 8;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel3_MouseDown);
            // 
            // icon_menu
            // 
            this.icon_menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("icon_menu.BackgroundImage")));
            this.icon_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icon_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon_menu.Location = new System.Drawing.Point(0, 0);
            this.icon_menu.Margin = new System.Windows.Forms.Padding(0);
            this.icon_menu.Name = "icon_menu";
            this.icon_menu.Size = new System.Drawing.Size(40, 32);
            this.icon_menu.TabIndex = 0;
            this.icon_menu.TabStop = false;
            this.icon_menu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Icon_menu_MouseClick);
            // 
            // btn_products
            // 
            this.btn_products.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_products.FlatAppearance.BorderSize = 0;
            this.btn_products.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_products.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_products.ForeColor = System.Drawing.Color.White;
            this.btn_products.Image = ((System.Drawing.Image)(resources.GetObject("btn_products.Image")));
            this.btn_products.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_products.Location = new System.Drawing.Point(0, 128);
            this.btn_products.Margin = new System.Windows.Forms.Padding(0);
            this.btn_products.Name = "btn_products";
            this.btn_products.Size = new System.Drawing.Size(200, 32);
            this.btn_products.TabIndex = 12;
            this.btn_products.Text = "         Produtos";
            this.btn_products.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_products.UseVisualStyleBackColor = true;
            this.btn_products.Click += new System.EventHandler(this.Btn_products_Click);
            // 
            // btn_home
            // 
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(0, 32);
            this.btn_home.Margin = new System.Windows.Forms.Padding(0);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(200, 32);
            this.btn_home.TabIndex = 2;
            this.btn_home.Text = "         Início";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.Btn_home_Click);
            // 
            // btn_clients
            // 
            this.btn_clients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_clients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clients.FlatAppearance.BorderSize = 0;
            this.btn_clients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_clients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clients.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clients.ForeColor = System.Drawing.Color.White;
            this.btn_clients.Image = ((System.Drawing.Image)(resources.GetObject("btn_clients.Image")));
            this.btn_clients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clients.Location = new System.Drawing.Point(0, 96);
            this.btn_clients.Margin = new System.Windows.Forms.Padding(0);
            this.btn_clients.Name = "btn_clients";
            this.btn_clients.Size = new System.Drawing.Size(200, 32);
            this.btn_clients.TabIndex = 13;
            this.btn_clients.Text = "         Clientes";
            this.btn_clients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clients.UseVisualStyleBackColor = false;
            this.btn_clients.Click += new System.EventHandler(this.Btn_clients_Click);
            // 
            // btn_report
            // 
            this.btn_report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_report.FlatAppearance.BorderSize = 0;
            this.btn_report.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_report.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.ForeColor = System.Drawing.Color.White;
            this.btn_report.Image = ((System.Drawing.Image)(resources.GetObject("btn_report.Image")));
            this.btn_report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_report.Location = new System.Drawing.Point(0, 160);
            this.btn_report.Margin = new System.Windows.Forms.Padding(0);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(200, 32);
            this.btn_report.TabIndex = 1;
            this.btn_report.Text = "         Relatórios";
            this.btn_report.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_report.UseVisualStyleBackColor = true;
            // 
            // middle
            // 
            this.middle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.middle.Controls.Add(this.btn_maximize);
            this.middle.Controls.Add(this.btn_minimize);
            this.middle.Controls.Add(this.btn_restore);
            this.middle.Controls.Add(this.btn_exit);
            this.middle.Controls.Add(this.content);
            this.middle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middle.Location = new System.Drawing.Point(200, 0);
            this.middle.Margin = new System.Windows.Forms.Padding(0);
            this.middle.Name = "middle";
            this.middle.Padding = new System.Windows.Forms.Padding(0, 32, 16, 16);
            this.middle.Size = new System.Drawing.Size(600, 450);
            this.middle.TabIndex = 3;
            this.middle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Middle_MouseDown);
            // 
            // btn_maximize
            // 
            this.btn_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximize.BackColor = System.Drawing.Color.Transparent;
            this.btn_maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_maximize.Image = ((System.Drawing.Image)(resources.GetObject("btn_maximize.Image")));
            this.btn_maximize.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_maximize.InitialImage")));
            this.btn_maximize.Location = new System.Drawing.Point(536, 0);
            this.btn_maximize.Margin = new System.Windows.Forms.Padding(0);
            this.btn_maximize.Name = "btn_maximize";
            this.btn_maximize.Size = new System.Drawing.Size(32, 32);
            this.btn_maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_maximize.TabIndex = 4;
            this.btn_maximize.TabStop = false;
            this.btn_maximize.Click += new System.EventHandler(this.Btn_maximize_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimize.Image")));
            this.btn_minimize.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_minimize.InitialImage")));
            this.btn_minimize.Location = new System.Drawing.Point(504, 0);
            this.btn_minimize.Margin = new System.Windows.Forms.Padding(0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(32, 32);
            this.btn_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_minimize.TabIndex = 3;
            this.btn_minimize.TabStop = false;
            this.btn_minimize.Click += new System.EventHandler(this.Btn_minimize_Click);
            // 
            // btn_restore
            // 
            this.btn_restore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_restore.BackColor = System.Drawing.Color.Transparent;
            this.btn_restore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_restore.Image = ((System.Drawing.Image)(resources.GetObject("btn_restore.Image")));
            this.btn_restore.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_restore.InitialImage")));
            this.btn_restore.Location = new System.Drawing.Point(536, 0);
            this.btn_restore.Margin = new System.Windows.Forms.Padding(0);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(32, 32);
            this.btn_restore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_restore.TabIndex = 2;
            this.btn_restore.TabStop = false;
            this.btn_restore.Click += new System.EventHandler(this.Btn_restore_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.InitialImage")));
            this.btn_exit.Location = new System.Drawing.Point(568, 0);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(32, 32);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_exit.TabIndex = 1;
            this.btn_exit.TabStop = false;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // content
            // 
            this.content.AutoSize = true;
            this.content.BackColor = System.Drawing.Color.White;
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(0, 32);
            this.content.Margin = new System.Windows.Forms.Padding(0);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(584, 402);
            this.content.TabIndex = 0;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.middle);
            this.Controls.Add(this.leftbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.leftbar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icon_menu)).EndInit();
            this.middle.ResumeLayout(false);
            this.middle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel leftbar;
        private System.Windows.Forms.Panel middle;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.PictureBox btn_minimize;
        private System.Windows.Forms.PictureBox btn_restore;
        private System.Windows.Forms.PictureBox btn_exit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox icon_menu;
        private System.Windows.Forms.PictureBox btn_maximize;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_activity;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_clients;
        private System.Windows.Forms.Button btn_products;
        private System.Windows.Forms.Button btn_logout;
    }
}

