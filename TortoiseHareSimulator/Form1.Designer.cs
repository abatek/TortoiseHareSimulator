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
            this.pbTrack = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbl_hair = new System.Windows.Forms.Label();
            this.lbl_tort = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTrack
            // 
            this.pbTrack.Location = new System.Drawing.Point(9, 10);
            this.pbTrack.Margin = new System.Windows.Forms.Padding(2);
            this.pbTrack.Name = "pbTrack";
            this.pbTrack.Size = new System.Drawing.Size(700, 100);
            this.pbTrack.TabIndex = 0;
            this.pbTrack.TabStop = false;
            this.pbTrack.Paint += new System.Windows.Forms.PaintEventHandler(this.pbTrack_Paint);
            // 
            // timer
            // 
            this.timer.Interval = 1;
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
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(720, 366);
            this.Controls.Add(this.lbl_tort);
            this.Controls.Add(this.lbl_hair);
            this.Controls.Add(this.pbTrack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTrack;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbl_hair;
        private System.Windows.Forms.Label lbl_tort;
    }
}

