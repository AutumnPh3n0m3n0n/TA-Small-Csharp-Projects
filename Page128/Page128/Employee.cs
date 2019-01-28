using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page128
{
    public class Employee : Person
    {
        public string occupation { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name:       " + firstName + " " + lastName);
            Console.WriteLine("Gender:     " + gender);
            Console.WriteLine("Occupation: " + occupation);
        } 

    }
}
