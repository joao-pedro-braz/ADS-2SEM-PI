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
    public partial class Seleção_Relatório : Form
    {
        public Seleção_Relatório()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu_Principal form = new Menu_Principal();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Relatorio_Estoque form = new Relatorio_Estoque();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Relatorio_Fornecedor form = new Relatorio_Fornecedor();
            form.Show();
        }
    }
}
