using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page128
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee botOne = new Employee();
            botOne.firstName = "Sample";
            botOne.lastName = "Student";
            botOne.gender = Convert.ToChar("X");
            botOne.occupation = "Computer Program";
            botOne.SayName();
            Console.WriteLine();

            Employee botTwo = new Employee();
            botTwo.firstName = "Sample";
            botTwo.lastName = "Student";
            botTwo.gender = Convert.ToChar("X");
            botTwo.occupation = "Computer Program";
            botTwo.SayName();
            Console.WriteLine();

            Employee botThree = new Employee();
            botThree.firstName = "Vancouver";
            botThree.lastName = "Canada";
            botThree.gender = Convert.ToChar("X");
            botThree.occupation = "Large City";
            botThree.SayName();
            Console.WriteLine();

            if (botOne == botTwo)
            {
                Console.WriteLine("Employees One and Two are identical");
            }
            if (botTwo != botThree)
            {
                Console.WriteLine("Employees Two and Three are NOT identical");
            }
            Console.WriteLine();

            //example.Quit(example);
            Console.ReadLine();
        }
    }
}