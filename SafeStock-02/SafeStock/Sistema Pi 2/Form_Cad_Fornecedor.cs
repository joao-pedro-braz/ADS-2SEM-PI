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
    public partial class Form_Cad_Fornecedor : Form
    {
        public Form_Cad_Fornecedor()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Cadastro_Fornecedores form = new Cadastro_Fornecedores();
            form.Show();
        }

        private void Form_Cad_Fornecedor_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_SalvarProd_Click(object sender, EventArgs e)
        {
            string conexao = "Server=localhost;Database=safestock;Uid=root;Pwd=senhapi022019;SslMode=none";

            var connection = new MySqlConnection(conexao);

            var comand = connection.CreateCommand();

            MySqlCommand query = new MySqlCommand("INSERT INTO safestock.fornecedores (nomeFornecedor, cnpj, cidade, telefone) VALUES ('" + txb_Nome.Text + "', '" + txb_Cnpj.Text + "', '" + txb_cidade.Text + "', '" + txb_Telefone.Text + "');", connection);
            connection.Open();
            //MessageBox.Show("Gravado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(Convert.ToString(query.CommandText));


            DataTable dataTable = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(query);
            da.Fill(dataTable);

            connection.Close();
        }
    }
}
