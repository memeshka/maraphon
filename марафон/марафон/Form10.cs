using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace марафон
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 yyy = new Form1();
            yyy.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 yyy = new Form1();
            yyy.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan t = Program.start - DateTime.Now;
            label3.Text = t.Days.ToString() + " days, " +
                t.Hours.ToString() + " hours, " +
                t.Minutes.ToString() + " minutes";
        }

       
    }
}
