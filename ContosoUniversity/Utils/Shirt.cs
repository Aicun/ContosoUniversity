using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Utils
{
    public class Shirt
    {
        public string Name { get; set; }
        public Color Color { get; set; }

    }

    public class Color
    {
        public string ColorType { get; set; }
        public string Value { get; set; }
    }
}