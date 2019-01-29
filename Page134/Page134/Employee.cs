using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page134
{
    public class Employee: Person
    {
        public string occupation { get; set; }
        public List<string> things { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name:       " + firstName + " " + lastName);
            Console.WriteLine("Occupation: " + occupation);
            Console.WriteLine("ID Number:  " + Identity);
        }
    }
}
