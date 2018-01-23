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
        public Rover RoverMove(Rover rover, params char[] commandLetters)
        {
            char currentD = rover.Direction;

            int[,] currentP = rover.Position;

            RoverHelper roverHelper = new RoverHelper();


            foreach (var letter in commandLetters)
            {
                if (letter == 'M')
                    roverHelper.ForwardRover(currentD,ref currentP);
                else
                {
                    roverHelper.TurnRover(ref currentD,letter);
                }
            }

            rover.Position = currentP;

            rover.Direction = currentD;

            return rover ;
        }

    }

}
