using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    internal class TextProcessor : IMaxFinder
    {
        private string text;

        public TextProcessor(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text), "Text can`t be null");
            }

            this.text = text;
        }

        public int FindDigitsSum()
        {
            int sum = 0;

            foreach (char c in text)
            {
                Int32.TryParse(c.ToString(), out int digit);
                sum += digit;
            }
            return sum;
        }

        public int FindMaxValue()
        {
            int max = Int32.MinValue;

            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    max = Math.Max(max, int.Parse(c.ToString()));
                }
            }

            return max==Int32.MinValue ? -1 : max;
        }

        public int FindMaxIndex()
        {
            int max = Int32.MinValue;
            int idx = 0;
            string str = text.Trim();

            foreach (char c in str)
            {
                if (char.IsDigit(c))
                {
                    int digit = int.Parse(c.ToString());
                    if (digit > max)
                    {
                        max = digit;
                        idx = str.IndexOf(c); 
                    }
                }
            }

            return max == Int32.MinValue ? -1 : idx;
        }

        public override string ToString()
        {
            return text;
        }
    }
}
