using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using RoverApp.Helper;

namespace RoverApp.Test.RoverHelperTests
{
    [TestFixture]
    class when_rover_direction_turning
    {
        private RoverHelper _roverHelper;
        [SetUp]
        public void Setup()
        {
            _roverHelper = new RoverHelper();
        }

        [Test]
        public void should_return_left_way_when_command_letter_is_L()
        {
            char currentDirection = 'N';

            _roverHelper.TurnRoverDirection(currentDirection, 'L').Should().Be('W');
        }

        [Test]
        public void should_return_right_way_when_command_letter_is_R()
        {
            char currentDirection = 'R';

            _roverHelper.TurnRoverDirection(currentDirection, 'R').Should().Be('E');
        }
    }
}
