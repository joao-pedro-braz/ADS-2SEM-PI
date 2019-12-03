using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using tokenkong.dal;

namespace tokenkong.forms
{
    public partial class ProductList : System.Windows.Forms.Form
    {
        Panel content;
        ProductsDAL productController = new ProductsDAL();

        public ProductList(Panel content)
        {
            InitializeComponent();

            this.init();
            this.content = content;
        }

        private void init()
        {
            this.initializeProductsTable();
        }

        private void initializeProductsTable()
        {
            try{
                MySqlDataAdapter adapter = this.productController.list();
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);
                dataTable.Columns["NAME"].ColumnName = "Produtos";
                dataTable.Columns["QUANTITY"].ColumnName = "Quantidade";
                dataTable.Columns["PRICE"].ColumnName = "Preço";
                dataTable.Columns["COST"].ColumnName = "Custo";
                dataTable.Columns["DESCRIPTION"].ColumnName = "Descrição";
                dataTable.Columns["PROVIDER"].ColumnName = "Fornecedor";

                table_products.DataSource = dataTable;
            }catch( Exception error)
            {
                Console.WriteLine(error);
            }
        }

        private void openContentForm(object form)
        {
            try
            {
                if (this.content.Controls.Count > 0)
                {
                    foreach (System.Windows.Forms.Form frm in this.content.Controls)
                    {
                        frm.Close();
                    }
                }

                System.Windows.Forms.Form f = form as System.Windows.Forms.Form;
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.content.Controls.Add(f);
                this.content.Tag = f;
                f.AutoScroll = true;
                f.Show();
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            this.openContentForm(new ProductForm(this.content));
        }
    }
}
