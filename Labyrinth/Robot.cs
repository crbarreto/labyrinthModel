using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth
{
    public class Robot
    {
        
        private float xPosition;
        private float yPosition;

        Robot(float xPosition, float yPosition) {
            this.xPosition = xPosition;
            this.yPosition = yPosition;
        }

        public float XPosition
        {
            get { return xPosition; }
            set { xPosition = value; }
        }

        public float YPosition
        {
            get { return yPosition; }
            set { yPosition = value; }
        }

    }
}
