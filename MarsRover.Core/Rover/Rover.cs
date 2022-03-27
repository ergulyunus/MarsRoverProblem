using MarsRover.Core.Enums;
using MarsRover.Core.Extensions;
using MarsRover.Core.RoverDirections;
using System;
using System.Drawing;

namespace MarsRover.Core.Rover
{
    public class Rover : IRover
    {
        public Point RoverCoordinate { get; set; }
        public Direction Direction { get; set; }
        public string Commands { get; set; }
        public Point PlateauMaxLimitCoordinate { get; set; }
        public IRoverDirection roverDirection;

        public Rover(Point roverCoordinate, Direction direction, string commands, Point plateauMaxLimitCoordinate)
        {
            RoverCoordinate = roverCoordinate;
            Direction = direction;
            Commands = commands;
            PlateauMaxLimitCoordinate = plateauMaxLimitCoordinate;
        }
        public bool IsNotValidPoint()
        {
            var IsNotValidPoint = RoverCoordinate.X > PlateauMaxLimitCoordinate.X || RoverCoordinate.X < 0 || RoverCoordinate.Y > PlateauMaxLimitCoordinate.Y || RoverCoordinate.Y < 0;
            return IsNotValidPoint;
        }
        public void StartAction(string commands)
        {
            roverDirection = new RoverDirection(RoverCoordinate, Direction);

            foreach (var command in commands)
            {
                if (IsNotValidPoint())
                    Console.WriteLine($"{MarsRoverError.LimitError.GetDescription()}");

                switch (command)
                {
                    case (char)Command.Move:
                        RoverCoordinate = roverDirection.Move();
                        break;
                    case (char)Command.TurnLeft:
                        roverDirection = roverDirection.Left();
                        break;
                    case (char)Command.TurnRight:
                        roverDirection = roverDirection.Right();
                        break;
                    default:
                        Console.WriteLine($"{MarsRoverError.UnknownCommandError.GetDescription()}");
                        break;
                }

            }
        }
    }
}
