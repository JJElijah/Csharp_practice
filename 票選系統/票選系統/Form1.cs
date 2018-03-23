using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 票選系統
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       int amount=0, iphone=0, htc=0, sony=0, samsung=0;
       bool isselected = false;

        private void button1_Click(object sender, EventArgs e)
        {
            
            

            if (rdhtc.Checked) {
                isselected = true;
                htc += 1;
                amount += 1;
                txthtc.Text = Convert.ToString(htc);
            }
            if (rdiphone.Checked)
            {
                isselected = true;
                iphone += 1;
                amount += 1;
                txtiphone.Text = Convert.ToString(iphone);
            }
            if (rdsamsung.Checked)
            {
                isselected = true;
                samsung += 1;
                amount += 1;
                txtsamsung.Text = Convert.ToString(samsung);
            }
            if (rdsony.Checked)
            {
                isselected = true;
                sony += 1;
                amount += 1;
                txtsony.Text = Convert.ToString(sony);
            }

            txtamount.Text = Convert.ToString(amount);

            if (!isselected) {
                MessageBox.Show("請選擇手機品牌", "提示視窗", MessageBoxButtons.OK);
            }
        }
    }
}
