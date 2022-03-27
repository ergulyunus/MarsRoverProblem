using MarsRover.Core.Enums;
using System.Drawing;

namespace MarsRover.Core.RoverDirections.States
{
    public class RoverDirectionSouth : IRoverDirection
    {
        private readonly Direction direction = Direction.S;
        public Point newCoordinate;

        public RoverDirectionSouth(Point coordinate)
        {
            newCoordinate = coordinate;
        }

        public Direction GetDirection()
        {
            return direction;
        }

        public IRoverDirection Left()
        {
            return new RoverDirectionEast(newCoordinate);
        }

        public Point Move()
        {
            newCoordinate.Y -= 1;
            return newCoordinate;
        }

        public IRoverDirection Right()
        {
            return new RoverDirectionWest(newCoordinate);
        }
    }
}
