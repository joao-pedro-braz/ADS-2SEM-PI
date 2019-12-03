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
    public partial class Alterar_Fornecedor : Form
    {
        public Alterar_Fornecedor()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Cadastro_Fornecedores form = new Cadastro_Fornecedores();
            form.Show();
        }
    }
}
