using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page124
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee example = new Employee();
            example.firstName = "Sample";
            example.lastName = "Student";
            example.gender = Convert.ToChar("X");
            example.occupation = "Computer Program";

            Console.WriteLine();
            example.SayName();
            Console.ReadLine();
        }
    }
}
