﻿namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.x = new System.Windows.Forms.TextBox();
            this.y = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.e5 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.f = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.g = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // x
            // 
            this.x.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.x.Location = new System.Drawing.Point(12, 48);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(220, 26);
            this.x.TabIndex = 0;
            this.x.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // y
            // 
            this.y.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.y.Location = new System.Drawing.Point(248, 48);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(220, 26);
            this.y.TabIndex = 1;
            // 
            // total
            // 
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.total.Location = new System.Drawing.Point(568, 48);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(220, 26);
            this.total.TabIndex = 2;
            this.total.TextChanged += new System.EventHandler(this.total_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(487, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "รวม";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "เงินเดือน";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "โบนัสและอื่นๆ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "รายได้ทั้งหมด";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox1.ForeColor = System.Drawing.Color.Crimson;
            this.checkBox1.Location = new System.Drawing.Point(12, 110);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 24);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "ประกันสังคม";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox2.ForeColor = System.Drawing.Color.Crimson;
            this.checkBox2.Location = new System.Drawing.Point(199, 110);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(140, 24);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "เบี้ยประกันสังคม";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox3.ForeColor = System.Drawing.Color.Crimson;
            this.checkBox3.Location = new System.Drawing.Point(388, 110);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(149, 24);
            this.checkBox3.TabIndex = 9;
            this.checkBox3.Text = "เบี้ยประกันสุขภาพ";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox4.ForeColor = System.Drawing.Color.Crimson;
            this.checkBox4.Location = new System.Drawing.Point(568, 110);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(222, 24);
            this.checkBox4.TabIndex = 10;
            this.checkBox4.Text = "เบี้ยประกันสุขภาพบิดามารดา";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox5.ForeColor = System.Drawing.Color.Crimson;
            this.checkBox5.Location = new System.Drawing.Point(12, 208);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(152, 24);
            this.checkBox5.TabIndex = 11;
            this.checkBox5.Text = "ประกันชีวิตคู่สมรส";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox6.ForeColor = System.Drawing.Color.Crimson;
            this.checkBox6.Location = new System.Drawing.Point(199, 208);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(197, 24);
            this.checkBox6.TabIndex = 12;
            this.checkBox6.Text = "เงินกองทุนสำรองเลี้ยงชีพ";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox7.ForeColor = System.Drawing.Color.Crimson;
            this.checkBox7.Location = new System.Drawing.Point(401, 208);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(179, 24);
            this.checkBox7.TabIndex = 13;
            this.checkBox7.Text = "เงินสะสมกองทุน กบข.";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "จ่ายจริง";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "จ่ายจริง";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "จ่ายจริง";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(565, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "จ่ายจริง";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "จ่ายจริง";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(202, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "จ่ายจริง";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(401, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "จ่ายจริง";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(66, 135);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 21;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(254, 138);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 22;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(440, 137);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 23;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(619, 137);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 24;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(66, 245);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 22);
            this.textBox8.TabIndex = 25;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(257, 245);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 22);
            this.textBox9.TabIndex = 26;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(456, 245);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 22);
            this.textBox10.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "ลดหย่อนได้";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(96, 168);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(0, 17);
            this.a.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(202, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 17);
            this.label13.TabIndex = 30;
            this.label13.Text = "ลดหย่อนได้";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(279, 167);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(0, 17);
            this.b.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(388, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 17);
            this.label12.TabIndex = 32;
            this.label12.Text = "ลดหย่อนได้";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(465, 166);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(0, 17);
            this.c.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(568, 166);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 17);
            this.label14.TabIndex = 34;
            this.label14.Text = "ลดหย่อนได้";
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(645, 168);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(0, 17);
            this.d.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 281);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 17);
            this.label15.TabIndex = 36;
            this.label15.Text = "ลดหย่อนได้";
            // 
            // e5
            // 
            this.e5.AutoSize = true;
            this.e5.Location = new System.Drawing.Point(89, 281);
            this.e5.Name = "e5";
            this.e5.Size = new System.Drawing.Size(0, 17);
            this.e5.TabIndex = 37;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(199, 281);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 17);
            this.label16.TabIndex = 38;
            this.label16.Text = "ลดหย่อนได้";
            // 
            // f
            // 
            this.f.AutoSize = true;
            this.f.Location = new System.Drawing.Point(276, 281);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(0, 17);
            this.f.TabIndex = 39;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(401, 280);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 17);
            this.label17.TabIndex = 40;
            this.label17.Text = "ลดหย่อนได้";
            // 
            // g
            // 
            this.g.AutoSize = true;
            this.g.Location = new System.Drawing.Point(478, 280);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(0, 17);
            this.g.TabIndex = 41;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button2.Location = new System.Drawing.Point(634, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 41);
            this.button2.TabIndex = 42;
            this.button2.Text = "check";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox11.Location = new System.Drawing.Point(511, 336);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(277, 36);
            this.textBox11.TabIndex = 43;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label18.Location = new System.Drawing.Point(564, 313);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(173, 20);
            this.label18.TabIndex = 44;
            this.label18.Text = "ภาษีที่ลดหย่อนได้ทั้งหมด";
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.YellowGreen;
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox12.Location = new System.Drawing.Point(33, 414);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(279, 36);
            this.textBox12.TabIndex = 45;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label19.Location = new System.Drawing.Point(119, 391);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 20);
            this.label19.TabIndex = 46;
            this.label19.Text = "รายได้สุทธิ";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button3.Location = new System.Drawing.Point(351, 413);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 37);
            this.button3.TabIndex = 47;
            this.button3.Text = "pay total";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.g);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.f);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.e5);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.d);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.c);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.b);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.total);
            this.Controls.Add(this.y);
            this.Controls.Add(this.x);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox x;
        private System.Windows.Forms.TextBox y;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label e5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label f;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label g;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button3;
    }
}

