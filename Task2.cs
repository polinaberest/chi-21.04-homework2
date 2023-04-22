using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    internal class Task2
    {
        public static void Run()
        {
            int max = -1;
            int maxIdx = -1;

            Console.WriteLine("Enter your text with whitespaces: ");
            string input = Console.ReadLine().TrimStart();

            if (input.Length > 0)
            {
                max = input.Where(char.IsDigit).Max(c => c - '0');
                maxIdx = input.IndexOf(max.ToString());
            }

           
            Console.WriteLine($"Index of the maximum digit: {maxIdx} {Environment.NewLine}");
        }
    }
}
