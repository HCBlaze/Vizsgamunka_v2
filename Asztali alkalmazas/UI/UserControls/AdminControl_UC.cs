﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Asztali_alkalmazas.Classes;
using System.IO;

namespace Asztali_alkalmazas.UI.UserControls
{
    public partial class AdminControl_UC : UserControl
    {
        MySqlConnection conn;
        string format = "yyyy-MM-dd";
        string createNUpdateFormat = "yyyy-MM-dd HH:mm:ss";
        int id;
        string username;
        string currentId;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public AdminControl_UC()
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
                DialogResult Error;
                Error = MessageBox.Show("Nem megfelelő authentikációs adatok.\n Ellenőrizd a connectionString.txt fájlt!", "Project 23", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Error == DialogResult.OK)
                {
                    string hiba = ex.Message.ToString();
                    ErrorLogs(hiba);
                    Application.Exit();
                }
            }
            conn.Close();
            getID();//Az adatbázisban következő ID-t adja az új felhasználónak           
            uj.setId(id);
        }
        DbConnection db = new DbConnection();
        Users uj = new Users();
        Users actual;
        PasswordCrypt pwd = new PasswordCrypt();
        private void addNewUserBT_Click(object sender, EventArgs e)
        {
            
            newUserGB.Location = adminOperationGB.Location;
            if (adminOperationGB.Visible == true)
            {
                adminOperationGB.Visible = false;
                newUserGB.Visible = true;
            }
            else
            {
                adminOperationGB.Visible = true;
                newUserGB.Visible = false;
            }

        }

        private void editUserBT_Click(object sender, EventArgs e)
        {
            
            editUserGB.Location = adminOperationGB.Location;
            if (adminOperationGB.Visible == true)
            {
                adminOperationGB.Visible = false;
                editUserGB.Visible = true;
            }
            else
            {
                adminOperationGB.Visible = true;
                editUserGB.Visible = false;
            }
        }

        private void backToOperationBT_Click(object sender, EventArgs e)
        {
            newUserGB.Visible = false;
            adminOperationGB.Visible = true;
        }

        private void backToOperationBT1_Click(object sender, EventArgs e)
        {
            editUserGB.Visible = false;
            adminOperationGB.Visible = true;
        }
        //Nem kritikus hibák leírása log fájlba.
        public void ErrorLogs(string error)
        {
            string log = "logs.txt";
            string datum = DateTime.Now.ToString(createNUpdateFormat);
            StreamWriter iras = new StreamWriter(log, true, Encoding.UTF8);
            iras.WriteLine(datum+" - "+error);
            iras.Close();
        }
        // Regisztrációs form részei: 

        //A soron következő id -t adja a felhasználónak.
        private void getID()
        {
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT id FROM local_store_project_23.users order by id desc ";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string ideig = dr["id"].ToString();
                id = int.Parse(ideig);
            }
            conn.Close();
        }
        private void RegBT_Click(object sender, EventArgs e)
        {
            if (isDeletedNoRB.Checked == true)
            {
                uj.setDeleted(false);
            }
            else
            {
                uj.setDeleted(true);
            }
            setUjFelhasznalo();
        }
        //Vezetéknév beállítása osztályban
        private void vezetekNevTB_Leave(object sender, EventArgs e)
        {
            try
            {
                string vnev = vezetekNevTB.Text;
                uj.setLastname(vnev);
                keresztNevTB.Focus();
            }
            catch (Exception ex)
            {
                string hiba = ex.Message.ToString();
                ErrorLogs(hiba);
            }

        }
        //Keresztnév beállítása osztályban
        private void keresztNevTB_Leave(object sender, EventArgs e)
        {
            try
            {
                uj.setFirstname(keresztNevTB.Text);
                JelszoTB.Focus();
            }
            catch (Exception ex)
            {
                string hiba = ex.Message.ToString();
                ErrorLogs(hiba);
            }

        }
        //Jelszó beállítása és titkosítása osztályban
        private void JelszoTB_Leave(object sender, EventArgs e)
        {
            try
            {
                uj.setPassword(JelszoTB.Text);
                string decodePwd = pwd.titkosPWD(uj.Password);
                if(uj.Password == "Default1234")
                {
                    DialogResult Error;
                    Error = MessageBox.Show("Az álltalad megadott jelszó nem megfelelő erősségű.\nBeállítottam az alap jelszót.", "Nem megfelelő erősségű jelszó!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    JelszoTB.Text = uj.Password;
                }
                emailTB.Focus();
            }
            catch (Exception ex)
            {
                string hiba = ex.Message.ToString();
                ErrorLogs(hiba);
            }

        }
        //Email beállítása és ellenőrzése 
        private void emailTB_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!emailTB.Text.Contains("@"))
                {
                    rosszEmailLL.ForeColor = Color.Red;
                    rosszEmailLL.Text = "Nem megfelelő email formátum! Írja be újra!";
                    rosszEmailLL.Visible = true;
                    emailTB.Clear();
                }
                else
                {
                    rosszEmailLL.Visible = false;
                    uj.setEmail(emailTB.Text);
                }
                dateTimePicker1.Focus();
            }
            catch (Exception ex)
            {
                string hiba = ex.Message.ToString();
                ErrorLogs(hiba);
            }

        }
        //Születési idő beállítása és ellenőrzése
        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            try
            {
                if (dateTimePicker1.Value <= DateTime.MinValue)
                {
                    rosszDatumLL.ForeColor = Color.Red;
                    rosszDatumLL.Visible = true;
                    rosszDatumLL.Text = "Túl régi dátum, add meg a valós születési dátumod.";
                    dateTimePicker1.Refresh();
                }
                else if (dateTimePicker1.Value >= DateTime.Now)
                {
                    rosszDatumLL.ForeColor = Color.Red;
                    rosszDatumLL.Visible = true;
                    rosszDatumLL.Text = "Még meg sem születtél, add meg a valós születési dátumod.";
                    dateTimePicker1.Refresh();
                }
                else
                {
                    rosszDatumLL.Visible = false;

                    uj.setBirthDate(dateTimePicker1.Value);
                }
                jogosultsagCB1.Focus();
            }
            catch (Exception ex)
            {
                string hiba = ex.Message.ToString();
                ErrorLogs(hiba);
            }

        }
        //Jogosultság ellenőrzése
        private void jogosultsagCB1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (jogosultsagCB1.SelectedItem is null || jogosultsagCB1.SelectedIndex == 0)
                {
                    rosszJogosultsagLL.ForeColor = Color.Red;
                    rosszJogosultsagLL.Text = "Kötelező megadni jogosultságot!";
                    RegBT.Enabled = false;
                    rosszJogosultsagLL.Visible = true;
                }
                else
                {
                    RegBT.Enabled = true;
                    rosszJogosultsagLL.Visible = false;
                }
            }
            catch (Exception ex)
            {
                string hiba = ex.Message.ToString();
                ErrorLogs(hiba);
            }

        }
        //Jogosultság beállítása osztályban
        private void jogosultsagCB1_Leave(object sender, EventArgs e)
        {
            try
            {
                uj.setPermission(jogosultsagCB1.SelectedIndex);
                userDeletedGB.Focus();
            }
            catch (Exception ex)
            {
                string hiba = ex.Message.ToString();
                ErrorLogs(hiba);
            }

        }
        //Uj felhasználó letárolása az adatbázisban
        private void setUjFelhasznalo()
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO `local_store_project_23`.`users`(`Password`, `First_name`, `Last_name`, `Email`, `Birth`, `Permission`, `Deleted`, `created_at`,`updated_at`)  VALUES ('" + pwd.CryptedPwd + "', '" + uj.Firstname + "', '" + uj.Lastname + "', '" + uj.Email + "', '" + uj.BirthDate.ToString(format) + "', '" + uj.Permission + "', '" + uj.Deleted + "','"+DateTime.Now.ToString(createNUpdateFormat)+"', '"+DateTime.Now.ToString(createNUpdateFormat)+"')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Létrehozva!");
                conn.Close();
                getID();
                uj.setId(id);
                uj.setUsername(uj.Firstname, uj.Lastname, uj.Id);
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE `local_store_project_23`.`users` SET Username = '" + uj.Username + "' where id = '" + uj.Id + "'";
                cmd.ExecuteNonQuery();
                clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hiba!" + ex.Message);
                string hiba = ex.Message.ToString();
                ErrorLogs(hiba);

            }
            conn.Close();
            id++;
            reLoadActive();
            
        }
        //Mező értékek törlése, a felhasználó felvétele után
        private void clear()
        {
            vezetekNevTB.Clear();
            keresztNevTB.Clear();
            JelszoTB.Clear();
            emailTB.Clear();
            dateTimePicker1.Value = DateTime.Now;
            rosszEmailLL.Visible = false;
            rosszJogosultsagLL.Visible = false;
            jogosultsagCB1.SelectedIndex = 0;
            JelszoTB.PasswordChar = '*';
        }
        private void updateSectionTBClear()
        {
            getKeresztnevTB.Clear();
            getVezeteknevTB.Clear();
            getJelszoTB.Clear();
            getEmailTB.Clear();
            dateTimePicker2.Value = DateTime.Now;
            getJogosultsagCB.SelectedIndex = 0;
        }

        private void AdminControl_UC_Load(object sender, EventArgs e)
        {
            FelhasznalokDGV.DataSource = GetUsersListActive();
        }
        //Lekérdezi a User táblában levő aktív felhasználókat
        private DataTable GetUsersListActive()
        {
            DataTable dtUsers = new DataTable();
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT users.id,Username,Password, First_name,Last_name,`Email`,Birth, permissions.Permission, Deleted FROM local_store_project_23.users, local_store_project_23.permissions\r\nwhere users.Permission = permissions.id and Deleted = 0\r\norder by id asc";
            dr = cmd.ExecuteReader();
            dtUsers.Load(dr);
            conn.Close();
            return dtUsers;

        }
        //Lekérdezi a User táblában levő törölt felhasználókat
        private DataTable GetUsersListDeleted()
        {
            DataTable dtUsers = new DataTable();
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT users.id,Username,Password, First_name,Last_name,`Email`,Birth, permissions.Permission, Deleted FROM local_store_project_23.users, local_store_project_23.permissions\r\nwhere users.Permission = permissions.id and Deleted = 1\r\norder by id asc";
            dr = cmd.ExecuteReader();
            dtUsers.Load(dr);
            conn.Close();
            return dtUsers;

        }
        //DataGridView újratöltése aktív felhasználók
        private void reLoadActive()
        {
            FelhasznalokDGV.DataSource = null;
            FelhasznalokDGV.DataSource = GetUsersListActive();
        }
        //DataGridView újratöltése törölt felhasználók
        private void reLoadDeleted()
        {
            FelhasznalokDGV.DataSource = null;
            FelhasznalokDGV.DataSource = GetUsersListDeleted();
        }
        //DataGridView cellákra kattintva feltöltöm a textboxokat
        private void FelhasznalokDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string pw = "";
            int deleted = 0;
            try
            {
                if (editUserGB.Visible == true)
                {
                    if (FelhasznalokDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        FelhasznalokDGV.CurrentRow.Selected = true;
                        username = FelhasznalokDGV.Rows[e.RowIndex].Cells["Username"].FormattedValue.ToString();
                        currentId = FelhasznalokDGV.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                        getJelszoTB.Text = FelhasznalokDGV.Rows[e.RowIndex].Cells["Password"].FormattedValue.ToString();
                        pw = pwd.fejtettPWD(getJelszoTB.Text);
                        getJelszoTB.Text = pw;
                        getKeresztnevTB.Text = FelhasznalokDGV.Rows[e.RowIndex].Cells["First_name"].FormattedValue.ToString();
                        getVezeteknevTB.Text = FelhasznalokDGV.Rows[e.RowIndex].Cells["Last_name"].FormattedValue.ToString();
                        getEmailTB.Text = FelhasznalokDGV.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();
                        string datum = FelhasznalokDGV.Rows[e.RowIndex].Cells["Birth"].FormattedValue.ToString();
                        dateTimePicker2.Value = DateTime.Parse(datum);
                        if (FelhasznalokDGV.Rows[e.RowIndex].Cells["Permission"].FormattedValue.ToString() == "Admin")
                        {
                            getJogosultsagCB.SelectedIndex = 1;
                        }
                        else if (FelhasznalokDGV.Rows[e.RowIndex].Cells["Permission"].FormattedValue.ToString() == "Leader")
                        {
                            getJogosultsagCB.SelectedIndex = 2;
                        }
                        else
                        {
                            getJogosultsagCB.SelectedIndex = 3;
                        }
                        if (FelhasznalokDGV.Rows[e.RowIndex].Cells["Deleted"].FormattedValue.ToString() == "0")
                        {
                            getIsDeletedNoRB.Checked = true;
                            getIsDeletedYesRB.Checked = false;
                            deleted = 0;
                        }
                        else
                        {
                            getIsDeletedYesRB.Checked = true;
                            getIsDeletedNoRB.Checked = false;
                            deleted = 1;
                        }
                    }
                    actual = new Users(int.Parse(currentId), username, pw, getKeresztnevTB.Text, getVezeteknevTB.Text, getEmailTB.Text, dateTimePicker2.Value, getJogosultsagCB.SelectedIndex, deleted);
                }
                else
                {
                    currentId = FelhasznalokDGV.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                string hiba = ex.Message.ToString();
                ErrorLogs(hiba);
            }

        }
        //Jelszó mutatása vagy takarása
        private void showPWD1_Click(object sender, EventArgs e)
        {
            if (newUserGB.Visible == true)
            {
                if (JelszoTB.PasswordChar == '*')
                {
                    JelszoTB.PasswordChar = '\0';
                }
                else
                {
                    JelszoTB.PasswordChar = '*';
                }

            }
        }
        //Jelszó mutatása vagy takarása
        private void showPWD2_Click(object sender, EventArgs e)
        {
            if (editUserGB.Visible == true)
            {
                if (getJelszoTB.PasswordChar == '*')
                {
                    getJelszoTB.PasswordChar = '\0';
                }
                else
                {
                    getJelszoTB.PasswordChar = '*';
                }

            }
        }
        //Kijelölt felhasználó törlése
        private void deleteUserBT_Click(object sender, EventArgs e)
        {

            DialogResult torli;
            torli = MessageBox.Show("Biztos törli az adott elemet?", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (torli == DialogResult.Yes)
            {
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE `local_store_project_23`.`users` SET `Deleted`= '1' WHERE `id`= @Employee_id;";
                cmd.Parameters.AddWithValue("@Employee_id", currentId);
                cmd.ExecuteNonQuery();
                conn.Close();
                reLoadActive();
            }
        }
        //DataGridView exportálása Excelbe
        private void dataExportBT_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;

            app.Visible = true;
            worksheet = workbook.Sheets["Munka1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Teljes személyi állomány";

            for (int i = 1; i < FelhasznalokDGV.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = FelhasznalokDGV.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < FelhasznalokDGV.Rows.Count - 1; i++)
            {
                for (int j = 0; j < FelhasznalokDGV.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = FelhasznalokDGV.Rows[i].Cells[j].Value.ToString();
                }
            }
        }
        //Törölt felhasználók megjelenítése
        private void showDeletedBT_Click(object sender, EventArgs e)
        {
            reLoadDeleted();
        }
        //Aktív felhasználók megjelenítése
        private void showActiveBT_Click(object sender, EventArgs e)
        {
            reLoadActive();
        }
        //Felhasználói adatok frissítése
        private void editUserBT2_Click(object sender, EventArgs e)
        {
            getJelszoTB.PasswordChar = '*';

            if (getIsDeletedNoRB.Checked == true)
            {
                uj.setDeleted(false);
            }
            else
            {
                uj.setDeleted(true);
            }


            if (actual.Firstname != getKeresztnevTB.Text || actual.Lastname != getVezeteknevTB.Text || actual.Password != getJelszoTB.Text || actual.Email != getEmailTB.Text || actual.BirthDate != dateTimePicker2.Value || actual.Permission != getJogosultsagCB.SelectedIndex)
            {
                uj.setFirstname(getKeresztnevTB.Text);
                uj.setLastname(getVezeteknevTB.Text);
                uj.setPassword(getJelszoTB.Text);
                string decodePwd = pwd.titkosPWD(uj.Password);
                uj.setEmail(getEmailTB.Text);
                uj.setBirthDate(dateTimePicker2.Value);
                uj.setPermission(getJogosultsagCB.SelectedIndex);
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE `local_store_project_23`.`users` SET Password= '" + pwd.CryptedPwd + "', First_name= '" + uj.Firstname + "',Last_name= '" + uj.Lastname + "', `Email`= '" + uj.Email + "',Birth= '" + uj.BirthDate.ToString(format) + "',Permission= '" + uj.Permission + "', Deleted= '" + uj.Deleted + "', updated_at= '"+DateTime.Now.ToString(createNUpdateFormat)+"' WHERE id= '" + currentId + "'";
                cmd.ExecuteNonQuery();
                conn.Close();
                updateSectionTBClear();
                reLoadActive();
                
            }
            else
            {
                MessageBox.Show("Nem változtattál semmilyen adaton.");
            }

            
        }

        private void getJelszoTB_Leave(object sender, EventArgs e)
        {
            if (getJelszoTB.Text.Any(char.IsUpper) && getJelszoTB.Text.Any(char.IsDigit) && getJelszoTB.Text.Length >= 8)
            {
            }
            else
            {
                DialogResult Error;
                Error = MessageBox.Show("Az álltalad megadott jelszó nem megfelelő erősségű.\nBeállítottam az alap jelszót.", "Nem megfelelő erősségű jelszó!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                getJelszoTB.Text = "Default1234";
            }
        }
    }
}
