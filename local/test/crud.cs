using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace project1.test
{
    public partial class crud : Form
    {

        public crud()
        {
            InitializeComponent();
        }

        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlConnection connection;
        MySqlCommand command;
        string serverinfo = string.Format("server=localhost;uid=root;pwd=;database=test12");

        private void btn_create_Click(object sender, EventArgs e)
        {
            
            string name = "Dell XPS 15";
            float price = 1300.0f;

            //we can work with database
           
            connection = new MySqlConnection(serverinfo);
            connection.Open();

            //mysqlcommand 
            string query = "insert into pcstore(brand_name,price) values('"+name+"','"+price+"')";
            //      work name
            adapter.InsertCommand= new MySqlCommand(query,connection);
            adapter.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("success data");

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //string serverinfo = string.Format("server=localhost;uid=root;pwd=;database=test12");
            connection = new MySqlConnection(serverinfo);
            connection.Open();

            //mysqlcommand 
            string query = "delete from pcstore where id=1";
            //      work name
            adapter.DeleteCommand = new MySqlCommand(query, connection);
            adapter.DeleteCommand.ExecuteNonQuery();
            MessageBox.Show("data deleted");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //string serverinfo = string.Format("server=localhost;uid=root;pwd=;database=test12");
            connection = new MySqlConnection(serverinfo);
            connection.Open();

            //mysqlcommand 
            string query = "update pcstore set price=2300 where brand_name='"+ "Dell XPS 15" + "'";
            //      work name
            adapter.UpdateCommand = new MySqlCommand(query, connection);
            adapter.UpdateCommand.ExecuteNonQuery();
            MessageBox.Show("data updated");
        }

        

        private void btn_read_Click(object sender, EventArgs e)
        {

            ArrayList data = new ArrayList();
            MySqlDataReader reader;
            string query = "select * from pcstore";
            connection = new MySqlConnection(serverinfo);
            connection.Open();
            
            command = new MySqlCommand(query,connection);
            

            DataTable dt;
            MySqlDataAdapter da;
            command.ExecuteNonQuery();
            dt = new DataTable();
            da = new MySqlDataAdapter(command);//
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;

        }
    }
}
