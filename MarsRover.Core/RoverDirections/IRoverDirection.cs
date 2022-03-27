using MarsRover.Core.Enums;
using System.Drawing;

namespace MarsRover.Core.RoverDirections
{
    public interface IRoverDirection
    {
        Point Move();
        IRoverDirection Left();
        IRoverDirection Right();
        Direction GetDirection();
    }
}
