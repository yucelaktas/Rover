using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverApp.Helper
{
    public class RoverHelper : IRoverHelper
    {
        private readonly char[] DIRECTIONS = { 'N', 'E', 'S', 'W' };

        public char TurnRoverDirection(char currentDirection, char commandLetter)
        {

            int indexOfDirection = Array.IndexOf(DIRECTIONS, currentDirection);

            char newDirection = currentDirection;

            if (commandLetter == 'R')
                newDirection = DIRECTIONS[(indexOfDirection + 1) % 4];

            if (commandLetter == 'L')
                newDirection = DIRECTIONS[(((indexOfDirection - 1) % 4) + 4) % 4];

            return newDirection;
        }

        public int[,] ForwardRoverPosition(char currentDirection, int[,] currentPosition)
        {
            int[,] newPosition = currentPosition;

            var addedPosition = _positionInfo[currentDirection];

            newPosition[0, 0] += addedPosition[0, 0];

            newPosition[0, 1] += addedPosition[0, 1];

            return newPosition;
        }

        private Dictionary<char, int[,]> _positionInfo = new Dictionary<char, int[,]>()
        {
            {'E',new int[1,2]{{1,0}}},
            {'W',new int[1,2]{{-1,0}}},
            {'N',new int[1,2]{{0,1}}},
            {'S',new int[1,2]{{0,-1}}}
        };

    }

}
