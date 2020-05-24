using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dreamtax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int m = int.Parse(textBox1.Text);
            int p = int.Parse(textBox2.Text);
            int other = int.Parse(textBox3.Text);
            int outcome;
            int sum = 0;
            if ((((m * 12) + p + other) * 50 / 100) > 100000)
            {
                sum = (((m * 12) + p + other) - 100000);
            }
            else if ((((m * 12) + p + other) * 50 / 100) <= 100000)
            {
                sum = ((m * 12) + p + other) * 50 / 100;
            }
            {
                outcome = sum;
                textBox4.Text = outcome.ToString();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 one = new Form2();
            one.textsum.Text = textBox4.Text;
            one.Show();
        }
    }
}
