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
using System.IO;


namespace Spotify
{
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
            track_volume.Value = 50;
            valume_value_lab.Text = track_volume.Value.ToString() + "%";
        }

        private void user_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (trak_list.SelectedIndex < trak_list.Items.Count - 1)
            {
                trak_list.SelectedIndex = trak_list.SelectedIndex + 1;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        string[] paths, files;

        private void trak_list_SelectedIndexChanged(object sender, EventArgs e)
        {

            player.URL = paths[trak_list.SelectedIndex];
            player.Ctlcontrols.play();
            try
            {
                var file = TagLib.File.Create(paths[trak_list.SelectedIndex]);
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                pictureBox1.Image = Image.FromStream(new MemoryStream(bin));
            }
            catch
            {

            }
        }

        private void stop_Click(object sender, EventArgs e)
        {

            player.Ctlcontrols.stop();
            musiq_bar.Value = 0;
        }

        private void play_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();

        }

        private void prev_Click(object sender, EventArgs e)
        {
            if (trak_list.SelectedIndex > 0)
            {
                trak_list.SelectedIndex = trak_list.SelectedIndex - 1;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                musiq_bar.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                musiq_bar.Value = (int)player.Ctlcontrols.currentPosition;
            }

            track_satrt_time.Text = player.Ctlcontrols.currentPositionString;
        }

        private void track_end_time_Click(object sender, EventArgs e)
        {

        }

        private void track_volume_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = track_volume.Value;
            valume_value_lab.Text = track_volume.Value.ToString() + "%";
        }

        private void musiq_bar_MouseDown(object sender, MouseEventArgs e)
        {
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / musiq_bar.Width;
        }

        private void player_Enter(object sender, EventArgs e)
        {

        }

        private void Player_Enter_1(object sender, EventArgs e)
        {

        }

        private void play_Click_1(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
        }

        private void prev_Click_1(object sender, EventArgs e)
        {

            if (trak_list.SelectedIndex > 0)
            {
                trak_list.SelectedIndex = trak_list.SelectedIndex - 1;
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (trak_list.SelectedIndex < trak_list.Items.Count - 1)
            {
                trak_list.SelectedIndex = trak_list.SelectedIndex + 1;
            }
        }

        private void puse_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        private void stop_Click_1(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            musiq_bar.Value = 0;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            
        }

        private void open_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;
                for (int x = 0; x < files.Length; x++)
                {
                    trak_list.Items.Add(files[x]);
                }
            }
        }

        
    }
}
