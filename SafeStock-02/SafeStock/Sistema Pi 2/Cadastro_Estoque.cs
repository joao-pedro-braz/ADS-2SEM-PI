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
    public partial class Cadastro_Estoque : Form
    {
        public Cadastro_Estoque()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastro_Material form = new Cadastro_Material();
            form.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            CC_Estoque form = new CC_Estoque();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Alterar_Cadastro form = new Alterar_Cadastro();
            form.Show();
        }
    }
}
