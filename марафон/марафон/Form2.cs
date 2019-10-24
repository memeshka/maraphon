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
    public partial class Form2 : Form
    {
        public class meow
    {
            public static string fyr1;
            public static string fyr2;
            public static string fyr3;
    }
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
                Close();
                Form1 yy = new Form1();
                yy.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan t = Program.start - DateTime.Now;
            label12.Text = t.Days.ToString() + " days, " +
                t.Hours.ToString() + " hours, " +
                t.Minutes.ToString() + " minutes";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g464_Iln_AlaDataSet.View_DisplayName' table. You can move, or remove it, as needed.
            this.view_DisplayNameTableAdapter.Fill(this.g464_Iln_AlaDataSet.View_DisplayName);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox7.Text) > 10)
            {
                int v = int.Parse(textBox7.Text);
                textBox7.Text = (v - 10).ToString();
                label13.Text = textBox7.Text + " $";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int v = int.Parse(textBox7.Text);
            textBox7.Text = (v + 10).ToString();
            label13.Text = textBox7.Text + " $";
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            label13.Text = textBox7.Text + " $";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Ваше имя" || textBox6.Text == "Владелец карты" || maskedTextBox4.Text == "1234 1234 1234 1234" || maskedTextBox1.Text == "123")
            {
                MessageBox.Show("Поля не заполнены!"); 
            }
            else
            {
        if ( maskedTextBox2.Text  != null && Convert.ToInt32(maskedTextBox2.Text) > 2018 && Convert.ToInt32(maskedTextBox2.Text) < 2100 )
        {
            if (maskedTextBox3.Text != null && Convert.ToInt32(maskedTextBox3.Text) < 13 && Convert.ToInt32(maskedTextBox3.Text) >= 1)
            {
                Close();
                Form3 yy = new Form3();
                yy.Show();
            }
            else
             { 
                 MessageBox.Show("Не действительная дата карты."); 
             }
        } 
             else 
            {
                string conn = "Data source=127.0.0.1;Initial Catalog=g464_Iln_Ala; User ID=student; Password=student";
                string str = "INSERT INTO [Sponsorship] ([SponsorName],[RegistrationId],[Amount]) VALUES ('" + textBox1.Text + "'," + comboBox1.SelectedValue + "," + textBox7.Text + ")";
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                con.Close();
                meow.fyr1 = textBox1.Text;
                meow.fyr2 = comboBox1.Text + "(" + comboBox1.SelectedValue + ")";
                meow.fyr3 = textBox7.Text;
                Close();
                Form3 yy = new Form3();
                yy.Show();  
            }
        }
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кошечки это круто! Мы лучшая организация.");
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
           textBox1.Text = "";
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            textBox6.Text = "";
        }

        private void maskedTextBox4_Enter(object sender, EventArgs e)
        {
            maskedTextBox4.Text = "";
        }

        private void maskedTextBox3_Enter(object sender, EventArgs e)
        {
            maskedTextBox3.Text = "";
        }

        private void maskedTextBox2_Enter(object sender, EventArgs e)
        {
            maskedTextBox2.Text = "";
        }

        private void maskedTextBox1_Enter(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
        }

   

   

  

   

   

    
      

     


   

 

     


     

 

 
    }
}
