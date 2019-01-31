using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page120
{
    public class Employee: Person
    {
        public int identity { get; set; }

        public void giveID()
        {
            Console.WriteLine("ID number:  " + identity);
        }
    }
}
