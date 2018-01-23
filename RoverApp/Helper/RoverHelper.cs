using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverApp.Helper
{
    public class RoverHelper
    {
        public  void TurnRover(ref char currentDirection, char commandLetter)
        {
            char[] directions = { 'N', 'W', 'S', 'E' };

            int currentIndex = Array.IndexOf(directions, currentDirection);

            switch (commandLetter)
            {
                case 'L':

                    if (currentIndex == directions.Length - 1)
                        currentDirection = 'N';
                    else
                    {
                        currentIndex += 1;

                        currentDirection = directions[currentIndex];
                    }
                    break;

                case 'R':

                    if (currentIndex == 0)
                        currentDirection = 'E';
                    else
                    {
                        currentIndex -= 1;

                        currentDirection = directions[currentIndex];
                    }
                    break;

            }
        }

        public void ForwardRover(char currentDirection, ref int[,] currentPosition)
        {
            switch (currentDirection)
            {
                case 'E':
                    currentPosition[0, 0] += 1;
                    break;
                case 'W':
                    currentPosition[0, 0] -= 1;
                    break;
                case 'N':
                    currentPosition[0, 1] += 1;
                    break;
                case 'S':
                    currentPosition[0, 1] -= 1;
                    break;
            }
        }
    }
}
