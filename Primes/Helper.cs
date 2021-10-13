using System;
using System.Collections.Generic;
using System.Threading;
using static System.Int32;
using static System.String;

namespace Primes
{
    class Helper
    {
        private static bool Success;
        private static string Input;
        private static int Number;

        /// <summary>
        /// Get user input as an integer.
        /// Method prompts user for input:
        /// {optionTag}: _____
        /// </summary>
        /// <param name="maxOptions">Maximum amount of input available for user to choose.</param>
        /// <param name="optionTag">ex: Option: // Amount: )</param>
        /// <returns>integer if user input was correct.</returns>
        public static int GetUserInputWithOption(int maxOptions)
        {
            Console.Write("Option: ");
            Input = Console.ReadLine()?.Trim().ToLower();
            Success = TryParse(Input, out Number);
            if (!Success || Number > maxOptions || Number <= 0)
            {
                Error();
                GetUserInputWithOption(maxOptions);
            }
            Console.ResetColor();
            return Number;
        }

        /// <summary>
        /// If user entered erronous input an error message will be displayed.
        /// </summary>
        public static void Error()
        {
            Console.WriteLine("Error, wrong input or number is not prime. Try again.");
            Thread.Sleep(1300);
        }
    }
}
