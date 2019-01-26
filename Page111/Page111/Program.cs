using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page111
{
    class Program
    {
        static void Main(string[] args)
        {
            int Response;
            do
            {
                Console.Write("\nPlease input a number:   ");
                Response = Convert.ToInt32(Console.ReadLine());
                if (Response > 40000 || Response < -40000)
                    Console.WriteLine("You number is too large (must be within -40000 and 40000 to prevent overflow)");
            } while (Response > 40000 || Response < -40000);
            //setting some conditions to prevent problems

            Console.WriteLine("\nYour number is:                               " + Response);
            if (Response < 0)
                Console.WriteLine("You number squared is:                        +" + Methods.Squared(Response));
            else
                Console.WriteLine("You number squared is:                        " + Methods.Squared(Response));
            Console.WriteLine("You number divided by 12 has a remainder of:  " + Methods.Remain12(Response));
            Console.WriteLine("You number incremented by its first digit is: " + Methods.IncrementFirstDigit(Response));

            Console.ReadLine();

        }
    }
}
