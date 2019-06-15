using System;
using Zer0.NumbersToWords.Core;

namespace Zer0.NumbersToWords.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Demo";

            while (true)
            {
                Console.Write("your number : ");
                var number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"converted value: {number.ToWords()}");
            }
        }
    }
}
