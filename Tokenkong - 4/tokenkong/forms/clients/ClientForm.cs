using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tokenkong.forms
{
    public partial class ClientForm : System.Windows.Forms.Form
    {
        Panel content;
        public ClientForm(Panel content)
        {
            InitializeComponent();
            this.content = content;
        }
    }
}
