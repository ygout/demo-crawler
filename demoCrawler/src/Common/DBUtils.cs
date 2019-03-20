using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace demoCrawler.src.Common
{
    class DbUtils
    {
        public static MySqlConnection GetDbConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "crawlerdemo";
            string username = "root";
            string password = "root";

            return DbMySqlUtils.GetDbConnection(host, port, database, username, password);
        }
    }
}
