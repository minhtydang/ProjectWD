namespace listnhac
{
    partial class Display_Songs
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvSong = new System.Windows.Forms.DataGridView();
            this.panelPlay = new System.Windows.Forms.Panel();
            this.lblTimeStart = new System.Windows.Forms.Label();
            this.lblTimeEnd = new System.Windows.Forms.Label();
            this.p_bar = new System.Windows.Forms.ProgressBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lbl_trackend = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            this.lblNameSong = new System.Windows.Forms.Label();
            this.txtNameSong = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.lblNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPlayAll = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSong)).BeginInit();
            this.panelPlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtNo);
            this.panel2.Controls.Add(this.lblNo);
            this.panel2.Controls.Add(this.txtTime);
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Controls.Add(this.txtAuthor);
            this.panel2.Controls.Add(this.lblAuthor);
            this.panel2.Controls.Add(this.txtNameSong);
            this.panel2.Controls.Add(this.lblNameSong);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 617);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnPlayAll);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.lblSearch);
            this.panel3.Controls.Add(this.panelPlay);
            this.panel3.Controls.Add(this.dgvSong);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(420, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(748, 617);
            this.panel3.TabIndex = 2;
            // 
            // dgvSong
            // 
            this.dgvSong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSong.Location = new System.Drawing.Point(0, 109);
            this.dgvSong.Name = "dgvSong";
            this.dgvSong.RowHeadersWidth = 51;
            this.dgvSong.RowTemplate.Height = 24;
            this.dgvSong.Size = new System.Drawing.Size(745, 435);
            this.dgvSong.TabIndex = 0;
            // 
            // panelPlay
            // 
            this.panelPlay.BackColor = System.Drawing.Color.Purple;
            this.panelPlay.Controls.Add(this.btnPlay);
            this.panelPlay.Controls.Add(this.btnStop);
            this.panelPlay.Controls.Add(this.btnPrevious);
            this.panelPlay.Controls.Add(this.btnNext);
            this.panelPlay.Controls.Add(this.btnPause);
            this.panelPlay.Controls.Add(this.lblTimeStart);
            this.panelPlay.Controls.Add(this.lblTimeEnd);
            this.panelPlay.Controls.Add(this.p_bar);
            this.panelPlay.Controls.Add(this.trackBar1);
            this.panelPlay.Controls.Add(this.lbl_trackend);
            this.panelPlay.Controls.Add(this.btnChon);
            this.panelPlay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPlay.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panelPlay.Location = new System.Drawing.Point(0, 543);
            this.panelPlay.Name = "panelPlay";
            this.panelPlay.Size = new System.Drawing.Size(748, 74);
            this.panelPlay.TabIndex = 8;
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
            // lblNameSong
            // 
            this.lblNameSong.AutoSize = true;
            this.lblNameSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSong.Location = new System.Drawing.Point(72, 188);
            this.lblNameSong.Name = "lblNameSong";
            this.lblNameSong.Size = new System.Drawing.Size(104, 22);
            this.lblNameSong.TabIndex = 0;
            this.lblNameSong.Text = "Name Song";
            // 
            // txtNameSong
            // 
            this.txtNameSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameSong.Location = new System.Drawing.Point(75, 220);
            this.txtNameSong.Name = "txtNameSong";
            this.txtNameSong.Size = new System.Drawing.Size(211, 28);
            this.txtNameSong.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSearch.Location = new System.Drawing.Point(439, 65);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(211, 22);
            this.txtSearch.TabIndex = 3;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(365, 67);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(68, 20);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(75, 307);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(211, 28);
            this.txtAuthor.TabIndex = 7;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(72, 275);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(63, 22);
            this.lblAuthor.TabIndex = 6;
            this.lblAuthor.Text = "Author";
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(75, 404);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(111, 28);
            this.txtTime.TabIndex = 9;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(72, 372);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(50, 22);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Time";
            // 
            // txtNo
            // 
            this.txtNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNo.Location = new System.Drawing.Point(75, 495);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(211, 28);
            this.txtNo.TabIndex = 11;
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.Location = new System.Drawing.Point(72, 463);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(48, 22);
            this.lblNo.TabIndex = 10;
            this.lblNo.Text = "No...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Purple;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(128, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Playlist";
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::listnhac.Properties.Resources.correct;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(116, 51);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(48, 37);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnPlayAll
            // 
            this.btnPlayAll.BackgroundImage = global::listnhac.Properties.Resources.play_button;
            this.btnPlayAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlayAll.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnPlayAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayAll.Location = new System.Drawing.Point(28, 34);
            this.btnPlayAll.Name = "btnPlayAll";
            this.btnPlayAll.Size = new System.Drawing.Size(67, 54);
            this.btnPlayAll.TabIndex = 12;
            this.btnPlayAll.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::listnhac.Properties.Resources.search_interface_symbol;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(646, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 23);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Purple;
            this.btnPlay.BackgroundImage = global::listnhac.Properties.Resources.play1;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.ForeColor = System.Drawing.Color.Purple;
            this.btnPlay.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlay.Location = new System.Drawing.Point(206, 23);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(33, 37);
            this.btnPlay.TabIndex = 32;
            this.btnPlay.UseVisualStyleBackColor = false;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Purple;
            this.btnStop.BackgroundImage = global::listnhac.Properties.Resources.play_pause;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.ForeColor = System.Drawing.Color.Purple;
            this.btnStop.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStop.Location = new System.Drawing.Point(293, 24);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(46, 36);
            this.btnStop.TabIndex = 31;
            this.btnStop.UseVisualStyleBackColor = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Purple;
            this.btnPrevious.BackgroundImage = global::listnhac.Properties.Resources.rewind;
            this.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.ForeColor = System.Drawing.Color.Purple;
            this.btnPrevious.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrevious.Location = new System.Drawing.Point(152, 24);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(48, 36);
            this.btnPrevious.TabIndex = 30;
            this.btnPrevious.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Purple;
            this.btnNext.BackgroundImage = global::listnhac.Properties.Resources.forward;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.Purple;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNext.Location = new System.Drawing.Point(345, 25);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(33, 37);
            this.btnNext.TabIndex = 29;
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Purple;
            this.btnPause.BackgroundImage = global::listnhac.Properties.Resources.pause__1____Copy1;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.ForeColor = System.Drawing.Color.Purple;
            this.btnPause.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPause.Location = new System.Drawing.Point(245, 23);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(42, 37);
            this.btnPause.TabIndex = 28;
            this.btnPause.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::listnhac.Properties.Resources.spotify1;
            this.pictureBox1.Location = new System.Drawing.Point(142, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::listnhac.Properties.Resources.letter_x;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(704, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 33);
            this.btnExit.TabIndex = 14;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Display_Songs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 617);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Display_Songs";
            this.Text = "Display_Songs";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSong)).EndInit();
            this.panelPlay.ResumeLayout(false);
            this.panelPlay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvSong;
        private System.Windows.Forms.Panel panelPlay;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label lblTimeStart;
        private System.Windows.Forms.Label lblTimeEnd;
        private System.Windows.Forms.ProgressBar p_bar;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lbl_trackend;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.TextBox txtNameSong;
        private System.Windows.Forms.Label lblNameSong;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPlayAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
    }
}