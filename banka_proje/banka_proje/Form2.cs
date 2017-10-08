using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banka_proje
{
    public partial class Form2 : Form
    {
        
       
      
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
           this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("select * from Kullanici", cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                label4.Text = dr["hesap_numarasi"].ToString();
                label5.Text = dr["adi"].ToString();
                label6.Text = dr["soyadi"].ToString();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
