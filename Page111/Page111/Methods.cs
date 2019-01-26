using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page111
{
    public class Methods
    {
        //method to get the number squared
        public static int Squared(int input)
        {
            input = input * input;
            return input;
        }

        //method to get the remainder of 12
        public static int Remain12(int input)
        {
            input %= 12;
            return input;
        }

        //method to increment the first digit
        public static int IncrementFirstDigit(int input)
        {
            if (input < 10 && input > -11)
            {
                input += 1;
                return input;
            }
            else if (input < 100 && input > -110)
            {
                input += 10;
                return input;
            }
            else if (input < 1000 && input > -1100)
            {
                input += 100;
                return input;
            }
            else if (input < 10000 && input > -11000)
            {
                input += 1000;
                return input;
            }
            else
            {
                input += 10000;
                return input;
            }
        }
    }
}
