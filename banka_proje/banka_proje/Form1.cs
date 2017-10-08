using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace banka_proje
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Kullanici where tc_kimlik='" + textBox1.Text + "'and sifre='" + textBox2.Text + "'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Form2 frm2 = new Form2();
               
                frm2.Show();
                this.Hide();
              

            }
            else
            {
                MessageBox.Show("yanlış giriş");
            }
        }
    }
}
