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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        //password checking
        void check_pwd()
        {
            if (txt_password.Text == txt_confirm_password.Text)
            {
                
                lb_wrongpassword.Text = "";
                user_info();
            }
            else
            {
                lb_wrongpassword.Text = "Wrong Password";
            }
        }

        //mysql server information 
        string serverinfo = string.Format("server=localhost;uid=root;pwd=;database=kbtc"),query;
        MySqlConnection connection;
        MySqlDataAdapter adapter = new MySqlDataAdapter();

        void user_info()
        {
            string name=txt_name.Text;
            string email=txt_email.Text;
            string phone=txt_phone.Text;
            string password = txt_password.Text;
            string cmf_pwd = txt_confirm_password.Text;
            //data encryption   caesar cipher  hello  khoor  3  
            password=Encipher(password, 3);
            cmf_pwd = Encipher(cmf_pwd, 3);
            //insert query   db=kbtc table=user_info
            connection = new MySqlConnection(serverinfo);
            connection.Open();

            query = "insert into user_info(name,email,phone,password,confirm_password) " +
                "values('"+name+"','"+email+"','"+phone+"','"+password+"','"+cmf_pwd+"')";
            adapter.InsertCommand = new MySqlCommand(query,connection);
            adapter.InsertCommand.ExecuteNonQuery();
            connection.Close();

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

        private void btn_register_Click(object sender, EventArgs e)
        {
            check_pwd();
        }
    }
}
