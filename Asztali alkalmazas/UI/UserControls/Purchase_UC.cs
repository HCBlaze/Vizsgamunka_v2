using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asztali_alkalmazas.Classes;
using Google.Protobuf;
using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;

namespace Asztali_alkalmazas.UI.UserControls
{
    public partial class Purchase_UC : UserControl
    {
        MySqlConnection conn;
        private int customerCurrentId;
        private int productCurrentId;
        private int orderCurrentId;
        private decimal vegosszeg;
        private string OrderNumber;
        private string deleteOrderItem;
        private string PhoneNumber;
        private DateTime lastOrderDate;
        string format = "yyyy-MM-dd HH:mm:ss";
        MySqlCommand cmd;
        MySqlDataReader dr;
        public Purchase_UC()
        {
            InitializeComponent();
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = db.getConnectionString();
                conn.Open();

            }
            catch (Exception)
            {
                DialogResult Error;
                Error = MessageBox.Show("Nem megfelelő authentikációs adatok.\n Ellenőrizd a connectionString.txt fájlt!", "Project 23", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Error == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            conn.Close();
        }
        Customer UjVasarlo;
        Product ujTermek;
        OrderItem ujRendeltTermek;
        Order ujRendeles;
        DbConnection db = new DbConnection();
        AdminControl_UC hibakezeles = new AdminControl_UC(); //Hibák logolása
        private List<KeyValuePair<int, string>> CustomerIdAndName = new List<KeyValuePair<int, string>>();
        private List<KeyValuePair<int, string>> ProductIdAndName = new List<KeyValuePair<int, string>>();
        private List<Product> OsszesTermek = new List<Product>();
        private List<OrderItem> RendeltTermekek = new List<OrderItem>();
        private List<decimal> VegosszegList = new List<decimal>();

        private void getCustomers()
        {
            if (CustomerIdAndName.Count == 0)
            {
                try
                {
                    conn.Open();
                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT id, concat(Last_name, ' ', First_name) as Fullname FROM local_store_project_23.customers;";
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        CustomerIdAndName.Add(new KeyValuePair<int, string>(Convert.ToInt32(dr[0]), dr[1].ToString()));
                    }
                    conn.Close();

                    for (int i = 0; i < CustomerIdAndName.Count; i++)
                    {
                        cbCustomers.Items.Add(CustomerIdAndName[i].Value);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba!" + ex.Message);
                    string hiba = ex.Message.ToString();
                    hibakezeles.ErrorLogs(hiba);
                }
            }
        }
        private void getProducts()
        {
            if (ProductIdAndName.Count == 0)
            {
                try
                {
                    conn.Open();
                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT products.id, products.ProductName FROM local_store_project_23.products;";
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        ProductIdAndName.Add(new KeyValuePair<int, string>(Convert.ToInt32(dr[0]), dr[1].ToString()));
                    }
                    conn.Close();

                    for (int i = 0; i < ProductIdAndName.Count; i++)
                    {
                        cbProducts.Items.Add(ProductIdAndName[i].Value);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba!" + ex.Message);
                    string hiba = ex.Message.ToString();
                    hibakezeles.ErrorLogs(hiba);
                }
            }
        }
        private void getAllProducts()
        {
            if(OsszesTermek.Count== 0)
            {
                try
                {
                    conn.Open();
                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT id, ProductName, SupplierId, UnitPrice, Package, Stock, ImageSrc FROM local_store_project_23.products;";
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        ujTermek = new Product(Convert.ToInt32(dr[0]), dr[1].ToString(), Convert.ToInt32(dr[2]), Convert.ToDecimal(dr[3]), dr[4].ToString(), Convert.ToInt32(dr[5]), dr[6].ToString());
                        OsszesTermek.Add(ujTermek);
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba!" + ex.Message);
                    string hiba = ex.Message.ToString();
                    hibakezeles.ErrorLogs(hiba);
                }
            }  
        }
        private void getCustomerDetails(int i)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT Last_name, First_name, Phone FROM local_store_project_23.customers where id = @currentCustomerId;";
                cmd.Parameters.AddWithValue("@currentCustomerId", i);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lblFullName.Text = dr[0].ToString() + " "+dr[1].ToString();
                    lblPhoneNumber.Text = dr[2].ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba!" + ex.Message);
                string hiba = ex.Message.ToString();
                hibakezeles.ErrorLogs(hiba);
            }            
        }
        private int setNewCustomer(string Fname,string Lname,string Phone)
        {
            UjVasarlo = new Customer();
            UjVasarlo.setFirstname(Fname);
            UjVasarlo.setLastname(Lname);
            UjVasarlo.setPhoneNumber(Phone);
            int id = 0;

            try
            {
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT id FROM local_store_project_23.customers where First_name = '" + UjVasarlo.First_name + "' and Last_name = '" + UjVasarlo.Last_name + "' and Phone = '" + UjVasarlo.Phone + "';";
                object result = cmd.ExecuteScalar();
                if(result == null)
                {
                    
                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO `local_store_project_23`.`customers`(`First_name`, `Last_name`, `Phone`, created_at, updated_at)  VALUES ('" + UjVasarlo.First_name + "', '" + UjVasarlo.Last_name + "', '" + UjVasarlo.Phone + "', '" + DateTime.Now.ToString(format) + "','" + DateTime.Now.ToString(format) + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Létrehozva!");
                    conn.Close();


                    conn.Open();
                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT id FROM local_store_project_23.customers where First_name = '" + UjVasarlo.First_name + "' and Last_name = '" + UjVasarlo.Last_name + "' and Phone = '" + UjVasarlo.Phone + "';";
                    object resultNew = cmd.ExecuteScalar();
                    id = Convert.ToInt32(resultNew);
                    conn.Close();
                }
                else
                {
                    id = Convert.ToInt32(result);
                    MessageBox.Show(id.ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba!" + ex.Message);
                string hiba = ex.Message.ToString();
                hibakezeles.ErrorLogs(hiba);
            }
            return id;
        }
        private void setNewOrder(DateTime Orderdate, int i, string totalamount, DateTime createdat, DateTime updatedat)
        {
            ujRendeles = new Order();
            ujRendeles.setOrderDate(Orderdate);
            lastOrderDate = Orderdate;
            OrderNumber = ujRendeles.setOrderNumber();
            ujRendeles.setCustomerId(i);
            ujRendeles.setTotalAmount(Convert.ToDecimal(totalamount));
            try
            {
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO local_store_project_23.orders (OrderDate, OrderNumber, CustomerId, TotalAmount, OrderStatus, created_at, updated_at) VALUES (@OrderDate, @OrderNumber, @customerId, @amount, 'New', @createdat, @updatedat)";
                cmd.Parameters.AddWithValue("@OrderDate", ujRendeles.OrderDate);
                cmd.Parameters.AddWithValue("@OrderNumber", OrderNumber);
                cmd.Parameters.AddWithValue("@customerId", ujRendeles.CustomerId);
                cmd.Parameters.AddWithValue("@amount", ujRendeles.TotalAmount);
                cmd.Parameters.AddWithValue("@createdat", createdat);
                cmd.Parameters.AddWithValue("@updatedat", updatedat);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba!" + ex.Message);
                string hiba = ex.Message.ToString();
                hibakezeles.ErrorLogs(hiba);
            }
        }
        private void setNewOrderItems(int orderid, int productid,decimal unitprice, int quantity, DateTime createdat, DateTime updatedat)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO local_store_project_23.order_items (OrderId, ProductId, UnitPrice, Quantity, created_at, updated_at) VALUES (@OrderId, @ProductId, @UnitPrice, @Quantity, @createdat, @updatedat);";
                cmd.Parameters.AddWithValue("@OrderId", orderid);
                cmd.Parameters.AddWithValue("@ProductId", productid);
                cmd.Parameters.AddWithValue("@UnitPrice", unitprice);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@createdat", createdat);
                cmd.Parameters.AddWithValue("@updatedat", updatedat);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba!" + ex.Message);
                string hiba = ex.Message.ToString();
                hibakezeles.ErrorLogs(hiba);
            }
        }
        private void setUpdateStock(int currentid,int stock,DateTime updateDate)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE local_store_project_23.products SET Stock= @stock, updated_at= @updateDate WHERE id= @currentid;";
                cmd.Parameters.AddWithValue("@currentid", currentid);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@updateDate", updateDate);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba!" + ex.Message);
                string hiba = ex.Message.ToString();
                hibakezeles.ErrorLogs(hiba);
            }
        }
        private int getCurrentOrderId()
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT id FROM local_store_project_23.orders order by id desc limit 1";
                orderCurrentId = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba!" + ex.Message);
                string hiba = ex.Message.ToString();
                hibakezeles.ErrorLogs(hiba);
            }

            return orderCurrentId;
        }
        //------------ UserControl betöltése és adatok elhelyezése és megadása ------------
        private void Purchase_UC_Load(object sender, EventArgs e)
        {
            dgvOrderItems.ColumnCount = 4;
            dgvOrderItems.Columns[0].HeaderText = "Termék megnevezése";
            dgvOrderItems.Columns[0].Name = "ProductName";
            dgvOrderItems.Columns[1].HeaderText = "Csomagolás";
            dgvOrderItems.Columns[1].Name = "Package";
            dgvOrderItems.Columns[2].HeaderText = "Ár(HUF)";
            dgvOrderItems.Columns[2].Name = "UnitPrice";
            dgvOrderItems.Columns[3].HeaderText = "Mennyiség";
            dgvOrderItems.Columns[3].Name = "Stock";
            dgvOrderItems.Font = new Font("Century Gothic", 11, FontStyle.Bold);
            dgvOrderItems.DefaultCellStyle.ForeColor = Color.Black;

            getCustomers();
            getProducts();
            getAllProducts();
            gbCart.ForeColor = Color.WhiteSmoke;
            gbCustomerDetails.ForeColor = Color.WhiteSmoke;
            cbCustomers.Font = new Font("Century Gothic", 12, FontStyle.Regular);
            cbProducts.Font = new Font("Century Gothic", 12, FontStyle.Regular);

        }
        //------------ UserControl betöltése és adatok elhelyezése és megadása vége------------
        //------------ Gombok és funkciók ------------
        private void cbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < CustomerIdAndName.Count; i++)
                {
                    if (cbCustomers.SelectedItem.ToString() == CustomerIdAndName[i].Value)
                    {
                        customerCurrentId = CustomerIdAndName[i].Key;
                    }
                }
                getCustomerDetails(customerCurrentId);
                gbCart.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                cbProducts.Visible = true;
                mennyisegNum.Visible = true;
                btnAddCart.Visible = true;
                btnDeleteCartItem.Visible = true;
                btnPurchaseFinish.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba!" + ex.Message);
                string hiba = ex.Message.ToString();
                hibakezeles.ErrorLogs(hiba);
            }
        }
        private void cbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            label7.Visible = true;
            lblcurrentProdStock.Visible = true;
            mennyisegNum.Enabled= true;
            try
            {
                for (int i = 0; i < ProductIdAndName.Count; i++)
                {
                    if (cbProducts.SelectedItem.ToString() == ProductIdAndName[i].Value)
                    {
                        productCurrentId = ProductIdAndName[i].Key;
                        foreach (var item in OsszesTermek)
                        {
                            if (productCurrentId == item.Id)
                            {
                                lblcurrentProdStock.Text = item.Stock.ToString();
                                mennyisegNum.Maximum = item.Stock;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba!" + ex.Message);
                string hiba = ex.Message.ToString();
                hibakezeles.ErrorLogs(hiba);
            }          
        }
        private void btnAddCart_Click(object sender, EventArgs e)
        {
            decimal price = 0;
            try
            {
                foreach (var item in OsszesTermek)
                {
                    if (item.ProductName == cbProducts.SelectedItem.ToString())
                    {
                        string[] adat = { item.ProductName, item.Package, item.UnitPrice.ToString(), mennyisegNum.Value.ToString() };
                        dgvOrderItems.Rows.Add(adat);
                        price = Convert.ToDecimal(adat[2]) * Convert.ToInt32(adat[3]);
                        VegosszegList.Add(price);
                        ujRendeltTermek = new OrderItem();
                        ujRendeltTermek.setOrderId(2);
                        ujRendeltTermek.setProductId(productCurrentId);
                        ujRendeltTermek.setUnitPrice(item.UnitPrice);
                        ujRendeltTermek.setQuantity(Convert.ToInt32(mennyisegNum.Value));
                        RendeltTermekek.Add(ujRendeltTermek);
                    }
                }
                vegosszeg = VegosszegList.Sum();
                lblTotalAmount.Text = vegosszeg.ToString() + " HUF";
                cbProducts.Text = " ";
                mennyisegNum.Value = 0;
            }
            catch (Exception ex )
            {
                MessageBox.Show("Hiba!" + ex.Message);
                string hiba = ex.Message.ToString();
                hibakezeles.ErrorLogs(hiba);
            }            
        }

        private void btnPurchaseFinish_Click(object sender, EventArgs e)
        {
            try
            {
                string[] ideig = lblTotalAmount.Text.Split(' ');
                string totalAmount = ideig[0];
                int reCalculateStock = 0;
                setNewOrder(DateTime.Now, customerCurrentId, totalAmount, DateTime.Now, DateTime.Now);
                foreach (var item in RendeltTermekek)
                {
                    item.setOrderId(getCurrentOrderId());
                    setNewOrderItems(item.OrderId, item.ProductId, item.UnitPrice, item.Quantity, DateTime.Now, DateTime.Now);
                    foreach (var stock in OsszesTermek)
                    {
                        if (item.ProductId == stock.Id)
                        {
                            reCalculateStock = stock.Stock - item.Quantity;
                        }
                    }
                    setUpdateStock(item.ProductId, reCalculateStock, DateTime.Now);
                }
                MessageBox.Show("A rendelésed megkaptuk, a következő rendelés számon tudod átvenni a rendelésed!\n" + OrderNumber);
                OsszesTermek.Clear();
                RendeltTermekek.Clear();
                getAllProducts();
                dgvOrderItems.RowCount = 0;
                gbCart.Visible = false;
                cbCustomers.Text = " ";
                cbProducts.Text = " ";
                VegosszegList.Clear();
                vegosszeg = 0;
                lblTotalAmount.Text = "";
                ll_OwnName.Text = "";
                tb_OwnPhoneNumber.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba!" + ex.Message);
                string hiba = ex.Message.ToString();
                hibakezeles.ErrorLogs(hiba);
            }            
        }
        private void dgvOrderItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvOrderItems.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {

                    dgvOrderItems.CurrentRow.Selected = true;
                    dgvOrderItems.Rows[e.RowIndex].Cells["ProductName"].FormattedValue.ToString();
                    dgvOrderItems.Rows[e.RowIndex].Cells["Package"].FormattedValue.ToString();
                    dgvOrderItems.Rows[e.RowIndex].Cells["UnitPrice"].FormattedValue.ToString();
                    dgvOrderItems.Rows[e.RowIndex].Cells["Stock"].FormattedValue.ToString();
                }
                deleteOrderItem = dgvOrderItems.Rows[e.RowIndex].Cells["ProductName"].FormattedValue.ToString() + ";" + dgvOrderItems.Rows[e.RowIndex].Cells["Package"].FormattedValue.ToString() + ";" + dgvOrderItems.Rows[e.RowIndex].Cells["UnitPrice"].FormattedValue.ToString() + ";" + dgvOrderItems.Rows[e.RowIndex].Cells["Stock"].FormattedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba!" + ex.Message);
                string hiba = ex.Message.ToString();
                hibakezeles.ErrorLogs(hiba);
            }
        }

        private void btnDeleteCartItem_Click(object sender, EventArgs e)
        {
            try
            {
                string[] ideig = deleteOrderItem.Split(';');
                int deletedProdId = 0;
                for (int j = ProductIdAndName.Count - 1; j >= 0; j--)
                {
                    if (ideig[0] == ProductIdAndName[j].Value)
                    {
                        deletedProdId = ProductIdAndName[j].Key;
                    }
                }
                for (int i = RendeltTermekek.Count - 1; i >= 0; i--)
                {
                    if (RendeltTermekek[i].ProductId == deletedProdId)
                    {

                        decimal deleteItemPrice = RendeltTermekek[i].UnitPrice * RendeltTermekek[i].Quantity;
                        for (int k = VegosszegList.Count - 1; k >= 0; k--)
                        {
                            if (VegosszegList[k] == deleteItemPrice)
                            {
                                VegosszegList.RemoveAt(k);
                            }
                        }
                        vegosszeg = VegosszegList.Sum();
                        lblTotalAmount.Text = vegosszeg.ToString() + " HUF";
                        RendeltTermekek.RemoveAt(i);
                    }
                }
                foreach (DataGridViewRow row in dgvOrderItems.SelectedRows)
                {
                    dgvOrderItems.Rows.Remove(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba!" + ex.Message);
                string hiba = ex.Message.ToString();
                hibakezeles.ErrorLogs(hiba);
            }            
        }

        private void tb_MyNameOrElse_Scroll(object sender, EventArgs e)
        {
            if (tb_MyNameOrElse.Value == 1)
            {
                label1.Visible = true;
                cbCustomers.Visible = true;
                gb_OwnData.Visible = false;
            }
            else
            {
                label1.Visible = false;
                cbCustomers.Visible = false;
                gb_OwnData.Visible = true;
            }           
        }
        private void tb_OwnPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                string[] ideig = ll_OwnName.Text.Split(' ');
                if (tb_OwnPhoneNumber.Text.Length == 0 || tb_OwnPhoneNumber.Text.Length < 12 && tb_OwnPhoneNumber.Text.StartsWith("+36"))
                {
                    MessageBox.Show("Nem megfelelő mobilszám!");
                    tb_OwnPhoneNumber.Clear();
                }
                else
                {
                    customerCurrentId = setNewCustomer(ideig[1], ideig[0], tb_OwnPhoneNumber.Text);
                    getCustomerDetails(customerCurrentId);
                    gbCart.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    cbProducts.Visible = true;
                    mennyisegNum.Visible = true;
                    btnAddCart.Visible = true;
                    btnDeleteCartItem.Visible = true;
                    btnPurchaseFinish.Visible = true;
                }
                
            }
        }
    }
}
