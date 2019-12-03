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
    public partial class CC_Fornecedores : Form
    {
        public CC_Fornecedores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Cadastro_Fornecedores form = new Cadastro_Fornecedores();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Seleção_Cadastro form = new Seleção_Cadastro();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Cons_Fornec form = new Form_Cons_Fornec();
            form.Show();
        }
    }
}
