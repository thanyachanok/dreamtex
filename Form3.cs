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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                numericUpDown5.Enabled = false;
            }
            else
            {
                numericUpDown5.Enabled = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                numericUpDown5.Enabled = false;
            }
            else
            {
                numericUpDown5.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                numericUpDown5.Enabled = true;
            }
            else
            {
                numericUpDown5.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
         

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(numericUpDown1.Text);
            int b = int.Parse(numericUpDown2.Text);
            int c = int.Parse(numericUpDown3.Text);
            int d = int.Parse(numericUpDown4.Text);
            int ea = int.Parse(numericUpDown5.Text);
            int f = int.Parse(numericUpDown6.Text);
            int n = int.Parse(numericUpDown7.Text);
            int sum = int.Parse(textsum.Text);
            int k = 0;
            int outcome;
            int outcome2;
            if ((b + c) > 100000)
            {
                k = 100000;
            }
            else if ((b + c) < 100000)
            {
                k = b + c;
            }

            {
                outcome = (a + k + d + ea + n + f);
                textBox5.Text = outcome.ToString();
                outcome2 = sum - (a + k + d + ea + n + f);
                textBox6.Text = outcome2.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 one = new Form2();
            one.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 two = new Form4();
            two.textsum.Text = textBox6.Text;
            two.Show();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
