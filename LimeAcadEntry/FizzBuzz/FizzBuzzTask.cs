using System;
using System.Text;

namespace FizzBuzz
{
    class FizzBuzzTask
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            FizzBuzz(n);            
        }

        private static void FizzBuzz(int n)
        {
            var sb = new StringBuilder();

            for (int number = 1; number <= n; number++)
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    sb.AppendLine("FizzBuzz");
                }
                else if (number % 3 == 0 && number % 5 != 0)
                {
                    sb.AppendLine("Fizz");
                }
                else if (number % 3 != 0 && number % 5 == 0)
                {
                    sb.AppendLine("Buzz");
                }
                else
                {
                    sb.AppendLine(number.ToString());
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
