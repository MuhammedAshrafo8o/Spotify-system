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
    public partial class formcryst1 : Form
    {
        CrystalReport1 cr;
        public formcryst1()
        {
            InitializeComponent();
        }

        private void formcryst1_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = cr;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            
        }
    }
}
