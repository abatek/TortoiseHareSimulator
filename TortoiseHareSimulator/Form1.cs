using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            spriteMode = SpriteMode.PICTURE;
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
            }
            if (hare.getPosition()*unit >= endPosition)
            {
                h_score++;
                resetContenders();
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
    }
}
