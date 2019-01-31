using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page115
{
    class Math
    {
        public int oneNumber(int input)
        {
            if (input <= 500)
            {
                input *= 100;
                return input;
            }
            else
            {
                input /= 10;
                return input;
            }
        }

        public int twoNumbers(int input1, int input2)
        {
            input1 *= input2;
            return input1;
        }
        
    }
}
