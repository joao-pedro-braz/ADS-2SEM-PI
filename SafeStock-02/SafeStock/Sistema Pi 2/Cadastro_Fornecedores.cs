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
    public partial class Cadastro_Fornecedores : Form
    {
        public Cadastro_Fornecedores()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            CC_Fornecedores form = new CC_Fornecedores();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Cad_Fornecedor form = new Form_Cad_Fornecedor();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Alterar_Fornecedor form = new Alterar_Fornecedor();
            form.Show();
        }
    }
}
