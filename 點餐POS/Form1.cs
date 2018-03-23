using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 點餐POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btcalm_Click(object sender, EventArgs e)
        {
            int totalprice=0;
            String str = "總計：";

            //主餐
            if (chkbeef.Checked) { totalprice += 75; }
            if (chkchicken.Checked) { totalprice += 70; }
            if (chkspizza.Checked) { totalprice += 250; }
            if (chkbpizza.Checked) { totalprice += 499; }

            //附餐
            if (chkfries.Checked)
            {
                if (rbsmallfries.Checked)
                {
                    totalprice += 25;
                }
                else
                {
                    totalprice += 35;
                }
            }

            //飲料
            if (chkdrink.Checked)
            {
                if (rbcola.Checked || rbblacktea.Checked)
                {
                    totalprice += 30;
                }
                else
                {
                    totalprice += 35;
                }
            }

            lbprice.Text = str+Convert.ToString(totalprice);
        }

        private void chkfries_CheckedChanged(object sender, EventArgs e)
        {
            if (chkfries.Checked)
            {
                rbsmallfries.Enabled = true;
                rbbigfries.Enabled = true;
            }
            else {
                rbsmallfries.Enabled = false;
                rbbigfries.Enabled = false;
            }
        }

        private void chkdrink_CheckedChanged(object sender, EventArgs e)
        {
            if (chkdrink.Checked)
            {
                rbcola.Enabled = true;
                rbcoffee.Enabled = true;
                rbblacktea.Enabled = true;
            }
            else
            {
                rbcola.Enabled = false;
                rbcoffee.Enabled = false;
                rbblacktea.Enabled = false;
            }
        }
    }
}
