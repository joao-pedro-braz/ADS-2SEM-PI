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
using tokenkong.models;

namespace tokenkong
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.login();
        }

        private void Txb_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.login();
            }
        }

        private void Txb_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void login()
        {
            try{
                UserModel user = new UserModel();
                Auth auth = new Auth();
                if (txb_email.Text != String.Empty && txb_password.Text != String.Empty)
                {
                    user = auth.login(txb_email.Text, txb_password.Text);
                    if (user != null)
                    {
                        Properties.Settings.Default.id = user.ID;
                        Properties.Settings.Default.email = user.EMAIL;
                        Properties.Settings.Default.name = user.NAME;
                        Properties.Settings.Default.Save();
                        Principal form = new Principal();
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Email ou Senha invalidos!");
                    }
                }
                else
                {
                    MessageBox.Show("Email ou Senha invalidos!");
                }
            }catch( Exception error)
            {
                Console.WriteLine(error);
            }

        }
    }
    
}
