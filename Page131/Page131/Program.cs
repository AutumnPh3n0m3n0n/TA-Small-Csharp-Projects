using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Make the Employee class take a generic type parameter.
//2. Add a property to the Employee class called "things" and have its data type be a generic list matching the generic type of the class.
//3. Instantiate an Employee object with type "string" as its generic parameter.Assign a list of strings as the property value of Things.
//4. Instantiate an Employee object with type "int" as its generic parameter.Assign a list of integers as the property value of Things.
//5. Create a loop that prints all of the Things to the Console.

namespace Page131
{
    class Program
    {
        static void Main(string[] args)
        {
            //for character strings
            Employee<string> botOne = new Employee<string>
            {
                firstName = "Sharath",
                lastName = "Menon",
                gender = Convert.ToChar("M"),
                Identity = 123456,
                things = new List<string> { "Helping others", "Organizing events", "Applying for jobs", "Going for Masters degree" }
            };

            Console.WriteLine();
            botOne.SayName();
            Console.WriteLine("Duties: ");
            for (int i = 0; i < botOne.things.Count; i++)
            {
                Console.WriteLine(botOne.things[i]);
            }

            //for integers
            Employee<int> botTwo = new Employee<int>
            {
                firstName = "Michael",
                lastName = "Jordan",
                gender = Convert.ToChar("M"),
                Identity = 23,
                things = new List<int> {1984, 1985, 1986, 1987, 1988, 1989, 1990, 1991, 1992, 1993, 1994, 1995, 1996, 1997, 1998, 1999, 2000, 2001, 2002, 2003}
            };

            Console.WriteLine();
            botTwo.SayName();
            Console.WriteLine("Years played in the NBA: ");
            for (int j = 0; j < botTwo.things.Count; j++)
            {
                Console.WriteLine(botTwo.things[j]);
            }

            //botOne.wordThings = new List<strings>();

            /*botOne.firstName = "Sample";
            botOne.lastName = "Student";
            botOne.gender = Convert.ToChar("X");
            botOne.Identity = 22222;
            Console.WriteLine();

            //Callinf the say name function
            botOne.SayName();
            */
            Console.ReadLine();
        }
    }
}
