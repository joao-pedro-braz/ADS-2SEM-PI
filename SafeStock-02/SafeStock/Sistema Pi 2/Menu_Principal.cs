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
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Localização form = new Localização();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Seleção_Cadastro form = new Seleção_Cadastro();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Cadastrar_Req form = new Cadastrar_Req();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Seleção_Relatório form = new Seleção_Relatório();
            form.Show();
        }
    }
}
