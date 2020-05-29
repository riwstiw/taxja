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
    public partial class group4 : Form
    {
        public group4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            home a = new home();
            a.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox2.Enabled = false;
            }
            else
            {
                groupBox2.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                groupBox1.Enabled = false;
            }
            else
            {
                groupBox1.Enabled = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void home_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int o = int.Parse(income.Text);
            int oo = int.Parse(bonus.Text);
            int total;
            total = (o * 12) + oo;
            ttotal.Text = total.ToString();

            int n7 = int.Parse(UpDown2.Text);//ราคาบ้าน
            int xi = (n7 * 20) / 100;

            taxpay.Text = xi.ToString();
            
            int xxx = int.Parse(taxpay.Text);
            int xx = xxx / 5;
            totaltax1.Text = xx.ToString();

            int tt = int.Parse(ttotal.Text);
            //int po1 = int.Parse(payout.Text);
            int ttt = int.Parse(totaltax1.Text);
            int p;
            p = tt - ttt;
            bl.Text = p.ToString();

            
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int o = int.Parse(income.Text);
            int oo = int.Parse(bonus.Text);
            
            int total;
            total = (o * 12) + oo;
            ttotal.Text = total.ToString();

            //int dh = int.Parse(home.Text);
            int n7 = int.Parse(UpDown1.Text);//ราคาบ้าน
            int xi = n7;

            if (xi <= 200000)
            {
                totaltax2.Text = xi.ToString();
            }
            else
            {
                totaltax2.Text = "200000";
            }

            int tt = int.Parse(ttotal.Text);
            int ttt = int.Parse(totaltax2.Text);
            
            int p;
            p = tt - ttt;
            bl.Text = p.ToString();

            
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                int u = int.Parse(textBox98.Text);
                int uu = int.Parse(all.Text);
                int sum;
                sum = u + uu;
                textBox98.Text = sum.ToString();
                all.Clear();
            } 
            else if (radioButton2.Checked)
            {
                int u = int.Parse(textBox98.Text);
                int uu = int.Parse(all.Text);
                int sum;
                sum = u + uu;
                textBox98.Text = sum.ToString();
            }
                
        }

        private void next_Click(object sender, EventArgs e)
        {
            this.Hide();
            group3 a = new group3();
            a.textBox99.Text = textBox98.Text;
            a.income.Text = income.Text;
            a.bonus.Text = bonus.Text;
            a.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                int u = int.Parse(home.Text);
                int uu = int.Parse(totaltax1.Text);
                int sum;
                sum = u + uu;
                all.Text = sum.ToString();
            }
            else if (radioButton2.Checked)
            {
                int u = int.Parse(home.Text);
                int uu = int.Parse(totaltax2.Text);
                int sum;
                sum = u + uu;
                all.Text = sum.ToString();
            }
        }
    }
}
