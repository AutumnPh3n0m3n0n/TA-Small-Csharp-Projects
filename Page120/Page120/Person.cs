using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page120
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public char gender { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name:       " + firstName + " " + lastName);
            Console.WriteLine("Gender:     " + gender);
        }
    }
}
