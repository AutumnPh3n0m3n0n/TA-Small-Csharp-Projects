using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDrills
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nDrill Number 1: Multiply by 50");
            Console.Write("Enter a number:  ");
            long num_1 = Convert.ToInt32(Console.ReadLine());
            num_1 *= 50;
            Console.WriteLine("The number you entered multiplied by 50 is   " + num_1);

            Console.WriteLine("\nDrill Number 2: Adding 25");
            Console.Write("Enter a number:  ");
            int num_2 = Convert.ToInt32(Console.ReadLine());
            num_2 += 25;
            Console.WriteLine("\nThe number you entered added by 25 is   " + num_2);

            Console.WriteLine("\nDrill Number 3: Dividing by 12.5");
            Console.Write("Enter a number:  ");
            double num_3 = Convert.ToInt32(Console.ReadLine());
            num_3 /= 12.5;
            Console.WriteLine("\nThe number you entered divided by 12.5 is   " + num_3);

            Console.WriteLine("\nDrill Number 4: Greater than 50?");
            Console.Write("Enter a number:  ");
            int num_4 = Convert.ToInt32(Console.ReadLine());
            bool greaterThan50;
            if (num_4 > 50)
                greaterThan50 = true;
            else
                greaterThan50 = false;
            Console.WriteLine("Is the number " + num_4 + " greater than 50?   " + greaterThan50);

            Console.WriteLine("\nDrill Number 5: Remainder from 7");
            Console.Write("Enter a number:  ");
            int num_5 = Convert.ToInt32(Console.ReadLine());
            int rem = num_5 % 7;
            Console.WriteLine("The number " + num_5 + " when divided by 7 has a remainder of   " + rem);
            Console.ReadLine();
        }
    }
}
