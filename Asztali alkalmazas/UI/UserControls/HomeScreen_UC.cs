using Asztali_alkalmazas.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asztali_alkalmazas.UI.UserControls
{
    public partial class HomeScreen_UC : UserControl
    {
        private Dashboard model;
        private Button currentButton;
        public HomeScreen_UC()
        {
            InitializeComponent();
            dtpStartDate.Value = Convert.ToDateTime("2022.11.03");
            dtpEndDate.Value = Convert.ToDateTime("2022.11.07");
            last7DaysBT.Select();
            setButtonColors(last7DaysBT);
            model = new Dashboard();
            
            LoadData();
        }
        //------------ UserControl betöltése és alap értékek felvétele ------------
        private void HomeScreen_UC_Load(object sender, EventArgs e)
        {
            labelEndDate.Text = dtpEndDate.Text;
            labelStartDate.Text = dtpStartDate.Text;
            understockDGV.Columns[1].Width = 100;
        }
        //------------ UserControl betöltése és alap értékek felvétele vége ------------
        //------------ Dashboard classból adatok elhelyezése megfelelő helyen ------------
        private void LoadData()
        {
            model.LoadData(dtpStartDate.Value, dtpEndDate.Value);

            labelCustomerCount.Text = model.NumberCustomers.ToString();
            labelSupplierCount.Text = model.NumberSuppliers.ToString();
            labelProductsCount.Text = model.NumberProducts.ToString();
            labelUsersCount.Text = model.NumberUsers.ToString();

            labelOrdersCount.Text = model.NumberOrders.ToString();
            labelTotalRevenue.Text= model.TotalRevenue.ToString()+" HUF";
            labelTotalProfit.Text = model.TotalProfit.ToString()+ " HUF";

            GrossRevenueChart.DataSource = model.GrossRevenueList;
            GrossRevenueChart.Series[0].XValueMember= "Date";
            GrossRevenueChart.Series[0].YValueMembers= "TotalAmount";
            GrossRevenueChart.DataBind();

            topProductsChart.DataSource = model.TopProductsList;
            topProductsChart.Series[0].XValueMember= "Key";
            topProductsChart.Series[0].YValueMembers= "Value";
            topProductsChart.DataBind();

            understockDGV.DataSource = model.UnderstockList;
            understockDGV.Columns[0].HeaderText = "Termék";
            understockDGV.Columns[1].HeaderText = "Mennyiség";
        }
        //------------ Dashboard classból adatok elhelyezése megfelelő helyen vége ------------
        //------------ Gombok színe és datetimepiker beállítások ------------
        private void setButtonColors(object button)
        {
            var btn = (Button)button;
            btn.BackColor = todayBT.FlatAppearance.BorderColor;
            btn.ForeColor = Color.WhiteSmoke;

            if(currentButton != null && currentButton != btn)
            {
                currentButton.BackColor = Color.FromArgb(24, 28, 43);
                currentButton.ForeColor = Color.FromArgb(124, 141, 181);
            }

            currentButton= btn;

            if(btn == customBT)
            {
                dtpEndDate.Enabled = true;
                dtpStartDate.Enabled = true;
                okCustomBT.Visible = true;
                labelStartDate.Cursor = Cursors.Hand;
                labelEndDate.Cursor = Cursors.Hand;
            }
            else
            {
                dtpEndDate.Enabled = false;
                dtpStartDate.Enabled = false;
                okCustomBT.Visible = false;
                labelStartDate.Cursor = Cursors.Default;
                labelEndDate.Cursor = Cursors.Default;
            }
        }
        //------------ Gombok színe és datetimepiker beállítások vége ------------
        //------------ Gombokhoz események és attributumok rendelése ------------
        private void todayBT_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            setButtonColors(sender);
        }

        private void last7DaysBT_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            setButtonColors(sender);
        }

        private void last30daysBT_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            setButtonColors(sender);
        }

        private void thisMonthBT_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month,1);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            setButtonColors(sender);
        }

        private void customBT_Click(object sender, EventArgs e)
        {
            dtpEndDate.Enabled = true;
            dtpStartDate.Enabled = true;
            okCustomBT.Visible = true;
            setButtonColors(sender);
        }

        private void okCustomBT_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void labelStartDate_Click(object sender, EventArgs e)
        {
            if(currentButton == customBT)
            {
                dtpStartDate.Select();
                SendKeys.Send("°%{DOWN}");
            }
        }

        private void labelEndDate_Click(object sender, EventArgs e)
        {
            if (currentButton == customBT)
            {
                dtpEndDate.Select();
                SendKeys.Send("°%{DOWN}");
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            labelStartDate.Text = dtpStartDate.Text;
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            labelEndDate.Text = dtpEndDate.Text;
        }
        //------------ Gombokhoz események és attributumok rendelése vége ------------
    }
}
