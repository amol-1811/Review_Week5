using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Week5
{
    internal class PrimeNumber
    {
        public static void CheckIsPrime()
        {
            Console.Write("Enter a number : ");
            string input = Console.ReadLine();
            try
            {
                int num = int.Parse(input);
                if (num < 0)
                {
                    Console.WriteLine("Enter only a positive number.");
                    return;
                }
                if (IsPrime(num))
                {
                    Console.WriteLine($"{num} is a prime number.");
                }
                else
                {
                    Console.WriteLine($"{num} is not a prime number.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
        public static bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}