using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ICTO_IS
{
    class ConnectionString
    {
       public static MySqlConnection conn = null;
        public void Connection()
        {
            conn = new MySqlConnection("Data Source = localhost; Initial Catalog = inventoryicto; username = root; password = ''");
            conn.Open();
        }
    }
}
