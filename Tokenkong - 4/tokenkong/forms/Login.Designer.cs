namespace tokenkong
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txb_email = new System.Windows.Forms.TextBox();
            this.txb_password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_minimize = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_email
            // 
            this.txb_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_email.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_email.Location = new System.Drawing.Point(12, 131);
            this.txb_email.Multiline = true;
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(276, 24);
            this.txb_email.TabIndex = 0;
            this.txb_email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txb_email_KeyDown);
            // 
            // txb_password
            // 
            this.txb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_password.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_password.Location = new System.Drawing.Point(12, 187);
            this.txb_password.Multiline = true;
            this.txb_password.Name = "txb_password";
            this.txb_password.PasswordChar = '*';
            this.txb_password.Size = new System.Drawing.Size(276, 24);
            this.txb_password.TabIndex = 1;
            this.txb_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txb_password_KeyDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button1.Location = new System.Drawing.Point(12, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "ENTRAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(105, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 42);
            this.label3.TabIndex = 6;
            this.label3.Text = "LOGIN";
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimize.Image")));
            this.btn_minimize.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_minimize.InitialImage")));
            this.btn_minimize.Location = new System.Drawing.Point(227, 9);
            this.btn_minimize.Margin = new System.Windows.Forms.Padding(0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(32, 32);
            this.btn_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_minimize.TabIndex = 8;
            this.btn_minimize.TabStop = false;
            this.btn_minimize.Click += new System.EventHandler(this.Btn_minimize_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.InitialImage")));
            this.btn_exit.Location = new System.Drawing.Point(259, 9);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(32, 32);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_exit.TabIndex = 7;
            this.btn_exit.TabStop = false;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_minimize);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 50);
            this.panel1.TabIndex = 9;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(300, 330);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txb_password);
            this.Controls.Add(this.txb_email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.TextBox txb_password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btn_minimize;
        private System.Windows.Forms.PictureBox btn_exit;
        private System.Windows.Forms.Panel panel1;
    }
}