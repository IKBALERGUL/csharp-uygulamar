using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hastane_kayit_programi
{
    public partial class Form1 : Form
    {
        Form2 frm2 = new Form2();
        Form3 frm3 = new Form3();
        Form4 frm4 = new Form4();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            string baglantı = ConfigurationManager.ConnectionStrings[1].ConnectionString;
            SqlConnection con = new SqlConnection(baglantı);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From hastalar where tc_no='"+textBox1.Text+"'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                if (textBox1.Text.ToString() == dr["tc_no"].ToString())
                {
                    if (textBox2.Text.ToString() == dr["parola"].ToString())
                    {
                        frm4.Show();
                        this.Hide();

                        
                    }
                    else
                    {
                        MessageBox.Show("geçersiz tc kimlik numarası veya parola ");
                    }

                }
            }
            con.Close();
        
        }


        private void button3_Click(object sender, EventArgs e)
        {
            frm2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm3.Show();
            this.Hide();
        }
    }
}
