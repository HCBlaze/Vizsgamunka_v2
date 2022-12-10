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

namespace Asztali_alkalmazas.UI
{
    public partial class Login_screen : Form
    {
        MySqlConnection conn;
        string connstring;
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

        private void FormRun()
        {
            Application.Run(new Loader());
        }
        PasswordCrypt uj = new PasswordCrypt();// Csóbor S. Erik csinálta
        private Point _mouseLoc;// Csóbor S. Erik csinálta
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
            conn.Open();
            string user = Username_Textbox.Text;
            string password = uj.titkosPWD(Password_Textbox.Text); // Csóbor S. Erik csinálta

            cmd = new MySqlCommand();

            cmd.Connection = conn;
            cmd.CommandText = "SELECT Username FROM local_store_project_23.users where Username ='" + user + "';";// Csóbor S. Erik csinálta
            object result = cmd.ExecuteScalar();// Csóbor S. Erik csinálta
            if (result == null)// Csóbor S. Erik csinálta
            {
                MessageBox.Show("Hibás felhasználónév!");// Csóbor S. Erik csinálta
                Username_Textbox.Clear();// Csóbor S. Erik csinálta
                Password_Textbox.Clear();// Csóbor S. Erik csinálta
                Username_Textbox.Focus();// Csóbor S. Erik csinálta
                conn.Close();// Csóbor S. Erik csinálta
            }
            else
            {
                cmd.CommandText = "SELECT id, Username,Password,Permission,Deleted FROM local_store_project_23.users where Username='" + user + "';"; //Csóbor S. Erik
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    int torolt = Convert.ToInt32(dr["Deleted"]);// Csóbor S. Erik csinálta
                    if (torolt == 0 && password == dr["Password"].ToString() && user == dr["Username"].ToString())// Csóbor S. Erik csinálta
                    {
                        MessageBox.Show("Betudott Lépni");
                        writeLogin(user, dr["Permission"].ToString());
                        ControlPanel CP = new ControlPanel();// Csóbor S. Erik csinálta
                        CP.Show();// Csóbor S. Erik csinálta
                        CP.BringToFront();// Csóbor S. Erik csinálta
                        this.Hide();// Csóbor S. Erik csinálta
                        conn.Close();
                    }
                    else if (torolt == 1) // Csóbor S. Erik csinálta
                    {
                        MessageBox.Show("Törölt felhasználó.");// Csóbor S. Erik csinálta
                        Username_Textbox.Clear();// Csóbor S. Erik csinálta
                        Password_Textbox.Clear();// Csóbor S. Erik csinálta
                        Username_Textbox.Focus();// Csóbor S. Erik csinálta
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Hibás jelszó.");// Csóbor S. Erik csinálta
                        Password_Textbox.Clear();// Csóbor S. Erik csinálta
                        conn.Close();
                    }
                }
            }
            conn.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Csóbor S. Erik csinálta
        private void writeLogin(string username,string permission)
        {
            string login = "succesLoginData.txt";
            StreamWriter iras = new StreamWriter(login, false, Encoding.UTF8);
            iras.WriteLine(username + ";" + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString() + ";" + permission);
            iras.Close();
        }
            //Egér lenyomásakor nézi és eltárolja hova húztuk az egeret, felengedéskor elmenti --> Csóbor S. Erik csinálta
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLoc = e.Location;
        }
            //A fent lementett érték x, y kordinátáját hozzáadjuk az alap kordínátákhoz, így megkapjuk az új locationt -->Csóbor S. Erik csinálta
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mouseLoc.X;
                int dy = e.Location.Y - _mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }
            
        private void Login_screen_Load(object sender, EventArgs e)
        {
            this.Activate();
            Username_Textbox.Focus();
        }
            //Viola János csinálta
        private void Password_Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                LogIn_Click(sender, e);
            }

        }
    }
}
