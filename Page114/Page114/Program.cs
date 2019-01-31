using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page114
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods ToMath = new Methods();

            Console.Write("Enter in an integer:   ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number multiplied by 25 is {0}", ToMath.Method1(input1));
            Console.Write("Enter in a decimal number:   ");
            decimal input2 = (decimal)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The number rounded and multiplied by 10 is {0}", ToMath.Method2(input2));
            Console.Write("Enter in a string:   ");
            string input3 = Console.ReadLine();
            Console.WriteLine("The length of the string divided by 2 and rounded is {0}", ToMath.Method3(input3));
            Console.ReadLine();
        }
    }
}
