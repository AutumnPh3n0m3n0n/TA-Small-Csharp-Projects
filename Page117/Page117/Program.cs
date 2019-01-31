using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page117
{
    class Program
    {
        static void Main(string[] args)
        {
            //A static class cannot be instantiated
            //Divide toDiv = new Divide();
            Console.Write("Please enter in a number:   ");
            int response = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("The number divided by 2 is   ");
            Divide.Div2(response);
            Console.ReadLine();
        }

    }
}
