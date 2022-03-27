using System.ComponentModel;

namespace MarsRover.Core.Enums
{
    /// <summary>
    ///  Hata kodlarını tek bir yerden yönetmek için kullanılmıştır.
    /// </summary>
    public enum MarsRoverError
    {
        [Description("Plato's limits have been exceeded.")]
        LimitError = 1,
        [Description("Unknown command detected. Only the M,L,R commands should be used.")]
        UnknownCommandError = 2,
        [Description("Unknown direction detected. Only the N,E,S,W directions should be used.")]
        UnknownDirectionError = 3,
        [Description("Unknown rover detected.")]
        UnknownRoverError = 4,
        [Description("The plateau coordinates were entered incorrectly. x > 0, y > 0 ")]
        UnknownPlateauSizeError = 5,
    }
}
