using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Random;


namespace 數學及亂數功能展示
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rd = new Random();
        String str;

        private void btramdom1_Click(object sender, EventArgs e)
        {
            str = Convert.ToString(rd.Next(1, 50));
            str += "\r\n";
            txtoutput.Text += str;
            
        }

        private void btramdom2_Click(object sender, EventArgs e)
        {
            str = Convert.ToString(rd.Next(50, 100));
            str += "\r\n";
            txtoutput.Text += str;
        }

        private void btclean_Click(object sender, EventArgs e)
        {
            txtoutput.Text = "";
        }

        private void btramdom3_Click(object sender, EventArgs e)
        {
            str = Convert.ToString(rd.Next(100, 150));
            str += "\r\n";
            txtoutput.Text += str;
        }

        private void btsin_Click(object sender, EventArgs e)
        {
            str = Convert.ToString(Math.Sin(0.8));
            str += "\r\n";
            txtoutput.Text += str;
        }

        private void btcos_Click(object sender, EventArgs e)
        {
            str = Convert.ToString(Math.Cos(0.5));
            str += "\r\n";
            txtoutput.Text += str;
        }

        private void bttan_Click(object sender, EventArgs e)
        {
            str = Convert.ToString(Math.Tan(0.5));
            str += "\r\n";
            txtoutput.Text += str;
        }
    }
}
