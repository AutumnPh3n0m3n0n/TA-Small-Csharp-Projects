using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page113
{
    class Program
    {
        static void Main(string[] args)
        {
            Extras statement = new Extras();
            Console.Write("What is your name?  ");
            string getName = Console.ReadLine();
            Console.Write("How old will you be?  ");
            int getAge = Convert.ToInt32(Console.ReadLine());
            statement.happyBirthday(getName, getAge);
            Console.ReadLine();
        }
    }
}
