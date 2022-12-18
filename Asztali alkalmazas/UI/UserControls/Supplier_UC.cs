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
using MySql.Data.MySqlClient;

namespace Asztali_alkalmazas.UI.UserControls
{
    public partial class Supplier_UC : UserControl
    {
        MySqlConnection conn;
        string format = "yyyy-MM-dd HH:mm:ss";
        int sID;
        string connstring;
        string currentId;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public Supplier_UC()
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
            uj.setId(sID);
        }
        Supplier uj = new Supplier();
        AdminControl_UC hibakezeles = new AdminControl_UC();
        private void Supplier_UC_Load(object sender, EventArgs e)
        {
            suppliersDGV.ClearSelection();
            deleteTB();
            ReLoadDGV();
        }
        private void getID()
        {
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT id FROM local_store_project_23.suppliers order by id desc ";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string ideig = dr["id"].ToString();
                sID = int.Parse(ideig);
            }
            conn.Close();
        }
        //------------ DataGridView feltöltése különféle adattáblával és újratöltés ------------
        private DataTable GetSuppliersList()
        {
            DataTable dtSuppliers = new DataTable();
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT suppliers.id as ID, CompanyName as 'Cegnev', ContactName as 'Kapcsolattarto neve', City as 'Varos' ,Phone as 'Mobilszam' FROM local_store_project_23.suppliers order by id asc;";
            dr = cmd.ExecuteReader();
            dtSuppliers.Load(dr);
            conn.Close();
            return dtSuppliers;
        }
        private DataTable GetSupplierProducts()
        {
            DataTable dtSupplierProducts = new DataTable();
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT suppliers.CompanyName as 'Cegnev', suppliers.ContactName as 'Kapcsolattarto neve', suppliers.City as 'Varos', suppliers.Phone as 'Mobilszam', products.ProductName as 'Termeknev', products.UnitPrice as 'Egysegar', products.Package as 'Kiszereles'\r\nfrom suppliers,products\r\nwhere products.SupplierId = suppliers.id and SupplierId = @ID";
            cmd.Parameters.AddWithValue("ID", currentId);
            dr = cmd.ExecuteReader();
            dtSupplierProducts.Load(dr);
            conn.Close();
            return dtSupplierProducts;
        }
        private void ReLoadDGV()
        {
            suppliersDGV.ClearSelection();
            deleteTB();
            suppliersDGV.DataSource = null;
            suppliersDGV.DataSource = GetSuppliersList();
            suppliersDGV.Columns[0].HeaderText = "ID";
            suppliersDGV.Columns[1].HeaderText = "Cégnév";
            suppliersDGV.Columns[2].HeaderText = "Kapcsolattartó neve";
            suppliersDGV.Columns[3].HeaderText = "Város";
            suppliersDGV.Columns[4].HeaderText = "Mobilszám";
        }
        //------------ DataGridView feltöltése különféle adattáblával és újratöltése vége------------
        //------------ Saját függvények ------------
        private void setNewSupplier()
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO `local_store_project_23`.`suppliers`(`CompanyName`, `ContactName`, `City` ,`Phone`, created_at, updated_at)  VALUES ('" + uj.CompanyName + "', '" + uj.ContactName + "', '"+uj.City+"' ,'" + uj.Phone + "', '" + DateTime.Now.ToString(format) + "','" + DateTime.Now.ToString(format) + "')";
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
            supplierCompanyNameTB.Clear();
            supplierContactNameTB.Clear();
            supplierCityTB.Clear();
            supplierPhoneTB.Clear();
        }
        //------------ Saját függvények ------------
        //------------ Gomb műveletekre végzett események ------------
        private void suppliersDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (suppliersDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    suppliersDGV.CurrentRow.Selected = true;
                    currentId = suppliersDGV.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                    supplierCompanyNameTB.Text = suppliersDGV.Rows[e.RowIndex].Cells["Cegnev"].FormattedValue.ToString();
                    supplierContactNameTB.Text = suppliersDGV.Rows[e.RowIndex].Cells["Kapcsolattarto neve"].FormattedValue.ToString();
                    supplierCityTB.Text = suppliersDGV.Rows[e.RowIndex].Cells["Varos"].FormattedValue.ToString();
                    supplierPhoneTB.Text = suppliersDGV.Rows[e.RowIndex].Cells["Mobilszam"].FormattedValue.ToString();
                }
                supplierUpdateBT.Enabled = true;
                getSupplierProductsBT.Enabled = true;
            }
            catch (Exception ex)
            {
                string hiba = ex.Message.ToString();

                hibakezeles.ErrorLogs(hiba);
            }
        }
        private void supplierDeleteBT_Click(object sender, EventArgs e)
        {
            DialogResult torli;
            torli = MessageBox.Show("Biztos törli az adott elemet?", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (torli == DialogResult.Yes)
            {
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "delete from `local_store_project_23`.`suppliers` WHERE `id`= @ID;";
                cmd.Parameters.AddWithValue("@ID", currentId);
                cmd.ExecuteNonQuery();
                conn.Close();
                ReLoadDGV();
            }
        }
        private void supplierCompanyNameTB_Leave(object sender, EventArgs e)
        {
            if(supplierCompanyNameTB.Text.Length > 0)
            {
                uj.setCompanyName(supplierCompanyNameTB.Text);
            }
        }
        private void supplierContactNameTB_Leave(object sender, EventArgs e)
        {
            if (supplierContactNameTB.Text.Length > 0)
            {
                uj.setContactName(supplierContactNameTB.Text);
            }
        }
        private void supplierCityTB_Leave(object sender, EventArgs e)
        {
            if (supplierCityTB.Text.Length > 0)
            {
                uj.setCity(supplierCityTB.Text);
            }
        }
        private void supplierPhoneTB_Leave(object sender, EventArgs e)
        {
            if (supplierPhoneTB.Text.Length > 0)
            {
                uj.setPhoneNumber(supplierPhoneTB.Text);
            }
        }
        private void supplierUpdateBT_Click(object sender, EventArgs e)
        {
            if (uj.CompanyName != supplierCompanyNameTB.Text || uj.ContactName != supplierContactNameTB.Text || uj.City != supplierCityTB.Text || uj.Phone != supplierPhoneTB.Text)
            {
                uj.setCompanyName(supplierCompanyNameTB.Text);
                uj.setContactName(supplierContactNameTB.Text);
                uj.setCity(supplierCityTB.Text);
                uj.setPhoneNumber(supplierPhoneTB.Text);
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE `local_store_project_23`.`suppliers` SET `CompanyName`='" + uj.CompanyName + "', ContactName = '" + uj.ContactName + "', City = '"+uj.City+"' ,Phone = '" + uj.Phone + "', updated_at = '" + DateTime.Now.ToString(format) + "' WHERE `id`= @ID;";
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
        private void supplierDGVReload_Click(object sender, EventArgs e)
        {
            ReLoadDGV();
        }
        private void supplierNewBT_Click(object sender, EventArgs e)
        {
            setNewSupplier();
            deleteTB();
        }
        private void getSupplierProductsBT_Click(object sender, EventArgs e)
        {
            suppliersDGV.DataSource = GetSupplierProducts();
            suppliersDGV.Columns[0].HeaderText = "Cégnév";
            suppliersDGV.Columns[1].HeaderText = "Kapcsolattartó neve";
            suppliersDGV.Columns[2].HeaderText = "Város";
            suppliersDGV.Columns[3].HeaderText = "Mobilszám";
            suppliersDGV.Columns[4].HeaderText = "Terméknév";
            suppliersDGV.Columns[5].HeaderText = "Egységár (HUF)";
            suppliersDGV.Columns[6].HeaderText = "Kiszerelés";
        }
        //------------ Gomb műveletekre végzett események vége ------------
    }
}
