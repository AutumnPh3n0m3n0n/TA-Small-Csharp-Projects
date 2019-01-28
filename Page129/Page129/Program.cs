using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page129
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee botOne = new Employee();
            botOne.firstName = "Sample";
            botOne.lastName = "Student";
            botOne.gender = Convert.ToChar("X");
            botOne.Identity = 22222;
            botOne.occupation = "Computer Program";
            botOne.SayName();
            Console.WriteLine();

            Employee botTwo = new Employee();
            botTwo.firstName = "Example";
            botTwo.lastName = "Student";
            botTwo.gender = Convert.ToChar("X");
            botTwo.Identity = 22222;
            botTwo.occupation = "Computer Program";
            botTwo.SayName();
            Console.WriteLine();

            Employee bot3 = new Employee();
            bot3.firstName = "Another";
            bot3.lastName = "Student";
            bot3.gender = Convert.ToChar("X");
            bot3.Identity = 33333;
            bot3.occupation = "Computer Program";
            bot3.SayName();
            Console.WriteLine();

            if (botOne == botTwo)
                Console.WriteLine("Programs One and Two are the same.");
            if (botTwo != bot3)
                Console.WriteLine("Programs Two and Three are NOT the same.");

            Console.ReadLine();
        }
    }
}
