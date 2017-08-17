using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int iterations = 100;

            fizzBuzzer(iterations);
        }

        public static void fizzBuzzer(int numberOfIterations)
        {
            String buffer = "";

            for (int i = 0; i < numberOfIterations; i++)
            {
                buffer += i + ": ";

                if ((i % 3) == 0)
                    buffer += "Fizz";

                if ((i % 5) == 0)
                    buffer += "Buzz";

                buffer += "\n";
            }

            Console.Write(buffer);
        }
    }
}
