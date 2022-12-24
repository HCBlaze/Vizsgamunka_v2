using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;

namespace Asztali_alkalmazas.Classes
{
    internal class DbConnection
    {
        private readonly string _connectionString;

        public string getConnectionString()
        {
            setConnStr();
            string connStr = _getConnection();
            return connStr;
        }
        private void setConnStr()
        {
            if (!File.Exists("connectionString.txt"))
            {
                string fajl = "connectionString.txt";
                StreamWriter iras = new StreamWriter(fajl, false, Encoding.UTF8);
                iras.WriteLine("server = localhost; port = 3306; database = local_store_project_23; user = root;");
                iras.Close();
            }
            else
            {
                Console.WriteLine("Létezik");
            }
        }
        private string _getConnection()
        {
            string connStr = "";
            string adat = "connectionString.txt";
            StreamReader olvas = new StreamReader(adat, Encoding.UTF8);
            while (!olvas.EndOfStream)
            {
                connStr = olvas.ReadLine();
            }
            olvas.Close();
            return connStr;
        }
            public DbConnection()
        {
            _connectionString = getConnectionString();
        }

        protected MySqlConnection getConnection()
        {
            return new MySqlConnection(_connectionString);
        }
    }
}
