using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page117
{
    public static class Divide
    {

        public static void Divide2(int input)
        {
            int output;
            //check if the input is an odd number
            if (input % 2 == 1)
            {
                input += 1;
                Divide2(out output, input);
            }
            else
            {
                Divide2(out output, input);
                //Console.WriteLine(input);
            }
            Console.WriteLine(output);
        }


        public static void Divide2(out int output, int input)
        {
            //check if the input is an odd number
            output = input / 2;

        }
    }
}
