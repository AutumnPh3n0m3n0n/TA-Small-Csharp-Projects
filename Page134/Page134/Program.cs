using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Objectives:
//1. Create an enum for the days of the week.
//2. Prompt the user to enter the current day of the week.
//3. Assign the value to a variable of that enum data type you just created.
//4. Wrap the above statement in a try/catch block and have it print 
//"Please enter an actual day of the week." to the console if an error occurs.

namespace Page134
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock setDay = new Clock();

            Employee toGet = new Employee();
            Console.Write("What is your first name?  ");
            toGet.firstName = Console.ReadLine();
            Console.Write("What is your last name?   ");
            toGet.lastName = Console.ReadLine();
            Console.Write("What is your occupation?  ");
            toGet.occupation = Console.ReadLine();
            Console.Write("What is your ID number?   ");
            toGet.Identity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nHello " + toGet.firstName + " " + toGet.lastName + ". Please enter the day of the week:   ");
            Console.Write("Input 0 for SUNDAY, 1 for MONDAY, 2 for TUESDAY, ... , 6 for SATURDAY         ");
            //setDay.Dates = Convert.ToInt32(Console.ReadLine());

            DayOfWeek SetTheDay = (DayOfWeek)Convert.ToInt32(Console.ReadLine());
            int getDay = Convert.ToInt32(SetTheDay);
            for (int i = 0; i < 7; i++)
            {
                if (i == getDay)
                    setDay.Date = SetTheDay;
            }
            //setDate[SetTheDay] = SetTheDay;
        }
   
        //public enum DaysOfWeek
        //{
        //    Sunday = SetTheDay,
        //    Monday = 1,
        //    Tuesday = 2,
        //    Wednesday = 3,
        //    Thursday = 4,
        //    Friday = 5,
        //    Saturday = 6
        //}
    }
}
