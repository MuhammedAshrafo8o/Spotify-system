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
    public partial class users : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public users()
        {
            InitializeComponent();
        }

        private void users_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            try
            { 
                string ordb = "Data source=orcl;User Id=hr; Password=hr;";
            string cmdstring = "";
            if (radioButton1.Checked)
                cmdstring = "select* from playlists_songs";
            else if (radioButton2.Checked)
                cmdstring = "select* from song";
            else if (radioButton3.Checked)
                cmdstring = "select* from playlist";

            adapter = new OracleDataAdapter(cmdstring, ordb);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
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
            builder =new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
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
                string ordb = "Data source=orcl;User Id=hr; Password=hr;";
            OracleConnection conn = new OracleConnection(ordb); 
            conn.Open();
            OracleCommand cmd = new OracleCommand();
          
            cmd.Connection = conn;
            cmd.CommandText = "getid";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("idd", textBox1.Text);
            cmd.Parameters.Add("id", OracleDbType.RefCursor, ParameterDirection.Output);
           ; 
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr[0]);

            }
            dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        { 
            try
            {
            string ordb = "Data source=orcl;User Id=hr; Password=hr;";
            string cmds = "select * from song where artist_id=:idd";
            adapter = new OracleDataAdapter(cmds, ordb);
            adapter.SelectCommand.Parameters.Add("idd", textBox1.Text);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
