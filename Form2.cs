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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                groupBox1.Enabled = false;
            }
            else
            {
                groupBox1.Enabled = true;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 cen = new Form1();
            cen.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
      

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                groupBox1.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int o = int.Parse(numericUpDown3.Text);
            int t = int.Parse(numericUpDown4.Text);
            int b = int.Parse(numericUpDown1.Text);
            int i = int.Parse(numericUpDown2.Text);
            int sum = int.Parse(textsum.Text);
            int a = 0;
            int c = 0;
            int d = 0;
            int ex = 0;
            int f = 0;
            int outcome1;
            int outcome3;
            if (radioButton5.Checked == true)
            {
                a = a + 60000;
            }
            if (checkBox1.Checked == true)
            {
                c = c + 30000;
            }
            if (checkBox2.Checked == true)
            {
                d = d + 30000;
            }
            if (checkBox3.Checked == true)
            {
                ex = ex + 30000;
            }
            if (checkBox4.Checked == true)
            {
                f = f + 30000;
            }

            o = o * 30000;
            t = t * 60000;
            i = i * 60000;
            {
                outcome1 = o + t + b + i + a + c + d + ex + f;
                textBox5.Text = outcome1.ToString();
                outcome3 = sum - (o + t + b + i + a + c + d + ex + f);
                textBox6.Text = outcome3.ToString();
            }
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 two = new Form3();
            two.textsum.Text = textBox6.Text;
            two.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
