using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page115
{
    class Program
    {
        static void Main(string[] args)
        {
            Math toMix = new Math();
            int response1;
            char option;
            int response2;
            Console.Write("Please enter in a number: ");
            response1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Do you want to enter in another number? (Press Y for Yes)  ");
            option = Convert.ToChar(Console.ReadLine());
            if (option == 'y' || option == 'Y')
            {
                Console.Write("\nPlease enter in another number: ");
                response2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine(toMix.twoNumbers(response1, response2));
            }
            else
            {
                Console.WriteLine(toMix.oneNumber(response1));
            }
            Console.WriteLine("\n\nIf the second number is null and I passed it in as a function, an exception would happen");
            Console.WriteLine("causing the program to crash.");
            Console.ReadLine();


        }
    }
}
