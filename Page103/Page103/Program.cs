using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page103
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 1: String array
            string[] things = new string[5];
            Console.WriteLine("Step 1: Please enter the first 5 things that come to mind: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter item {0}: ", i+1);
                things[i] = Console.ReadLine();
            }
            Console.WriteLine("\nThe items are: ");
            for (int j = 0; j < 5; j++)
            {
                Console.Write(things[j] + "      ");
            }
            Console.WriteLine("\n");

            //Step 2: Infinite loop
            int toLoop = 0;
            Console.Write("Steps 2 and 3:   ");
            while (toLoop < 10)
            {
                Console.Write(toLoop + "     ");
                //Step 3: Fix the loop
                toLoop++; 
            }
            Console.WriteLine();

            //Step 4: While loop with < operator (repeating Step 2)
            Console.Write("\nStep 4:      ");
            while (toLoop < 20)
            {
                Console.Write(toLoop + "     ");
                
                toLoop++;
            }
            Console.WriteLine();

            //Step 5: While loop with < operator (repeating Step 2)
            toLoop = 1;
            Console.Write("\nStep 5:     ");
            while (toLoop <= 20)
            {
                Console.Write(toLoop + "  ");
                //Step 3: Fix the loop
                toLoop++;
            }

            //Step 6: Select from array
            string[] sports = new string[] { "basketball", "football", "soccer", "baseball", "tennis", "swimming", "hockey", "lacrosse" };
            Console.WriteLine("\n\nStep 6, 7, and 8: What is your favorite sports from the below array?");
            for (int k = 0; k < sports.Length; k++)
            {
                Console.Write(sports[k] + "  ");
            }
            Console.WriteLine();
            //Step 7: Get the response
            string response = Console.ReadLine();
            bool matching = false;
            response = response.ToLower();
            for (int l = 0; l < sports.Length; l++)
            {
                if (String.Compare(sports[l], response) == 0)
                {
                    Console.WriteLine("Your response is {0}", sports[l]);
                    matching = true;
                    //Step 8: Break the loop f match has been found
                    break;
                }
            }
            if (!matching)
                Console.WriteLine("Your item was not found. Be careful of spelling errors.");

            //Step 9: Create a list with a repeat
            List<string> aRepeat = new List<string> { "red", "green", "blue", "yellow", "blue", "orange", "purple" };
            Console.WriteLine("\n\nSteps 9 and 10: Enter an item in the list below: ");
            for (int m = 0; m < aRepeat.Count; m++)
            {
                Console.Write(m + ".) " +aRepeat[m] + "   ");
            }
            Console.WriteLine();
            string getAns = Console.ReadLine();
            for (int n = 0; n < aRepeat.Count; n++)
            {
                if (String.Compare(aRepeat[n], getAns) == 0)
                {
                    Console.WriteLine("Your response is {0}", aRepeat[n]);
                    matching = true;
                    //Step 8: Break the loop f match has been found
                    break;
                }
            }
            //Step 10: Let user know if they entered something not in the list
            if (!matching)
                Console.WriteLine("You did not enter something in the list.");

            //Step 11: Create another list with a repeat and use a foreach loop
            List<string> shapeRepeat = new List<string> { "circle", "triangle", "square", "rectangle", "hexagon", "pentagon", "square", "rectangle", "octagon" };
            Console.WriteLine("\n\nStep 11: Another repeating item in a list");
            for (int p = 0; p < aRepeat.Count; p++)
            {
                Console.Write(shapeRepeat[p] + "   ");
            }
            bool match = false;
            int numShape;
            int numDuplicate;
            foreach (string shape in shapeRepeat)
            {
                foreach (string duplicate in shapeRepeat)
                {
                    if (String.Compare(shape, duplicate) == 0 && shapeRepeat.IndexOf(shape) == 2)
                    {
                        Console.WriteLine("There is a match of {0} and {1}", shape, duplicate);
                        match = true;
                        break;
                    }
                }
            }
            if (!match)
                Console.WriteLine("\nThere are no matching items in this list");

            Console.WriteLine();
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}