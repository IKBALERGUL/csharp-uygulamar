using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hastane_kayit_programi
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string klinik = comboBox1.SelectedItem.ToString();
            string doktor = comboBox2.SelectedItem.ToString();
            string tarih = dateTimePicker1.Text;
            string saat = comboBox3.SelectedItem.ToString();
            string[] bilgiler = { klinik, doktor, tarih, saat };
            listView1.Items.Add(new ListViewItem(bilgiler));
            MessageBox.Show("DOKTOR: "+comboBox2.SelectedItem.ToString()+
                            "KLİNİK: "+comboBox1.SelectedItem.ToString()+
                            "TARİH: "+dateTimePicker1.Text+
                            "SAAT "+comboBox3.SelectedItem.ToString());


        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
