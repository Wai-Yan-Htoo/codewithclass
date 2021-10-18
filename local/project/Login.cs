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

namespace project1.project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }
        MySqlDataReader reader;
        data_connectionclass dc = new data_connectionclass();

        /*bool check_name_password()
        {
            bool check=false;
            string data = "";
            string name = txt_name.Text;
            string password = txt_password.Text;
            password = Encipher(password, 3);
            //MessageBox.Show(password);
            string query = "select name,password from user_info where name='" + name + "' and password='" + password + "'";

            //string query = "select name,password from user_info";
            dc.connect_to_server();


            MySqlCommand command = new MySqlCommand(query, dc.connection);
            //MessageBox.Show(command.ToString());

            //  checking password for encipher
            //reader = command.ExecuteReader();
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    data += $"{reader.GetValue(0)} {reader.GetValue(1)}";

                }
                if (data == "")
                {
                    check = false;
                }
                else
                {
                  
                    check = true;
                }
                
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
            return check;
        }

        bool check_email_password()
        {
            bool check=false;
             string data = "";
            string email= txt_name.Text;
            string password=txt_password.Text;
            password = Encipher(password, 3);
            //MessageBox.Show(password);
            string query = "select email,password from user_info where email='" + email + "' and password='" + password + "'";
            
            //string query = "select name,password from user_info";
            dc.connect_to_server();
            

            MySqlCommand command = new MySqlCommand(query,dc.connection);
            //MessageBox.Show(command.ToString());

            //  checking password for encipher
            //reader = command.ExecuteReader();
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    data += $"{reader.GetValue(0)} {reader.GetValue(1)}";

                }
                if (data == "")
                {
                    check = false;
                }
                else
                {
                   
                    check = true;
                }
               
            }catch(Exception m)
            {
                MessageBox.Show(m.Message);
            }

            return check;
        }
        */

        private void btn_login_Click(object sender, EventArgs e)
        {
           
            string data = "";
            string name_email = txt_name.Text;
            string password = txt_password.Text;
            password = Encipher(password, 3);
            //MessageBox.Show(password);

            string query = "select name,email,password from user_info where name='"+name_email+"' or email='" + name_email + "' and password='" + password + "'";

            //string query = "select name,password from user_info";
            dc.connect_to_server();


            MySqlCommand command = new MySqlCommand(query, dc.connection);
            //MessageBox.Show(command.ToString());

            //checking password for encipher
            //reader = command.ExecuteReader();
            try
                {
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        data += $"{reader.GetValue(0)} {reader.GetValue(1)}";

                    }
                    if (data == "")
                    {
                    MessageBox.Show("login fail");
                    }
                    else
                    {
                    MessageBox.Show("login success");
                    }

                }
                catch (Exception m)
                {
                    MessageBox.Show(m.Message);
                }

            /*
               if(check_name_password()==true ||check_email_password()==true)
               {
                   MessageBox.Show("login success");
               }
               else
               {
                   MessageBox.Show("login fail");
               }
            */
        }
        public static char cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {

                return ch;
            }

            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);


        }

        public static string Encipher(string input, int key)
        {

            string output = string.Empty;

            foreach (char ch in input)
                output += cipher(ch, key);

            return output;
        }
    }
}
