using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RoverApp
{
    public class RoverManager
    {
        public int[,] RoverMove(int[,] currentPosition,char currentDirection,out char lastDirection, params char[] commandLetters)
        {
            char currentD = currentDirection;

            int[,] currentP = currentPosition;


            foreach (var letter in commandLetters)
            {
                if (letter == 'M')
                    ForwardRover(currentD,ref currentP);
                else
                {
                    TurnRover(ref currentD,letter);
                }
            }

            lastDirection = currentD;

            return currentP;
        }

        private void TurnRover(ref char currentDirection, char commandLetter)
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

        private void ForwardRover(char currentDirection,ref int[,] currentPosition)
        {
            switch (currentDirection)
            {
                case 'E':
                    currentPosition[0, 0] += currentPosition[0,0];
                    break;
                case 'W':
                    currentPosition[0, 0] -= currentPosition[0, 0];
                    break;
                case 'N':
                    currentPosition[0, 1] += currentPosition[0, 1];
                    break;
                case 'S':
                    currentPosition[0, 1] -= currentPosition[0, 1];
                    break;
            }
        }
    }

}
