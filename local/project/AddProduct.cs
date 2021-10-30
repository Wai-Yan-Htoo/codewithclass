using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1.project
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void btn_increase_Click(object sender, EventArgs e)
        {
            int quantity=int.Parse(txt_quantity.Text);
            quantity++;
            txt_quantity.Text= quantity.ToString();
        }

        private void btn_decrease_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(txt_quantity.Text);
            if (quantity >1)
            {
                quantity--;
            }
            else{
                quantity=1;
            }
            
            txt_quantity.Text = quantity.ToString();
        }

        private void btn_buynow_Click(object sender, EventArgs e)
        {
            float dell_xps = 1600.0f;
            int quantity=int.Parse(txt_quantity.Text);
            float total_ammount = dell_xps * quantity;
            MessageBox.Show($"Total Ammount = {total_ammount}");
        }
    }
}
