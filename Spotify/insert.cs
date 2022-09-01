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
    public partial class insert : Form
    {
        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;
        public insert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into playlist values(:id,:name,:followers)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", comboBox1.Text);
            cmd.Parameters.Add("name", textBox1.Text);
          
            cmd.Parameters.Add("followers", textBox2.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                comboBox1.Items.Add(comboBox1.Text);
            }
            MessageBox.Show("new playlist is added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void insert_Load(object sender, EventArgs e)
        {
            try
            {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select id from playlist";

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);

            }
            dr.Close();
                cmd.CommandText = "select id from playlist";
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr2 = cmd.ExecuteReader();
                while (dr2.Read())
                {

                    comboBox2.Items.Add(dr2[0]);
                }
                dr2.Close();
                cmd.CommandText = "select id from song";
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr3 = cmd.ExecuteReader();
                while (dr3.Read())
                {

                    comboBox3.Items.Add(dr3[0]);
                }

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
            cmd.CommandText = "insert into playlists_songs values(:artist-id,:song_id) ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("artist-id", comboBox2.Text);
            cmd.Parameters.Add("song_id", comboBox3.Text);
            
            MessageBox.Show("new song is added");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "delete from playlists_songs where song_id=:id";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("id", comboBox3.Text);
                //cmd.Parameters.Add("name", textBox1.Text);
                //cmd.Parameters.Add("listners", textBox2.Text);
                //cmd.Parameters.Add("followers", textBox3.Text);
                int r = cmd.ExecuteNonQuery();

                if (r != -1)
                {
                    MessageBox.Show("song deleted");
                    comboBox3.Items.RemoveAt(comboBox3.SelectedIndex);
                }


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
                cmd.CommandText = "delete from playlist where id=:id";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("id", comboBox1.Text);
                //cmd.Parameters.Add("name", textBox1.Text);
                //cmd.Parameters.Add("listners", textBox2.Text);
                //cmd.Parameters.Add("followers", textBox3.Text);
                int r = cmd.ExecuteNonQuery();

                if (r != -1)
                {
                    MessageBox.Show("playlist_deleted");
                    comboBox1.Items.RemoveAt(comboBox3.SelectedIndex);
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
           
            
    }
}
