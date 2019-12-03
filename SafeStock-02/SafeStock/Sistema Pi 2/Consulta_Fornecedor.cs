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
    public partial class Form_Cons_Fornec : Form
    {
        public Form_Cons_Fornec()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            CC_Fornecedores form = new CC_Fornecedores();
            form.Show();
        }
    }
}
