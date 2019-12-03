using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tokenkong.dal;

namespace tokenkong.forms
{
    public partial class ClientList : System.Windows.Forms.Form
    {
        Panel content;
        public ClientList(Panel content)
        {
            InitializeComponent();
     
            this.init();
            this.content = content;
        }

        private void init()
        {
            this.initializeClientsTable();
        }

        private void initializeClientsTable()
        {
            ClientsDAL clientController = new ClientsDAL();
            table_clients.DataSource = clientController.list();
        }

        private void openContentForm(object form)
        {
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
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            this.openContentForm(new ClientForm(this.content));
        }
    }
}
