using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page137
{
    class Program
    {
        static void Main(string[] args)
        {
            Number toInitial = new Number();
            toInitial.Amount = 4.294967296m;

            Console.WriteLine("\n" + toInitial.Amount);
            Console.WriteLine("\nThis number is 2^32 divided by 10^9");

            Console.ReadLine();
        }
    }
}