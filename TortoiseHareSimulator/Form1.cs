using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TortoiseHareSimulator
{
    public partial class Form1 : Form
    {
        public Tortoise tortoise = new Tortoise();
        public Hare hare = new Hare();
        public int t_score;
        public int h_score;
        public int unit;
        public int endPosition;
        public SpriteMode spriteMode;
        

        public Form1()
        {
            InitializeComponent();
            Contender.setNumSteps(70);
            unit = pbTrack.Width / Contender.getNumSteps();
            endPosition = unit * Contender.getNumSteps();
            spriteMode = SpriteMode.DRAW;
            rbDraw.Select();

            TextReader tr = new StreamReader("data.txt");
            String[] str = tr.ReadLine().Split();
            tr.Close();
            t_score = Convert.ToInt32(str[0]);
            h_score = Convert.ToInt32(str[1]);
            lbl_tort.Text = t_score.ToString();
            lbl_hair.Text = h_score.ToString();

        }

        public enum SpriteMode
        {
            DRAW,
            PICTURE
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tortoise.updatePosition();
            hare.updatePosition();
            
            if (tortoise.getPosition()*unit >= endPosition)
            {
                t_score++;
                resetContenders();
                updateChart();
            }
            if (hare.getPosition()*unit >= endPosition)
            {
                h_score++;
                resetContenders();
                updateChart();
            }
            lbl_tort.Text = t_score.ToString();
            lbl_hair.Text = h_score.ToString();


            if (spriteMode == SpriteMode.DRAW)
            {
                pbTrack.Invalidate();
            }
            else
            {
                updatePictureBoxPositions();
            }
        }

        private void updatePictureBoxPositions()
        {
            pbTortoise.Location = new Point(pbTrack.Location.X + tortoise.getPosition() * unit - pbHare.Width / 2, pbTortoise.Location.Y);
            pbHare.Location = new Point(pbTrack.Location.X + hare.getPosition() * unit - pbTortoise.Width / 2, pbHare.Location.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbHare.Visible = (spriteMode == SpriteMode.PICTURE);
            pbTortoise.Visible = (spriteMode == SpriteMode.PICTURE);
            pbTrack.Visible = (spriteMode == SpriteMode.DRAW);

            //initalize chart values with names
            chart.Series["Series1"].Points[0].SetValueXY("Tortoise", 0);
            chart.Series["Series1"].Points[0].Color = Color.Green;
            chart.Series["Series1"].Points[1].SetValueXY("Hare", 0);
            chart.Series["Series1"].Points[1].Color = Color.Red;

            rbNum.Checked = true;

        }

        private void pbTrack_Paint(object sender, PaintEventArgs e)
        {
            hare.Draw(e.Graphics, unit);
            tortoise.Draw(e.Graphics, unit);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Enabled = false;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            resetContenders();
        }

        private void resetContenders()
        {
            tortoise.setPosition(0);
            hare.setPosition(0);
            updatePictureBoxPositions();
            pbTrack.Invalidate();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer.Interval = 11 - trackBar1.Value;
        }

        private void rbDraw_CheckedChanged(object sender, EventArgs e)
        {
            spriteMode = SpriteMode.DRAW;
            pbHare.Visible = (spriteMode == SpriteMode.PICTURE);
            pbTortoise.Visible = (spriteMode == SpriteMode.PICTURE);
            pbTrack.Visible = (spriteMode == SpriteMode.DRAW);
        }

        private void rbPicture_CheckedChanged(object sender, EventArgs e)
        {
            spriteMode = SpriteMode.PICTURE;
            pbHare.Visible = (spriteMode == SpriteMode.PICTURE);
            pbTortoise.Visible = (spriteMode == SpriteMode.PICTURE);
            pbTrack.Visible = (spriteMode == SpriteMode.DRAW);
        }

        public void updateChart()
        {
            chart.Series["Series1"].Points[0].SetValueY(t_score);
            chart.Series["Series1"].Points[1].SetValueY(h_score);
            chart.Refresh();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //store data
            TextWriter tw = new StreamWriter("data.txt");
            tw.Write(t_score + " " + h_score);
            tw.Close();
        }

        private void rbNum_CheckedChanged(object sender, EventArgs e)
        {
            lbl_disp_hare.Visible = true;
            lbl_hair.Visible = true;
            lbl_disp_tort.Visible = true;
            lbl_tort.Visible = true;

            chart.Visible = false;
        }

        private void rbChart_CheckedChanged(object sender, EventArgs e)
        {
            lbl_disp_hare.Visible = false;
            lbl_hair.Visible = false;
            lbl_disp_tort.Visible = false;
            lbl_tort.Visible = false;

            chart.Visible = true;
        }
    }
}
