using Asztali_alkalmazas.UI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MySql.Data.MySqlClient;
using System.Drawing.Text;
using Asztali_alkalmazas.Classes;

namespace Asztali_alkalmazas.UI
{
    public partial class ControlPanel : Form
    {
        MySqlConnection conn;
        string connstring;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public ControlPanel()
        {
            InitializeComponent();
            panelSlide.Height = mainBT.Height;
            panelSlide.Top = mainBT.Top;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
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

        private Point _mouseLoc; // Kezdő egérhelyzet felvétele
        private string picSrc;
        private string username;
        private string date;
        private string permission;

        //Borderless form meretezhetőségének beállítása
        private const int cGrip = 16;
        private const int cCaption = 32;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }
        //Borderless form meretezhetőségének beállításának vége

        private void mainBT_Click(object sender, EventArgs e)
        {
            panelSlide.Height = mainBT.Height;
            panelSlide.Top = mainBT.Top;
            panelSlide2.Visible = false;

            userProfil_UC1.Visible = false;
            adminControl_UC1.Visible = false;
            try
            {
                Load_PicSrc();
                userProfilePic.Image = new Bitmap(picSrc);
            }
            catch (Exception)
            {
                //
            }
        }

        private void CustomerBT_Click(object sender, EventArgs e)
        {
            panelSlide.Height = CustomerBT.Height;
            panelSlide.Top = CustomerBT.Top;
            panelSlide2.Visible = false;
        }

        private void adminBT_Click(object sender, EventArgs e)
        {
            panelSlide2.Width = adminBT.Width;
            panelSlide2.Left = adminBT.Left;
            panelSlide2.Visible = true;

            adminControl_UC1.Location = userProfil_UC1.Location;
            adminControl_UC1.Dock= DockStyle.Fill;
            adminControl_UC1.Visible = true;
            userProfil_UC1.Visible = false;
        }

        private void supplierBT_Click(object sender, EventArgs e)
        {
            panelSlide.Height = supplierBT.Height;
            panelSlide.Top = supplierBT.Top;
            panelSlide2.Visible = false;
        }

        private void raktarBT_Click(object sender, EventArgs e)
        {
            panelSlide.Height = raktarBT.Height;
            panelSlide.Top = raktarBT.Top;
            panelSlide2.Visible = false;
        }

        private void ordersBT_Click(object sender, EventArgs e)
        {
            panelSlide.Height = ordersBT.Height;
            panelSlide.Top = ordersBT.Top;
            panelSlide2.Visible = false;
        }
        private void ExitBT_Click(object sender, EventArgs e)
        {
            panelSlide.Height = ExitBT.Height;
            panelSlide.Top = ExitBT.Top;
            panelSlide2.Visible = false;

            DialogResult Exit;
            Exit = MessageBox.Show("Bezárja a programot?", "Project 23", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void userProfilBT_Click(object sender, EventArgs e)
        {
            userProfil_UC1.Visible = true;
            adminControl_UC1.Visible = false;
            panelSlide2.Width = userProfilBT.Width;
            panelSlide2.Left = userProfilBT.Left;
            panelSlide2.Visible = true;
        }

        private void kijelentkezBT_Click(object sender, EventArgs e)
        {
            panelSlide2.Width = kijelentkezBT.Width;
            panelSlide2.Left = kijelentkezBT.Left;
            panelSlide2.Visible = true;

            DialogResult Logout;
            Logout = MessageBox.Show("Biztos kijelentkezel?", "Project 23", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (Logout == DialogResult.Yes)
            {
                Application.Restart();
            }
            else
            {
                panelSlide2.Visible = false;
                mainBT_Click(sender, e);
            }

        }

        private void closeBT_Click(object sender, EventArgs e)
        {
            DialogResult Exit;
            Exit = MessageBox.Show("Bezárja a programot?", "Project 23", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Exit == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                panelSlide2.Visible = false;
                mainBT_Click(sender, e);
            }
        }

        private void closeBT_MouseEnter(object sender, EventArgs e)
        {
            closeBT.BackColor = Color.Red;
        }

        private void closeBT_MouseLeave(object sender, EventArgs e)
        {
            closeBT.BackColor = panel3.BackColor;
        }

        private void minBT_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void minBT_MouseEnter(object sender, EventArgs e)
        {
            minBT.BackColor = Color.Gray;
        }

        private void minBT_MouseLeave(object sender, EventArgs e)
        {
            minBT.BackColor = panel3.BackColor;
        }

        private void maxBT_Click(object sender, EventArgs e)
        {
            if (WindowState is FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void maxBT_MouseEnter(object sender, EventArgs e)
        {
            maxBT.BackColor = Color.Gray;
        }

        private void maxBT_MouseLeave(object sender, EventArgs e)
        {
            maxBT.BackColor = panel3.BackColor;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLoc = e.Location;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mouseLoc.X;
                int dy = e.Location.Y - _mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        private void Load_PicSrc()
        {
            string adat = "picSrc.txt";
            StreamReader olvas = new StreamReader(adat, Encoding.UTF8);
            string [] sor;
            while (!olvas.EndOfStream)
            {
                sor = olvas.ReadLine().Split(';');
                if (!sor.Equals(""))
                {
                    if(username == sor[0])
                    {
                        picSrc = sor[1];
                    } 
                }
            }
            olvas.Close();
        }

        private void Load_UserData()
        {
            string log = "succesLoginData.txt";
            StreamReader olvas = new StreamReader(log, Encoding.UTF8);
            string sor = "";
            while (!olvas.EndOfStream)
            {
                sor = olvas.ReadLine();
                string[] ideig = sor.Split(';');
                if (!sor.Equals(""))
                {
                    username = ideig[0];
                    date = ideig[1];
                    permission = ideig[2];
                }
            }
            olvas.Close();
        }
        private void get_UserData()
        {
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT First_name, Last_name, permissions.Permission FROM local_store_project_23.users, local_store_project_23.permissions where users.Permission = permissions.id and Username= @Username;";
            cmd.Parameters.AddWithValue("@Username", username);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                label3.Text = dr["Last_name"].ToString() + " " + dr["First_name"].ToString();
                timer1.Start();
                adminLL.Text = dr["Permission"].ToString();
                if (adminLL.Text != "Admin")
                {
                    adminBT.Visible = false;
                }
                else
                {
                    adminBT.Visible = true;
                }
                conn.Close();
            }
            conn.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            label6.Text = currentTime.ToString();
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {
            Load_UserData();
            get_UserData();
            adminControl_UC1.Visible = false;
            try
            {

                Load_PicSrc();
                userProfilePic.Image = new Bitmap(picSrc);
            }
            catch (Exception)
            {

            }
        }
    }
}
