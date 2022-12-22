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
            string connStr = _getConnection();
            return connStr;
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
