using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page140
{
    class Employee: Person
    {
        public string occupation { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name:       " + firstName + " " + lastName);
            Console.WriteLine("Gender:     " + gender);
            Console.WriteLine("Occupation: " + occupation);
            Console.WriteLine("ID Number:  " + Identity);
        }

        public Employee (string first, string last, char sex, string job, int ident)
        {
            firstName = first;
            lastName = last;
            gender = sex;
            occupation = job;
            Identity = ident;
        }
    }
}
