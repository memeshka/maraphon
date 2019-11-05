using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 yyy = new Form4();
            yyy.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan t = Program.start - DateTime.Now;
            label3.Text = t.Days.ToString() + " days, " +
                t.Hours.ToString() + " hours, " +
                t.Minutes.ToString() + " minutes";
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string conn = "Data Source=127.0.0.1;Initial Catalog=g464_Iln_Ala;User ID = student;Password=student";

            int n =14;
            string name;
            string disc;
            string img;
            string fall;
                for (int i = 0; i < n; i++)
                {
                    string str = "SELECT [CharityName], [CharityDescription], [CharityLogo] FROM [g464_Iln_Ala].[dbo].[Charity] WHERE [CharityId] = " + (i+1);
                    SqlConnection con = new SqlConnection(conn);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read() == true)
                    {
                    name = rdr.GetString(0);
                    disc = rdr.GetString(1);
                    img = rdr.GetString(2);

                    fall = "C:/Users/user01/Desktop/464/марафон/jpg/"+img;
                            Image x = Image.FromFile(fall);
                         UserControl1 ctl = new UserControl1();
                        ctl.pictureBox1.Image = x;
                        ctl.label1.Text = name;
                        ctl.label2.Text = disc;
                         flowLayoutPanel1.Controls.Add(ctl);
                    }      
                }
        }

      
    }
}
