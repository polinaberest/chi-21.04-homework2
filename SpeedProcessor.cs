using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    internal class SpeedProcessor : ItemCollector
    {
        public SpeedProcessor(int[] carSpeeds) : base(40)
        {
            if (carSpeeds == null)
            {
                throw new ArgumentNullException(nameof(carSpeeds), "CarSpeeds can`t be null");
            }

            if (carSpeeds.Length != Count)
            {
                throw new ArgumentException($"CarSpeeds array Length should be {Count}", nameof(carSpeeds));
            }

            itemArray = carSpeeds;
        }

        public SpeedProcessor(uint minSpeed, uint maxSpeed) : base(40, minSpeed, maxSpeed)
        {
        }

        protected override void FillRandomly(uint min, uint max)
        {
            Random random = new Random();
            itemArray = new int[Count];

            for (int i = 0; i < Count; i++)
            {
                itemArray[i] = random.Next((int)min, (int)max + 1);
            }
        }

        public int FindFastestCarIndex()
        {
            int fastestIdx = Array.IndexOf(itemArray, itemArray.Max());

            if (fastestIdx == -1)
            {
                throw new InvalidOperationException("The array is empty");
            }

            return fastestIdx;
        }

        public int FindLastFastestCarIndex()
        {
            int fastestLastIdx = Array.LastIndexOf(itemArray, itemArray.Max());

            if (fastestLastIdx == -1)
            {
                throw new InvalidOperationException("The array is empty");
            }

            return fastestLastIdx;
        }
    }
}
