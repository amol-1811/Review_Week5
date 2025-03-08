using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Week5
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message)
        {
        }
    }
    internal class ValidateAge
    {
        public static void CheckAge()
        {
            Console.Write("Enter your age: ");
            int age;

            if (int.TryParse(Console.ReadLine(), out age))
            {
                try
                {
                    CheckIfLess(age);
                    Console.WriteLine("Age is valid.");
                }
                catch (InvalidAgeException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number for age.");
            }
        }
        public static void CheckIfLess(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException($"Invalid age: {age}. Age must be 18 or greater.");
            }
            else
            {
                Console.WriteLine("Age is valid.");
            }
            
        }
    }
}
