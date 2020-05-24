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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 two = new Form7();
            two.textsum.Text = textBox13.Text;
            two.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                groupBox2.Enabled = false;
            }
            else
            {
                groupBox2.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                groupBox1.Enabled = false;
            }
            else
            {
                groupBox1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pp58 = int.Parse(numericUpDown2.Text);
            int thome = int.Parse(numericUpDown1.Text);
            int outcome58;
            int outcome4;
            int outcomefinal58;
            int outcomesum;
            int sum = int.Parse(textsum.Text);
            {
                outcome58 = (pp58 * 20) / 100;
                textBox3.Text = outcome58.ToString();
                outcome4 = (outcome58 * 20) / 100;
                textBox1.Text = outcome4.ToString();
                outcomefinal58 = (thome + outcome4);
                textBox11.Text = outcomefinal58.ToString();
                outcomesum = sum - (thome + outcome4);
                textBox13.Text = outcomesum.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int pp = int.Parse(numericUpDown3.Text);
            int thome = int.Parse(numericUpDown1.Text);
            int outcome62;
            int sum = int.Parse(textsum.Text);
            int outcomefinal62;
            int outcomesum;
            int z = 0;
            if (pp <= 5000000)
            {
                z = 200000;
            }
            else if (pp > 5000000)
            {
                z = 200000;
            }
            else if (pp < 200000)
            {
                z = pp;
            }
            outcome62 = z;
            textBox5.Text = outcome62.ToString();
            outcomefinal62 = thome + z;
            textBox11.Text = outcomefinal62.ToString();
            outcomesum = sum - (thome + z);
            textBox13.Text = outcomesum.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 two = new Form3();
            two.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }
    }
}
