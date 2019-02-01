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
            char response;
            //string response;
            Console.Write("Please enter in a number:    ");
            int response1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Do you want to enter a second number? (Press Y for yes, N for no)   ");
            response = Convert.ToChar(Console.ReadLine());
            if (response == 'y' || response == 'Y')
            {
                Console.Write("\nPlease enter in another number  :    ");
                int response2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The two numbers multiplied are {0}", toMix.twoNumbers(response1, response2));
                //Console.WriteLine(response2);
            }
            else if (response == 'n' || response == 'N')
            {
                Console.WriteLine();
                Console.WriteLine("The number you entered multiplied by 10 is {0}", toMix.twoNumbers(response1, 10));
            }
            else
            {
                Console.WriteLine("Please enter either a Y for Yes or N for No");
            }

            Console.ReadLine();


        }
    }
}
