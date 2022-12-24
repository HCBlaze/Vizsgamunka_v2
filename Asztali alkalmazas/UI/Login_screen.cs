using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using Asztali_alkalmazas.Classes;
using Asztali_alkalmazas.UI;
using Google.Protobuf;
using System.Threading;
using Asztali_alkalmazas.UI.UserControls;

namespace Asztali_alkalmazas.UI
{
    public partial class Login_screen : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public Login_screen()
        {
            Thread trd = new Thread(new ThreadStart(FormRun));
            trd.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            trd.Abort();
            Password_Textbox.PasswordChar = '*';
            Password_Textbox.MaxLength = 15;
            Password_Textbox.Multiline = false;
            Username_Textbox.Multiline = false;
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
                    hibakezeles.ErrorLogs(hiba);
                    Application.Exit();
                }
            }
            conn.Close();
        }
        DbConnection db = new DbConnection();
        PasswordCrypt uj = new PasswordCrypt();
        AdminControl_UC hibakezeles = new AdminControl_UC(); //Hibák logolása
        private Point _mouseLoc;
        private void FormRun()
        {
            Application.Run(new Loader());
        }
        private void Login_screen_Load(object sender, EventArgs e)
        {
            this.Activate();
            Username_Textbox.Focus();
        }
        private void Show_Password_Click(object sender, EventArgs e)
        {
            Password_Textbox.PasswordChar = '\0';
            Hide_Password.BringToFront();
            Show_Password.SendToBack();
        }

        private void Hide_Password_Click(object sender, EventArgs e)
        {
            Password_Textbox.PasswordChar = '*';
            Show_Password.BringToFront();
            Hide_Password.SendToBack();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string user = Username_Textbox.Text;
                string password = uj.titkosPWD(Password_Textbox.Text);

                cmd = new MySqlCommand();

                cmd.Connection = conn;
                cmd.CommandText = "SELECT Username FROM local_store_project_23.users where Username ='" + user + "';";
                object result = cmd.ExecuteScalar();
                if (result == null)
                {
                    MessageBox.Show("Hibás felhasználónév!");
                    Username_Textbox.Clear();
                    Password_Textbox.Clear();
                    Username_Textbox.Focus();
                    conn.Close();
                }
                else
                {
                    cmd.CommandText = "SELECT id, Username,Password,Permission,Deleted FROM local_store_project_23.users where Username='" + user + "';";
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        int torolt = Convert.ToInt32(dr["Deleted"]);
                        if (torolt == 0 && password == dr["Password"].ToString() && user == dr["Username"].ToString())
                        {
                            MessageBox.Show("Betudott Lépni");
                            writeLogin(user, dr["Permission"].ToString());
                            ControlPanel CP = new ControlPanel();
                            CP.Show();
                            CP.BringToFront();
                            this.Hide();
                            conn.Close();
                        }
                        else if (torolt == 1)
                        {
                            MessageBox.Show("Törölt felhasználó.");
                            Username_Textbox.Clear();
                            Password_Textbox.Clear();
                            Username_Textbox.Focus();
                            conn.Close();
                        }
                        else
                        {
                            MessageBox.Show("Hibás jelszó.");
                            Password_Textbox.Clear();
                            conn.Close();
                        }
                    }
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
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void writeLogin(string username,string permission) //Belépési adatokat kiírjuk.
        {
            string login = "succesLoginData.txt";
            StreamWriter iras = new StreamWriter(login, false, Encoding.UTF8);
            iras.WriteLine(username + ";" + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString() + ";" + permission);
            iras.Close();
        }
            //Egér lenyomásakor nézi és eltárolja hova húztuk az egeret, felengedéskor elmenti
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLoc = e.Location;
        }
            //A fent lementett érték x, y kordinátáját hozzáadjuk az alap kordínátákhoz, így megkapjuk az új locationt
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mouseLoc.X;
                int dy = e.Location.Y - _mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }
        private void Password_Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                LogIn_Click(sender, e);
            }

        }
    }
}
