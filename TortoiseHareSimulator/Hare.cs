using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TortoiseHareSimulator
{
    class Hare : Contender
    {
        public Random rnd;

        public Hare() : base()
        {
            rnd = new Random(100);
        }

        public Hare(int numSteps) : base(numSteps)
        {
            rnd = new Random(100);
        }

        public void updatePosition()
        {
            throw new NotImplementedException();
        }

        public void Draw(Graphics g)
        {
            throw new NotImplementedException();
        }
    }
}
