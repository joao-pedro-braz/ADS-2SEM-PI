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
    public partial class Seleção_Cadastro : Form
    {
        public Seleção_Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CC_Estoque form = new CC_Estoque();
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            CC_Fornecedores form = new CC_Fornecedores();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu_Principal form = new Menu_Principal();
            form.Show();
        }
    }
}
