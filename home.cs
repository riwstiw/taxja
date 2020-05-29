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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            group1 a = new group1();
            a.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            group4 a = new group4();
            a.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            group3 a = new group3();
            a.Show();
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            group5 a = new group5();
            a.Show();
            this.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void next_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
