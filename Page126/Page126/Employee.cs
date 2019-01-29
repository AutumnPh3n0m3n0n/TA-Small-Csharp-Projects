using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page126
{
    class Employee: Person
    {
        public string occupation { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name:       " + firstName + " " + lastName);
            Console.WriteLine("Gender:     " + gender);
            Console.WriteLine("Occupation: " + occupation);
        }

        public void Quit()
        {
            Console.WriteLine(firstName + " " + lastName + " has quit their job.");

        }
    }
}
