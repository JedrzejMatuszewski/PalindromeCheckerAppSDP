using System;
using System.Linq;

namespace PalindromeCheckerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type text to check if it's a palindorme:");

            var textToCheck = Console.ReadLine();
            if (PalindromeChecker.Check(textToCheck))
            {
                Console.WriteLine($"Text '{textToCheck}' is a palindrome :) ");
            }
            else
            {
                Console.WriteLine($"Text '{textToCheck}' is NOT a palindrome :( ");
            }


        }
    }
}
