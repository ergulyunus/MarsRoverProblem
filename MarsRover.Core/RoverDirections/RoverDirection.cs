using MarsRover.Core.Enums;
using MarsRover.Core.RoverDirections.States;
using System.Drawing;

namespace MarsRover.Core.RoverDirections
{
    class RoverDirection : IRoverDirection
    {
        private readonly IRoverDirection roverDirection;

        public RoverDirection(Point coordinate, Direction direction)
        {
            switch (direction)
            {
                case Direction.N:
                    roverDirection = new RoverDirectionNorth(coordinate);
                    break;
                case Direction.E:
                    roverDirection = new RoverDirectionEast(coordinate);
                    break;
                case Direction.S:
                    roverDirection = new RoverDirectionSouth(coordinate);
                    break;
                case Direction.W:
                    roverDirection = new RoverDirectionWest(coordinate);
                    break;
                default:
                    break;
            }
        }
        public Direction GetDirection()
        {
            return roverDirection.GetDirection();
        }

        public IRoverDirection Left()
        {
            return roverDirection.Left();
        }

        public Point Move()
        {
            return roverDirection.Move();
        }

        public IRoverDirection Right()
        {
            return roverDirection.Right();
        }
    }
}
