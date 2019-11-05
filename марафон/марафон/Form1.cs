﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace марафон
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan t = Program.start - DateTime.Now;
            label1.Text = t.Days.ToString() + " days, " +
                t.Hours.ToString() + " hours, " +
                t.Minutes.ToString() + " minutes";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 yyy = new Form2();
            yyy.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 yyy = new Form4();
            yyy.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 yyy = new Form7();
            yyy.Show();
        }

 
    }
}
