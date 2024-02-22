using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    internal class FizzBuzz
    {
        static void Main(string[] args)
        {
            int input = 100;
            FizzBuzzprint(input);
            Console.ReadLine();
        }

        private static void FizzBuzzprint(int input)
        {
            for (int i = 1; i <= input; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
}
