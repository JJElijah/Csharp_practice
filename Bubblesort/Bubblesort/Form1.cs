using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bubblesort
{
    public partial class Form1 : Form
    {
        int[] num_array = new int[5];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int temp = 0;
            
            num_array[0] = Convert.ToInt32(txt1.Text);
            num_array[1] = Convert.ToInt32(txt2.Text);
            num_array[2] = Convert.ToInt32(txt3.Text);
            num_array[3] = Convert.ToInt32(txt4.Text);
            num_array[4] = Convert.ToInt32(txt5.Text);

            for (int i = num_array.Length-1; i >0 ; i--) {
                for (int j = 0; j  <= i-1; j++) {
                    if (num_array[j] < num_array[j + 1]) {
                        temp = num_array[j+1];
                        num_array[j+1] = num_array[j];
                        num_array[j] = temp;
                    }
                }
            }

            txtshow1.Text = Convert.ToString(num_array[0]);
            txtshow2.Text = Convert.ToString(num_array[1]);
            txtshow3.Text = Convert.ToString(num_array[2]);
            txtshow4.Text = Convert.ToString(num_array[3]);
            txtshow5.Text = Convert.ToString(num_array[4]);
        }
    }
}
