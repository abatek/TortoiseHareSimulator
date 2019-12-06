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
            this.pbTrack.Location = new System.Drawing.Point(12, 12);
            this.pbTrack.Name = "pbTrack";
            this.pbTrack.Size = new System.Drawing.Size(776, 116);
            this.pbTrack.TabIndex = 0;
            this.pbTrack.TabStop = false;
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
            this.lbl_hair.Location = new System.Drawing.Point(530, 143);
            this.lbl_hair.Name = "lbl_hair";
            this.lbl_hair.Size = new System.Drawing.Size(230, 270);
            this.lbl_hair.TabIndex = 1;
            this.lbl_hair.Text = "0";
            // 
            // lbl_tort
            // 
            this.lbl_tort.AutoSize = true;
            this.lbl_tort.Font = new System.Drawing.Font("Comic Sans MS", 72F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_tort.Location = new System.Drawing.Point(65, 143);
            this.lbl_tort.Name = "lbl_tort";
            this.lbl_tort.Size = new System.Drawing.Size(230, 270);
            this.lbl_tort.TabIndex = 2;
            this.lbl_tort.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_tort);
            this.Controls.Add(this.lbl_hair);
            this.Controls.Add(this.pbTrack);
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

