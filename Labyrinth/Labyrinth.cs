using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth
{
    public class Labyrinth
    {

        Labyrinth() {}

        Labyrinth(Robot robot, User user) {
            this.robot = robot;
        }

        private Robot robot;

        public Robot Robot
        {
            get { return robot; }
            set { robot = value; }
        }

        public void EvaluateMove(float newXPos, float newYPos) {
            /*
             * We don't know how this function works,
             * only know it would move robot if the validation
             * is correct
            */
            this.MoveRobot(newXPos, newYPos);
        }

        public void MoveRobot(float newXPos, float newYPos) {
            this.robot.XPosition = newXPos;
            this.robot.XPosition = newYPos;
        }
        
    }
}
