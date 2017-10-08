using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace point_asansor
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label8.Text = "1";
            label5.BackColor = Color.Purple;
            label7.BackColor = Color.Purple;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label8.Text = "0";
            label4.BackColor = Color.Purple;
            label6.BackColor = Color.Purple;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label8.Text=="1")
            {
                pictureBox1.Top -= 5;
                if (pictureBox1.Location.Y<=98)
                {
                    timer1.Stop();
                    label4.BackColor = Color.Yellow;
                    label6.BackColor = Color.Yellow;
                    
                }
            }
            if (label8.Text=="0")
            {
                pictureBox1.Top += 5;
                if (pictureBox1.Location.Y >= 364)
                {
                    timer1.Stop();
                    label5.BackColor = Color.Yellow;
                    label7.BackColor = Color.Yellow;
                    
                }
            }
        }
    }
}
