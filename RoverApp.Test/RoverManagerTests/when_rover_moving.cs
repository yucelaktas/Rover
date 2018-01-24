using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using RoverApp.Helper;
using RoverApp.Model;

namespace RoverApp.Test.RoverManagerTests
{
    [TestFixture]
    public class when_rover_moving
    {
        private Mock<IRoverHelper> _mockedRoverHelper;

        private RoverManager _roverManager; 
        
        [SetUp]
        public void Setup()
        {
            _mockedRoverHelper = new Mock<IRoverHelper>();

            _roverManager = new RoverManager(_mockedRoverHelper.Object);
        }

        [Test]
        public void should_Return_Rover_Not_Null()
        {
            char currentDirection = 'W';
            int[,] currentPosition = {{1, 1}};

            _mockedRoverHelper.Setup(x => x.ForwardRoverPosition(currentDirection, currentPosition)
                .Returns();

            _mockedRoverHelper.Setup(x=>x.TurnRoverDirection('W','L').ret

        }

    }
}
