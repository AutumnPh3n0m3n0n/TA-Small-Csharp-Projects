using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page156
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime current = DateTime.Now;
            Console.WriteLine("The time right now is {0}", current.ToString("MM/dd/yyyy h:mm tt"));
            Console.Write("Enter in an integer to see what time it will be however many hours from now:  ");
            int later = Convert.ToInt32(Console.ReadLine());
            DateTime future = current.AddHours(later);
            Console.WriteLine("The time {0} hours in the future is {1}", later, future.ToString("MM/dd/yyyy h:mm tt"));
            Console.ReadLine();

        }
    }
}
