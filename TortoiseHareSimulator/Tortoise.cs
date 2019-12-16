using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TortoiseHareSimulator
{
    public class Tortoise : Contender
    {
        public Random rnd;

        public Tortoise() : base()
        {
            rnd = new Random();
        }

        public Tortoise(int numSteps) : base (numSteps)
        {
            rnd = new Random();
        }

        public void updatePosition()
        {
            int rand = rnd.Next(100);
            int moveAmount;
            
            if (rand < 50)
            {
                //fast plod
                moveAmount = 3;
            }else if (rand < 70)
            {
                //slip
                moveAmount = -6;
            }else
            {
                //slow plod
                moveAmount = 1;
            }
            position += moveAmount;
            position = Math.Max(0, position);

        }

        public void Draw (Graphics g, int unit)
        {
            g.FillEllipse(Brushes.Blue, position*unit, 63, spriteWidth, spriteHeight);
        }
    }
}
