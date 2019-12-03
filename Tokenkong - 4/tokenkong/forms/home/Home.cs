using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tokenkong.forms.home
{
    public partial class Home : Form
    {
        Panel content;
        public Home(Panel content)
        {
            InitializeComponent();

            this.init();
            this.content = content;
        }

        private void init()
        {
        }
    }
}
