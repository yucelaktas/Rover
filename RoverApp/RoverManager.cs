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
        public int[,] RoverMove(int[,] correntPosition, params char[] commandLetters)
        {

            foreach (var letter in commandLetters)
            {
                switch (letter)
                {
                    case 'R':

                        break;

                    case 'L':

                        break;

                    case 'M':

                        break;
                }
            }


            return null;
        }
    }
}
