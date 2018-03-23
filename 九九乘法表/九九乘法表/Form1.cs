using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 九九乘法表
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j,result;
            string output="";

            for (i = 1; i <= 9; i++) {
                for (j = 1; j <= 9; j++) {
                    result = i * j;
                    output += i + "*" + j +"="+ result + "\r\n";//text控制項換行需用\r\n
                }
                output += "\r\n";
            }
            txtshow.Text = output;
        }
    }
}
