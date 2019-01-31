using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page117
{
    public static class Divide
    {
        private static bool ifEven = false;

        //overloading the divide by two function
        public static bool IfEven(int input)
        {
            if (input % 2 == 0)
                return true;
            else
                return false;
        }

        public static void Div2(int input)
        {
            //check if the input is an odd number
            if (ifEven == false)
            {
                float half = (float)input;
                half /= 2;
                Console.WriteLine(half);
            }
            else
            {
                input /= 2;
                Console.WriteLine(input);
            }
        }
    }
}
