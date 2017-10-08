using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListBox_Şehir_Girme_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sehirler = textBox1.Text;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Boş Değer Girilemez");
            }
            else  if (listBox1.Items.Contains(sehirler)==false)
            {
                listBox1.Items.Add(sehirler);
                label4.ForeColor = Color.Green;
                label4.Text = "Şehir Eklendi";
            }
            
            else
            {
                label4.ForeColor = Color.Red;
                label4.Text = "Şehir Mevcut";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = listBox1.SelectedItem.ToString();
        }
    }
}
