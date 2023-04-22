using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace homework2
{
    internal class BookStorage : ItemCollector, IMaxFinder
    {
        //private int[] pagesCount;
        //private const int BookCount = 100;

        public BookStorage(uint minCount, uint maxCount) : base(100, minCount, maxCount)
        { 
        }


        public BookStorage(int[] pagesCount) : base(100)
        {
            if (pagesCount == null)
            {
                throw new ArgumentNullException(nameof(pagesCount), "PagesCount array can`t be null");
            }
            else if (pagesCount.Length != 100) 
            {
                throw new ArgumentException("PagesCount must contain 100 elements", nameof(pagesCount));
            }

            //this.pagesCount = pagesCount;
        }

        protected override void FillRandomly(uint min, uint max) 
        { 
            Random random = new Random();
            itemArray = new int[Count];

            for (int i = 0; i < Count; i++)
            {
                itemArray[i] = random.Next((int)min, (int)max+1);
            }
        }

        public int FindMaxValue()
        { 
            return itemArray.Max(); 
        }
    }
}
