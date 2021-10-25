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
        data_connectionclass dc = new data_connectionclass();

        //password checking
        void check_pwd()
        {
            try
            {
                if (txt_password.Text == txt_confirm_password.Text && txt_password.Text != "" && txt_name.Text != "" && txt_email.Text != "" && txt_phone.Text != "")
                {

                    lb_wrongpassword.Text = "";
                    user_info();
                    Login log = new Login();
                    log.Show();
                    this.Hide();
                }
                else
                {
                    lb_wrongpassword.Text = "Wrong Password";
                }
            }catch(Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        //mysql server information 
        string query;
        MySqlDataAdapter adapter = new MySqlDataAdapter();

        void user_info()
        {
            try
            {
                string name = txt_name.Text;
                string email = txt_email.Text;
                string phone = txt_phone.Text;
                string password = txt_password.Text;
                string cmf_pwd = txt_confirm_password.Text;
                //data encryption   caesar cipher  hello  khoor  3  
                password = Encipher(password, 3);
                cmf_pwd = Encipher(cmf_pwd, 3);
                //insert query   db=kbtc table=user_info
                dc.connect_to_server();

                query = "insert into user_info(name,email,phone,password,confirm_password) " +
                    "values('" + name + "','" + email + "','" + phone + "','" + password + "','" + cmf_pwd + "')";
                adapter.InsertCommand = new MySqlCommand(query, dc.connection);
                adapter.InsertCommand.ExecuteNonQuery();

                dc.connection.Close();
            }catch(Exception m)
            {
                MessageBox.Show(m.Message);
            }
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
            if (character_of_gmail()== true)
            {
                check_pwd();//to do update  change void function to bool function
            }
            else
            {
                MessageBox.Show("you need to check gmail have '@gmail.com' or not ");
            }
            

        }

        private void llb_already_account_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        public bool character_of_gmail()
        {
            bool rt_data = false;
            try
            {
                
                string data = "";
                string email = txt_email.Text;
                int len = email.Length;
                len -= 10;
                for (; len < email.Length; len++)
                {
                    data += email[len];
                }
                //left update for perfect mail
                if (data == "@gmail.com")
                {
                    rt_data = true;
                }
            }catch(Exception m)
            {
                MessageBox.Show(m.Message);
            }
            return rt_data;
        }

    }
}
