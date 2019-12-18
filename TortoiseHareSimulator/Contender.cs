using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TortoiseHareSimulator
{
    public class Contender
    {
        protected int position;
        protected static int numSteps;
        protected static readonly int spriteWidth = 10;
        protected static readonly int spriteHeight = 10;

        public Color color;

        public Contender()
        {
            position = 0;
        }

        public Contender(int position)
        {
            this.position = position;
        }

        public void setPosition(int position)
        {
            this.position = position;
        }

        public static void setNumSteps(int steps)
        {
            numSteps = steps;
        }

        public int getPosition()
        {
            return position;
        }

        public static int getNumSteps()
        {
            return numSteps;
        }
    }
}
