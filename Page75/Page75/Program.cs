using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page75
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In this excersize, we will see if you quality for car insurance. To quality, you must have:");
            Console.WriteLine("1. Be at least 16 years of age");
            Console.WriteLine("2. Don't have any DUIs");
            Console.WriteLine("3. Have up to 3 parking or speeding violations");
            bool insurance = true;

            Console.Write("\nHow old are you?  ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 16)
                insurance = false;

            Console.Write("Do you have a DUI? (Answer Y for Yes or N for No)     ");
            char DUI = Console.ReadKey().KeyChar;
            if (DUI == 'Y' || DUI == 'y')
                insurance = false;

            Console.Write("\n\nHow many speeding or parking violations do you have? (Answer 0 if none)      ");
            int citations = Convert.ToInt32(Console.ReadLine());
            if (citations > 3)
                insurance = false;

            if (insurance == true)
                Console.WriteLine("\nCongratulations! You quality for car insurance.");
            else
            {
                Console.WriteLine("Unfortunately, you fail to quality for car insurance");
                Console.WriteLine("You need to be at least 16 years old, have no DUI violations,");
                Console.WriteLine("and must have no more than 3 parking or speeding violations.");
            }
            Console.ReadLine();
        }
    }
}
