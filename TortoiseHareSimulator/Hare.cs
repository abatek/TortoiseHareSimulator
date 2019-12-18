using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TortoiseHareSimulator
{
    public class Hare : Contender
    {
        public Random rnd;

        public Hare() : base()
        {
            rnd = new Random();
        }

        public void updatePosition()
        {
            int rand = rnd.Next(100);
            int moveAmount;

            if (rand < 20)
            {
                //sleep
                moveAmount = 0;
            }
            else if (rand < 40)
            {
                //big hop
                moveAmount = 8;
            }
            else if (rand < 50)
            {
                //big slip
                moveAmount = -10;
            }
            else if (rand < 80)
            {
                //small hop
                moveAmount = 1;
            }
            else
            {
                //small slip
                moveAmount = -2;
            }
            position += moveAmount;
            position = Math.Max(0, position);
        }

        public void Draw(Graphics g, int unit)
        {
            g.FillRectangle(Brushes.Red, position*unit, 33 - spriteHeight/2, spriteWidth, spriteHeight);
        }
    }
}
