using MarsRover.Core.Enums;
using MarsRover.Core.Extensions;
using MarsRover.Core.Helper;
using MarsRover.Core.Rover;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace MarsRover
{
    class Program
    {
        static void Main()
        {
            var resultList = new List<String>();
            var plateauSize = Console.ReadLine().ToUpper().Trim();

            if (!Helper.CheckPlateauInput(plateauSize))
            {
                Console.WriteLine(MarsRoverError.UnknownPlateauSizeError.GetDescription());
                return;
            }

            // 2 Gezgin için input değerlerinin alınması sağlandı. (Eğer 1 veya 2 den çok girilebilecekse düzenlenmelidir.)
            for (int i = 0; i < 2; i++)
            {
                var roverInfo = Console.ReadLine().ToUpper().Trim();
                if (!Helper.CheckRoverInput(roverInfo))
                {
                    Console.WriteLine(MarsRoverError.UnknownRoverError.GetDescription());
                    return;
                }

                Point coordinete = new Point() { X = Convert.ToInt32(roverInfo.Split(' ')[0]), Y = Convert.ToInt32(roverInfo.Split(' ')[1]) };
                if (!Helper.CheckDirection(roverInfo.Split(' ')[2]))
                {
                    Console.WriteLine($"{MarsRoverError.UnknownDirectionError.GetDescription()}");
                    return;
                }

                var direction = (Direction)Enum.Parse(typeof(Direction), roverInfo.Split(' ')[2]);
                var commands = Console.ReadLine().ToUpper();
                if (!Helper.CheckCommands(commands))
                {
                    Console.WriteLine($"{MarsRoverError.UnknownCommandError.GetDescription()}");
                    return;
                }

                var rover = new Rover(coordinete, direction, commands, plateauSize.ToPoint());
                rover.StartAction(commands);
                resultList.Add($"{rover.RoverCoordinate.X} {rover.RoverCoordinate.Y} {rover.roverDirection.GetDirection()}");
            }

            foreach (var item in resultList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
