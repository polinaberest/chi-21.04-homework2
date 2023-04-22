using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    internal abstract class ItemCollector
    {
        protected readonly int Count;
        protected int[] itemArray;

        public ItemCollector(int count)
        {
            Count = count;
        }

        public ItemCollector(int count, uint min, uint max) : this(count)
        {
            if (max > min)
                FillRandomly(min, max);
            else
            {
                throw new ArgumentException("Max should be bigger than min :)", nameof(itemArray));
            }
        }

        protected abstract void FillRandomly(uint min, uint max);
    }
}
