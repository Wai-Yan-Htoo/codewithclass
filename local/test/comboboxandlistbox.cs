using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1.test
{
    public partial class comboboxandlistbox : Form
    {
        public comboboxandlistbox()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem=="Semester I")
            {
                listBox1.Items.Add("Diploma in programming");
                listBox1.Items.Add("C++");
                listBox1.Items.Add("Python");
                listBox1.Items.Add("Java");
                listBox1.Items.Add("C#");
                listBox1.Items.Add("Database and Datastructure");
                
               
            }
            else
            {
               
                listBox1.Items.Add("Office solution development");
                listBox1.Items.Add("Object Oriented development and design");
                listBox1.Items.Add("Computing");
                listBox1.Items.Add("VB.net");
               
            }
          
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
