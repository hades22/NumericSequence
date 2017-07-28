using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericSequenceCore
{
    public interface INumericSequenceService
    {
        int TheNumber { get; set; }
        List<int> All();
        List<int> Odd();
        List<int> Even();
        ArrayList Multipler();
        ArrayList FibonacciGenerate();
    }

    public class NumericSequenceService: INumericSequenceService
    {
        public int TheNumber { get; set; }
        

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

        public ArrayList Multipler()
        {
            var result = new ArrayList();
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
                    result.Insert(i, value);
                }
            }
            return result;
        }

        public ArrayList FibonacciGenerate()
        {
            ArrayList fibonacci = new ArrayList();
            fibonacci.Insert(0, 0);
            fibonacci.Insert(1, 1);
            for (int i = 2; (int) fibonacci[i - 1] <= TheNumber; i++)
            {
                var value = (int) fibonacci[i - 1] + (int) fibonacci[i - 2];
                if (value > TheNumber)
                    break;              
                fibonacci.Insert(i, value);
            }
            return fibonacci;
        }


    }
}
