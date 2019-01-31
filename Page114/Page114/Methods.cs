using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page114
{
    class Methods
    {
        public int Method1(int input1)
        {
            input1 *= 25;
            return input1;
        }

        public int Method2(decimal input2)
        {
            int goToInt = Convert.ToInt32(input2);
            goToInt *= 10;
            return goToInt;
        }

        public int Method3(string input3)
        {
            int goLength = input3.Length;
            goLength /= 2;
            return goLength;
        }
    }
}
