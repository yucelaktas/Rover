using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoverApp.Model;

namespace RoverApp.Helper
{
    public interface IRoverHelper
    {
        char TurnRoverDirection(char currentDirection, char commandLetter);

        int[,] ForwardRoverPosition(char currentDirection, int[,] currentPosition);

    }
}
