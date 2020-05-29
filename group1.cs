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
    public partial class group1 : Form
    {
        public group1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            home a = new home();
            a.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

       

        private void button3_Click(object sender, EventArgs e)//ภาษีที่ลดหย่อนได้
        {
            

            int x1 = int.Parse(income.Text);//เงินเดือน
            int z1 = int.Parse(bonus.Text);//โบนัส
            int total;
            total = (x1 * 12) + z1;
            textBox11.Text = total.ToString();//รายได้เพิงประเมิน



            int a1 = int.Parse(numericUpDown1.Text);//บุตรเกิดก่อน61
            int a2 = int.Parse(numericUpDown2.Text);//บุตรเกิดหลัง61
            int a3 = int.Parse(textBox2.Text);//ค่าฝากครรภ์
            int a4 = int.Parse(textBox3.Text);//อุปการะคนพิการ
            int a5; 
            int a6;
            int a7 = int.Parse(momdad.Text);
            int n = 0;
            int o = 0;
            int p = 0;
            //int q = 0;
            //int r = 0;
            int t;
            int s;


            
            if (checkBox10.Checked)//สมรสมีรายได้
            {
                n = 0;
            }
            if (checkBox11.Checked)//สมรสไม่มีรายได้
            {
                o = 60000;
            }
            if (checkBox1.Checked)//ไม่มีลูก
            {
                p = 0;
            }
            /*if (checkBox2.Checked)//เกิดก่อน
            {
                q = 30000;
            }
            if (checkBox3.Checked)//เกิดหลัง
            {
                r = 60000;  
            }*/
            
            a5 = a1 * 30000;//ก่อน   
            a6 = a2 * 60000;//หลัง
            t = a7 * 30000;//พ่อแม่
            s = a4 * 60000;//พิการ
            int tt = a3  + a5 + a6 +  n + o + p + t + s + 60000;
            textBox4.Text = tt.ToString();

            //int po = int.Parse(textBox11.Text);
            

            int b1 = int.Parse(textBox11.Text);//รายได้สุทธิ
            int b2 = int.Parse(textBox4.Text);
            int outcome;
            outcome = b1 - b2 ;
            textBox5.Text = outcome.ToString();
            
             
              
            }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            Form1 a = new Form1();
            a.textBox99.Text = textBox4.Text;
            a.income.Text = income.Text;
            a.bonus.Text = bonus.Text;
            a.Show();
            

            
        }
    }
}
