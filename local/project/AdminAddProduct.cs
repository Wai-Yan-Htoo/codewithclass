using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace project1.project
{
    public partial class AdminAddProduct : Form
    {
        public AdminAddProduct()
        {
            InitializeComponent();
        }
        data_connectionclass dc = new data_connectionclass();
        string query;
        MySqlDataAdapter adapter=new MySqlDataAdapter();
        private void btn_addproduct_Click(object sender, EventArgs e)
        {
            try
            {
                string name,  barcode;
                float price;
                name = txt_name.Text;
                price = int.Parse(txt_price.Text);
                barcode = txt_barcode.Text;

              
                //insert query   db=kbtc table=user_info
                dc.connect_to_server();

                query = "insert into addproduct(name,price,barcode) " +
                    "values('" + name + "','"+price+"','"+barcode+"')";
                adapter.InsertCommand = new MySqlCommand(query, dc.connection);
                adapter.InsertCommand.ExecuteNonQuery();

                dc.connection.Close();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }
    }
}




