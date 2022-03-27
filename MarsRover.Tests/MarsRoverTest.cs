using MarsRover.Core.Enums;
using MarsRover.Core.Extensions;
using MarsRover.Core.Helper;
using MarsRover.Core.Rover;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Xunit;

namespace MarsRover.Tests
{
    public class MarsRoverTest
    {
        [Theory]
        [InlineData("5 5", "1 2 N", "LMLMLMLMM")]
        public void MarsRoverTest_With_Correct_Request_Parameter_Then_OK_Test(string plateauSize, string roverInfo, string roverCommands)
        {
            Point coordinete = new Point() { X = Convert.ToInt32(roverInfo.Split(' ')[0]), Y = Convert.ToInt32(roverInfo.Split(' ')[1]) };
            var direction = (Direction)Enum.Parse(typeof(Direction), roverInfo.Split(' ')[2]);
            var rover = new Rover(coordinete, direction, roverCommands, plateauSize.ToPoint());
            rover.StartAction(roverCommands);

            Assert.Equal("1 3 N", $"{rover.RoverCoordinate.X} {rover.RoverCoordinate.Y} {rover.roverDirection.GetDirection()}");
        }

    }
}
