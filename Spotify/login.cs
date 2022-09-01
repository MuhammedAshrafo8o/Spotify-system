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
    public partial class login : Form
    {
        Form1 f = new Form1();
        register r1 = new register();
        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;
        public login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT username , password  FROM sotify_user WHERE username=: usernam and password =:pass";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("usernam", textBox1.Text);
            cmd.Parameters.Add("pass", textBox2.Text);

            OracleDataReader dr = cmd.ExecuteReader();
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("username or passwored or Poth is empty please fill all date and tray again........");

            }

            else if (textBox1.Text == "mohamed salama" && textBox2.Text == "20191700534")
            {

                MessageBox.Show("welcome admin");


                f.Show();
                this.Hide();


            }
            
         else if (dr.Read())
            {
                if (textBox1.Text.Equals(dr["username".ToString()]) && textBox2.Text.Equals(dr["password"].ToString()))
                {
                    MessageBox.Show("login successfully");
                    user u = new user();
                    u.Show();
                    this.Hide()
;                }
           
            }
            else
                MessageBox.Show("invalid username or password");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (r1 == null)
            {
                r1.Show();

            }
            else
            {
                r1.Show();
                r1.Focus();
            }
            this.Hide();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            
        }
    }
}
