using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    internal class Task3
    {
        public static void Run(uint len)
        {
            var pages = new uint[len];
            uint minValue, maxValue;

            Console.Write("Enter a minimum possible book pages count: ");
            
            while (!uint.TryParse(Console.ReadLine(), out minValue) || minValue < 1)
            {
                Console.Write("Enter a whole positive number: ");
            }

            Console.Write("Enter a maximum possible book pages count: ");
            while (!uint.TryParse(Console.ReadLine(), out maxValue) || maxValue < 1)
            {
                Console.Write("Enter a whole positive number: ");
            }


            if (maxValue > minValue)
                FillArrayRandomly(pages, minValue, maxValue);
            else
            {
                Console.WriteLine("Max should be bigger than min!");
                return;
            }

            uint maxPages = pages.Max();
            Console.WriteLine($"Pages count in the largest book: {maxPages} {Environment.NewLine}");
        }

        public static void FillArrayRandomly(uint[] array, uint minValue, uint maxValue)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (uint)random.Next((int)minValue, (int)(maxValue + 1));
            }
        }

    }
}
