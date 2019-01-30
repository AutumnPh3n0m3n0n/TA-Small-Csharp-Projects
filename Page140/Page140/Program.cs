using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page140
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> Roster = new List<Employee>();
            //to create these lists
            List<Employee> forEachList = new List<Employee>();
            //List<Employee> Lambdas = new List<Employee>();
            //List<Employee> greaterThan5 = new List<Employee>();

            Employee bot1 = new Employee("Joe", "Smith", Convert.ToChar("M"), "Worker", 3);
            Roster.Add(bot1);
            Employee bot2 = new Employee("Molly", "Jones", Convert.ToChar("F"), "Worker", 6);
            Roster.Add(bot2);
            Employee bot3 = new Employee("Joe", "Davis", Convert.ToChar("M"), "Worker", 9);
            Roster.Add(bot3);
            Employee bot4 = new Employee("Beth", "Parker", Convert.ToChar("F"), "Worker", 12);
            Roster.Add(bot4);
            Employee bot5 = new Employee("Joe", "Dennis", Convert.ToChar("M"), "Worker", 4);
            Roster.Add(bot5);
            Employee bot6 = new Employee("Claire", "Lilly", Convert.ToChar("F"), "Worker", 2);
            Roster.Add(bot6);
            Employee bot7 = new Employee("Michael", "Muller", Convert.ToChar("M"), "Worker", 7);
            Roster.Add(bot7);
            Employee bot8 = new Employee("Jen", "Matthews", Convert.ToChar("F"), "Worker", 8);
            Roster.Add(bot8);
            Employee bot9 = new Employee("David", "Harris", Convert.ToChar("M"), "Worker", 5);
            Roster.Add(bot9);
            Employee bot10 = new Employee("Emily", "Adams", Convert.ToChar("F"), "Worker", 11);
            Roster.Add(bot10);

            Console.WriteLine("Here is every employee with the first name JOE:");
            foreach (Employee bot in Roster)
            {
                if (String.Compare(bot.firstName, "Joe") == 0)
                    forEachList.Add(bot);
            }
            foreach (Employee bot in forEachList)
                bot.SayName();

            Console.WriteLine("\nHere is with the lambda function:");
            List<Employee> Lambdas = Roster.Where(bot => String.Compare(bot.firstName, "Joe") == 0).ToList();
            foreach (Employee bot in Lambdas)
                bot.SayName();

            Console.WriteLine("\nAll employees greater than 5:");
            List<Employee> greaterThan5 = Roster.Where(bot => bot.Identity > 5).ToList();
            foreach (Employee bot in greaterThan5)
                bot.SayName();

            Console.ReadLine();
        }
    }
}
