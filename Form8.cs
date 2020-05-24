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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 complete = new Form9();
            complete.textsum.Text = textBox7.Text;
            complete.Show();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int nation = int.Parse(numericUpDown1.Text);
            int edusport = int.Parse(numericUpDown2.Text);
            int book = int.Parse(numericUpDown3.Text);
            int otop = int.Parse(numericUpDown10.Text);
            int travalmain = int.Parse(numericUpDown4.Text);
            int travalsecond = int.Parse(numericUpDown5.Text);
            int spendhouse1 = int.Parse(numericUpDown6.Text);
            int spendcar1 = int.Parse(numericUpDown7.Text);
            int spendhouse2 = int.Parse(numericUpDown8.Text);
            int spendcar2 = int.Parse(numericUpDown9.Text);
            int sum = int.Parse(textsum.Text);
            int a = 0;
            int b = 0;
            int c = 0;
            int outcome;
            int outcomesum;
            if ((travalmain + travalsecond) >= 20000)
            {
                a = 20000;
            }
            else if ((travalmain + travalsecond) < 20000)
            {
                a = travalmain + travalsecond;
            }
            if ((spendhouse1 + spendcar1) >= 100000)
            {
                b = 100000;
            }
            else if ((spendhouse1 + spendcar1) < 100000)
            {
                b = spendhouse1 + spendcar1;
            }
            if ((spendhouse2 + spendcar2) >= 100000)
            {
                c = 100000;
            }
            else if ((spendhouse2 + spendcar2) < 100000)
            {
                c = spendhouse2 + spendcar2;
            }
            {
                outcome = (nation + edusport + book + otop + a + b + c);
                textBox6.Text = outcome.ToString();
                outcomesum = (sum - (nation + edusport + book + otop + a + b + c));
                textBox7.Text = outcomesum.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 four = new Form7();
            four.Show();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
