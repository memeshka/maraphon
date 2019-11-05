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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan t = Program.start - DateTime.Now;
            label5.Text = t.Days.ToString() + " days, " +
                t.Hours.ToString() + " hours, " +
                t.Minutes.ToString() + " minutes";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 yyy = new Form1();
            yyy.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         //      if ((textBox1.Text == null) && (textBox2.Text == null))
          //       {
            string login;
            string pass;
            string role;

             string conn = "Data Source=127.0.0.1;Initial Catalog=g464_Iln_Ala;User ID = student;Password=student";

             string str = "SELECT [Email],[Password],[RoleId]  FROM [g464_Iln_Ala].[dbo].[User] where ([Email] = '" + textBox1.Text + "') and ([Password] = '" + textBox2.Text + "') ";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
             SqlDataReader rdr = cmd.ExecuteReader();
             while (rdr.Read() == true)
             {
                 login = rdr.GetString(0);
                 pass = rdr.GetString(1);
                 role = rdr.GetString(2);

              
                    
                     if ((textBox1.Text == login) && (textBox2.Text == pass))
                     {
                         this.Hide();
                         Form4 yyy = new Form4();
                         yyy.Show();
                     }
                     else MessageBox.Show("Неверный логин или пароль");
                 }
                 
          //   }
         //      else MessageBox.Show("Не заполнены поля");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 yyy = new Form1();
            yyy.Show();
        }
    }
    }
