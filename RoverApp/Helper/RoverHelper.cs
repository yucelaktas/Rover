using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverApp.Helper
{
    public class RoverHelper : IRoverHelper
    {
        public char TurnRoverDirection(char currentDirection, char commandLetter)
        {
            char[] directions = { 'N', 'W', 'S', 'E' };

            int indexOfDirection = Array.IndexOf(directions, currentDirection);

            char newDirection;

            switch (commandLetter)
            {
                case 'L':

                    if (indexOfDirection == directions.Length - 1)
                        newDirection = 'N';
                    else
                    {
                        indexOfDirection += 1;

                        newDirection = directions[indexOfDirection];
                    }
                    break;

                case 'R':

                    if (indexOfDirection == 0)
                        newDirection = 'E';
                    else
                    {
                        indexOfDirection -= 1;

                        newDirection = directions[indexOfDirection];
                    }
                    break;

                default:
                    newDirection = currentDirection;
                    break;
            }
            return newDirection;
        }

        public int[,] ForwardRoverPosition(char currentDirection, int[,] currentPosition)
        {
            int[,] newPosition = currentPosition;

            switch (currentDirection)
            {
                case 'E':
                    newPosition[0, 0] += 1;
                    break;
                case 'W':
                    newPosition[0, 0] -= 1;
                    break;
                case 'N':
                    newPosition[0, 1] += 1;
                    break;
                case 'S':
                    newPosition[0, 1] -= 1;
                    break;
            }
            return newPosition;
        }
    }
}
