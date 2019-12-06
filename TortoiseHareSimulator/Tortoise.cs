using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TortoiseHareSimulator
{
    class Tortoise : Contender
    {
        public Random rnd;

        public Tortoise() : base()
        {
            rnd = new Random(100);
        }

        public Tortoise(int numSteps) : base (numSteps)
        {
            rnd = new Random(100);
        }

        public void updatePosition()
        {
            throw new NotImplementedException();
        }

        public void Draw (Graphics g)
        {
            throw new NotImplementedException();
        }

    }
}
