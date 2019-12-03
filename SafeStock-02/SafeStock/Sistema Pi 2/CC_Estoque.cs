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
    public partial class CC_Estoque : Form
    {
        public CC_Estoque()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastro_Estoque form = new Cadastro_Estoque();
            form.Show();
            this.Close();
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
            Consulta_Material form = new Consulta_Material();
            form.Show();
        }
    }
}
