using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace demoCrawler.src.Common
{
    class DbMySqlUtils
    {
        public static MySqlConnection GetDbConnection(string host, int port, string database, string username, string password)
        {
            // Connection String
            String connString = $"Server={host}; Database={database}; port={port}; User Id={username}; password={password}";

            return new MySqlConnection(connString);
        }
    }
}
