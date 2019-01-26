using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Page97
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence_1 = "hello, my name is Sharath. ";
            string sentence_2 = "my goal is to graduate Tech Academy, get the Comptia A+ certification, and do my Master's degree. ";
            string sentence_3 = "then, I can be more qualified for industry and making a good living. ";

            string before = sentence_1 + sentence_2 + sentence_3;
            Console.WriteLine(before);

            sentence_1 = FirstLetterToUpper(sentence_1);
            sentence_2 = FirstLetterToUpper(sentence_2);
            sentence_3 = FirstLetterToUpper(sentence_3);

            Console.WriteLine("\n\n");
            string phrase = sentence_1 + sentence_2 + sentence_3;
            Console.WriteLine(phrase);
            Console.ReadLine();


            // Create a StringBuilder that expects to hold 50 characters.
            // Initialize the StringBuilder with "ABC".
            StringBuilder about = new StringBuilder("I live in Portland and I like it here. ", 500);

            // Append three characters (D, E, and F) to the end of the StringBuilder.
            about.Append("However the Winters here can be gloomy ");
            about.Append("and the cost of living here is crazy.");


            // Insert a string at the beginning of the StringBuilder.
            about.Insert(0, "My name is Sharath. ");

            // Display the number of characters in the StringBuilder and its string.
            Console.WriteLine(about.ToString());
            Console.ReadLine();

            string FirstLetterToUpper(string str)
            {
                if (str == null)
                    return null;

                if (str.Length > 1)
                    return char.ToUpper(str[0]) + str.Substring(1);

                return str.ToUpper();
            }
        }
    }
}
