using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace tokenkong
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Properties.Settings.Default.email != String.Empty && Properties.Settings.Default.name != String.Empty)
            {
                Application.Run(new Principal());
            }
            else
            {
                Application.Run(new Login());
            }
            
        }
    }
}
