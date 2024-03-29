﻿namespace TortoiseHareSimulator
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPicture = new System.Windows.Forms.RadioButton();
            this.rbDraw = new System.Windows.Forms.RadioButton();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_disp_tort = new System.Windows.Forms.Label();
            this.lbl_disp_hare = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbChart = new System.Windows.Forms.RadioButton();
            this.rbNum = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTortoise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.lbl_hair.Location = new System.Drawing.Point(221, 114);
            this.lbl_hair.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_hair.Name = "lbl_hair";
            this.lbl_hair.Size = new System.Drawing.Size(116, 136);
            this.lbl_hair.TabIndex = 1;
            this.lbl_hair.Text = "0";
            // 
            // lbl_tort
            // 
            this.lbl_tort.AutoSize = true;
            this.lbl_tort.Font = new System.Drawing.Font("Comic Sans MS", 72F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_tort.Location = new System.Drawing.Point(4, 114);
            this.lbl_tort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tort.Name = "lbl_tort";
            this.lbl_tort.Size = new System.Drawing.Size(116, 136);
            this.lbl_tort.TabIndex = 2;
            this.lbl_tort.Text = "0";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(125, 159);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(125, 188);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 6;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(125, 217);
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
            this.trackBar1.Location = new System.Drawing.Point(342, 154);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 196);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "10";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPicture);
            this.groupBox1.Controls.Add(this.rbDraw);
            this.groupBox1.Location = new System.Drawing.Point(125, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(75, 66);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // rbPicture
            // 
            this.rbPicture.AutoSize = true;
            this.rbPicture.Location = new System.Drawing.Point(7, 43);
            this.rbPicture.Name = "rbPicture";
            this.rbPicture.Size = new System.Drawing.Size(58, 17);
            this.rbPicture.TabIndex = 1;
            this.rbPicture.TabStop = true;
            this.rbPicture.Text = "Picture";
            this.rbPicture.UseVisualStyleBackColor = true;
            this.rbPicture.CheckedChanged += new System.EventHandler(this.rbPicture_CheckedChanged);
            // 
            // rbDraw
            // 
            this.rbDraw.AutoSize = true;
            this.rbDraw.Location = new System.Drawing.Point(7, 20);
            this.rbDraw.Name = "rbDraw";
            this.rbDraw.Size = new System.Drawing.Size(50, 17);
            this.rbDraw.TabIndex = 0;
            this.rbDraw.TabStop = true;
            this.rbDraw.Text = "Draw";
            this.rbDraw.UseVisualStyleBackColor = true;
            this.rbDraw.CheckedChanged += new System.EventHandler(this.rbDraw_CheckedChanged);
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.Transparent;
            chartArea5.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart.Legends.Add(legend5);
            this.chart.Location = new System.Drawing.Point(472, 152);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series5.Points.Add(dataPoint5);
            series5.Points.Add(dataPoint6);
            this.chart.Series.Add(series5);
            this.chart.Size = new System.Drawing.Size(300, 184);
            this.chart.TabIndex = 13;
            this.chart.Text = "Pie Chart";
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(831, 162);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            // 
            // lbl_disp_tort
            // 
            this.lbl_disp_tort.AutoSize = true;
            this.lbl_disp_tort.Location = new System.Drawing.Point(37, 254);
            this.lbl_disp_tort.Name = "lbl_disp_tort";
            this.lbl_disp_tort.Size = new System.Drawing.Size(41, 13);
            this.lbl_disp_tort.TabIndex = 2;
            this.lbl_disp_tort.Text = "tortoise";
            // 
            // lbl_disp_hare
            // 
            this.lbl_disp_hare.AutoSize = true;
            this.lbl_disp_hare.Location = new System.Drawing.Point(260, 254);
            this.lbl_disp_hare.Name = "lbl_disp_hare";
            this.lbl_disp_hare.Size = new System.Drawing.Size(28, 13);
            this.lbl_disp_hare.TabIndex = 15;
            this.lbl_disp_hare.Text = "hare";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbChart);
            this.groupBox2.Controls.Add(this.rbNum);
            this.groupBox2.Location = new System.Drawing.Point(233, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(75, 66);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display";
            // 
            // rbChart
            // 
            this.rbChart.AutoSize = true;
            this.rbChart.Location = new System.Drawing.Point(7, 43);
            this.rbChart.Name = "rbChart";
            this.rbChart.Size = new System.Drawing.Size(50, 17);
            this.rbChart.TabIndex = 1;
            this.rbChart.TabStop = true;
            this.rbChart.Text = "Chart";
            this.rbChart.UseVisualStyleBackColor = true;
            this.rbChart.CheckedChanged += new System.EventHandler(this.rbChart_CheckedChanged);
            // 
            // rbNum
            // 
            this.rbNum.AutoSize = true;
            this.rbNum.Location = new System.Drawing.Point(7, 20);
            this.rbNum.Name = "rbNum";
            this.rbNum.Size = new System.Drawing.Size(67, 17);
            this.rbNum.TabIndex = 0;
            this.rbNum.TabStop = true;
            this.rbNum.Text = "Numbers";
            this.rbNum.UseVisualStyleBackColor = true;
            this.rbNum.CheckedChanged += new System.EventHandler(this.rbNum_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(832, 366);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_disp_hare);
            this.Controls.Add(this.lbl_disp_tort);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.groupBox1);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTortoise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPicture;
        private System.Windows.Forms.RadioButton rbDraw;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbl_disp_tort;
        private System.Windows.Forms.Label lbl_disp_hare;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbChart;
        private System.Windows.Forms.RadioButton rbNum;
    }
}

