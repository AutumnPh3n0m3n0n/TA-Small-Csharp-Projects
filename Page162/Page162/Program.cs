using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page162
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the license plate number of your car?    ");
            string license = Console.ReadLine();
            Car setCar = new Car(license);
            Console.WriteLine();
            Console.Write("What is your first name?   ");
            string first = Console.ReadLine();
            Console.Write("What is your last name?    ");
            string last = Console.ReadLine();
            var setName = new Person(first, last);
            Console.WriteLine();
            setCar.Details();
            Console.WriteLine();
            setName.Description();
            Console.ReadLine();

        }
    }
}
