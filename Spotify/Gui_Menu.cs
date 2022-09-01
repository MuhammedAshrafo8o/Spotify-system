using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spotify
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            insert ins = new insert();
            ins.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            login lo = new login();
            lo.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            user us = new user();
            us.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            register re = new register();
            re.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            users us2 = new users();
            us2.Show();
            this.Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formcryst2 cry22 = new formcryst2();
            cry22.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formcryst1 cry1 = new formcryst1();
            cry1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ad = new Form1();
            ad.Show();
            this.Hide();
        }
        
    }
}
