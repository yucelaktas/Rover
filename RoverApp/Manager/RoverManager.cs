using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RoverApp.Helper;
using RoverApp.Model;

namespace RoverApp
{
    public class RoverManager
    {
        private readonly IRoverHelper _roverHelper;

        public RoverManager(IRoverHelper roverHelper)
        {
            _roverHelper = roverHelper;
        }

        public Rover RoverMove(Rover rover, params char[] commandLetters)
        {
            char currentD = rover.Direction;

            int[,] currentP = rover.Position;

            RoverHelper roverHelper = new RoverHelper();

            foreach (var letter in commandLetters)
            {
                if (letter == 'M')
                    rover.Position = roverHelper.ForwardRoverPosition(currentD, currentP);
                else
                {
                    rover.Direction = roverHelper.TurnRoverDirection(currentD, letter);
                }
            }

            return rover;
        }

    }
}

