using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SftwPI
{
    public partial class FrmCarreagemento : Form
    {
        
        FrmPrincipal principal = new FrmPrincipal();
        public FrmCarreagemento()
        {
            
            InitializeComponent();
        }

        private void FrmCarreagemento_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            FrmCarreagemento carregamnto = new FrmCarreagemento();

            progressBar1.Increment(2);
            if (progressBar1.Value > 1 && progressBar1.Value < 100)
            {
                lblPorcentagem.Text = String.Format("Carregando... {0}%", progressBar1.Value);
            }
            else if (progressBar1.Value == 100)
            {
                lblPorcentagem.Text = "Concluiído!";
                timer1.Stop();
                carregamnto.Close();
                principal.Show();
                
            }
        }
    }
}
