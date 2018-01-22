using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverApp.Model
{
    public class Rover : IMoveable
    {
        public Rover(int[,] startedPosition, char startedDireciton)
        {
            if (startedPosition.GetLength(0) == 1 && startedPosition.GetLongLength(1) == 2)
            {
                char[] directions = {'N', 'S', 'W', 'E'};
                if (directions.Equals(startedDireciton))
                {
                    _position = startedPosition;
                    _direction = startedDireciton;
                }
            }
            else
            {
                _position = new int[1, 2]
                {
                    {0, 0}
                };

                _direction = 'N';
            }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int[,] _position;

        public int[,] Position
        {
            get { return _position; }

            set
            {
                if (value.GetLength(0) == 1 && value.GetLongLength(1) == 2)
                {
                    _position = value;
                }
            }
        }

        private char _direction;

        public char Direction
        {
            get { return _direction; }
            set { _direction = value; }
        }


        public void Move(char commandLetter)
        {
            char[] commandLetters = { 'L', 'R', 'M' };

            if (commandLetters.Equals(commandLetter))
            {
                

            }
        }
    }
}
