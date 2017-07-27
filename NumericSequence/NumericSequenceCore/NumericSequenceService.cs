using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericSequenceCore
{
    public class NumericSequenceService
    {
        public int TheNumber { get; set; }
        private int[] fibonacci;

        public List<int> All()
        {
            var result = new List<int>();
            if (TheNumber > 0)
            {
                for (int i = 0; i <= TheNumber; i++)
                {
                    result.Add(i);
                }
            }
            return result;
        }

        public List<int> Odd()
        {
            var result = new List<int>();
            if (TheNumber > 0)
            {
                for (int i = 0; i <= TheNumber; i++)
                {
                    if (i % 2 != 0)
                        result.Add(i);
                }
            }
            return result;
        }

        public List<int> Even()
        {
            var result = new List<int>();
            if (TheNumber > 0)
            {
                for (int i = 0; i <= TheNumber; i++)
                {
                    if (i % 2 == 0)
                        result.Add(i);
                }
            }
            return result;
        }

        public List<string> Multipler()
        {
            var result = new List<string>();
            if (TheNumber > 0)
            {
                for (int i = 0; i <= TheNumber; i++)
                {
                    var value = i.ToString();
                    if (i % 3 == 0)
                        value = "C";
                    if (i % 5 == 0)
                        value = "E";
                    if (i % 15 == 0)
                        value = "Z";
                    result.Add(value);
                }
            }
            return result;
        }

        private void FibonacciGenerate()
        {
            fibonacci[0] = 0;
            fibonacci[1] = 1;
            for (int i = 2; fibonacci[i - 1] <= TheNumber; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }

        }

        public List<int> Fibonacci()
        {
            FibonacciGenerate();
            return fibonacci.ToList();
        }

    }
}
