using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Utils
{
    public class PersonInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Greeting { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + BirthDate+ " "+ Gender + " " +Age + " " + Greeting;
        }
    }
}