using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using tokenkong.forms;
using tokenkong.forms.home;

namespace tokenkong
{
    public partial class Principal : System.Windows.Forms.Form
    {
        public Principal()
        {
            InitializeComponent();
            this.init();
        }

        private void init()
        {
            this.openContentForm(new Home(this.content), "home");
            this.initializeWindowState();
        }

        public void initializeWindowState()
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                btn_restore.Visible = true;
                btn_maximize.Visible = false;
            }
            else
            {
                btn_restore.Visible = false;
                btn_maximize.Visible = true;
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void Icon_menu_MouseClick(object sender, MouseEventArgs e)
        {
            if (leftbar.Width == 200)
            {
                leftbar.Width = 40;
            }
            else
            {
                leftbar.Width = 200;
            }
        }

        private void Btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_maximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_maximize.Visible = false;
            btn_restore.Visible = true;
        }

        private void Btn_restore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_restore.Visible = false;
            btn_maximize.Visible = true;
        }

        private void Btn_home_Click(object sender, EventArgs e)
        {
            this.openContentForm(new Home(this.content), "home");
        }

        private void Btn_activity_Click(object sender, EventArgs e)
        {
            this.openContentForm(new SaleList(this.content), "activity");
        }

        private void Btn_products_Click(object sender, EventArgs e)
        {
            this.openContentForm(new ProductList(this.content), "products");
        }

        private void Btn_clients_Click(object sender, EventArgs e)
        {
            this.openContentForm(new ClientList(this.content), "client");
        }

        private void openContentForm(object form, string activeTab)
        {

            switch (activeTab)
            {
                case "home":
                    btn_home.BackColor = Color.FromArgb(234, 140, 68);

                    btn_activity.BackColor = Color.FromArgb(51, 51, 51);
                    btn_products.BackColor = Color.FromArgb(51, 51, 51);
                    btn_report.BackColor = Color.FromArgb(51, 51, 51);
                    btn_clients.BackColor = Color.FromArgb(51, 51, 51);
                    break;
                case "activity":
                    btn_activity.BackColor = Color.FromArgb(234, 140, 68);

                    btn_home.BackColor = Color.FromArgb(51, 51, 51);
                    btn_products.BackColor = Color.FromArgb(51, 51, 51);
                    btn_report.BackColor = Color.FromArgb(51, 51, 51);
                    btn_clients.BackColor = Color.FromArgb(51, 51, 51);
                    break;
                case "client":
                    btn_clients.BackColor = Color.FromArgb(234, 140, 68);

                    btn_activity.BackColor = Color.FromArgb(51, 51, 51);
                    btn_home.BackColor = Color.FromArgb(51, 51, 51);
                    btn_products.BackColor = Color.FromArgb(51, 51, 51);
                    btn_report.BackColor = Color.FromArgb(51, 51, 51);
                    break;
                case "products":
                    btn_products.BackColor = Color.FromArgb(234, 140, 68);

                    btn_home.BackColor = Color.FromArgb(51, 51, 51);
                    btn_activity.BackColor = Color.FromArgb(51, 51, 51);
                    btn_report.BackColor = Color.FromArgb(51, 51, 51);
                    btn_clients.BackColor = Color.FromArgb(51, 51, 51);
                    break;
                case "report":
                    btn_report.BackColor = Color.FromArgb(234, 140, 68);

                    btn_home.BackColor = Color.FromArgb(51, 51, 51);
                    btn_activity.BackColor = Color.FromArgb(51, 51, 51);
                    btn_products.BackColor = Color.FromArgb(51, 51, 51);
                    btn_clients.BackColor = Color.FromArgb(51, 51, 51);
                    break;
            }

            try
            {
                if (this.content.Controls.Count > 0)
                {
                    foreach (System.Windows.Forms.Form frm in this.content.Controls)
                    {
                        frm.Close();
                    }
                }

                System.Windows.Forms.Form f = form as System.Windows.Forms.Form;
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.content.Controls.Add(f);
                this.content.Tag = f;
                f.AutoScroll = true;
                f.Show();
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Middle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Btn_logout_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
