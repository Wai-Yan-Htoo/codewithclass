using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = txt_name;
            txt_name.Focus();
        }

        private void btn_click_Click(object sender, EventArgs e)
        {//  positoin             1         2         3                                4
            string name = txt_name.Text;
            string phno=txt_phno.Text;

            //datatype
            List<string> lnnpn = new List<string>();
            lnnpn.Add($"{name}{phno}");
            //MessageBox.Show(lnnpn[0]);

            ArrayList arr=new ArrayList();
            arr.Add(name);
            arr.Add(phno);

            var cities = new Dictionary<int, string>(){
            {1, "London, Manchester, Birmingham"},
            {2, "Chicago, New York, Washington"},
            {3, "Mumbai, New Delhi, Pune"}
            };
            //MessageBox.Show(cities[3]);

            //tuple
            var star = Tuple.Create("twinkle", "twinkle little star");
           // MessageBox.Show(star.Item1);
            /*
            try :                          try{ }
               possible error
            except:                         catch {}
                error come
            else:                          throw{}
                 no error
            finally:                         finally{}
                 whatever
             */

            //int.Parse()  
            try
            {
             var age = int.Parse(txt_age.Text);
                if (age < 20)
                {
                    MessageBox.Show("hello boy");
                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
            
            
            //string interpolaion
            //MessageBox.Show($"{name} = {phno}","Title",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);//show(" definition ","title","button"," icon ")
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            try
            {
                //where we use this (ctrl+o) file open function we can use file open function like notepad
                string file_name=txt_name.Text.ToLower();
                
                MessageBox.Show(file_name);
                if (file_name == "hello")
                {
                    Process.Start("notepad.exe", "C:\\src\\csharp\\dotnet\\project1\\hello.txt");
                }
                else if(file_name=="program")
                {
                    Process.Start("notepad.exe", "C:\\src\\csharp\\dotnet\\project1\\Program.cs");
                }
                txt_name.Clear();                
                
                /*FileStream fileopen = new FileStream("C:\\src\\csharp\\dotnet\\project1\\hello.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fileopen);
              
                string str = " hello hi hi hello";
                sw.WriteLine(str);
                sw.Flush();*/
                MessageBox.Show("success");
            }
            catch(Exception m)
            {
                MessageBox.Show(m.Message);
            }
            
        }

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            //     list          asccii  
            if (e.KeyCode == Keys.Enter)
            {
                //focus()
                txt_phno.Focus();
            }
        }

        private void txt_phno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_age.Focus();
            }
            
        }

        private void txt_age_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_password.Focus();
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_open.PerformClick();
            }
        }

        /*private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_phno.Focus();
            }
        }

        private void txt_phno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_age.Focus();
            }
        }

        private void txt_age_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_password.Focus();
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_open.PerformClick();
            }
        }*/
    }
}
