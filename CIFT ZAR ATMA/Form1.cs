using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIFT_ZAR_ATMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "SALLA";
            button2.Text = "DUR";
            button2.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Enabled = false;
            button2.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int zar1, zar2;

            Random rnd = new Random();
            zar1 = rnd.Next(0, 6);
            zar2 = rnd.Next(0, 6);

            pictureBox1.Image = ImageList1.Images[zar1];
            pictureBox2.Image = ImageList1.Images[zar2];
        }
    }
}
