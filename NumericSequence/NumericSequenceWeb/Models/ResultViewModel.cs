using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NumericSequenceWeb.Models
{
    public class ResultViewModel
    {
        public List<int> All { get; set; }
        public List<int> Odd { get; set; }
        public List<int> Even { get; set; }
        public ArrayList Multipler { get; set; }
        public ArrayList Fibonacci { get; set; }
    }
}