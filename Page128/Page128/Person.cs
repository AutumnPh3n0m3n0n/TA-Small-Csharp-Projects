using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page128
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public char gender { get; set; }

        public static bool operator == (Person firstEmploy, Person secondEmploy)
        {
            if (String.Compare(firstEmploy.firstName, secondEmploy.firstName) != 0)
                return false;
            if (String.Compare(firstEmploy.lastName, secondEmploy.lastName) != 0)
                return false;
            if (firstEmploy.gender != secondEmploy.gender)
                return false;

            return true;
        }

        public static bool operator != (Person firstEmploy, Person secondEmploy)
        {
            if (String.Compare(firstEmploy.firstName, secondEmploy.firstName) != 0)
                return true;
            if (String.Compare(firstEmploy.lastName, secondEmploy.lastName) != 0)
                return true;
            if (firstEmploy.gender != secondEmploy.gender)
                return true;

            return false;
        }
    }
}