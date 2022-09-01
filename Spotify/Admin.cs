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
    public partial class Form1 : Form
    {
        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select id from artist";

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_id.Items.Add(dr[0]);
            }
            dr.Close();
            cmd.CommandText = "select id from song";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr2 = cmd.ExecuteReader();
            while (dr2.Read())
            {

                comboBox1.Items.Add(dr2[0]);
            }
            dr.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into ARTIST values(:id,:name,:listners,:followers)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", cmb_id.Text);
            cmd.Parameters.Add("name", textBox1.Text);
            cmd.Parameters.Add("listners", textBox2.Text);
            cmd.Parameters.Add("followers", textBox3.Text);
            int r = cmd.ExecuteNonQuery();

            if (r != -1)
            {
                cmb_id.Items.Add(cmb_id.Text);
            }
            MessageBox.Show("new artist is added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete from artist where id=:id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", cmb_id.Text);
            //cmd.Parameters.Add("name", textBox1.Text);
            //cmd.Parameters.Add("listners", textBox2.Text);
            //cmd.Parameters.Add("followers", textBox3.Text);
            int r = cmd.ExecuteNonQuery();

            if (r != -1)
            {
                MessageBox.Show("artist deleted");
                cmb_id.Items.RemoveAt(cmb_id.SelectedIndex);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }



        private void cmb_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select NAME,MONTHLY_LISTENERS,FOLLOWERS from ARTIST where ID=:idd";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("idd", cmb_id.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr[0].ToString();
                textBox2.Text = dr[1].ToString();
                textBox3.Text = dr[2].ToString();
            }
            dr.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select artist_id,title,release_date,plays from song where ID=:idd";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("idd", comboBox1.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
               
                textBox5.Text = dr[0].ToString();
                textBox6.Text = dr[1].ToString();
                textBox7.Text = dr[2].ToString();
                textBox8.Text = dr[3].ToString();
            }
            dr.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into song values(:id,:artist_id,:title,:release_date,:plays)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", comboBox1.Text);
            cmd.Parameters.Add("artist_id", textBox5.Text);
            cmd.Parameters.Add("title", textBox6.Text);
            cmd.Parameters.Add("release_date", textBox7.Text);
            cmd.Parameters.Add("plays", textBox8.Text);
            int r = cmd.ExecuteNonQuery();

            if (r != -1)
            {
                comboBox1.Items.Add(comboBox1.Text);
            }
            MessageBox.Show("new song is added");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete from song where id=:id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", comboBox1.Text);
            //cmd.Parameters.Add("name", textBox1.Text);
            //cmd.Parameters.Add("listners", textBox2.Text);
            //cmd.Parameters.Add("followers", textBox3.Text);
            int r = cmd.ExecuteNonQuery();

            if (r != -1)
            {
                MessageBox.Show("song deleted");
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);

              
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            login lo = new login();
            lo.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            

        }
    }
}
