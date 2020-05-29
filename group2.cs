using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        private void total_TextChanged(object sender, EventArgs e)
        {

        }

        private void group1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                checkBox5.Enabled = false;
                updown5.Enabled = false;
            }
            else
            {
                checkBox5.Enabled = true;
                updown5.Enabled = true;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
        }






        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                checkBox5.Enabled = false;
                updown5.Enabled = false;
            }
            else
            {
                checkBox5.Enabled = true;
                updown5.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            home a = new home();
            a.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            uint inc = uint.Parse(income.Text);
            uint bon = uint.Parse(bonus.Text);
            uint outcome;
            outcome = (inc * 12) + bon;
            total.Text = outcome.ToString();
            if (checkBox1.Checked)
            {

                int n1 = int.Parse(updown1.Text);

                if (n1 <= 9000)
                {
                    tax1.Text = n1.ToString();
                }
                else
                {
                    tax1.Text = "9000";
                }
            }
            if (checkBox2.Checked)
            {
                int n2 = int.Parse(updown2.Text);
                if (n2 <= 100000)
                {
                    tax2.Text = n2.ToString();
                }
                else
                {
                    tax2.Text = "100000";
                }
            }
            if (checkBox3.Checked)
            {
                int nn3 = int.Parse(tax2.Text);
                int nnn3;
                if (nn3 <= 100000)
                {
                    nnn3 = 100000 - nn3;
                    tax3.Text = nnn3.ToString();

                    if (nnn3 <= 15000)
                    {
                        tax3.Text = nnn3.ToString();
                    }
                    else
                    {
                        tax3.Text = "15000";
                    }
                }
            }
            if (checkBox4.Checked)
            {
                int n4 = int.Parse(updown5.Text);
                if (n4 <= 15000)
                {
                    tax4.Text = n4.ToString();
                }
                else
                {
                    tax4.Text = "15000";
                }
            }
            if (checkBox5.Checked)
            {
                int n5 = int.Parse(updown7.Text);
                if (n5 <= 15000)
                {
                    tax5.Text = n5.ToString();
                }
                else
                {
                    tax5.Text = "15000";
                }
            }
            if (checkBox6.Checked)
            {
                int n6 = int.Parse(updown6.Text);
                if (n6 <= 10000)
                {
                    tax6.Text = n6.ToString();
                }
                else
                {
                    tax6.Text = "10000";
                }
            }
            if (checkBox7.Checked)
            {
                int n7 = int.Parse(updown3.Text);
                if (n7 <= 500000)
                {
                    tax7.Text = n7.ToString();
                }
                else
                {
                    tax7.Text = "500000";
                }

            }
            int d;
            int x1 = int.Parse(tax1.Text);
            int x2 = int.Parse(tax2.Text);
            int x3 = int.Parse(tax3.Text);
            int x4 = int.Parse(tax4.Text);
            int x5 = int.Parse(tax5.Text);
            int x6 = int.Parse(tax6.Text);
            int x7 = int.Parse(tax7.Text);
            d = x1 + x2 + x3 + x4 + x5 + x6 + x7;
            totaltax.Text = d.ToString();

            

            int tt = int.Parse(total.Text);
            
            int ttt = int.Parse(totaltax.Text);
            int p;
            p = tt - ttt;
            bl.Text = p.ToString();

            
            
        }
        

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                checkBox5.Enabled = true;
                updown5.Enabled = true;
            }
            else
            {
                checkBox5.Enabled = false;
                updown5.Enabled = false;
            }
    }

        private void next_Click(object sender, EventArgs e)
        {
           this.Hide();
           group4 a = new group4();
           a.textBox98.Text = textBox99.Text;
            a.income.Text = income.Text;
            a.bonus.Text = bonus.Text;
            a.Show();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            int u = int.Parse(textBox99.Text);
            int uu = int.Parse(totaltax.Text);
            int sum;
            sum = u + uu;
            textBox99.Text = sum.ToString();
            totaltax.Clear();
        }
    }
}