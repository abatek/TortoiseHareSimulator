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
        public Tortoise tort = new Tortoise();
        public Hare hair = new Hare();
        public int t_score = 0;
        public int h_score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tort.updatePosition();
            hair.updatePosition();
            int t_val = tort.getPosition();
            int h_val = hair.getPosition();
            if (t_val >= 70)
            {
                t_score++;
                t_val = 0;
                h_val = 0;
            }
            if (h_val >= 70)
            {
                h_score++;
                t_val = 0;
                h_val = 0;
            }
            lbl_tort.Text = t_score.ToString();
            lbl_hair.Text = h_score.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }
    }
}
