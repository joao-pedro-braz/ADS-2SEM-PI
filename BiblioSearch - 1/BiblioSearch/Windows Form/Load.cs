using System;
using MaterialSkin;


namespace ConsoleApplication.Windows_Form
{
    public partial class Load : MaterialSkin.Controls.MaterialForm
    {
        public Load()
        {
            InitializeComponent();

            MaterialSkin.MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue300, Primary.Blue400, Primary.Blue200, Accent.Red100, TextShade.WHITE);
        }

        int contador = 0;
        private void Load_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BiblioSearch biblioSearch = new BiblioSearch();

            if (contador != 100)
            {
                progressBar1.Value = contador;
                contador++;
            }
            else
            {
                timer1.Stop();
                this.Hide();
                biblioSearch.ShowDialog();
            }

        }

    }
}
