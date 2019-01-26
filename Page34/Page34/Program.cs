using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your first name:       ");
            string first = Console.ReadLine();
            Console.Write("Please enter your last name:        ");
            string last = Console.ReadLine();
            Console.WriteLine("Welcome to Acme Accounting Systems " + first + " " + last);
            Console.WriteLine("Remember, we’re “accounting” on you!");
            Console.ReadLine();
        }
    }
}
