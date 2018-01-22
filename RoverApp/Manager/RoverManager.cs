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
        public int[,] RoverMove(int[,] correntPosition, char currentDirection, params char[] commandLetters)
        {

            foreach (var letter in commandLetters)
            {
                if(letter=='M')
                    ForwardRover()
            }


            return null;
        }

        private char TurnRover(char currentDirection, char commandLetter)
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
            return currentDirection;
        }

        private char ForwardRover()
        {
            
        }
    }

}
