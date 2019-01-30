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
            Employee<string> botOne = new Employee<string>();
            //botOne.wordThings = new List<strings>();
            botOne.Things.Add("Helping others");
            botOne.Things.Add("Writing programs");
            botOne.Things.Add("Soft skills");
            botOne.Things.Add("Organizing events");
            botOne.Things.Add("Gaining knowledge");
            botOne.numberThings.Add(87);
            botOne.numberThings.Add(93);
            botOne.numberThings.Add(90);
            botOne.numberThings.Add(79);
            botOne.numberThings.Add(75);
            botOne.numberThings.Add(80);
            botOne.numberThings.Add(85);
            botOne.numberThings.Add(88);
            botOne.firstName = "Sample";
            botOne.lastName = "Student";
            botOne.gender = Convert.ToChar("X");
            botOne.Identity = 22222;
            Console.WriteLine();

            botOne.SayName();
            Console.ReadLine();
        }
    }
}
