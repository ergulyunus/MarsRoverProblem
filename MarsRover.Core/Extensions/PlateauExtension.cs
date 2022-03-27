using System.Drawing;

namespace MarsRover.Core.Extensions
{
    public static class PlateauExtension
    {
        public static Point ToPoint(this string plateauSize)
        {
            var result = new Point(0, 0);
            if (!string.IsNullOrWhiteSpace(plateauSize))
            {
                var area = plateauSize.Split(' ');
                if (area.Length == 2)
                {
                    if (int.TryParse(area[0], out int x))
                    {
                        if (int.TryParse(area[1], out int y))
                        {
                            result.X = x;
                            result.Y = y;
                        }
                    }

                }
            }

            return result;
        }
    }
}
