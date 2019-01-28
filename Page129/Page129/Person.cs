using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page129
{
    internal class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public char gender { get; set; }
        public int Identity { get; set; }

        public static bool operator == (Person getFirst, Person getSecond)
        {
            if (getFirst.Identity == getSecond.Identity)
                return true;
            else
                return false;
        }

        public static bool operator != (Person getFirst, Person getSecond)
        {
            if (getFirst.Identity == getSecond.Identity)
                return false;
            else
                return true;
        }

        public override bool Equals(System.Object input)
        {
            if (input == null)
                return false;

            Person Another = input as Person;
            if ((System.Object)Another == null)
                return false;

            return (Identity == Another.Identity);
        }

        public bool Equals(Person input)
        {
            if ((object)input == null)
                return false;

            return (input.Identity == input.Identity);
        }

        public override int GetHashCode()
        {
            return Identity.GetHashCode();
        }
    }
}
