using System;
using System.Collections.Generic;

namespace MarsRover.Core.Helper
{
    public static class Helper
    {
        /// <summary>
        ///  Girilen Yön bilgisinin doğruluğunu kontrol eder. 
        /// </summary>
        /// <param name="direction"> string olarak yön bilgisi N,E,S,W değerlerinden biri olmalıdır. </param>
        /// <returns> bool </returns>
        public static bool CheckDirection(string direction)
        {
            var result = true;
            List<string> directions = new List<string>() { "N", "E", "S", "W" };

            if (!directions.Contains(direction))
                result = false;

            return result;
        }

        /// <summary>
        ///  Komut bilgisinin doğruluğunu kontrol eder. 
        /// </summary>
        /// <param name="command"> string olarak yön bilgisi M,L,R değerlerinden biri olmalıdır. </param>
        /// <returns> bool </returns>
        public static bool CheckCommands(string command)
        {
            var result = true;
            List<char> commands = new List<char>() { 'M', 'L', 'R' };

            foreach (var item in command)
            {
                if (!commands.Contains(item))
                    result = false;
            }
            return result;
        }

        /// <summary>
        ///  Girilen plato büyüklük bilgisinin doğruluğunu kontrol eder. 
        /// </summary>
        /// <param name="input"> string olarak input 2 karakterden oluşur ve aralarında ' ' boşluk vardır. </param>
        /// <returns> bool </returns>
        public static bool CheckPlateauInput(string input)
        {
            var sizes = input.ToUpper().Trim().Split(' ');
            foreach (var size in sizes)
            {
                foreach (char chr in size.ToCharArray())
                {
                    if (!Char.IsNumber(chr) || chr < 0) return false;
                }
            }
            return true;
        }

        /// <summary>
        ///  Girilen gezgin bilgilerinin doğruluğunu kontrol eder. 
        /// </summary>
        /// <param name="input"> string olarak input 3 karakterden oluşur ve aralarında ' ' boşluk vardır. ilk 2 karakter koordinat bilgisi için nümeric olmalı son karakter yön bilgisi için N,E,S,W karakterterinden biri olmalıdır. </param>
        /// <returns> bool </returns>
        public static bool CheckRoverInput(string input)
        {
            var roverInfo = input.ToUpper().Trim().Split(' ');
            if (roverInfo.Length != 3)
                return false;

            for (int i = 0; i < 2; i++)
            {
                foreach (char chr in roverInfo[i].ToCharArray())
                {
                    if (!Char.IsNumber(chr) || chr < 0) return false;
                }
            }

            if (!CheckDirection(roverInfo[2])) return false;
            //foreach (char chr in roverInfo[2].ToCharArray())
            //{
            //    if (Char.IsNumber(chr) || Char.IsPunctuation(chr)) return false;
            //}

            return true;
        }
    }
}
