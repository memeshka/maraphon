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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan t = Program.start - DateTime.Now;
            label3.Text = t.Days.ToString() + " days, " +
                t.Hours.ToString() + " hours, " +
                t.Minutes.ToString() + " minutes";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 yyy = new Form4();
            yyy.Show();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            pictureBox2.Show();
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            pictureBox2.Hide();
        }
    }
}
