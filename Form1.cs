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
        int salary = 0, salaryvat = 0, vat = 0, Total = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void total_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x1 = int.Parse(x.Text);
            int y1 = int.Parse(y.Text);
            int outcome;
            outcome = (x1 * 12) + y1;
            total.Text = outcome.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                int a6 = int.Parse(textBox4.Text);
                if (a6 <= 9000)
                {
                    a.Text = a6.ToString();
                }
                else
                {
                    a.Text = "9000";
                }
            }
            if (checkBox2.Checked)
            {
                int bb = int.Parse(textBox5.Text);
                if (bb <= 100000)
                {
                    b.Text = bb.ToString();
                }
                else
                {
                    b.Text = "100000";
                }
            }
            if (checkBox3.Checked)
            {
                int cc = int.Parse(textBox6.Text);
                if (cc <= 15000)
                {
                    c.Text = cc.ToString();
                }
                else
                {
                    c.Text = "15000";
                }
            }
            if (checkBox4.Checked)
            {
                int dd = int.Parse(textBox7.Text);
                if (dd <= 15000)
                {
                    d.Text = dd.ToString();
                }
                else
                {
                    d.Text = "15000";
                }
            }
            if (checkBox5.Checked)
            {
                int pe = int.Parse(textBox8.Text);
                if (pe <= 10000)
                {
                    e5.Text = pe.ToString();
                }
                else
                {
                    e5.Text = "10000";
                }
            }
            if (checkBox6.Checked)
            {
                int ff = int.Parse(textBox9.Text);
                if (ff <= 10000)
                {
                    f.Text = ff.ToString();
                }
                else
                {
                    f.Text = "10000";
                }
            }
            if (checkBox7.Checked)
            {
                int gg = int.Parse(textBox10.Text);
                if (gg <= 500000)
                {
                    g.Text = gg.ToString();
                }
                else
                {
                    g.Text = "500000";
                }
            }
            int p;
            int aa = int.Parse(a.Text);
            int ab = int.Parse(b.Text);
            int ac = int.Parse(c.Text);
            int ad = int.Parse(d.Text);
            int ae = int.Parse(e5.Text);
            int af = int.Parse(f.Text);
            int ag = int.Parse(g.Text);
            p = aa + ab + ac + ad + ae + af + ag;
            textBox11.Text = p.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int salary = int.Parse(total.Text);
            int salaryvat;

            if (salary > 5000000)
            {
                vat = salary * 35 / 100;
            }
            else if (salary > 2000000)
            {
                vat = salary * 30 / 100;
            }
            else if (salary > 1000000)
            {
                vat = salary * 25 / 100;
            }
            else if (salary > 750000)
            {
                vat = salary * 20 / 100;
            }
            else if (salary > 500000)
            {
                vat = salary * 15 / 100;
            }
            else if (salary > 300000)
            {
                vat = salary * 10 / 100;
            }
            else if (salary > 150000)
            {
                vat = salary * 5 / 100;
            }
            else
            {
                vat = 0;
            }
            salaryvat = salary - vat;
            textBox12.Text = salaryvat.ToString();
        }
    }
}