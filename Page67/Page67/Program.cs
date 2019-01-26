using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page67
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            bool e1_makes_more;

            Console.WriteLine("Please enter the income logs for Employee 1 ");
            Console.WriteLine("How many hours did Employee 1 work this week? ");
            int e1_hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the hourly salary of Employee 1? ");
            double e1_salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How many hours did Employee 2 work? ");
            int e2_hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the hourly salary of Employee 2? ");
            double e2_salary = Convert.ToDouble(Console.ReadLine());

            double e1_total = e1_hours * e1_salary;
            double e2_total = e2_hours * e2_salary;

            Console.WriteLine("\n\nWeekly salary of Employee 1 is: $" + Math.Round(e1_total, 2));
            Console.WriteLine("Weekly salary of Employee 2 is: $" + Math.Round(e2_total, 2));

            if (e1_total > e2_total)
                e1_makes_more = true;
            else
                e1_makes_more = false;


            Console.WriteLine("\nDoes Employee 1 make more than Employee 2? ");
            if (e1_makes_more == true)
                Console.WriteLine("Yes. Employee 1 has a higher salary.");
            else
                Console.WriteLine("No. Employee 2 has a higher salary.");

            Console.ReadLine();
        }
    }
}
