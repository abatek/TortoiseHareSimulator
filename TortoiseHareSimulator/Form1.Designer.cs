namespace TortoiseHareSimulator
{
    partial class Form1
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbl_hair = new System.Windows.Forms.Label();
            this.lbl_tort = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbTortoise = new System.Windows.Forms.PictureBox();
            this.pbHare = new System.Windows.Forms.PictureBox();
            this.pbTrack = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTortoise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbl_hair
            // 
            this.lbl_hair.AutoSize = true;
            this.lbl_hair.Font = new System.Drawing.Font("Comic Sans MS", 72F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_hair.Location = new System.Drawing.Point(398, 114);
            this.lbl_hair.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_hair.Name = "lbl_hair";
            this.lbl_hair.Size = new System.Drawing.Size(173, 204);
            this.lbl_hair.TabIndex = 1;
            this.lbl_hair.Text = "0";
            // 
            // lbl_tort
            // 
            this.lbl_tort.AutoSize = true;
            this.lbl_tort.Font = new System.Drawing.Font("Comic Sans MS", 72F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_tort.Location = new System.Drawing.Point(49, 114);
            this.lbl_tort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tort.Name = "lbl_tort";
            this.lbl_tort.Size = new System.Drawing.Size(173, 204);
            this.lbl_tort.TabIndex = 2;
            this.lbl_tort.Text = "0";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(247, 169);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(247, 232);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 6;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(272, 294);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TortoiseHareSimulator.Properties.Resources.finishline;
            this.pictureBox1.Location = new System.Drawing.Point(712, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pbTortoise
            // 
            this.pbTortoise.BackColor = System.Drawing.Color.Transparent;
            this.pbTortoise.Image = global::TortoiseHareSimulator.Properties.Resources.tortoise_flip;
            this.pbTortoise.Location = new System.Drawing.Point(56, 60);
            this.pbTortoise.Name = "pbTortoise";
            this.pbTortoise.Size = new System.Drawing.Size(65, 50);
            this.pbTortoise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTortoise.TabIndex = 4;
            this.pbTortoise.TabStop = false;
            // 
            // pbHare
            // 
            this.pbHare.BackColor = System.Drawing.Color.Transparent;
            this.pbHare.Image = global::TortoiseHareSimulator.Properties.Resources.hare_flip;
            this.pbHare.Location = new System.Drawing.Point(56, 10);
            this.pbHare.Name = "pbHare";
            this.pbHare.Size = new System.Drawing.Size(64, 50);
            this.pbHare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHare.TabIndex = 3;
            this.pbHare.TabStop = false;
            // 
            // pbTrack
            // 
            this.pbTrack.BackColor = System.Drawing.Color.White;
            this.pbTrack.Location = new System.Drawing.Point(56, 10);
            this.pbTrack.Margin = new System.Windows.Forms.Padding(2);
            this.pbTrack.Name = "pbTrack";
            this.pbTrack.Size = new System.Drawing.Size(700, 100);
            this.pbTrack.TabIndex = 0;
            this.pbTrack.TabStop = false;
            this.pbTrack.Paint += new System.Windows.Forms.PaintEventHandler(this.pbTrack_Paint);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(687, 122);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(69, 196);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.Value = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(738, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(738, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(832, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pbTortoise);
            this.Controls.Add(this.pbHare);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lbl_tort);
            this.Controls.Add(this.lbl_hair);
            this.Controls.Add(this.pbTrack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTortoise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTrack;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbl_hair;
        private System.Windows.Forms.Label lbl_tort;
        private System.Windows.Forms.PictureBox pbHare;
        private System.Windows.Forms.PictureBox pbTortoise;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

