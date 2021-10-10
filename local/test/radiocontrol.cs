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
    public partial class radiocontrol : Form
    {
        public radiocontrol()
        {
            InitializeComponent();
        }

        int pan = 0;
        bool poin;

        private void btn_click_Click(object sender, EventArgs e)
        {

            int score = 0;
            if (pineapple() == true)
            {
                score += 1;
            }
            pan += 1;
           
            panel1.Show();
            if (secondpanel() == true)
            {
                score += 1;
            }
            lb_score.Text = score.ToString();
            

        }

        bool secondpanel()
        {
            if (rdbtn_red.Checked == true)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        bool pineapple()
        {
            
            if (rdbtn_workout.Checked == true)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            if (pan == 0)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
            }

        }

        private void panel_apple_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
