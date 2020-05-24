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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 tree = new Form4();
            tree.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int t = int.Parse(textBox12.Text);
            int y = int.Parse(textBox11.Text);
            int p = int.Parse(numericUpDown1.Text);
            int outcome3;
            {
                outcome3 = t + y + p;
                textBox7.Text = outcome3.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int m = int.Parse(textsum.Text);
            int outcome1;
            {
                outcome1 = ((m * 10) / 100);
                textBox8.Text = outcome1.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ed = int.Parse(textBox1.Text);
            int s = int.Parse(textBox2.Text);
            int h = int.Parse(textBox3.Text);
            int p = int.Parse(textBox4.Text);
            int outcome2;
            {
                outcome2 = ((ed + s + h + p) * 2);
                textBox6.Text = outcome2.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int t1 = int.Parse(textBox6.Text);
            int t2 = int.Parse(textBox7.Text);
            int moneyten = int.Parse(textBox8.Text);
            int sum = int.Parse(textsum.Text);
            int outcome4;
            int outcomesum;
            int tan = 0;
            if ((t1 + t2) > moneyten)
            {
                tan = tan + moneyten;
            }
            else if ((t1 + t2) < moneyten)
            {
                tan = t1 + t2;
            }
            {
                outcome4 = tan;
                textBox9.Text = outcome4.ToString();
                outcomesum = sum - tan;
                textBox10.Text = outcomesum.ToString();
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 one = new Form8();
            one.textsum.Text = textBox10.Text;
            one.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }
    }
}
