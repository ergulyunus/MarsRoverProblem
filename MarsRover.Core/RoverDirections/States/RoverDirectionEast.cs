using MarsRover.Core.Enums;
using System.Drawing;

namespace MarsRover.Core.RoverDirections.States
{
    public class RoverDirectionEast : IRoverDirection
    {
        private readonly Direction direction = Direction.E;
        public Point newCoordinate;

        public RoverDirectionEast(Point coordinate)
        {
            newCoordinate = coordinate;
        }

        public Direction GetDirection()
        {
            return direction;
        }

        public IRoverDirection Left()
        {
            return new RoverDirectionNorth(newCoordinate);
        }

        public Point Move()
        {
            newCoordinate.X += 1;
            return newCoordinate;
        }

        public IRoverDirection Right()
        {
            return new RoverDirectionSouth(newCoordinate);
        }
    }
}
