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
using System.CodeDom;

namespace form_dersleri_bilgi_yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=ERCANMONSTER\\ERCANSERVER;Initial Catalog=sorularım;Integrated Security=True");
        int COUNTER = 0;
        int point = 0;
        int time = 21;
      /*  private void gorunurluluk()
        {
            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

        }*/
        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            time = 21;
            button1.BackColor = Color.Gray;
            button2.BackColor = Color.Gray;
            button3.BackColor = Color.Gray;
            button4.BackColor = Color.Gray;
            button5.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Text = "NEXT";
            COUNTER++;
            label4.Text = COUNTER.ToString();
            if (COUNTER == 1)
            {
                connect.Open();
                SqlCommand command = new SqlCommand("Select * from soru1 order by NEWID()", connect);
                SqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    button1.Text = (read["a"].ToString());
                    button2.Text = (read["b"].ToString());
                    button3.Text = (read["c"].ToString());
                    button4.Text = (read["d"].ToString());
                    label1.Text = (read["doğru"].ToString());
                    textBox1.Text = (read["soru"].ToString());



                }
                connect.Close();
            }
            if (COUNTER == 2)
            {
                connect.Open();
                SqlCommand command = new SqlCommand("Select * from soru2 order by NEWID()", connect);
                SqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    button1.Text = (read["a"].ToString());
                    button2.Text = (read["b"].ToString());
                    button3.Text = (read["c"].ToString());
                    button4.Text = (read["d"].ToString());
                    label1.Text = (read["doğru"].ToString());
                    textBox1.Text = (read["soru"].ToString());
                }
                connect.Close();
            }
            if (COUNTER == 3)
            {
                connect.Open();
                SqlCommand command = new SqlCommand("Select * from soru3 order by NEWID()", connect);
                SqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    button1.Text = (read["a"].ToString());
                    button2.Text = (read["b"].ToString());
                    button3.Text = (read["c"].ToString());
                    button4.Text = (read["d"].ToString());
                    label1.Text = (read["doğru"].ToString());
                    textBox1.Text = (read["soru"].ToString());
                }
                connect.Close();
            }
            if (COUNTER == 4)
            {
                connect.Open();
                SqlCommand command = new SqlCommand("Select * from soru4 order by NEWID()", connect);
                SqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    button1.Text = (read["a"].ToString());
                    button2.Text = (read["b"].ToString());
                    button3.Text = (read["c"].ToString());
                    button4.Text = (read["d"].ToString());
                    label1.Text = (read["doğru"].ToString());
                    textBox1.Text = (read["soru"].ToString());
                }
                connect.Close();
            }
            if (COUNTER == 5)
            {
                connect.Open();
                SqlCommand command = new SqlCommand("Select * from soru5 order by NEWID()",connect);
                SqlDataReader read =command.ExecuteReader();
                while (read.Read())
                {
                    button1.Text = (read["a"].ToString());
                    button2.Text = (read["b"].ToString());
                    button3.Text = (read["c"].ToString());
                    button4.Text = (read["d"].ToString());
                    label1.Text = (read["doğru"].ToString());
                    textBox1.Text = (read["soru"].ToString());
                }
                connect.Close();
            }
            if (COUNTER == 6)
            {
                connect.Open();
                SqlCommand command = new SqlCommand("Select * from soru6  order by NEWID()",connect);
                SqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    button1.Text = (read["a"].ToString());
                    button2.Text = (read["b"].ToString());
                    button3.Text = (read["c"].ToString());
                    button4.Text = (read["d"].ToString());
                    label1.Text = (read["doğru"].ToString());
                    textBox1.Text = (read["soru"].ToString());
                    
                }
                connect.Close();
            }
            if (COUNTER == 7)
            {
                connect.Open();
                button5.Text = "GAME OVER";
                button5.Enabled = false;

                SqlCommand command = new SqlCommand("Select * from soru7 order by NEWID()",connect);
                SqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    button1.Text = (read["a"].ToString());
                    button2.Text = (read["b"].ToString());
                    button3.Text = (read["c"].ToString());
                    button4.Text = (read["d"].ToString());
                    label1.Text = (read["doğru"].ToString());
                    textBox1.Text = (read["soru"].ToString());

                }
                connect.Close();
            }
            if (COUNTER == 8)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

            private void Form1_Load(object sender, EventArgs e)
            {
                label4.Text = COUNTER.ToString();

            }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == label1.Text)
            {
                point = point + 10;
                label3.Text = point.ToString();
                button1.BackColor = Color.DarkGreen;
            }
            else
            {
                button1.BackColor = Color.Red;
            }
            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == label1.Text)
            {
                point = point + 10;
                label3.Text = point.ToString();
                button3.BackColor = Color.DarkGreen;
            }
            else
            {
                button3.BackColor = Color.Red;
            }
            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == label1.Text)
            {
                point = point + 10;
                label3.Text = point.ToString();
                button2.BackColor = Color.DarkGreen;
            }
            else
            {
                button2.BackColor = Color.Red;
            }
            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == label1.Text)
            {
                point = point + 10;
                label3.Text = point.ToString();
                button4.BackColor = Color.DarkGreen;
            }
            else
            {
                button4.BackColor = Color.Red;

            }
            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time - 1;
            label6.Text = time.ToString();
            if (time == 0)
            {
                timer1.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }
    }
}
