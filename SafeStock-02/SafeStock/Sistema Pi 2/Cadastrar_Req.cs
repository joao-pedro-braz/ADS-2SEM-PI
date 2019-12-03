using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Pi_2
{
    public partial class Cadastrar_Req : Form
    {
        public Cadastrar_Req()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu_Principal form = new Menu_Principal();
            form.Show();
        }
    }
}
