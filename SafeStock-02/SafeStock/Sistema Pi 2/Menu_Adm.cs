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
    public partial class Menu_Adm : Form
    {
        public Menu_Adm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Adm_Usuário form3 = new Adm_Usuário();
            
            form3.Show();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Adm_Grupo_Usuário form2 = new Adm_Grupo_Usuário();

            form2.Show();
        }
    }
}
