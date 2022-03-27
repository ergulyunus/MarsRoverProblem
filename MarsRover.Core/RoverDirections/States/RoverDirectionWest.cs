using MarsRover.Core.Enums;
using System.Drawing;

namespace MarsRover.Core.RoverDirections.States
{
    public class RoverDirectionWest : IRoverDirection
    {
        private readonly Direction direction = Direction.W;
        public Point newCoordinate;
        public RoverDirectionWest(Point coordinate)
        {
            newCoordinate = coordinate;
        }

        public Direction GetDirection()
        {
            return direction;
        }

        public IRoverDirection Left()
        {
            return new RoverDirectionSouth(newCoordinate);
        }

        public Point Move()
        {
            newCoordinate.X -= 1;
            return newCoordinate;
        }

        public IRoverDirection Right()
        {
            return new RoverDirectionNorth(newCoordinate);
        }
    }
}
