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
    public partial class Prodcut_UC : UserControl
    {
        MySqlConnection conn;
        string format = "yyyy-MM-dd HH:mm:ss";
        int pID;
        string currentId;
        int newSupplierID;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public Prodcut_UC()
        {
            InitializeComponent();
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = db.getConnectionString();
                conn.Open();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            getID();//Az adatbázisban következő ID-t adja az új felhasználónak           
            uj.setId(pID);
        }
        //------------------------------------------------------------------------------New Product section start-------------------------------------------------------------------
        DbConnection db = new DbConnection();
        Product uj = new Product();
        Product actual;
        AdminControl_UC hibakezeles = new AdminControl_UC();
        List<KeyValuePair<int,string>> SupplierIdandName = new List<KeyValuePair<int,string>>();
        List<KeyValuePair<int,string>> Products = new List<KeyValuePair<int,string>>();
        private void Prodcut_UC_Load(object sender, EventArgs e)
        {
            getSuppliers();
        }
        private void getID()
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT id FROM local_store_project_23.products order by id desc ";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string ideig = dr["id"].ToString();
                    pID = int.Parse(ideig);
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
        private void getSuppliers()
        {
            if(SupplierIdandName.Count == 0)
            {
                try
                {
                    conn.Open();
                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT suppliers.id, suppliers.CompanyName FROM local_store_project_23.suppliers order by id asc ";
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        SupplierIdandName.Add(new KeyValuePair<int, string>(Convert.ToInt32(dr[0]), dr[1].ToString()));
                    }
                    conn.Close();

                    for (int i = 0; i < SupplierIdandName.Count; i++)
                    {
                        suppliersCB.Items.Add(SupplierIdandName[i].Value);
                        updateSuppliersCB.Items.Add(SupplierIdandName[i].Value);
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
        private void setNewProduct()
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO `local_store_project_23`.`products`(`ProductName`, `SupplierId`, `UnitPrice` ,`Package`, `Stock` ,created_at, updated_at)  VALUES ('" + uj.ProductName + "', '" + uj.SupplierId + "', '" + uj.UnitPrice + "' ,'" + uj.Package + "', '" + uj.Stock + "' ,'" + DateTime.Now.ToString(format) + "','" + DateTime.Now.ToString(format) + "')";
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
        }
        private void deleteTB()
        {
            productNameTB.Clear();
            productUnitPriceTB.Clear();
            productStockTB.Clear();
            productPackageTB.Clear();
        }
        private void tabControl1_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    tabControl1.SelectedIndex = 0;
                    getSuppliers();
                    break;
                case 1:
                    tabControl1.SelectedIndex = 1;
                    ReLoadDGV(GetProductsList());
                    productUpdateNDeleteDGV.Columns[0].HeaderText = "ID";
                    productUpdateNDeleteDGV.Columns[1].HeaderText = "Termék megnevezése";
                    productUpdateNDeleteDGV.Columns[2].HeaderText = "Beszállító";
                    productUpdateNDeleteDGV.Columns[3].HeaderText = "Egységár (HUF)";
                    productUpdateNDeleteDGV.Columns[4].HeaderText = "Kiszerelés";
                    productUpdateNDeleteDGV.Columns[5].HeaderText = "Készlet";
                    break;
                case 2:
                    tabControl1.SelectedIndex = 2;
                    getProducts();
                    break;                   
                default:
                    tabControl1.SelectedIndex = 0;
                    getSuppliers();
                    break;
            }
        }
        private void suppliersCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < SupplierIdandName.Count; i++)
            {
                if (suppliersCB.SelectedItem.ToString().Contains(SupplierIdandName[i].Value))
                {
                    productSupplierIdLL.Text = SupplierIdandName[i].Key.ToString();
                }
            }
            label4.Visible = true;
            productDetailsGB.Visible = true;
        }
        private void productNameTB_Leave(object sender, EventArgs e)
        {
            if(productNameTB.Text.Length > 0)
            {
                uj.setProductName(productNameTB.Text);
                uj.setSupplierId(Convert.ToInt32(productSupplierIdLL.Text));
            }          
        }
        private void productUnitPriceTB_Leave(object sender, EventArgs e)
        {
            if(productUnitPriceTB.Text.Length > 0)
            {
                uj.setUnitPrice(decimal.Parse(productUnitPriceTB.Text));
            }
        }
        private void productPackageTB_Leave(object sender, EventArgs e)
        {
            if(productPackageTB.Text.Length > 0)
            {
                uj.setPackage(productPackageTB.Text);
            }
        }
        private void productStockTB_Leave(object sender, EventArgs e)
        {
            if(productStockTB.Text.Length > 0)
            {
                uj.setStock(int.Parse(productStockTB.Text));
            }
        }
        private void newProductBT_Click(object sender, EventArgs e)
        {
            setNewProduct();
            deleteTB();
        }
        //-------------------------------------------------------------------New Product section end-------------------------------------------------------------------
        //-------------------------------------------------------------------Product update and delete section start --------------------------------------------------
        public void deleteProductUpdateTB()
        {
            productUpdateNDeleteDGV.ClearSelection();
            productUpdateName.Clear();
            updateSuppliersCB.SelectedValue= string.Empty;
            productUpdatePrice.Clear();
            productUpdatePackage.Clear();
            productUpdateStock.Clear();
        }
        private DataTable GetProductsList()
        {
            DataTable dtProducts = new DataTable();
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT products.id as 'ID', ProductName as 'Termeknev', suppliers.CompanyName as 'Beszallito', UnitPrice as 'Egysegar' ,Package as 'Kiszereles', Stock as 'Keszlet' FROM local_store_project_23.suppliers, products where products.SupplierId = suppliers.id order by id asc;";
            dr = cmd.ExecuteReader();
            dtProducts.Load(dr);
            conn.Close();
            return dtProducts;
        }
        private void ReLoadDGV(DataTable data)
        {
            productUpdateNDeleteDGV.ClearSelection();
            deleteProductUpdateTB();
            productUpdateNDeleteDGV.DataSource = null;
            productUpdateNDeleteDGV.DataSource = data;
            productUpdateNDeleteDGV.Columns[0].HeaderText = "ID";
            productUpdateNDeleteDGV.Columns[1].HeaderText = "Termék megnevezése";
            productUpdateNDeleteDGV.Columns[2].HeaderText = "Beszállító";
            productUpdateNDeleteDGV.Columns[3].HeaderText = "Egységár (HUF)";
            productUpdateNDeleteDGV.Columns[4].HeaderText = "Kiszerelés";
            productUpdateNDeleteDGV.Columns[5].HeaderText = "Készlet";
        }
        private void productUpdateNDeleteDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string currentSupplier = "";
            
            try
            {
                if (productUpdateNDeleteDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    productUpdateNDeleteDGV.CurrentRow.Selected = true;
                    currentId = productUpdateNDeleteDGV.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                    productUpdateName.Text = productUpdateNDeleteDGV.Rows[e.RowIndex].Cells["Termeknev"].FormattedValue.ToString();
                    currentSupplier = productUpdateNDeleteDGV.Rows[e.RowIndex].Cells["Beszallito"].FormattedValue.ToString();
                    foreach(string a in updateSuppliersCB.Items)
                    {
                        if(currentSupplier == a)
                        {
                            updateSuppliersCB.SelectedItem = a;
                            for(int i = 0; i < SupplierIdandName.Count; i++)
                            {
                                if(a == SupplierIdandName[i].Value)
                                {
                                    newSupplierID = SupplierIdandName[i].Key;
                                }
                            }
                        }
                    }
                    productUpdatePrice.Text = productUpdateNDeleteDGV.Rows[e.RowIndex].Cells["Egysegar"].FormattedValue.ToString();
                    productUpdatePackage.Text = productUpdateNDeleteDGV.Rows[e.RowIndex].Cells["Kiszereles"].FormattedValue.ToString();
                    productUpdateStock.Text = productUpdateNDeleteDGV.Rows[e.RowIndex].Cells["Keszlet"].FormattedValue.ToString();
                }
                productUpdateGB.Visible = true;
                productUpdateBT.Visible = true;
                productDeleteBT.Visible = true;
                actual = new Product(Convert.ToInt32(currentId), productUpdateName.Text, newSupplierID, Convert.ToDecimal(productUpdatePrice.Text), productUpdatePackage.Text, Convert.ToInt32(productUpdateStock.Text));
            }
            catch (Exception ex)
            {
                string hiba = ex.Message.ToString();

                hibakezeles.ErrorLogs(hiba);
            }
        }
        private void productDeleteBT_Click(object sender, EventArgs e)
        {
            DialogResult torli;
            torli = MessageBox.Show("Biztos törli az adott elemet?", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (torli == DialogResult.Yes)
            {
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "delete from `local_store_project_23`.`products` WHERE `id`= @ID;";
                cmd.Parameters.AddWithValue("@ID", currentId);
                cmd.ExecuteNonQuery();
                conn.Close();
                ReLoadDGV(GetProductsList());
            }
        }
        private void productUpdateBT_Click(object sender, EventArgs e)
        {
            if (actual.ProductName != productUpdateName.Text ||actual.SupplierId != newSupplierID ||actual.UnitPrice != decimal.Parse(productUpdatePrice.Text) || actual.Package != productUpdatePackage.Text || actual.Stock != int.Parse(productUpdateStock.Text))
            {
                uj.setProductName(productUpdateName.Text);
                uj.setUnitPrice(decimal.Parse(productUpdatePrice.Text));
                uj.setPackage(productUpdatePackage.Text);
                uj.setStock(int.Parse(productUpdateStock.Text));
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE `local_store_project_23`.`products` SET `ProductName`='" + uj.ProductName + "', SupplierId = '"+uj.SupplierId+"', UnitPrice = '" + uj.UnitPrice + "', Package = '" + uj.Package + "' ,Stock = '" + uj.Stock + "', updated_at = '" + DateTime.Now.ToString(format) + "' WHERE `id`= @ID;";
                cmd.Parameters.AddWithValue("@ID", currentId);
                cmd.ExecuteNonQuery();
                conn.Close();
                ReLoadDGV(GetProductsList());
            }
            else
            {
                MessageBox.Show("Nem változtattál semmilyen adaton.");
            }
            conn.Close();
        }
        private void productUpdateName_Leave(object sender, EventArgs e)
        {
            if(productUpdateName.Text.Length > 0)
            {
                uj.setProductName(productUpdateName.Text);
            }
            
        }
        private void updateSuppliersCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < SupplierIdandName.Count; i++)
            {
                if (updateSuppliersCB.SelectedItem.ToString() == SupplierIdandName[i].Value)
                {
                    newSupplierID = SupplierIdandName[i].Key;
                }
            }
            uj.setSupplierId(newSupplierID);
            label17.Visible = true;
        }
        private void productUpdatePrice_Leave(object sender, EventArgs e)
        {
            if (productUpdatePrice.Text.Length > 0)
            {
                uj.setUnitPrice(decimal.Parse(productUpdatePrice.Text));
            }
            label17.Visible = false;
        }
        private void productUpdatePackage_Leave(object sender, EventArgs e)
        {
            if (productUpdatePackage.Text.Length > 0)
            {
                uj.setPackage(productUpdatePackage.Text);
            }
        }

        private void productUpdateStock_Leave(object sender, EventArgs e)
        {
            if (productUpdateStock.Text.Length > 0)
            {
                uj.setStock(int.Parse(productUpdateStock.Text));
            }
        }

        private void productUpdateDGVReload_Click(object sender, EventArgs e)
        {
            ReLoadDGV(GetProductsList());
        }
        //-------------------------------------------------------------------Product update and delete section end --------------------------------------------------
        //-------------------------------------------------------------------Product stock update section start -----------------------------------------------------
        private void getProducts()
        {
            if(Products.Count == 0)
            {
                try
                {
                    conn.Open();
                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT products.id, products.ProductName FROM local_store_project_23.products order by id asc ";
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Products.Add(new KeyValuePair<int, string>(Convert.ToInt32(dr[0]), dr[1].ToString()));
                    }
                    conn.Close();

                    for (int i = 0; i < Products.Count; i++)
                    {
                        productsCB.Items.Add(Products[i].Value);
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
        private void prodcutUpdateStock(int stock, string msg)
        {
            try
            {
                uj.setStock(stock);
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE `local_store_project_23`.`products` SET `Stock`='" + uj.Stock + "', updated_at = '" + DateTime.Now.ToString(format) + "' WHERE `id`= @ID;";
                cmd.Parameters.AddWithValue("@ID", int.Parse(selectedProdcutId.Text));
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(msg);
                textBox1.Clear();
                productsCB.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba!" + ex.Message);
                string hiba = ex.Message.ToString();
                hibakezeles.ErrorLogs(hiba);
            }
            conn.Close();
        }
        private void productsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(productsCB.SelectedIndex >= 0)
            {
                for (int i = 0; i < Products.Count; i++)
                {
                    if (productsCB.SelectedItem.ToString().Contains(Products[i].Value))
                    {
                        selectedProdcutId.Text = Products[i].Key.ToString();
                    }
                }
                try
                {
                    conn.Open();
                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT products.Package, products.Stock, products.supplierId FROM local_store_project_23.products where products.id = @ID";
                    cmd.Parameters.AddWithValue("ID", int.Parse(selectedProdcutId.Text));
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        selectedProductPackage.Text = dr[0].ToString();
                        selectedProductStock.Text = dr[1].ToString();
                        selectProductSupplierId.Text = dr[2].ToString();
                    }
                    productSotckGB.Text = productsCB.SelectedItem.ToString() + " készlet:";
                    selectedProductStock.Visible = true;
                    selectedProductPackage.Visible = true;
                    productSotckGB.Visible = true;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba!" + ex.Message);
                    string hiba = ex.Message.ToString();
                    hibakezeles.ErrorLogs(hiba);
                }
                conn.Close();
                try
                {
                    conn.Open();
                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT suppliers.CompanyName, suppliers.ContactName, suppliers.City, suppliers.Phone from local_store_project_23.suppliers  where suppliers.id = @ID";
                    cmd.Parameters.AddWithValue("ID", int.Parse(selectProductSupplierId.Text));
                    dr = cmd.ExecuteReader();
                    while(dr.Read())
                    {
                        supplierCompanyNameLL.Text = dr[0].ToString();
                        supplierContactNameLL.Text = dr[1].ToString();
                        supplierCityLL.Text = dr[2].ToString();
                        supplierPhoneLL.Text = dr[3].ToString();
                    }
                    suppliersDataCB.Visible = true;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba!" + ex.Message);
                    string hiba = ex.Message.ToString();
                    hibakezeles.ErrorLogs(hiba);
                }
                conn.Close();
            }
            else
            {
                selectedProdcutId.Text = "";
                selectedProductStock.Text = "";
                selectedProductPackage.Text = "";
            }    
        }
        private void selectedProductStockUpdateBT_Click(object sender, EventArgs e)
        {
            int newStock;
            string msg = "";
            if (selectedProductStockUpdateBT.Text == "Készlet hozzáadása")
            {
                newStock = Convert.ToInt32(selectedProductStock.Text) + Convert.ToInt32(textBox1.Text);
                msg = "Készlet hozzáadva a megadott termékhez!";
                prodcutUpdateStock(newStock, msg);
            }
            else
            {
                newStock = Convert.ToInt32(selectedProductStock.Text) - Convert.ToInt32(textBox1.Text);
                msg = "Megadott mennyiség eltávolítva!";
                if (Convert.ToInt32(selectedProductStock.Text) < Convert.ToInt32(textBox1.Text))
                {
                    MessageBox.Show("Nincs ennyi db ebből a termékből!");
                    textBox1.Clear();
                    
                }
                else if(Convert.ToInt32(selectedProductStock.Text) == Convert.ToInt32(textBox1.Text))
                {
                    prodcutUpdateStock(newStock,msg);
                    MessageBox.Show("Ebből a termékből kifogytunk");
                }
                else
                {
                    prodcutUpdateStock(newStock, msg);
                }
            }            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            selectedProductStockUpdateBT.Enabled = true;
        }
        private void productAddOrRemoveBT_Click(object sender, EventArgs e)
        {
            if(productAddOrRemoveBT.Text == "Készlet feltöltése")
            {
                productAddOrRemoveBT.Text = "Készlet csökkentése";
                selectedProductStockUpdateBT.Text = "Készlet hozzáadása";
            }
            else
            {
                productAddOrRemoveBT.Text = "Készlet feltöltése";
                selectedProductStockUpdateBT.Text = "Készlet eltávolítása";
            }
        }
        //-------------------------------------------------------------------Product stock update section end -------------------------------------------------------
    }
}
