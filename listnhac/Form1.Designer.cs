namespace listnhac
{
    partial class frmMedia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedia));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnMusic = new System.Windows.Forms.Button();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.btnVideo = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnNoPlaying = new System.Windows.Forms.Button();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabMusic = new System.Windows.Forms.TabPage();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.dgvMusic = new System.Windows.Forms.DataGridView();
            this.lblMusic = new System.Windows.Forms.Label();
            this.tabVideos = new System.Windows.Forms.TabPage();
            this.panelPlay = new System.Windows.Forms.Panel();
            this.lblTimeStart = new System.Windows.Forms.Label();
            this.lblTimeEnd = new System.Windows.Forms.Label();
            this.p_bar = new System.Windows.Forms.ProgressBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lbl_trackend = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblVideo = new System.Windows.Forms.Label();
            this.btnAll = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.btnAddVideo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colMusic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playMusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.picAvt = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.tab.SuspendLayout();
            this.tabMusic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusic)).BeginInit();
            this.tabVideos.SuspendLayout();
            this.panelPlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelMenu.Controls.Add(this.splitter1);
            this.panelMenu.Controls.Add(this.btnSetting);
            this.panelMenu.Controls.Add(this.btnMusic);
            this.panelMenu.Controls.Add(this.btnPlaylist);
            this.panelMenu.Controls.Add(this.btnVideo);
            this.panelMenu.Controls.Add(this.lblUser);
            this.panelMenu.Controls.Add(this.btnNoPlaying);
            this.panelMenu.Controls.Add(this.picAvt);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(266, 666);
            this.panelMenu.TabIndex = 0;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnSetting.Location = new System.Drawing.Point(65, 625);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(195, 38);
            this.btnSetting.TabIndex = 6;
            this.btnSetting.Text = "Settings...";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.UseVisualStyleBackColor = false;
            // 
            // btnMusic
            // 
            this.btnMusic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMusic.FlatAppearance.BorderSize = 0;
            this.btnMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusic.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusic.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnMusic.Location = new System.Drawing.Point(65, 233);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(195, 38);
            this.btnMusic.TabIndex = 5;
            this.btnMusic.Text = "Musics";
            this.btnMusic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusic.UseVisualStyleBackColor = false;
            this.btnMusic.Click += new System.EventHandler(this.btnMusic_Click);
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaylist.FlatAppearance.BorderSize = 0;
            this.btnPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylist.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaylist.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnPlaylist.Location = new System.Drawing.Point(65, 321);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Size = new System.Drawing.Size(195, 38);
            this.btnPlaylist.TabIndex = 4;
            this.btnPlaylist.Text = "Playlists";
            this.btnPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylist.UseVisualStyleBackColor = false;
            // 
            // btnVideo
            // 
            this.btnVideo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVideo.FlatAppearance.BorderSize = 0;
            this.btnVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnVideo.Location = new System.Drawing.Point(65, 277);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(195, 38);
            this.btnVideo.TabIndex = 3;
            this.btnVideo.Text = "Videos";
            this.btnVideo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVideo.UseVisualStyleBackColor = false;
            this.btnVideo.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Purple;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(61, 110);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(109, 23);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = " Cong Thanh";
            // 
            // btnNoPlaying
            // 
            this.btnNoPlaying.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNoPlaying.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNoPlaying.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNoPlaying.Enabled = false;
            this.btnNoPlaying.FlatAppearance.BorderSize = 0;
            this.btnNoPlaying.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoPlaying.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoPlaying.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnNoPlaying.Location = new System.Drawing.Point(65, 189);
            this.btnNoPlaying.Name = "btnNoPlaying";
            this.btnNoPlaying.Size = new System.Drawing.Size(195, 38);
            this.btnNoPlaying.TabIndex = 1;
            this.btnNoPlaying.Text = "Home...";
            this.btnNoPlaying.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoPlaying.UseVisualStyleBackColor = false;
            // 
            // tab
            // 
            this.tab.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tab.Controls.Add(this.tabMusic);
            this.tab.Controls.Add(this.tabVideos);
            this.tab.Location = new System.Drawing.Point(266, 3);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(734, 583);
            this.tab.TabIndex = 1;
            // 
            // tabMusic
            // 
            this.tabMusic.Controls.Add(this.btnDelete);
            this.tabMusic.Controls.Add(this.cmbSort);
            this.tabMusic.Controls.Add(this.btnExit);
            this.tabMusic.Controls.Add(this.btnAdd);
            this.tabMusic.Controls.Add(this.btnShuffle);
            this.tabMusic.Controls.Add(this.dgvMusic);
            this.tabMusic.Controls.Add(this.lblMusic);
            this.tabMusic.Controls.Add(this.playMusic);
            this.tabMusic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabMusic.Location = new System.Drawing.Point(4, 4);
            this.tabMusic.Name = "tabMusic";
            this.tabMusic.Padding = new System.Windows.Forms.Padding(3);
            this.tabMusic.Size = new System.Drawing.Size(726, 554);
            this.tabMusic.TabIndex = 0;
            this.tabMusic.Text = "Playing";
            this.tabMusic.UseVisualStyleBackColor = true;
            // 
            // cmbSort
            // 
            this.cmbSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cmbSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Location = new System.Drawing.Point(202, 98);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(103, 24);
            this.cmbSort.TabIndex = 13;
            this.cmbSort.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(576, 87);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 40);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add Music";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnShuffle
            // 
            this.btnShuffle.BackColor = System.Drawing.Color.Purple;
            this.btnShuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShuffle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShuffle.FlatAppearance.BorderSize = 0;
            this.btnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShuffle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuffle.ForeColor = System.Drawing.Color.White;
            this.btnShuffle.Location = new System.Drawing.Point(14, 88);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(158, 38);
            this.btnShuffle.TabIndex = 11;
            this.btnShuffle.Text = "Shuffle and play";
            this.btnShuffle.UseVisualStyleBackColor = false;
            // 
            // dgvMusic
            // 
            this.dgvMusic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMusic.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvMusic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMusic,
            this.colLink});
            this.dgvMusic.Location = new System.Drawing.Point(6, 172);
            this.dgvMusic.Name = "dgvMusic";
            this.dgvMusic.RowHeadersWidth = 51;
            this.dgvMusic.RowTemplate.Height = 24;
            this.dgvMusic.Size = new System.Drawing.Size(712, 367);
            this.dgvMusic.TabIndex = 10;
            // 
            // lblMusic
            // 
            this.lblMusic.AutoSize = true;
            this.lblMusic.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusic.Location = new System.Drawing.Point(3, 13);
            this.lblMusic.Name = "lblMusic";
            this.lblMusic.Size = new System.Drawing.Size(151, 62);
            this.lblMusic.TabIndex = 9;
            this.lblMusic.Text = "Music";
            // 
            // tabVideos
            // 
            this.tabVideos.Controls.Add(this.button5);
            this.tabVideos.Controls.Add(this.dataGridView1);
            this.tabVideos.Controls.Add(this.btnAddVideo);
            this.tabVideos.Controls.Add(this.button6);
            this.tabVideos.Controls.Add(this.comboBox1);
            this.tabVideos.Controls.Add(this.btnAll);
            this.tabVideos.Controls.Add(this.lblVideo);
            this.tabVideos.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabVideos.Location = new System.Drawing.Point(4, 4);
            this.tabVideos.Name = "tabVideos";
            this.tabVideos.Padding = new System.Windows.Forms.Padding(3);
            this.tabVideos.Size = new System.Drawing.Size(726, 554);
            this.tabVideos.TabIndex = 1;
            this.tabVideos.Text = "Videos";
            this.tabVideos.UseVisualStyleBackColor = true;
            this.tabVideos.Click += new System.EventHandler(this.tabVideos_Click);
            // 
            // panelPlay
            // 
            this.panelPlay.BackColor = System.Drawing.Color.Purple;
            this.panelPlay.Controls.Add(this.button4);
            this.panelPlay.Controls.Add(this.button3);
            this.panelPlay.Controls.Add(this.button2);
            this.panelPlay.Controls.Add(this.button1);
            this.panelPlay.Controls.Add(this.btnStop);
            this.panelPlay.Controls.Add(this.lblTimeStart);
            this.panelPlay.Controls.Add(this.lblTimeEnd);
            this.panelPlay.Controls.Add(this.p_bar);
            this.panelPlay.Controls.Add(this.trackBar1);
            this.panelPlay.Controls.Add(this.lbl_trackend);
            this.panelPlay.Controls.Add(this.btnChon);
            this.panelPlay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPlay.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panelPlay.Location = new System.Drawing.Point(266, 592);
            this.panelPlay.Name = "panelPlay";
            this.panelPlay.Size = new System.Drawing.Size(734, 74);
            this.panelPlay.TabIndex = 7;
            // 
            // lblTimeStart
            // 
            this.lblTimeStart.AutoSize = true;
            this.lblTimeStart.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeStart.ForeColor = System.Drawing.Color.White;
            this.lblTimeStart.Location = new System.Drawing.Point(12, 2);
            this.lblTimeStart.Name = "lblTimeStart";
            this.lblTimeStart.Size = new System.Drawing.Size(44, 19);
            this.lblTimeStart.TabIndex = 26;
            this.lblTimeStart.Text = "00:00";
            // 
            // lblTimeEnd
            // 
            this.lblTimeEnd.AutoSize = true;
            this.lblTimeEnd.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeEnd.ForeColor = System.Drawing.Color.White;
            this.lblTimeEnd.Location = new System.Drawing.Point(530, 2);
            this.lblTimeEnd.Name = "lblTimeEnd";
            this.lblTimeEnd.Size = new System.Drawing.Size(44, 19);
            this.lblTimeEnd.TabIndex = 25;
            this.lblTimeEnd.Text = "00:00";
            // 
            // p_bar
            // 
            this.p_bar.Location = new System.Drawing.Point(62, 11);
            this.p_bar.Name = "p_bar";
            this.p_bar.Size = new System.Drawing.Size(462, 6);
            this.p_bar.TabIndex = 21;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(580, 7);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(142, 56);
            this.trackBar1.TabIndex = 24;
            // 
            // lbl_trackend
            // 
            this.lbl_trackend.AutoSize = true;
            this.lbl_trackend.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_trackend.ForeColor = System.Drawing.Color.Black;
            this.lbl_trackend.Location = new System.Drawing.Point(975, -7);
            this.lbl_trackend.Name = "lbl_trackend";
            this.lbl_trackend.Size = new System.Drawing.Size(75, 24);
            this.lbl_trackend.TabIndex = 23;
            this.lbl_trackend.Text = "00:00";
            // 
            // btnChon
            // 
            this.btnChon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChon.Location = new System.Drawing.Point(938, 29);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(10, 10);
            this.btnChon.TabIndex = 20;
            this.btnChon.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 666);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(469, 88);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 40);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Remove";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblVideo
            // 
            this.lblVideo.AutoSize = true;
            this.lblVideo.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVideo.Location = new System.Drawing.Point(3, 13);
            this.lblVideo.Name = "lblVideo";
            this.lblVideo.Size = new System.Drawing.Size(150, 62);
            this.lblVideo.TabIndex = 10;
            this.lblVideo.Text = "Video";
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.Purple;
            this.btnAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAll.FlatAppearance.BorderSize = 0;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.White;
            this.btnAll.Location = new System.Drawing.Point(28, 88);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(125, 38);
            this.btnAll.TabIndex = 12;
            this.btnAll.Text = "Play all";
            this.btnAll.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(597, 139);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(103, 24);
            this.comboBox1.TabIndex = 14;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(469, 94);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(101, 40);
            this.button6.TabIndex = 15;
            this.button6.Text = "Remove";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnAddVideo
            // 
            this.btnAddVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVideo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVideo.Location = new System.Drawing.Point(576, 93);
            this.btnAddVideo.Name = "btnAddVideo";
            this.btnAddVideo.Size = new System.Drawing.Size(124, 40);
            this.btnAddVideo.TabIndex = 16;
            this.btnAddVideo.Text = "Add Video";
            this.btnAddVideo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(712, 367);
            this.dataGridView1.TabIndex = 18;
            // 
            // colMusic
            // 
            this.colMusic.HeaderText = "Music";
            this.colMusic.MinimumWidth = 6;
            this.colMusic.Name = "colMusic";
            // 
            // colLink
            // 
            this.colLink.HeaderText = "Nguồn";
            this.colLink.MinimumWidth = 6;
            this.colLink.Name = "colLink";
            // 
            // playMusic
            // 
            this.playMusic.Enabled = true;
            this.playMusic.Location = new System.Drawing.Point(43, 454);
            this.playMusic.Name = "playMusic";
            this.playMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("playMusic.OcxState")));
            this.playMusic.Size = new System.Drawing.Size(524, 44);
            this.playMusic.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Purple;
            this.button4.BackgroundImage = global::listnhac.Properties.Resources.play1;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Purple;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(206, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(33, 37);
            this.button4.TabIndex = 32;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Purple;
            this.button3.BackgroundImage = global::listnhac.Properties.Resources.play_pause;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Purple;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(332, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 36);
            this.button3.TabIndex = 31;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Purple;
            this.button2.BackgroundImage = global::listnhac.Properties.Resources.rewind;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Purple;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(152, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 36);
            this.button2.TabIndex = 30;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.BackgroundImage = global::listnhac.Properties.Resources.forward;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Purple;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(293, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 37);
            this.button1.TabIndex = 29;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Purple;
            this.btnStop.BackgroundImage = global::listnhac.Properties.Resources.pause__1____Copy1;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.ForeColor = System.Drawing.Color.Purple;
            this.btnStop.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStop.Location = new System.Drawing.Point(245, 23);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(42, 37);
            this.btnStop.TabIndex = 28;
            this.btnStop.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnExit.BackgroundImage = global::listnhac.Properties.Resources.reject;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(697, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(29, 30);
            this.btnExit.TabIndex = 6;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.button5.BackgroundImage = global::listnhac.Properties.Resources.reject;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button5.Location = new System.Drawing.Point(697, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(29, 30);
            this.button5.TabIndex = 19;
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // picAvt
            // 
            this.picAvt.BackgroundImage = global::listnhac.Properties.Resources.Picture1;
            this.picAvt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAvt.ErrorImage = null;
            this.picAvt.InitialImage = null;
            this.picAvt.Location = new System.Drawing.Point(71, 20);
            this.picAvt.Name = "picAvt";
            this.picAvt.Size = new System.Drawing.Size(83, 65);
            this.picAvt.TabIndex = 0;
            this.picAvt.TabStop = false;
            // 
            // frmMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1000, 666);
            this.Controls.Add(this.panelPlay);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMedia";
            this.Load += new System.EventHandler(this.frmMedia_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.tab.ResumeLayout(false);
            this.tabMusic.ResumeLayout(false);
            this.tabMusic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusic)).EndInit();
            this.tabVideos.ResumeLayout(false);
            this.tabVideos.PerformLayout();
            this.panelPlay.ResumeLayout(false);
            this.panelPlay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picAvt;
        private System.Windows.Forms.Button btnNoPlaying;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnMusic;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.Button btnVideo;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.TabPage tabMusic;
        private System.Windows.Forms.TabPage tabVideos;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelPlay;
        private System.Windows.Forms.Label lbl_trackend;
        private System.Windows.Forms.ProgressBar p_bar;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.TrackBar trackBar1;
        private AxWMPLib.AxWindowsMediaPlayer playMusic;
        private System.Windows.Forms.Label lblTimeStart;
        private System.Windows.Forms.Label lblTimeEnd;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.DataGridView dgvMusic;
        private System.Windows.Forms.Label lblMusic;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Label lblVideo;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAddVideo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMusic;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLink;
    }
}

