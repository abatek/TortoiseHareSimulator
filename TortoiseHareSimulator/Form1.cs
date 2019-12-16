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

        public Form1()
        {
            InitializeComponent();
            unit = pbTrack.Width / 70;
            endPosition = unit * 70;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tortoise.updatePosition();
            hare.updatePosition();
            
            if (tortoise.getPosition()*unit >= endPosition)
            {
                t_score++;
                tortoise.setPosition(0);
                hare.setPosition(0);
            }
            if (hare.getPosition()*unit >= endPosition)
            {
                h_score++;
                tortoise.setPosition(0);
                hare.setPosition(0);
            }
            lbl_tort.Text = t_score.ToString();
            lbl_hair.Text = h_score.ToString();

            pbTrack.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void pbTrack_Paint(object sender, PaintEventArgs e)
        {
            hare.Draw(e.Graphics, unit);
            tortoise.Draw(e.Graphics, unit);
        }
    }
}
