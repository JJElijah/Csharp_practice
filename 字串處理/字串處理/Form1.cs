using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 字串處理
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void trim_check()
        {
            string[] str;
            if (chktrim.Checked)
            {
                str = txtoutput.Text.Split(' ');
                txtoutput.Text = null;
                for (int i = 0; i < str.Length; i++)
                {
                    txtoutput.Text += str[i];
                }

            }
        }

        private void btlength_Click(object sender, EventArgs e)
        {
            string str="長度為：";
            int length = txtoutput.Text.Length;
            str += Convert.ToString(length);
            MessageBox.Show(str, "顯示長度", MessageBoxButtons.OK);
        }

        private void btlower_Click(object sender, EventArgs e)
        {
            txtoutput.Text = txtinput.Text.ToLower();
            trim_check();
        }

        private void btupper_Click(object sender, EventArgs e)
        {
            txtoutput.Text = txtinput.Text.ToUpper();
            trim_check();

        }

        private void btfirstword_Click(object sender, EventArgs e)
        {
            int length = txtinput.Text.Length;
            String[] word_array= new String[length];
            word_array = txtinput.Text.Split(' ');
            txtoutput.Text = word_array[0].ToString();
        }

        private void txtinput_TextChanged(object sender, EventArgs e)
        {
            trim_check();
            txtoutput.Text = txtinput.Text.ToString();
        }

        private void chktrim_CheckedChanged(object sender, EventArgs e)
        {
            trim_check();
        }

        private void rb_hello_CheckedChanged(object sender, EventArgs e)
        {
            txtinput.Text = "HELLO WORLD";
            trim_check();
        }

        private void rb_pen_CheckedChanged(object sender, EventArgs e)
        {
            txtinput.Text = "this is a pen";
            trim_check();
        }

        private void rb_name_CheckedChanged(object sender, EventArgs e)
        {
            txtinput.Text = "My name is JJ";
            trim_check();
        }
    }
}
