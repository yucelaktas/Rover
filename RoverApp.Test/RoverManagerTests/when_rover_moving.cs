using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
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
        public void should_return_rover_not_null()
        {
            char Direction = 'W';

            int[,] Position = {{1, 1}};

            _mockedRoverHelper.Setup(x => x.TurnRoverDirection(Direction, 'L')).Returns('S');

            Rover result = _roverManager.RoverMove(new Rover(Position, Direction), 'L');

            result.Should().NotBeNull();
        }

        [Test]
        public void should_return_truth_rover_when_command_is_L()
        {
            char Direction = 'W';

            int[,] Position = { { 1, 1 } };

            _mockedRoverHelper.Setup(x => x.TurnRoverDirection(Direction, 'L')).Returns('S');

            Rover result = _roverManager.RoverMove(new Rover(Position, Direction), 'L');

            result.Direction.Should().Be('S');

        }

        [Test]
        public void should_truth_rover_when_command_is_L()
        {
            char Direction = 'W';

            int[,] Position = { { 1, 1 } };

            _mockedRoverHelper.Setup(x => x.TurnRoverDirection(Direction, 'R')).Returns('N');

            Rover result = _roverManager.RoverMove(new Rover(Position, Direction), 'R');

            result.Direction.Should().Be('N');
        }

        [Test]
        public void should_truth_rover_when_command_is_M()
        {
            char Direction = 'N';

            int[,] Position = { { 1, 1 } };

            _mockedRoverHelper.Setup(x=>x.ForwardRoverPosition(Direction,Position)).Returns(new int[1,2]{{2,1}});

            Rover result = _roverManager.RoverMove(new Rover(Position, Direction), 'M');

            result.Position[0, 0].Should().Be(2);

            result.Position[0, 1].Should().Be(1);
                
        }

    }
}
