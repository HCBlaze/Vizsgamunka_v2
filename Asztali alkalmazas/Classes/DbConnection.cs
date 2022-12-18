using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Asztali_alkalmazas.Classes
{
    internal class DbConnection
    {
        private readonly string _connectionString;

        public DbConnection()
        {
            _connectionString = "server=localhost;port=3306;database=local_store_project_23;user=root;";
        }

        protected MySqlConnection getConnection()
        {
            return new MySqlConnection(_connectionString);
        }
    }
}
