
namespace Spotify
{
    partial class user
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user));
            this.track_volume = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trak_list = new System.Windows.Forms.ListBox();
            this.musiq_bar = new System.Windows.Forms.ProgressBar();
            this.open = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.puse = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.prev = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.valume_value_lab = new System.Windows.Forms.Label();
            this.track_satrt_time = new System.Windows.Forms.Label();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // track_volume
            // 
            this.track_volume.Location = new System.Drawing.Point(57, 273);
            this.track_volume.Margin = new System.Windows.Forms.Padding(2);
            this.track_volume.Maximum = 100;
            this.track_volume.Name = "track_volume";
            this.track_volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.track_volume.Size = new System.Drawing.Size(56, 203);
            this.track_volume.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(148, 273);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 212);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // trak_list
            // 
            this.trak_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trak_list.ForeColor = System.Drawing.Color.Green;
            this.trak_list.FormattingEnabled = true;
            this.trak_list.ItemHeight = 16;
            this.trak_list.Location = new System.Drawing.Point(498, 273);
            this.trak_list.Margin = new System.Windows.Forms.Padding(2);
            this.trak_list.Name = "trak_list";
            this.trak_list.Size = new System.Drawing.Size(425, 212);
            this.trak_list.TabIndex = 20;
            // 
            // musiq_bar
            // 
            this.musiq_bar.Location = new System.Drawing.Point(14, 162);
            this.musiq_bar.Margin = new System.Windows.Forms.Padding(2);
            this.musiq_bar.Name = "musiq_bar";
            this.musiq_bar.Size = new System.Drawing.Size(803, 34);
            this.musiq_bar.TabIndex = 19;
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(695, 213);
            this.open.Margin = new System.Windows.Forms.Padding(2);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(121, 41);
            this.open.TabIndex = 18;
            this.open.Text = "broswer";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click_1);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(560, 213);
            this.stop.Margin = new System.Windows.Forms.Padding(2);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(121, 41);
            this.stop.TabIndex = 17;
            this.stop.Text = "stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click_1);
            // 
            // puse
            // 
            this.puse.Location = new System.Drawing.Point(421, 213);
            this.puse.Margin = new System.Windows.Forms.Padding(2);
            this.puse.Name = "puse";
            this.puse.Size = new System.Drawing.Size(121, 41);
            this.puse.TabIndex = 16;
            this.puse.Text = "puse";
            this.puse.UseVisualStyleBackColor = true;
            this.puse.Click += new System.EventHandler(this.puse_Click);
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(148, 213);
            this.play.Margin = new System.Windows.Forms.Padding(2);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(117, 41);
            this.play.TabIndex = 15;
            this.play.Text = "play";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click_1);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(283, 213);
            this.next.Margin = new System.Windows.Forms.Padding(2);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(121, 41);
            this.next.TabIndex = 14;
            this.next.Text = "next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(14, 213);
            this.prev.Margin = new System.Windows.Forms.Padding(2);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(112, 41);
            this.prev.TabIndex = 13;
            this.prev.Text = "prev";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_Click_1);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // valume_value_lab
            // 
            this.valume_value_lab.AutoSize = true;
            this.valume_value_lab.Location = new System.Drawing.Point(10, 359);
            this.valume_value_lab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valume_value_lab.Name = "valume_value_lab";
            this.valume_value_lab.Size = new System.Drawing.Size(42, 17);
            this.valume_value_lab.TabIndex = 24;
            this.valume_value_lab.Text = "label1";
            // 
            // track_satrt_time
            // 
            this.track_satrt_time.AutoSize = true;
            this.track_satrt_time.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.track_satrt_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.track_satrt_time.Location = new System.Drawing.Point(378, 89);
            this.track_satrt_time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.track_satrt_time.Name = "track_satrt_time";
            this.track_satrt_time.Size = new System.Drawing.Size(176, 56);
            this.track_satrt_time.TabIndex = 25;
            this.track_satrt_time.Text = "00:00";
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(-11, 12);
            this.player.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(803, 43);
            this.player.TabIndex = 26;
            this.player.Enter += new System.EventHandler(this.Player_Enter_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 89);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 27;
            this.button1.Text = "logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(969, 29);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(44, 17);
            this.linkLabel1.TabIndex = 28;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Home";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 654);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.track_satrt_time);
            this.Controls.Add(this.track_volume);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.trak_list);
            this.Controls.Add(this.musiq_bar);
            this.Controls.Add(this.open);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.puse);
            this.Controls.Add(this.play);
            this.Controls.Add(this.next);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.valume_value_lab);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "user";
            this.Text = "user";
            this.Load += new System.EventHandler(this.user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar track_volume;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox trak_list;
        private System.Windows.Forms.ProgressBar musiq_bar;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button puse;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label valume_value_lab;
        private System.Windows.Forms.Label track_satrt_time;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}