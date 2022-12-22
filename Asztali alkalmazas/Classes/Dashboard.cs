using Asztali_alkalmazas.Classes;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace Asztali_alkalmazas.Classes
{
    public struct RevenueByDate
    {
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }
    }
    internal class Dashboard : DbConnection
    {
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;

        public int NumberCustomers { get; private set; }
        public int NumberSuppliers { get; private set; }
        public int NumberProducts { get; private set; }
        public int NumberUsers { get; private set; }
        public int NumberOrders { get; private set; }
        public decimal TotalRevenue { get; private set; }
        public decimal TotalProfit { get; private set; }
        public List<KeyValuePair<string, int>> TopProductsList { get; private set; }
        public List<KeyValuePair<string, int>> UnderstockList { get; private set; }
        public List<RevenueByDate> GrossRevenueList  { get; private set; }

        public Dashboard ()
        {

        }

        private void getTotalNumberItems()
        {
            using (var conn = getConnection())
            {
                conn.Open();
                using(var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    //Vásárlók száma
                    cmd.CommandText = "SELECT count(id) FROM local_store_project_23.customers;";
                    NumberCustomers = Convert.ToInt32(cmd.ExecuteScalar());

                    //Beszállítók száma
                    cmd.CommandText = "SELECT count(id) FROM local_store_project_23.suppliers;";
                    NumberSuppliers = Convert.ToInt32(cmd.ExecuteScalar());

                    //Termékek száma
                    cmd.CommandText = "SELECT count(id) FROM local_store_project_23.products;";
                    NumberProducts = Convert.ToInt32(cmd.ExecuteScalar());

                    //Felhasználók száma
                    cmd.CommandText = "SELECT count(id) FROM local_store_project_23.users;";
                    NumberUsers = Convert.ToInt32(cmd.ExecuteScalar());

                    //Megrendelések száma
                    cmd.CommandText = @"SELECT count(id) FROM local_store_project_23.orders " +
                                                "where OrderDate between @fromDate and @toDate;";
                    cmd.Parameters.Add("@fromDate", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = startDate;
                    cmd.Parameters.Add("@toDate", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = endDate;
                    NumberOrders = Convert.ToInt32(cmd.ExecuteScalar());
                }
                // conn.Close();
            }
        }
        private void getOrdersAnalisys()
        {
            GrossRevenueList = new List<RevenueByDate>();
            TotalProfit = 0;
            TotalRevenue = 0;
            using (var conn = getConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    
                    cmd.CommandText = "SELECT OrderDate, sum(TotalAmount) FROM local_store_project_23.orders where OrderDate between @fromDate and @toDate group by orders.OrderDate  ;";
                    cmd.Parameters.Add("@fromDate", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = startDate;
                    cmd.Parameters.Add("@toDate", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = endDate;
                    var resultList = new List<KeyValuePair<DateTime, decimal>>();
                    MySqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        resultList.Add(new KeyValuePair<DateTime, decimal>(Convert.ToDateTime(rd[0]), Convert.ToDecimal(rd[1])));
                        TotalRevenue += Convert.ToDecimal(rd[1]);
                    }
                    TotalProfit = TotalRevenue * 0.27m; //27% -a a bruttó bevételnek
                    rd.Close();

                    if (numberDays <= 1)
                    {
                        GrossRevenueList = (from orderList in resultList
                                            group orderList by orderList.Key.ToString("HH:mm")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }

                    //Group by Days
                    else if (numberDays <= 30)
                    {
                        GrossRevenueList = (from orderList in resultList
                                            group orderList by orderList.Key.ToString("MMM dd")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                    //Group by Weeks
                    else if (numberDays <= 92)
                    {
                        GrossRevenueList = (from orderList in resultList
                                            group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                                orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = "Week " + order.Key.ToString(),
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                    //Group by Months
                    else if (numberDays <= (365 * 2))
                    {
                        bool isYear = numberDays <= 365 ? true : false;
                        GrossRevenueList = (from orderList in resultList
                                            group orderList by orderList.Key.ToString("yyyy MMM")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                    //Group by Years
                    else
                    {
                        GrossRevenueList = (from orderList in resultList
                                            group orderList by orderList.Key.ToString("yyyy")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                }
                //conn.Close();
            }

        }
        private void getProductsAnalisys()
        {
            TopProductsList = new List<KeyValuePair<string, int>>();
            UnderstockList = new List<KeyValuePair<string, int>>();

            using (var conn = getConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    MySqlDataReader rd;
                    cmd.Connection = conn;
                    // Top 5 termék
                    cmd.CommandText = "SELECT products.ProductName, sum(order_items.Quantity) as Q  FROM local_store_project_23.order_items,products,orders where products.id = order_items.ProductId and orders.id = order_items.OrderId and date(orders.OrderDate) between @fromDate and @toDate group by products.ProductName order by Q desc limit 5;";
                    cmd.Parameters.Add("@fromDate", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = startDate;
                    cmd.Parameters.Add("@toDate", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = endDate;
                    rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        TopProductsList.Add(new KeyValuePair<string, int>(rd[0].ToString(), Convert.ToInt32(rd[1])));
                    }
                    rd.Close();

                    //Készlethiányos termékek
                    cmd.CommandText = "SELECT ProductName, Stock FROM local_store_project_23.products where stock <= 6;";
                    rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        UnderstockList.Add(new KeyValuePair<string, int>(rd[0].ToString(), Convert.ToInt32(rd[1])));
                    }
                    rd.Close();
                }
                //conn.Close(); -> using state miatt autómatikusan lezárja a kapcsolatot.
            }
        }

        public void LoadData(DateTime startDate, DateTime endDate)
        {
            this.startDate = startDate;
            this.endDate = endDate;
            this.numberDays = (endDate - startDate).Days;

            getTotalNumberItems();
            getProductsAnalisys();
            getOrdersAnalisys();
        }
    }
}
