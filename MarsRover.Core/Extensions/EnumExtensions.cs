using MarsRover.Core.Enums;
using System.ComponentModel;

namespace MarsRover.Core.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDescription(this MarsRoverError val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
               .GetType()
               .GetField(val.ToString())
               .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
    }
}
