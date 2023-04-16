using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Streltsov_DZ3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal x = decimal.Parse(textBox1.Text);
            decimal y = decimal.Parse(textBox2.Text);

            if (radioButton1.Checked)
            {
                label1.Text = (5 * x + 10 / y).ToString();
            }
            else if (radioButton2.Checked)
            {
                label1.Text = (3 * (x * x) + y + 3).ToString();
            }
            else if (radioButton3.Checked)
            {
                label1.Text = ((x + 10 * y) / 3).ToString();
            }
        }
    }
}
