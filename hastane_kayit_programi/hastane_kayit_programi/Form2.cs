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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string b = ConfigurationManager.ConnectionStrings[1].ConnectionString;
            SqlConnection con = new SqlConnection(b);
            con.Open();
            SqlCommand komut =new SqlCommand("insert into hastalar(tc_no,ad,soyad,cinsiyet,d_yeri,d_tarihi,anne,baba,cep_tel,sabit_tel,mail,parola) values(@tc_kimlik,@ad,@soyad,@cinsiyet,@d_yeri,@d_tarihi,@anne_adi,@baba_adi,@c_tel,@s_tel,@e_mail,@parola)",con);
             komut.Parameters.AddWithValue("@tc_kimlik",textBox1.Text.ToString());
             komut.Parameters.AddWithValue("@ad",textBox2.Text.ToString());
             komut.Parameters.AddWithValue("@soyad",textBox3.Text.ToString());
             komut.Parameters.AddWithValue("@cinsiyet",textBox4.Text.ToString());
             komut.Parameters.AddWithValue("@d_yeri",textBox5.Text.ToString());
             komut.Parameters.AddWithValue("@d_tarihi",textBox6.Text.ToString());
             komut.Parameters.AddWithValue("@anne_adi",textBox7.Text.ToString());
             komut.Parameters.AddWithValue("@baba_adi",textBox8.Text.ToString());
             komut.Parameters.AddWithValue("@c_tel",textBox9.Text.ToString());
             komut.Parameters.AddWithValue("@s_tel",textBox10.Text.ToString());
             komut.Parameters.AddWithValue("@e_mail",textBox11.Text.ToString()); 
             komut.Parameters.AddWithValue("@parola",textBox12.Text.ToString());
             komut.ExecuteNonQuery();
             con.Close();

            MessageBox.Show("Kaydetme işleminiz tamamlanmıştır");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox t = (TextBox)item;
                    t.Clear();
                }
            }
          
        }
    }
}
