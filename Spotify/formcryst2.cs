using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using CrystalDecisions.Shared;
namespace Spotify
{
    public partial class formcryst2 : Form
    {
        CrystalReport2 cr;
        public formcryst2()
        {
            InitializeComponent();
        }

        private void formcryst2_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport2();

            foreach (ParameterDiscreteValue v in cr.ParameterFields[0].DefaultValues)
                comboBox1.Items.Add(v.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cr.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource = cr;
            
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            
        }
    }
}
