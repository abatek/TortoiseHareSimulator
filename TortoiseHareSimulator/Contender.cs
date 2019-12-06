using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TortoiseHareSimulator
{
    public class Contender
    {
        protected int position;
        protected int numSteps;
        public Color color;
        public Contender()
        {
            position = 0;
        }

        public Contender(int numSteps)
        {
            position = 0;
            this.numSteps = numSteps;
        }

        public void setPosition(int position)
        {
            this.position = position;
        }

        public void setNumSteps(int numSteps)
        {
            this.numSteps = numSteps;
        }

        public int getPosition()
        {
            return position;
        }

        public int getNumSteps()
        {
            return numSteps;
        }
    }
}
