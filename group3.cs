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
    public partial class group3 : Form
    {
        public group3()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            home a = new home();
            a.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           




        }

        private void button2_Click(object sender, EventArgs e)
        {
            int o = int.Parse(income.Text);
            int oo = int.Parse(bonus.Text);
            int total;
            total = (o * 12) + oo;
            ttotal.Text = total.ToString();

            

            int study = int.Parse(UpDown1.Text);
            int government = int.Parse(UpDown2.Text);
            int sport = int.Parse(UpDown3.Text);
            int public1 = int.Parse(UpDown4.Text);
            int pabuk = int.Parse(UpDown5.Text);
            int general= int.Parse(UpDown6.Text);
            int politics = int.Parse(UpDown7.Text);
            int to = int.Parse(ttotal.Text);//รายได้พึงประะเมิน
            int a1;
            int a2;
            int a3;
            int a4;
            int a5;
            int a6;
            int a7;
            int tot;//บริจาค
            //int taxtotal;//สามารถลดหย่อนได้ 

            a1 = (study * 2);
            textBox11.Text = a1.ToString();
            a2 = (government * 2);
            textBox12.Text = a2.ToString();
            a3 = (sport * 2);
            textBox13.Text = a3.ToString();
            a4 = (public1 * 2);
            textBox14.Text = a4.ToString();
            a5 = pabuk;
            textBox15.Text = a5.ToString();
            a6 = general;
            textBox16.Text = a6.ToString();
            a7 = politics;
            textBox17.Text = a7.ToString();
            tot = (a1 + a2 + a3 + a4 + a5 + a6 + a7);//บริจาค
            all.Text = tot.ToString();

            int al = int.Parse(all.Text);
            total = to - al;//รายได้สุทธิ = รายได้พึงประเมิน-ภาษีที่ลดหย่อนได้
            bl.Text = total.ToString();

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        
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

        private void next_Click(object sender, EventArgs e)
        {
            this.Hide();
            group5 a = new group5();
            a.textBox99.Text = textBox99.Text;
            a.income.Text = income.Text;
            a.bonus.Text = bonus.Text;
            a.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int qq = int.Parse(bl.Text);
            int qqq = int.Parse(textBox99.Text);
            int at;
            at = qq - qqq;
            after.Text = at.ToString();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int xo = int.Parse(after.Text);

            int xi;
            xi = (xo * 10) / 100;

            totaltax.Text = xi.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
