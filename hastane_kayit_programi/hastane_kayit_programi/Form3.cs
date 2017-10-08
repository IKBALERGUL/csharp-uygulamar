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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bag = ConfigurationManager.ConnectionStrings[1].ConnectionString;
            SqlConnection con = new SqlConnection(bag);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from hastalar where tc_no='" + textBox1.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox2.Text = dr["parola"].ToString();
                
            }
            con.Close();
           
        }
    }
}
