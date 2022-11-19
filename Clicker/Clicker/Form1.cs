using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker
{
    public partial class Form1 : Form
    {
        public int multi = 1;
        public int cristals = 100;
        public int clicks = 0;
        public int money = 1;
        public int level = 1;
        public Form1()
        {
            InitializeComponent();
            label1.Text = $"{money}$";
            label2.Text = $"Level:{level}";
            label3.Text = $" {100}$";
            label4.Text = $"clicks: {clicks}";
            label6.Text = $"{cristals}";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            clicks= clicks + multi;
            label4.Text = $"clicks: {clicks}";
            money= money + multi;
            label1.Text = $"{money}$";
        }
        private void button2_Click(object sender, EventArgs e)
        {   
            if (level == 1)
            { 
              if (money >= 100)
              {
                money = money - 100;
                label1.Text = $"{money}$";
                pictureBox1.Size = new System.Drawing.Size(206,217);
                pictureBox1.Image = Properties.Resources._2222742_front_home_house_view_building_icon__1_;
                level = level + 1;
                label2.Text = $"Level:{level}";
                label3.Text = $"{1000}$";
                cristals = cristals + 100;
                label6.Text = $"{cristals}";

                }
            }
           else if (level == 2)
           {
                if(money >= 1000)
                { 
                 money = money - 1000;
                 label1.Text = $"{money}$";
                 pictureBox1.Size = new System.Drawing.Size(206, 195);
                 pictureBox1.Image = Properties.Resources._2222737_and_garage_home_house_estate_icon;
                 level = level + 1;
                 label2.Text = $"Level:{level}";
                 label3.Text = $"{10000}$";
                 cristals = cristals + 100;
                 label6.Text = $"{cristals}";
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (cristals >= 300 )
            {
                multi = multi + 1;
                cristals = cristals - 300;
                label6.Text = $"{cristals}";
            }
        }
    }
}
