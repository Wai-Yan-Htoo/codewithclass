using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1.test
{
    public partial class checkgmail : Form
    {
        public checkgmail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email="helloedu.mm.com";
            //"hello@gmail.com"=length
            int len=email.Length;
            string data = "";
            len -= 10;
            string same = "@gmail.com";
            for( ; len < email.Length; len++)
            {
                data += email[len];
            }
            if (data == same)
            {
                MessageBox.Show(data);
            }
            else
            {
                MessageBox.Show("invalid gmail");
            }
            
        }
    }
}
