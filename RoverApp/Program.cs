using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoverApp.Model;

namespace RoverApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rover rover1 = new Rover(new[,] { { 1, 2 } }, 'N');

            rover1.Name = "rover1";

            Rover rover2 = new Rover(new[,] { { 3, 3 } }, 'E');

            rover2.Name = "rover2";

            RoverManager roverManager = new RoverManager();

            rover1 = roverManager.RoverMove(rover1, 'L', 'M', 'L', 'M', 'L', 'M', 'L', 'M', 'M');

            rover2 = roverManager.RoverMove(rover2, 'M', 'M', 'R', 'M', 'M', 'R', 'M', 'R', 'R', 'M');

            Console.WriteLine(rover1.Name + "   " + rover1.Position[0, 0] + "," + rover1.Position[0, 1] + "," + rover1.Direction);

            Console.WriteLine(rover2.Name + "   " + rover2.Position[0, 0] + "," + rover2.Position[0, 1] + "," + rover2.Direction);

            Console.ReadLine();
        }
    }
}
