using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using tokenkong.dal;
using tokenkong.models;
using MySql.Data.MySqlClient;
using System.IO;
using System.Resources;

namespace tokenkong.forms
{
    public partial class SaleForm : System.Windows.Forms.Form
    {
        List<ProductModel> products = new List<ProductModel>();
        List<ClientModel> clients = new List<ClientModel>();
        Panel content;
        float totalPrice = 0;
        Image image;

        public SaleForm(Panel content)
        {
            try{
                InitializeComponent();

                this.init();
                this.content = content;
            }
            catch(Exception error)
            {
                Console.WriteLine(error);
            }
        }

        private void init()
        {
            this.buildProductTable();
            this.buildProductList();
            this.buildClientList();
            total.Text = this.totalPrice.ToString("R$ 00000.00");
        }

        private void buildProductTable()
        {
            DataTable table = new DataTable();

            DataColumn columnName = new DataColumn();
            DataColumn columnPrice = new DataColumn();
            DataColumn columnQuantity = new DataColumn();

            columnName.ColumnName = "Produto";
            columnName.DataType = System.Type.GetType("System.String");

            columnPrice.ColumnName = "Preço";
            columnPrice.DataType = System.Type.GetType("System.Single");

            columnQuantity.ColumnName = "Quantidade";
            columnQuantity.DataType = System.Type.GetType("System.Int32");

            table.Columns.Add(columnName);
            table.Columns.Add(columnPrice);
            table.Columns.Add(columnQuantity);

            product_list.DataSource = table;
        }

        private void buildProductList()
        {
            ProductsDAL productDAL = new ProductsDAL();
            MySqlDataAdapter adapter = productDAL.list();
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            foreach (DataTable table in dataSet.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    ProductModel product = new ProductModel();

                    product.ID = int.Parse(row["ID"].ToString());
                    product.NAME = row["NAME"].ToString();
                    product.QUANTITY = int.Parse(row["QUANTITY"].ToString());
                    product.PRICE = float.Parse(row["PRICE"].ToString());
                    product.COST = float.Parse(row["COST"].ToString());
                    product.DESCRIPTION = row["DESCRIPTION"].ToString();
                    product.PROVIDER = row["PROVIDER"].ToString();
                    product.IMAGE = row["IMAGE"].ToString();

                    this.products.Add(product);
                    ComboBoxItem item = new ComboBoxItem();
                    item.Text = row["NAME"].ToString();
                    item.Value = row["ID"].ToString();
                    cb_products.Items.Add(item);
                }
            }
        }

        private void buildClientList()
        {
            ClientsDAL clientsDAL = new ClientsDAL();
            MySqlDataAdapter adapter = clientsDAL.list2();
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            foreach (DataTable table in dataSet.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    ClientModel client = new ClientModel();

                    client.ID = int.Parse(row["ID"].ToString());
                    client.NAME = row["NAME"].ToString();
                    client.EMAIL = row["EMAIL"].ToString();
                    client.PHONE = row["PHONE"].ToString();
                    client.CPF = row["CPF"].ToString();

                    this.clients.Add(client);
                    ComboBoxItem item = new ComboBoxItem();
                    item.Text = row["NAME"].ToString();
                    item.Value = row["ID"].ToString();
                    cb_clients.Items.Add(item);
                }
            }
        }

        private void Cb_products_DropDown(object sender, EventArgs e)
        {
            product_list.ClearSelection();
        }

        private void Cb_products_Click(object sender, EventArgs e)
        {
            product_list.ClearSelection();
        }

        private void Cb_products_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)cb_products;
            ComboBoxItem cmbItem = (ComboBoxItem)cmb.SelectedItem;
            int selectedValue = int.Parse(cmbItem.Value.ToString());

            foreach (ProductModel product in this.products)
            {
                if (selectedValue == product.ID)
                {
                    //Get the assembly information
                    System.Reflection.Assembly assemblyInfo = System.Reflection.Assembly.GetExecutingAssembly();
                    //Location is where the assembly is run from 
                    string assemblyLocation = assemblyInfo.Location;
                    //CodeBase is the location of the ClickOnce deployment files
                    Uri uriCodeBase = new Uri(assemblyInfo.CodeBase);
                    string clickOnceLocation = Path.GetDirectoryName(uriCodeBase.LocalPath.ToString());
                    this.image = Image.FromFile(clickOnceLocation + "\\assets\\images\\products\\" + product.IMAGE);
                    //img_product.Image = new Bitmap(this.image);
                    img_product.Image = this.rescale(img_product.Width, img_product.Height);

                }
            }
        }

        public Bitmap rescale(float width,float height)
        {
            Bitmap bmp = null;
            try
            {
                if(this.image != null){
                    Bitmap image = new Bitmap(this.image);
                    var brush = new SolidBrush(Color.White);
                    float scale = Math.Min(width / image.Width, height / image.Height);
                    bmp = new Bitmap((int)width, (int)height);
                    var graph = Graphics.FromImage(bmp);
                    var scaleWidth = (int)(image.Width * scale);
                    var scaleHeight = (int)(image.Height * scale);
                    graph.FillRectangle(brush, new RectangleF(0, 0, width, height));
                    graph.DrawImage(image, ((int)width - scaleWidth) / 2, ((int)height - scaleHeight) / 2, scaleWidth, scaleHeight);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return bmp;
        }

        private void addProductToList(ProductModel product)
        {
            try{
                DataRow row;

                var dataTable = (DataTable)product_list.DataSource;
                row = dataTable.NewRow();
                row[0] = product.NAME;
                row[1] = product.PRICE;
                row[2] = (1).ToString();
                dataTable.Rows.Add(row);
                int rowIndex = dataTable.Rows.Count - 1;
                
                product_list.Rows[rowIndex].Tag = product.ID.ToString();

                this.totalPrice += product.PRICE;

                total.Text = this.totalPrice.ToString("R$ 00000.00");
                product_list.ClearSelection();
            }
            catch(Exception error)
            {
                Console.WriteLine(error);
            }
        }

        private void Product_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try{
                if(e.RowIndex >= 0 && e.ColumnIndex >= 0){
                    DataGridViewRow element = product_list.Rows[e.RowIndex];
                    if (element != null )
                    {
                        product_list.CurrentRow.Selected = true;
                    }
                }
            }catch(Exception error)
            {
                Console.WriteLine(error);
            }
        }

        private void Product_list_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            float price = float.Parse(product_list.Rows[e.RowIndex].Cells["Preço"].Value.ToString());
            int quantity = int.Parse(product_list.Rows[e.RowIndex].Cells["Quantidade"].Value.ToString());

            this.totalPrice += (price * quantity);
            total.Text = this.totalPrice.ToString("R$ 00000.00");
        }

        private void Product_list_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            float price = float.Parse(product_list.Rows[e.RowIndex].Cells["Preço"].Value.ToString());
            int quantity = int.Parse(product_list.Rows[e.RowIndex].Cells["Quantidade"].Value.ToString());

            this.totalPrice -= (price * quantity);
        }

        private void Product_list_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {

                int currentMouseOverRow = product_list.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    ContextMenu contexMenu = new ContextMenu();
                    MenuItem item = new MenuItem("Remover");
                    item.Tag = currentMouseOverRow.ToString();
                    contexMenu.MenuItems.Add(item);
                    item.Click += contextItemClick;
                    contexMenu.Show(product_list, new Point(e.X, e.Y));
                }
            }
        }

        void contextItemClick(object sender, EventArgs e)
        {
            try{
                int? rowIndex = null;
                MenuItem clickedItem = sender as MenuItem;
                rowIndex = int.Parse(clickedItem.Tag.ToString());
                DataGridViewRow row = product_list.Rows[rowIndex.Value];
                float price = float.Parse(row.Cells["Preço"].Value.ToString());
                int quantity = int.Parse(row.Cells["Quantidade"].Value.ToString());
                this.totalPrice -= (price * quantity);
                total.Text = this.totalPrice.ToString("R$ 00000.00");
                product_list.Rows.RemoveAt(rowIndex.Value);
                product_list.ClearSelection();
            }catch(Exception error)
            {
                Console.WriteLine(error);
            }
        }

        private void submit()
        {
            try{
                if (this.submitPrepare())
                {
                    SaleModel sale = new SaleModel();

                    sale.USER_ID = Properties.Settings.Default.id;
                    sale.CLIENT_ID = int.Parse(((ComboBoxItem)cb_clients.SelectedItem).Value.ToString());
                    sale.AMOUNT = this.totalPrice;
                    sale.DESCRIPTION = txb_description.Text;
                    sale.PRODUCTS = new List<int>();

                    for (int i = 0; i < product_list.Rows.Count - 1; i++)
                    {

                        int product_id = int.Parse(product_list.Rows[i].Tag.ToString());
                        sale.PRODUCTS.Add(product_id);

                    }

                    SalesDAL salesDAL = new SalesDAL();
                    if(salesDAL.add(sale)){
                        MessageBox.Show("A venda foi inserida com sucesso!");
                        cb_clients.SelectionLength = -1;
                        this.totalPrice = 0;
                        product_list.DataSource = null;
                        this.buildProductTable();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel inserir a venda!");
                    }
                }
            }catch(Exception error)
            {
                Console.WriteLine(error);
            }
        }

        private bool submitPrepare()
        {
            try
            {
                bool result = false;
                
                if (Properties.Settings.Default.id != 0)
                {
                    if ((ComboBoxItem)cb_clients.SelectedItem != null)
                    {
                        if (product_list.Rows.Count > 1)
                        {
                            result = true;
                        }
                        else
                        {
                            MessageBox.Show("Não há produtos adicionados!", "Atenção!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("O Cliente não foi selecionado!", "Atenção!");
                    }
                }
                else
                {
                    MessageBox.Show("Conta não autenticada, faça o login novamente!");
                    Properties.Settings.Default.Reset();
                }

                return result;
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                return false;
            }
        } 

        private void Btn_submit_Click(object sender, EventArgs e)
        {
            this.submit();
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

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.openContentForm(new SaleList(this.content));
        }

        private void Img_product_Resize(object sender, EventArgs e)
        {
            img_product.Image = this.rescale(img_product.Width, img_product.Height);
        }

        private void Img_panel_Resize(object sender, EventArgs e)
        {
       
        }

        private void Btn_insert_product_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBox cmb = (ComboBox)cb_products;
                ComboBoxItem cmbItem = (ComboBoxItem)cmb.SelectedItem;
                int selectedValue = int.Parse(cmbItem.Value.ToString());

                foreach (ProductModel product in this.products)
                {
                    if (selectedValue == product.ID)
                    {
                        this.addProductToList(product);
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Todas as configurações serão perdidas, tem certeza que deseja cancelar?","Atenção!",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.openContentForm(new SaleList(this.content));
            }
        }
    }

    public class ComboBoxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }
        public override string ToString()
        {
            return Text;
        }
    }
}
