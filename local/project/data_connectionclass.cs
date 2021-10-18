using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace project1.project
{
    
    class data_connectionclass
    {
        public string serverinfo = string.Format("server=localhost;uid=root;pwd=;database=kbtc"), query;
        public MySqlConnection connection = new MySqlConnection();
        public void connect_to_server()
        {
            connection = new MySqlConnection(serverinfo);
            connection.Open();
            MessageBox.Show("connection open");
        }
    }
}
