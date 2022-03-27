using MarsRover.Core.Enums;
using System.Drawing;

namespace MarsRover.Core.RoverDirections
{
    /// <summary>
    /// Her gezginin hareket kabiliyetlerini ve yön bilgisini temsil eder. 
    /// </summary>
    public interface IRoverDirection
    {
        Point Move();
        IRoverDirection Left();
        IRoverDirection Right();
        Direction GetDirection();
    }
}
