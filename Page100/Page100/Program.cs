using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page100
{
    class Program
    {
        static void Main(string[] args)
        {
            //make the array of strings
            string[] sports = new string[] { "football", "basketball", "baseball", "soccer", "hockey", "tennis" };
            int stop = sports.Length;
            int response;
                Console.WriteLine("Here is a list of sports. Choose a number between 1 and 6 to see which item from the array you want displayed.");
            for (int i = 0; i < stop; ++i)
            {
                Console.WriteLine(i+1 + "). " + sports[i] + "\n");
            };
            do
            {
                response = Convert.ToInt32(Console.ReadLine());
                if (response < 1 || response > 6)
                    Console.WriteLine("Please enter a number between 1 and 6 \n");
            } while (response < 1 || response > 6);
            Console.WriteLine("The sports item you chose is " + sports[response - 1] + "\n");


            //make the array of integers
            int[] cubes = new int[] { 1, 8, 27, 64, 125, 216, 343, 512, 729, 1000, 1331, 1728, 2197, 2744, 3375 };
            stop = cubes.Length + 1;
                Console.WriteLine("Here is a list all the numbers corresponsing with their cubed values.");
            for (int j = 1; j < stop; ++j)
            {
            Console.WriteLine(j + "). " + cubes[j-1]);
            };
            Console.WriteLine("Please enter a number between 1 and 15");
            do
            {
                response = Convert.ToInt32(Console.ReadLine());
                if (response < 1 || response > 15)
                    Console.WriteLine("Please enter a number between 1 and 15");
            } while (response < 1 || response > 15);
            Console.WriteLine("The number you chose to the 3rd power is " + cubes[response - 1] + "\n");

            //make a list of strings
            List<string> majorCities = new List<string>() { "Portland", "Seattle", "Vancouver", "Calgary", "Edmonton", "San Francisco", "Oakland", "San Jose",
                                                            "Sacramento", "Los Angeles", "San Diego", "Phoenix", "Denver", "Salt Lake City", "Las Vegas"};
            for (int l = 0; l < majorCities.Count; ++l)
            {
                Console.WriteLine(l+1 + "). " + majorCities[l]);
            };
            Console.WriteLine("Please enter which city you are from based on the list:  ");
            do
            {
                response = Convert.ToInt32(Console.ReadLine());
                if (response < 1 || response > 15)
                    Console.WriteLine("Please enter a number between 1 and 16");
            } while (response < 1 || response > 15);
            Console.WriteLine("\nSo you are from " + majorCities[response-1] + "?");

            Console.ReadLine();
        }
    }
}
