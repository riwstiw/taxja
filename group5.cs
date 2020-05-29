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
    public partial class group5 : Form
    {
        public group5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            home a = new home();
            a.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {
            int o = int.Parse(income.Text);
            int oo = int.Parse(bonus.Text);
            int total;
            total = (o * 12) + oo;
            ttotal.Text = total.ToString();

            
            int h = int.Parse(numericUpDown1.Text);
            int study = int.Parse(numericUpDown2.Text);
            int book = int.Parse(numericUpDown3.Text);
            int ot = int.Parse(numericUpDown4.Text);
            int travel1 = int.Parse(numericUpDown5.Text);
            int travel2 = int.Parse(numericUpDown6.Text);
            int home = int.Parse(numericUpDown7.Text);
            int car = int.Parse(numericUpDown8.Text);
            int tot = int.Parse(ttotal.Text);
            int tax;
            int i = 0;
            int j = 0;

            if ((travel1 + travel2) <= 20000)
            {
                i = (travel1 + travel2);
            }
            else if ((travel1 + travel2) > 20000)
            {
                i = 20000;
            }
            if ((home + car) < 100000)
            {
                j = (home + car);
            }
            else if ((home + car) > 100001)
            {
                j = 100000;
            }

            tax = h + study + book + ot + i + j;
            textBox5.Text = tax.ToString();
            label29.Text = tax.ToString();
            
            int tb99 = int.Parse(textBox99.Text);

            total = tot - tb99 - 100000;
            bl.Text = total.ToString();

            
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            int u = int.Parse(textBox99.Text);
            int uu = int.Parse(textBox5.Text);

            int sum;
            sum = u + uu;
            textBox99.Text = sum.ToString();

            textBox5.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int x = int.Parse(bl.Text);
            int qwerty;
            if (x > 5000000)
            {
                qwerty = (x * 35) / 100;
                pay.Text = qwerty.ToString() + "บาท";
            }
            else if (x >= 2000001)
            {
                qwerty = (x * 30) / 100;
                pay.Text = qwerty.ToString() + "บาท";
            }
            else if (x >= 1000001)
            {
                qwerty = (x * 25) / 100;
                pay.Text = qwerty.ToString() + "บาท";
            }
            else if (x >= 750001)
            {
                qwerty = (x * 20) / 100;
                pay.Text = qwerty.ToString() + "บาท";
            }
            else if (x >= 500001)
            {
                qwerty = (x * 15) / 100;
                pay.Text = qwerty.ToString() + "บาท";
            }
            else if (x >= 300001)
            {
                qwerty = (x * 10) / 100;
                pay.Text = qwerty.ToString() + "บาท";
            }
            else if (x >= 150001)
            {
                qwerty = (x * 5) / 100;
                pay.Text = qwerty.ToString() + "บาท";
            }
            else if (x <= 150000)
            {
                qwerty = (x * 0) / 100;
                pay.Text = qwerty.ToString() + "บาท";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            popup a = new popup();
            a.Show();
            this.Visible = true;
        }
    }
}
