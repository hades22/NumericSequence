using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace NumericSequenceWeb.Models
{
    public class ResultViewModel
    {
        public ResultViewModel()
        {
            Number = 0;
        }
        public int Number { get; set; }
        public List<int> All { get; set; }
        public List<int> Odd { get; set; }
        public List<int> Even { get; set; }
        public ArrayList Multipler { get; set; }
        public ArrayList Fibonacci { get; set; }

        public string AllList
        {
            get
            {
                StringBuilder list = new StringBuilder();
                foreach(var value in All)
                {
                    list.Append(value.ToString() + ", ");
                }
                return list.ToString();
            }
        }

        public string OddList
        {
            get
            {
                StringBuilder list = new StringBuilder();
                foreach (var value in Odd)
                {
                    list.Append(value.ToString() + ", ");
                }
                return list.ToString();
            }
        }

        public string EvenList
        {
            get
            {
                StringBuilder list = new StringBuilder();
                foreach (var value in Even)
                {
                    list.Append(value.ToString() + ", ");
                }
                return list.ToString();
            }
        }


        public string MultiplerList
        {
            get
            {
                StringBuilder list = new StringBuilder();
                foreach (var value in Multipler)
                {
                    list.Append(value.ToString() + ", ");
                }
                return list.ToString();
            }
        }

        public string FibonacciList
        {
            get
            {
                StringBuilder list = new StringBuilder();
                foreach (var value in Fibonacci)
                {
                    list.Append(value.ToString() + ", ");
                }
                return list.ToString();
            }
        }
    }
}