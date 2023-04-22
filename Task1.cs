using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    internal class Task1
    {
        public static void Run()
        {
            int sum = 0;
            int max = -1;

            Console.Write("Enter the text: ");
            string input = Console.ReadLine();

            if (input.Length > 0)
            {
                sum = input.Where(char.IsDigit).Sum(c => c - '0');
                max = input.Where(char.IsDigit).Max(c => c - '0');
            }

            Console.WriteLine($"Digits sum: {sum}");
            Console.WriteLine($"Max digit: {max} {Environment.NewLine}");
        }
    }
}
