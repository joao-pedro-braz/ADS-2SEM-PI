using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Sistema_Pi_2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Botao_Login_Click(object sender, EventArgs e)
        {
            string conexao = "Server=localhost;Database=safestock;Uid=root;Pwd=senhapi022019;SslMode=none";

            var connection = new MySqlConnection(conexao);

            var comand = connection.CreateCommand();

            MySqlCommand query = new MySqlCommand("SELECT COUNT(*) FROM usuarios WHERE nome = '" + txb_usuario.Text + "' AND senha = '" + txb_senha.Text + "'", connection);
            connection.Open();

            DataTable dataTable = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(query);
            da.Fill(dataTable);

            foreach (DataRow list in dataTable.Rows)
            {
                if (Convert.ToInt32(list.ItemArray[0]) > 0)
                {
                    Menu_Principal form = new Menu_Principal();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Usuário Inválido", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            connection.Close();
        }

    }
}