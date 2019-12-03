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
using System.IO.Ports;



namespace Sistema_Pi_2
{
    public partial class Cadastro_Material : Form
    {
        public Cadastro_Material()
        {
            InitializeComponent();
        }
        SerialPort arduino = new SerialPort("COM5", 9600); 
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Cadastro_Estoque form = new Cadastro_Estoque();
            form.Show();
        }

        private void btn_SalvarProd_Click(object sender, EventArgs e)
        {
            string conexao = "Server=localhost;Database=safestock;Uid=root;Pwd=senhapi022019;SslMode=none";

            var connection = new MySqlConnection(conexao);

            var comand = connection.CreateCommand();

            MySqlCommand query = new MySqlCommand("INSERT INTO safestock.estoque (nomeProduto, lote, dataEntrada, quantidade, fornecedor, localizacao) VALUES ('" + txb_Produto.Text + "', " + txb_Lote.Text + ", '" + dateTimePicker1.Value + "', " + txb_Qtd.Text + ", '" + txb_Fornec.Text + "', '" + txb_Local.Text + "');", connection);
            connection.Open();
            MessageBox.Show("Gravado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            


            DataTable dataTable = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(query);
            da.Fill(dataTable);

            connection.Close();
        }

        private void Cadastro_Material_Load(object sender, EventArgs e)
        {
            arduino.Open();
            

            
        }

        private void Cadastro_Material_FormClosing(object sender, FormClosingEventArgs e)
        {
            arduino.Close();
        }

        private void btRFID_Click(object sender, EventArgs e)
        {

            arduino.ReadLine();

            if (arduino.ReadLine() == "02 38 2C 21")



            {

                txb_Produto.Text = "Produto 01";
                txb_Lote.Text = "17112019";
                txb_Local.Text = "P02A06";
                txb_Qtd.Text = "50";
                txb_Fornec.Text = "Fornecedor01";

            }


        }
    }
}
