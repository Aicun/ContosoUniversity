using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Utils
{
    public class Calculation
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public int Add()
        {
            return FirstNumber + SecondNumber;
        }
    }
}