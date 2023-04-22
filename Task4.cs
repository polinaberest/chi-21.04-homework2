using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    internal class Task4
    {
        public static void Run(uint len)
        {
            var speeds = new uint[len];
            uint minValue, maxValue;

            Console.Write("Enter a minimum possible speed: ");

            while (!uint.TryParse(Console.ReadLine(), out minValue) || minValue < 1)
            {
                Console.Write("Enter a whole positive number: ");
            }

            Console.Write("Enter a maximum possible speed: ");
            while (!uint.TryParse(Console.ReadLine(), out maxValue) || maxValue < 1)
            {
                Console.Write("Enter a whole positive number: ");
            }


            if (maxValue > minValue)
                Task3.FillArrayRandomly(speeds, minValue, maxValue);
            else
            {
                Console.WriteLine("Max should be bigger than min!");
                return;
            }

            uint maxSpeed = speeds.Max();
            int firstIndex = Array.IndexOf(speeds, maxSpeed);
            int lastIndex = Array.LastIndexOf(speeds, maxSpeed);

            Console.WriteLine($"Index of the fastest (first entry): {firstIndex}");
            Console.WriteLine($"Index of the fastest (last entry): {lastIndex}");
        }
    }
}
