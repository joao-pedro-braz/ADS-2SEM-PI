namespace tokenkong.forms
{
    partial class SaleForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.product_list = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_description = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_insert_product = new System.Windows.Forms.Button();
            this.cb_products = new System.Windows.Forms.ComboBox();
            this.cb_clients = new System.Windows.Forms.ComboBox();
            this.lbl_client = new System.Windows.Forms.Label();
            this.img_product = new System.Windows.Forms.PictureBox();
            this.lbl_products = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.product_list)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_product)).BeginInit();
            this.SuspendLayout();
            // 
            // product_list
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.product_list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.product_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.product_list.BackgroundColor = System.Drawing.Color.White;
            this.product_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.product_list.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.product_list.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.product_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.product_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.product_list.EnableHeadersVisualStyles = false;
            this.product_list.GridColor = System.Drawing.Color.White;
            this.product_list.Location = new System.Drawing.Point(0, 0);
            this.product_list.Margin = new System.Windows.Forms.Padding(0);
            this.product_list.Name = "product_list";
            this.product_list.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.product_list.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.product_list.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.product_list.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.product_list.Size = new System.Drawing.Size(260, 354);
            this.product_list.TabIndex = 5;
            this.product_list.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Product_list_CellBeginEdit);
            this.product_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Product_list_CellClick);
            this.product_list.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Product_list_CellEndEdit);
            this.product_list.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Product_list_MouseClick);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(16, 16);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 322F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 322F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(536, 354);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(536, 354);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.product_list);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.panel2.Size = new System.Drawing.Size(268, 354);
            this.panel2.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btn_cancel, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.total, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.btn_submit, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.txb_description, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cb_clients, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lbl_client, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.img_product, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_products, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(271, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 11;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(262, 348);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cancel.Location = new System.Drawing.Point(0, 333);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(0);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(262, 26);
            this.btn_cancel.TabIndex = 17;
            this.btn_cancel.Text = "CANCELAR";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(0, 245);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "TOTAL:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.BackColor = System.Drawing.Color.White;
            this.total.Dock = System.Windows.Forms.DockStyle.Fill;
            this.total.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.total.Location = new System.Drawing.Point(0, 281);
            this.total.Margin = new System.Windows.Forms.Padding(0);
            this.total.MinimumSize = new System.Drawing.Size(150, 26);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(262, 26);
            this.total.TabIndex = 6;
            this.total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(140)))), ((int)(((byte)(68)))));
            this.btn_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_submit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_submit.FlatAppearance.BorderSize = 0;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submit.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.Color.White;
            this.btn_submit.Location = new System.Drawing.Point(0, 307);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(262, 26);
            this.btn_submit.TabIndex = 10;
            this.btn_submit.Text = "FINALIZAR";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.Btn_submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Observações: ";
            // 
            // txb_description
            // 
            this.txb_description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txb_description.Location = new System.Drawing.Point(0, 225);
            this.txb_description.Margin = new System.Windows.Forms.Padding(0);
            this.txb_description.Name = "txb_description";
            this.txb_description.Size = new System.Drawing.Size(262, 20);
            this.txb_description.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btn_insert_product, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cb_products, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 126);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(262, 26);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // btn_insert_product
            // 
            this.btn_insert_product.AutoSize = true;
            this.btn_insert_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_insert_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_insert_product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_insert_product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_insert_product.FlatAppearance.BorderSize = 0;
            this.btn_insert_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insert_product.Font = new System.Drawing.Font("Poppins Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert_product.ForeColor = System.Drawing.Color.White;
            this.btn_insert_product.Location = new System.Drawing.Point(172, 0);
            this.btn_insert_product.Margin = new System.Windows.Forms.Padding(0);
            this.btn_insert_product.MaximumSize = new System.Drawing.Size(0, 21);
            this.btn_insert_product.Name = "btn_insert_product";
            this.btn_insert_product.Size = new System.Drawing.Size(90, 21);
            this.btn_insert_product.TabIndex = 5;
            this.btn_insert_product.Text = "ADICIONAR";
            this.btn_insert_product.UseVisualStyleBackColor = false;
            this.btn_insert_product.Click += new System.EventHandler(this.Btn_insert_product_Click);
            // 
            // cb_products
            // 
            this.cb_products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_products.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_products.FormattingEnabled = true;
            this.cb_products.ItemHeight = 13;
            this.cb_products.Location = new System.Drawing.Point(0, 0);
            this.cb_products.Margin = new System.Windows.Forms.Padding(0);
            this.cb_products.Name = "cb_products";
            this.cb_products.Size = new System.Drawing.Size(172, 21);
            this.cb_products.TabIndex = 4;
            this.cb_products.DropDown += new System.EventHandler(this.Cb_products_DropDown);
            this.cb_products.SelectedIndexChanged += new System.EventHandler(this.Cb_products_SelectedIndexChanged);
            this.cb_products.Click += new System.EventHandler(this.Cb_products_Click);
            // 
            // cb_clients
            // 
            this.cb_clients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_clients.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_clients.FormattingEnabled = true;
            this.cb_clients.ItemHeight = 13;
            this.cb_clients.Location = new System.Drawing.Point(0, 178);
            this.cb_clients.Margin = new System.Windows.Forms.Padding(0);
            this.cb_clients.Name = "cb_clients";
            this.cb_clients.Size = new System.Drawing.Size(262, 21);
            this.cb_clients.TabIndex = 4;
            // 
            // lbl_client
            // 
            this.lbl_client.AutoSize = true;
            this.lbl_client.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_client.Location = new System.Drawing.Point(0, 152);
            this.lbl_client.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_client.Name = "lbl_client";
            this.lbl_client.Size = new System.Drawing.Size(72, 26);
            this.lbl_client.TabIndex = 8;
            this.lbl_client.Text = "Cliente: ";
            // 
            // img_product
            // 
            this.img_product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img_product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.img_product.Location = new System.Drawing.Point(0, 0);
            this.img_product.Margin = new System.Windows.Forms.Padding(0);
            this.img_product.Name = "img_product";
            this.img_product.Size = new System.Drawing.Size(262, 100);
            this.img_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_product.TabIndex = 16;
            this.img_product.TabStop = false;
            this.img_product.Resize += new System.EventHandler(this.Img_product_Resize);
            // 
            // lbl_products
            // 
            this.lbl_products.AutoSize = true;
            this.lbl_products.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_products.Location = new System.Drawing.Point(0, 100);
            this.lbl_products.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_products.Name = "lbl_products";
            this.lbl_products.Size = new System.Drawing.Size(88, 26);
            this.lbl_products.TabIndex = 8;
            this.lbl_products.Text = "Produtos: ";
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(568, 386);
            this.Controls.Add(this.tableLayoutPanel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaleForm";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.Text = "SalesForm";
            ((System.ComponentModel.ISupportInitialize)(this.product_list)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView product_list;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_products;
        private System.Windows.Forms.Label lbl_products;
        private System.Windows.Forms.Label lbl_client;
        private System.Windows.Forms.ComboBox cb_clients;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_description;
        private System.Windows.Forms.PictureBox img_product;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_insert_product;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_cancel;
    }
}