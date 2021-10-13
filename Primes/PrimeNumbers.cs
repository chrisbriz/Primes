using System;
using System.Collections.Generic;
using Primes.Menu;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes
{
    class PrimeNumbers
    {
        public static List<double> PrimeList = new List<double>();

        /// <summary>
        /// Checks if the user selected number is a prime nuumber and if yes, adds it to the list
        /// </summary>
        /// <param name="number">Number inputed by the user</param>
        public static void NumberSelection(double number)
        {
            if (!IsPrimeNumber(number))
                Helper.Error();
            else
                PrimeList.Add(number);
        }

        /// <summary>
        /// Adds the next largest prime number to the list if the list isn't empty
        /// </summary>
        public static void AddNextLargestPrime()
        {
            PrimeList.Sort();
            double nextPrime = GetNextPrime(PrimeList.Last());
            PrimeList.Add(nextPrime);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number">the number that needs to be confirmed as prime</param>
        /// <returns>Boolean</returns>
        private static bool IsPrimeNumber(double number)
        {
            double k = 2;
            if (number == 1)
            {
                return false;
            }
            while (k * k <= number)
            {
                if ((number % k) == 0)
                    return false;
                else k++;
            }
            return true;
        }

        /// <summary>
        /// Get the next highest prime number
        /// </summary>
        /// <param name="number">the current highest number in the list</param>
        /// <returns>the next highest number</returns>
        private static double GetNextPrime(double number)
        {

            double nextNumber = number + 1;

            while (!IsPrimeNumber(nextNumber))
            {
                nextNumber++;
            }

            return nextNumber;
        }
    }
}
