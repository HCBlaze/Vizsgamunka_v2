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
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Asztali_alkalmazas.UI.UserControls
{
    public partial class Customer_UC : UserControl
    {
        MySqlConnection conn;
        string format = "yyyy-MM-dd HH:mm:ss";
        int cID;
        string connstring;
        string currentId;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public Customer_UC()
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
            getID();//Az adatbázisban következő ID-t adja az új felhasználónak           
            uj.setId(cID);
        }
        Customer uj = new Customer();
        AdminControl_UC hibakezeles = new AdminControl_UC();

        private void getID()
        {
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT id FROM local_store_project_23.customers order by id desc ";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string ideig = dr["id"].ToString();
                cID = int.Parse(ideig);
            }
            conn.Close();
        }

        private DataTable GetCustomersList()
        {
            DataTable dtCustomers = new DataTable();
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT customers.id as ID, First_name as 'Keresztnev', Last_name as 'Vezeteknev', Phone as 'Mobilszam' FROM local_store_project_23.customers order by id asc;";
            dr = cmd.ExecuteReader();
            dtCustomers.Load(dr);
            conn.Close();
            return dtCustomers;
        }
        private DataTable GetCustomerOrder()
        {
            DataTable dtCustomerOrder = new DataTable();
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT customers.First_name as 'Keresztnev', customers.Last_name as 'Vezeteknev', OrderDate as 'Rendeles datuma', OrderNumber as 'Rendeles szama', TotalAmount as 'Vegosszeg(Ft)' FROM local_store_project_23.orders,customers\r\nwhere orders.CustomerId = customers.id and CustomerId = @ID;";
            cmd.Parameters.AddWithValue("ID", currentId);
            dr = cmd.ExecuteReader();
            dtCustomerOrder.Load(dr);
            conn.Close();
            return dtCustomerOrder;
        }

        private void ReLoadDGV()
        {
            CustomersDGV.DataSource = null;
            CustomersDGV.DataSource = GetCustomersList();
        }
        private void setNewCustomer()
        {
            
            try
            {
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO `local_store_project_23`.`customers`(`First_name`, `Last_name`, `Phone`, created_at, updated_at)  VALUES ('" + uj.First_name + "', '" + uj.Last_name + "', '" + uj.Phone + "', '"+DateTime.Now.ToString(format)+"','"+DateTime.Now.ToString(format)+"')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Létrehozva!");
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hiba!" + ex.Message);
                string hiba = ex.Message.ToString();
                hibakezeles.ErrorLogs(hiba);

            }
            conn.Close();
            ReLoadDGV();

        }
        private void deleteTB()
        {
            customerLNTB.Clear();
            customerFNTB.Clear();
            customerPhone.Clear();
        }
        private void Customer_UC_Load(object sender, EventArgs e)
        {
            ReLoadDGV();

        }

        private void CustomersDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                    if (CustomersDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        CustomersDGV.CurrentRow.Selected = true;
                        currentId = CustomersDGV.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                        customerFNTB.Text = CustomersDGV.Rows[e.RowIndex].Cells["Keresztnev"].FormattedValue.ToString();
                        customerLNTB.Text = CustomersDGV.Rows[e.RowIndex].Cells["Vezeteknev"].FormattedValue.ToString();
                        customerPhone.Text = CustomersDGV.Rows[e.RowIndex].Cells["Mobilszam"].FormattedValue.ToString();
                    }
                customerUpdateBT.Enabled = true;
                getCustomerOrderBT.Enabled = true;
            }
            catch (Exception ex)
            {
                string hiba = ex.Message.ToString();
                
                hibakezeles.ErrorLogs(hiba);
            }
        }

        private void customerDeleteBT_Click(object sender, EventArgs e)
        {
            DialogResult torli;
            torli = MessageBox.Show("Biztos törli az adott elemet?", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (torli == DialogResult.Yes)
            {
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "delete from `local_store_project_23`.`customers` WHERE `id`= @ID;";
                cmd.Parameters.AddWithValue("@ID", currentId);
                cmd.ExecuteNonQuery();
                conn.Close();
                ReLoadDGV();
            }
        }

        private void customerLNTB_Leave(object sender, EventArgs e)
        {
            if(customerLNTB.Text.Length > 0)
            {
                uj.setLastname(customerLNTB.Text);

            }
        }

        private void customerFNTB_Leave(object sender, EventArgs e)
        {
            if(customerFNTB.Text.Length > 0)
            {
                uj.setFirstname(customerFNTB.Text);
            }
        }

        private void customerPhone_Leave(object sender, EventArgs e)
        {
            if(customerPhone.Text.Length > 0)
            {
                uj.setPhoneNumber(customerPhone.Text);
            }
        }

        private void customerNewBT_Click(object sender, EventArgs e)
        {
            setNewCustomer();
            deleteTB();
        }

        private void customerUpdateBT_Click(object sender, EventArgs e)
        {
            if(uj.First_name != customerFNTB.Text || uj.Last_name != customerLNTB.Text || uj.Phone != customerPhone.Text)
            {
                uj.setFirstname(customerFNTB.Text);
                uj.setLastname(customerLNTB.Text);
                uj.setPhoneNumber(customerPhone.Text);
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE `local_store_project_23`.`customers` SET `First_name`='" + uj.First_name + "', Last_name = '" + uj.Last_name + "', Phone = '" + uj.Phone + "', updated_at = '" + DateTime.Now.ToString(format) + "' WHERE `id`= @ID;";
                cmd.Parameters.AddWithValue("@ID", currentId);
                cmd.ExecuteNonQuery();
                conn.Close();
                ReLoadDGV();
            }
            else
            {
                MessageBox.Show("Nem változtattál semmilyen adaton.");
            }
        }

        private void userProfilBT_Click(object sender, EventArgs e)
        {
            ReLoadDGV();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomersDGV.DataSource = GetCustomerOrder();
        }
    }
}
