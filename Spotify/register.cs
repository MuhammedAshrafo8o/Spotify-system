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
namespace Spotify
{
    
    public partial class register : Form
    {
        
        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;
        public register()
        {
            InitializeComponent();
        }

        private void register_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select id from sotify_user";

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
               
            }
            dr.Close();
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
        }
            private void button1_Click(object sender, EventArgs e)
        {

                conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into SOTIFY_USER values(:id,:name,:password)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", comboBox1.Text);
            cmd.Parameters.Add("name", textBox1.Text);
            cmd.Parameters.Add("password", textBox2.Text);
       
            int r = cmd.ExecuteNonQuery();

            if (r != -1)
            {
                comboBox1.Items.Add(comboBox1.Text);
            }
            MessageBox.Show(" registered");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login l = new login();
            if (l == null)
            {
                l.Show();

            }
            else
            {
                l.Show();
                l.Focus();

            }
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            
        }
    }
}
