using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes.Menu
{

    /// <summary>
    /// Part of the application where inputs are handled
    /// </summary>
    class MenuSelections
    {
        public static void Menu()
        {
            if (PrimeNumbers.PrimeList.Count > 0)
            {
                Console.WriteLine("Current Numbers in list");
                foreach (var number in PrimeNumbers.PrimeList)
                {
                    Console.Write(number + ", ");
                }
                Console.WriteLine("Press enter to contine");
                Console.ReadLine();
            }
            Console.WriteLine("1-Number selection");
            Console.WriteLine("2-Add next highest prime number");
            Console.WriteLine("3- Exit");
            var userInput = Helper.GetUserInputWithOption(3);
            MenuOptions(userInput);
        }

        /// <summary>
        /// Menu control, 
        /// In case 1, performs checks if the user inputs anything other than a number.
        /// In case 2, performs check if list is empty
        /// </summary>
        /// <param name="userInput"></param>
        private static void MenuOptions(int userInput)
        {
            switch (userInput)
            {
                case 1:
                    Console.WriteLine("Choose a number");
                    double number;
                    var isNumber = double.TryParse(Console.ReadLine(), out number);
                    if (!isNumber)
                    {
                        Helper.Error();
                        Menu();
                    }
                    PrimeNumbers.NumberSelection(number);
                    Menu();
                    break;
                case 2:
                    if (PrimeNumbers.PrimeList.Count <= 0)
                    {
                        Console.WriteLine("The list is empty");
                        Console.WriteLine("Press Enter to return to menu");
                        Console.ReadLine();
                        Menu();
                    }
                    PrimeNumbers.AddNextLargestPrime();
                    Menu();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
