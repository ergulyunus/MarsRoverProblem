using MarsRover.Core.Enums;
using System.Drawing;

namespace MarsRover.Core.RoverDirections.States
{
    public class RoverDirectionNorth : IRoverDirection
    {
        private readonly Direction direction = Direction.N;
        public Point newCoordinate;

        public RoverDirectionNorth(Point coordinate)
        {
            newCoordinate = coordinate;
        }
        public Direction GetDirection()
        {
            return direction;
        }

        public IRoverDirection Left()
        {
            return new RoverDirectionWest(newCoordinate);
        }

        public Point Move()
        {
            newCoordinate.Y += 1;
            return newCoordinate;
        }

        public IRoverDirection Right()
        {
            return new RoverDirectionEast(newCoordinate);
        }
    }
}
