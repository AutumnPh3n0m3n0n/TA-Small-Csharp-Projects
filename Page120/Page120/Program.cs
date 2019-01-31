using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page120
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee example = new Employee();
            example.firstName = "Sample";
            example.lastName = "Student";
            example.gender = Convert.ToChar("X");
            example.identity = 1234;

            Console.WriteLine();
            example.SayName();
            example.giveID();
            Console.ReadLine();
        }
    }
}
