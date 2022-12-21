using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asztali_alkalmazas.Classes;
using Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;

namespace Asztali_alkalmazas.UI.UserControls
{
    public partial class Order_UC : UserControl
    {
        MySqlConnection conn;
        string phone;
        string connstring;
        string currentId;
        string customerId;
        string status;
        int newOrderDB;
        MySqlCommand cmd;
        MySqlDataReader dr;


        public Order_UC()
        {
            InitializeComponent();
            connstring = "server=localhost;port=3306;database=local_store_project_23;user=root;";
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = connstring;
                conn.Open();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
        Order actual;
        AdminControl_UC hibakezeles = new AdminControl_UC(); //Hibák logolása

        //------------ UserControl betöltése és adatok elhelyezése és megadása ------------
        private void Order_UC_Load(object sender, EventArgs e)
        {
            NewOrderMonitor.Start();

            labelStartDate.Location = orderStartDate.Location;
            labelEndDate.Location = orderEndDate.Location;
            labelStartDate.Text = orderStartDate.Text;
            labelEndDate.Text = orderEndDate.Text;

            selectedOrderProductsDGV.Font = new System.Drawing.Font("Century Gothic", 11, FontStyle.Bold);

            selectedDateOrdersDGV.DataSource = getNewOrders();
            selectedDateOrdersDGV.DataSource = GetOrdersList();
            selectedDateOrdersDGV.Columns[0].HeaderText = "ID";
            selectedDateOrdersDGV.Columns[1].HeaderText = "Rendelés dátuma";
            selectedDateOrdersDGV.Columns[2].HeaderText = "Rendelés azonosító";
            selectedDateOrdersDGV.Columns[3].HeaderText = "Vásárló azonosító";
            selectedDateOrdersDGV.Columns[4].HeaderText = "Végösszeg(HUF)";
            selectedDateOrdersDGV.Columns[5].HeaderText = "Rendelés státusza";
        }
        //------------ UserControl betöltése és adatok elhelyezése és megadása vége------------
        //------------ DataGridView különféle adattáblák ------------
        private System.Data.DataTable GetOrdersList()
        {
            System.Data.DataTable dtOrders = new System.Data.DataTable();
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT orders.id as ID, orders.OrderDate as 'Rendeles datuma', orders.OrderNumber as 'Rendeles azonosito', orders.CustomerId as 'Vasarlo azonosito', orders.TotalAmount as 'Vegosszeg(Ft)', orders.OrderStatus FROM local_store_project_23.orders order by id asc;";
            dr = cmd.ExecuteReader();
            dtOrders.Load(dr);
            conn.Close();
            return dtOrders;
        }
        private System.Data.DataTable GetSelectedDateOrdersList()
        {
            System.Data.DataTable dtSelectedDateOrders = new System.Data.DataTable();
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT orders.id as ID, orders.OrderDate as 'Rendeles datuma', orders.OrderNumber as 'Rendeles azonosito', orders.CustomerId as 'Vasarlo azonosito', orders.TotalAmount as 'Vegosszeg(Ft)',orders.OrderStatus FROM local_store_project_23.orders where orders.OrderDate between @startDate and @endDate order by OrderDate asc;";
            cmd.Parameters.AddWithValue("@startDate", labelStartDate.Text);
            cmd.Parameters.AddWithValue("@endDate", labelEndDate.Text);
            dr = cmd.ExecuteReader();
            dtSelectedDateOrders.Load(dr);
            conn.Close();
            return dtSelectedDateOrders;
        }
        private System.Data.DataTable GetSelectedOrderProducts(string currentId)
        {
            System.Data.DataTable dtGetSelectedOrderProducts = new System.Data.DataTable();
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT products.ProductName as 'Termek neve', products.Package as 'Csomagolas', order_items.Quantity as 'Mennyiseg' FROM local_store_project_23.order_items,products where order_items.productId = products.id and order_items.OrderId = @currentId;";
            cmd.Parameters.AddWithValue("@currentId", currentId);
            dr = cmd.ExecuteReader();
            dtGetSelectedOrderProducts.Load(dr);
            conn.Close();
            return dtGetSelectedOrderProducts;
        }

        private System.Data.DataTable GetSelectedStatusOrdersList(string status)
        {
            System.Data.DataTable dtSelectedStatusOrders = new System.Data.DataTable();
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT orders.id as ID, orders.OrderDate as 'Rendeles datuma', orders.OrderNumber as 'Rendeles azonosito', orders.CustomerId as 'Vasarlo azonosito', orders.TotalAmount as 'Vegosszeg(Ft)', orders.OrderStatus FROM local_store_project_23.orders where orders.OrderStatus = @status order by id asc;";
            cmd.Parameters.AddWithValue("@status", status);
            dr = cmd.ExecuteReader();
            dtSelectedStatusOrders.Load(dr);
            conn.Close();
            return dtSelectedStatusOrders;
        }
        private System.Data.DataTable getInvoiceProducts(string currentId)
        {
            System.Data.DataTable getInvoiceProducts = new System.Data.DataTable();
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT products.ProductName, order_items.Quantity, products.Package, products.UnitPrice FROM local_store_project_23.order_items,products where order_items.productId = products.id and order_items.OrderId = @currentId;";
            cmd.Parameters.AddWithValue("@currentId", currentId);
            dr = cmd.ExecuteReader();
            getInvoiceProducts.Load(dr);
            conn.Close();
            return getInvoiceProducts;
        }
        //------------ DataGridView különféle adattáblák vége ------------
        private int getNewOrderNumber()
        {
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT count(OrderStatus) FROM local_store_project_23.orders where OrderStatus = 'New';";
            newOrderDB = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return newOrderDB;
        }
        private void setNewStatus(string currentId, int status)
        {
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE local_store_project_23.orders SET OrderStatus = @status WHERE id = @currentId;";
            cmd.Parameters.AddWithValue("@status", actual.setOrderStatus(status));
            cmd.Parameters.AddWithValue("@currentid", currentId);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private System.Data.DataTable getNewOrders()
        {
            System.Data.DataTable getNewOrders = new System.Data.DataTable();
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT orders.id as ID, orders.OrderDate as 'Rendeles datuma', orders.OrderNumber as 'Rendeles azonosito', orders.CustomerId as 'Vasarlo azonosito', orders.TotalAmount as 'Vegosszeg(Ft)', orders.OrderStatus FROM local_store_project_23.orders where orders.OrderStatus = 'New' order by id asc;";
            dr = cmd.ExecuteReader();
            getNewOrders.Load(dr);
            conn.Close();
            return getNewOrders;
        }
        private string getSelectedOrderCustomerName(string customerId)
        {
            string fullName = "";

            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT First_name, Last_name, Phone FROM local_store_project_23.customers\r\nwhere id = @ID";
            cmd.Parameters.AddWithValue("@ID", int.Parse(customerId));
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                fullName = dr[1] + " " + dr[0].ToString();
                phone = dr[2].ToString();
            }
            conn.Close();
            return fullName;
        }
        private System.Data.DataTable getNewOrders()
        {
            System.Data.DataTable getNewOrders = new System.Data.DataTable();
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT orders.id as ID, orders.OrderDate as 'Rendeles datuma', orders.OrderNumber as 'Rendeles azonosito', orders.CustomerId as 'Vasarlo azonosito', orders.TotalAmount as 'Vegosszeg(Ft)', orders.OrderStatus FROM local_store_project_23.orders where orders.OrderStatus = 'New' order by id asc;";
            dr = cmd.ExecuteReader();
            getNewOrders.Load(dr);
            conn.Close();
            return getNewOrders;
        }
        //------------ Gombok és események ------------
        private void generateInvoice_Click(object sender, EventArgs e) //Számla generálása
        {
            Invoice iV = new Invoice();
            iV.customerName = labelOrderCustomerName.Text;
            iV.customerPhone = phone;
            iV.customerOrderDate = labelOrderDate.Text;
            iV.customerOrderNumber = labelOrderNumber.Text;
            iV.customerTotalAmount = labelTotalAmount.Text;
            iV.dtInvoiceProduct = getInvoiceProducts(currentId);
            iV.ShowDialog();
            setNewStatus(currentId, 3);
            selectedDateOrdersDGV.DataSource = GetOrdersList();
        }
        private void labelStartDate_Click(object sender, EventArgs e) //labelre kattintva datetimepickerren kattintás esemény meghívása
        {
            orderStartDate.Select();
            SendKeys.Send("%{DOWN}");
        }

        private void labelEndDate_Click(object sender, EventArgs e) //labelre kattintva datetimepickerren kattintás esemény meghívása
        {
            orderEndDate.Select();
            SendKeys.Send("%{DOWN}");
        }

        private void orderStartDate_ValueChanged(object sender, EventArgs e) //ha dátumot változtatjuk a label felveszi az értékét
        {
            labelStartDate.Text = orderStartDate.Text;
        }

        private void orderEndDate_ValueChanged(object sender, EventArgs e) //ha dátumot változtatjuk a label felveszi az értékét
        {
            labelEndDate.Text = orderEndDate.Text;
        }
        private void ordersStatusCheckBT_Click(object sender, EventArgs e)
        {
            setNewStatus(currentId,2);
            selectedDateOrdersDGV.DataSource = GetOrdersList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                selectedDateOrdersDGV.DataSource = GetSelectedDateOrdersList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba!" + ex.Message);
                string hiba = ex.Message.ToString();
                hibakezeles.ErrorLogs(hiba);
            }   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedDateOrdersDGV.DataSource = GetSelectedStatusOrdersList(status);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ordersStatusCB.SelectedIndex = -1;
            selectedDateOrdersDGV.DataSource = GetOrdersList();
        }
        private void selectedDateOrdersDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                if (selectedDateOrdersDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    selectedDateOrdersDGV.CurrentRow.Selected = true;
                    currentId = selectedDateOrdersDGV.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                    labelOrderDate.Text = selectedDateOrdersDGV.Rows[e.RowIndex].Cells["Rendeles datuma"].FormattedValue.ToString();
                    labelOrderNumber.Text = selectedDateOrdersDGV.Rows[e.RowIndex].Cells["Rendeles azonosito"].FormattedValue.ToString();
                    customerId = selectedDateOrdersDGV.Rows[e.RowIndex].Cells["Vasarlo azonosito"].FormattedValue.ToString();
                    labelOrderCustomerName.Text = getSelectedOrderCustomerName(customerId);
                    labelTotalAmount.Text = selectedDateOrdersDGV.Rows[e.RowIndex].Cells["Vegosszeg(Ft)"].FormattedValue.ToString()+" Ft";
                    labelOrderStatus.Text = selectedDateOrdersDGV.Rows[e.RowIndex].Cells["OrderStatus"].FormattedValue.ToString();
                }
                selectedOrderDetailsGB.Visible = true;
            }
            catch (Exception ex)
            {
                string hiba = ex.Message.ToString();

                hibakezeles.ErrorLogs(hiba);
            }
            selectedOrderProductsDGV.DataSource = GetSelectedOrderProducts(currentId);
            selectedOrderProductsDGV.Columns[0].HeaderText = "Termék megnevezése";
            selectedOrderProductsDGV.Columns[1].HeaderText = "Kiszerelés";
            selectedOrderProductsDGV.Columns[2].HeaderText = "Mennyiség";

            string[] ideig = labelTotalAmount.Text.Split(' ');
            string totalAmount = ideig[0];
            actual = new Order(Convert.ToInt32(currentId), Convert.ToDateTime(labelOrderDate.Text), labelOrderNumber.Text, Convert.ToInt32(customerId), Convert.ToDecimal(totalAmount), labelOrderStatus.Text);

            if(actual.OrderStatus == "New")
            {
                ordersStatusCheckBT.Enabled = true;
            }
        }
        private void ordersStatusCB_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(ordersStatusCB.SelectedIndex == 0)
           {
                status = "New";
           }
           else if(ordersStatusCB.SelectedIndex == 1)
           {
                status = "inProgress";
           }
           else
           {
                status = "Finished";
           }
        }
<<<<<<< HEAD
        private void ordersStatusCheckBT_Click(object sender, EventArgs e)
        {
            DialogResult setStatus;
            setStatus = MessageBox.Show("Biztos a kiválasztott rendelést akarod összekészíteni?", "Project 23", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if(setStatus == DialogResult.Yes)
            {
                setNewStatus(currentId, 2);
                selectedDateOrdersDGV.DataSource = GetOrdersList();
            }
        }
        private void NewOrderMonitor_Tick(object sender, EventArgs e)
        {
            getNewOrderNumber();

            if (newOrderDB > 0)
            {
                DialogResult newOrder;
                newOrder = MessageBox.Show("Érkezett új megrendelés!", "Project 23", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (newOrder == DialogResult.OK)
                {
                    selectedDateOrdersDGV.DataSource = getNewOrders();
                    NewOrderMonitor.Stop();
                }
            }
        }
        //------------ Gombok és események vége ------------

    }
}
