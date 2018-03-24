using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 字串搜尋及取代
{

    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        int index;
        private void btsearch_Click(object sender, EventArgs e)
        {
            
            index = txtinput.Text.IndexOf(txtsearch.Text);//字串位置索引

            if (index != -1) //找不到字串傳回-1
            {
                txtinput.SelectionStart = index;
                txtinput.SelectionLength = txtsearch.Text.Length;
                txtinput.Focus();
            }
            else {
                MessageBox.Show("無此字串", "顯示", MessageBoxButtons.OK);
            }
        }

        private void btreplace_Click(object sender, EventArgs e)
        {
            index = txtinput.Text.IndexOf(txtsearch.Text);//字串位置索引
            
            string str = txtinput.Text;
            string strleft = str.Substring(0, index);//取得左側字串
            string strright = str.Substring(index + txtreplace.Text.Length);//取得右側字串
            //substring(x) 從x位置開始到字串結尾

           
            txtinput.Text = strleft + txtreplace.Text + strright;
        }
    }
}
